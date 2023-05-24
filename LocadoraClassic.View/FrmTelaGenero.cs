using LocadoraClassic.DAL;
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

namespace LocadoraClassic.View
{
    public partial class FrmTelaGenero : Form
    {
        //private static FrmTelaGenero instance;
        public FrmTelaGenero()
        {
            InitializeComponent();
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


        }



        //private FrmTelaGenero()
        //{

        //}
        //public static FrmTelaGenero Instance
        //{
        //    get
        //    {
        //        if (Instance == null || Instance.IsDisposed)
        //        {
        //            instance = new FrmTelaGenero();
        //        }
        //        return instance;
        //    }
        //}
    }
}
