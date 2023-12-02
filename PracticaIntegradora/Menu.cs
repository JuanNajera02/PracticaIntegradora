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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Empleados frmEmpleados = new Empleados();

            frmEmpleados.Show(this);
            

        }

        private void btn_servidor_Click(object sender, EventArgs e)
        {
            Mensajes frmMensajes = new Mensajes();  

            frmMensajes.Show(this);
        }

        private void btn_tareas_Click(object sender, EventArgs e)
        {
            Hilos frmTareas = new Hilos();

            frmTareas.Show(this);

        }

        private void btn_clima_Click(object sender, EventArgs e)
        {
            Clima frmClima = new Clima();

            frmClima.Show(this);

        }
    }
}
