﻿using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraClassic.View
{
    public partial class FrmTelaGenero : Form
    {
        //private static FrmTelaGenero instance;
        public FrmTelaGenero()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btnCadastrarGenero_Click(object sender, EventArgs e)
        {
            //Objeto VO
            Genero genero = new Genero();

            //objeto DAL
            GeneroDAL generoDAL = new GeneroDAL(); 
            
            //pegar o valor da textbox
            genero.Nome = txtNomeGenero.Text;
            generoDAL.IserirGenero(genero);

            MessageBox.Show(genero.Nome + " inserido no banco de dados!");
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {  
            //Automaticamente gera as colunas
            dataGridViewGenero.AutoGenerateColumns = true;

            //Configura a origem dos dados
            conexao2BindingSource.DataSource = GetData("select * from genero"); // <- Comando SQL a ser enviado ao MSSQL server
            dataGridViewGenero.DataSource = conexao2BindingSource;

            //Automaticamente reajusta as linhas e colunas, tambem pode ser alterado em propriedades
            dataGridViewGenero.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewGenero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private static DataTable GetData(string sqlCommand)
        {
            DataTable table = new DataTable();
            try
            {
                //SqlConnection sqlcon;
                //sqlcon = new SqlConnection(ConexaoBD.ConnectionStringBD);
                
                Conexao2.Sqlcon.Open();
                //sqlcon.Open();
                //SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);  // Usando a conection string instanciada no Conexao2 -> Conexao2.Sqlcon
                adapter.InsertCommand = command;

                //command = new SqlCommand(sqlCommand, sqlcon); // Usando a connection string local do metodo -> sqlcon
                //adapter.InsertCommand = command;

                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                Conexao2.Sqlcon.Close();

                adapter.SelectCommand = command;
                
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
            }
            catch (System.InvalidOperationException)
            {
                Conexao2.Sqlcon.Close();
                MessageBox.Show("O sistema perdeu a conexão ao banco de dados"); 
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Conexao2.Sqlcon.Close();
                MessageBox.Show("Erro de pesquisa no banco de dados, verificar com o administrador do sistema");
            }
            return table;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = 0;

            if(dataGridViewGenero.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGenero.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_genero"].Value);
                MessageBox.Show("O valor do campo 'id' a ser excluido é: " + id.ToString());
            }
            Genero genero = new Genero();
            GeneroDAL generoDAL = new GeneroDAL();

            genero.Id = id;
            generoDAL.DeletarGenero(genero);
            InitializeDataGridView();
        }

        private void btnReordenarId_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            GeneroDAL generoDAL = new GeneroDAL();
            int id = 0;

            if (dataGridViewGenero.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGenero.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_genero"].Value);
                //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());   
            }
            genero.Id = id;
            genero.Nome = txtNomeNovo.Text;
            generoDAL.AlterarGenero(genero);
            InitializeDataGridView();
        }
        private void DataGridViewGenero_SelectionChanged(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            GeneroDAL generoDAL = new GeneroDAL();
            int id = 0;

            if (dataGridViewGenero.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewGenero.SelectedRows[0];
                id = Convert.ToInt32(selectedRow.Cells["id_genero"].Value);
                //MessageBox.Show("O 'id' a ser alterado é: " + id.ToString());
                genero.Id = id;
                txtNomeSelecionado.Text = generoDAL.BuscarGenero(genero);
            }
            // MessageBox.Show(generoDAL.BuscarGenero(genero));
        }
    }
 }
