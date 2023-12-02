using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIntegradora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

           if( txt_contra.Text == "sa" & txt_usuario.Text == "admin")
            {
                Menu frmMenu = new Menu();
               
                frmMenu.Show();
                
            }

        }
    }
}
