using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using LocadoraClassic.DAL;
using LocadoraClassic.VO;

namespace LocadoraClassic.View
{
    public partial class FrmConectarBD : Form
    {
        public FrmConectarBD()
        {
            InitializeComponent();
        }
        public void btnConectar_Click(object sender, EventArgs e)
        {
            string concatenarString;
            string connectionString;
            SqlConnection sqlcon;

            ConexaoBD login = new ConexaoBD();
            login.Server = txtServer.Text;
            login.UserID = txtUserId.Text;
            login.Password = txtPassword.Text;
            login.InitialCatalog = txtInitialCatalog.Text;

            concatenarString = "Initial Catalog="+login.InitialCatalog+";User ID="+login.UserID+";Password="+login.Password+";Server="+login.Server;
            ConexaoBD.ConnectionStringBD = concatenarString;
 
            connectionString = concatenarString;
            
            sqlcon = new SqlConnection(connectionString);
            Conexao2.Sqlcon.ConnectionString = ConexaoBD.ConnectionStringBD; // instancia a connection string no Conexao2

            try
            {
                sqlcon.Open();
                
                MessageBox.Show("Conectado!");
                sqlcon.Close();
                Hide(); // Oculta a tela de login do servidor
                //fmrMenu frmTelaPrincipal = new fmrMenu();
                //frmTelaPrincipal.Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Falha ao conectar!");
            }
        }
    }
}
