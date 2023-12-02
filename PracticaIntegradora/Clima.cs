using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PracticaIntegradora
{
    public partial class Clima : Form
    {
        public Clima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clientes = Convert.ToInt32(txt_clientes.Text);
            int pago = Convert.ToInt32(txt_precio.Text);
            MathOperation("calcular", clientes, pago);


        
        async void MathOperation(string operacion, int num1, int num2)
        {
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest($"/{operacion}?a={num1}&b={num2}");
            var response = client.Execute(request);
            lbl_resul.Text = response.Content.ToString();
        }


    }

    private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
