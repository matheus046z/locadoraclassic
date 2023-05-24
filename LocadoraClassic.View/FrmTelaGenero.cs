using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            conexao2BindingSource.DataSource = GetData("select * from genero");
            dataGridViewGenero.DataSource = conexao2BindingSource;

            //Automaticamente reajusta as linhas visiveis
            dataGridViewGenero.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }
        private static DataTable GetData(string sqlCommand)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            //string sql = "";
            //sql = "SELECT * FROM genero";

            command = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
            adapter.InsertCommand = new SqlCommand(sqlCommand, Conexao2.Sqlcon);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Conexao2.Sqlcon.Close();

            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
    }
 }
