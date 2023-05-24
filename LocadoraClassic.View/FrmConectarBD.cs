using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;

namespace LocadoraClassic.View
{
    public partial class FrmConectarBD : Form
    {
        public FrmConectarBD()
        {
            InitializeComponent();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string connectionString;
            string concatenarString;
            SqlConnection sqlcon;

            ConexaoBD login = new ConexaoBD();
            login.Server = txtServer.Text;
            login.UserID = txtUserId.Text;
            login.Password = txtPassword.Text;
            login.InitialCatalog = txtInitialCatalog.Text;

            concatenarString = "Initial Catalog="+login.InitialCatalog+";User ID="+login.UserID+";Password="+login.Password+";Server="+login.Server;
            MessageBox.Show(concatenarString);


            connectionString = concatenarString;
                //@"Initial Catalog=locadoraclassic;User ID=Matheus;Password=zmThe$19-03sql; Server=192.168.0.49";

            sqlcon = new SqlConnection(connectionString);

            
            try
            {
                sqlcon.Open();
                MessageBox.Show("Conectado!");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Falha ao conectar!");
            }

            sqlcon.Close();
        }
    }
}
