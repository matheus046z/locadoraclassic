using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.DAL;
using System.Data.SqlClient;

namespace LocadoraClassic.View
{
    public partial class FrmTelaCategoria : Form
    {
        public FrmTelaCategoria()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaDAL categoriaDAL = new CategoriaDAL();

            categoria.Nome = txtNomeCategoria.Text;
            categoria.ValorDiaria = txtValorDiaria.Text;

            categoriaDAL.InserirCategoria(categoria);
            
            MessageBox.Show(categoria.Nome +" ("+categoria.ValorDiaria+")" + " inserido no banco de dados!");

            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dataGridViewCategoria.AutoGenerateColumns = true;
            conexao2BindingSource.DataSource = GetData("select * from categoria");
            dataGridViewCategoria.DataSource = conexao2BindingSource;
            dataGridViewCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }
        private static DataTable GetData(string sqlCommand)
        {
            Conexao2.Sqlcon.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

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
