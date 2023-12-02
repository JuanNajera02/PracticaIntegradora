using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PracticaIntegradora
{
    public partial class Empleados : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-QPU6AMU2;Initial Catalog=PracticaIntegradora;Integrated Security=True");
        public Empleados()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string nss = txt_NSS.Text;
            string cadena = "select nombre, apellidoPaterno, apellidoMaterno, sueldoXhora, horasTrabajadas from empleados where nss=" + nss;
            
            
            conn.Open();
           

        
            SqlCommand comando = new SqlCommand(cadena, conn);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read()){
                txt_nombre.Text = registro["nombre"].ToString();
                txt_apellido_paterno.Text = registro["apellidoPaterno"].ToString();
                txt_apellido_materno.Text = registro["apellidoMaterno"].ToString();
                txt_sueldo.Text = registro["sueldoXhora"].ToString();
                txt_horas.Text = registro["horasTrabajadas"].ToString();
            }
            else
                MessageBox.Show("No existe ese empleado");
            conn.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string query = "insert into empleados (nombre, apellidoPaterno, apellidoMaterno, nss, sueldoXhora, horasTrabajadas) values (@nombre, @apellidoPaterno, @apellidoMaterno, @nss, @sueldoXhora, @horasTrabajadas)";
            conn.Open();

            EmpleadoPorHoras emp = new EmpleadoPorHoras(txt_nombre.Text, txt_apellido_paterno.Text, txt_apellido_materno.Text, Convert.ToInt32(txt_NSS.Text), Convert.ToDouble(txt_sueldo.Text), Convert.ToDouble(txt_horas.Text));

            SqlCommand comando = new SqlCommand(query, conn);
            comando.Parameters.AddWithValue("@nombre", emp.getNombre());
            comando.Parameters.AddWithValue("@apellidoPaterno", emp.getApellPaterno());
            comando.Parameters.AddWithValue("@apellidoMaterno", emp.getApellMaterno());
            comando.Parameters.AddWithValue("@nss", emp.getNumeroSeguroSocia());
            comando.Parameters.AddWithValue("@sueldoXhora", emp.getSueldo());
            comando.Parameters.AddWithValue("@horasTrabajadas", emp.getHoras());
            comando.ExecuteNonQuery();
            MessageBox.Show("exito el registro");

            conn.Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_pago_Click(object sender, EventArgs e)
        {
            EmpleadoPorHoras emp = new EmpleadoPorHoras(txt_nombre.Text, txt_apellido_paterno.Text, txt_apellido_materno.Text, Convert.ToInt32(txt_NSS.Text), Convert.ToDouble(txt_sueldo.Text), Convert.ToDouble(txt_horas.Text));

            double cantidadPagar = 0;
            cantidadPagar = emp.calcularIngresos();


            MessageBox.Show("La cantidad a pagar al empleado es de: $" + cantidadPagar);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nss = txt_NSS.Text;
            string pagoXhoras = txt_sueldo.Text;
            string cadena = "update empleados set sueldoXhora='" + pagoXhoras + "' where nss=" + nss;
            SqlCommand comando = new SqlCommand(cadena, conn);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del empleado");
                txt_NSS.Text = "";
                txt_sueldo.Text = "";
                txt_nombre.Text = "";
                txt_horas.Text = "";
                txt_apellido_materno.Text = "";
                txt_apellido_paterno.Text = "";
            }
            else
                MessageBox.Show("No existe el empleado con el nss ingresado");
            conn.Close();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nss = txt_NSS.Text;

            string cadena = "DELETE FROM Empleados WHERE nss = " + nss;
            SqlCommand comando = new SqlCommand(cadena, conn);
            comando.ExecuteNonQuery();
            MessageBox.Show("Empleado Eliminado");

            conn.Close();
        }
    }

    class Empleado{//clase padre

        private string nombre;
        private string apellPaterno;
        private string apellMaterno;
        private int numeroSeguroSocia;

        public Empleado(string nombre, string apellMaterno, string apellPaterno, int
        numeroSeguroSocia){// sobrecarga
            this.nombre = nombre;
            this.apellMaterno = apellMaterno;
            this.apellPaterno = apellPaterno;
            this.numeroSeguroSocia = numeroSeguroSocia;
        }


        public Empleado()
        {

        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellMaterno()
        {
            return apellMaterno;
        }

        public string getApellPaterno()
        {
            return apellPaterno;
        }

        public int getNumeroSeguroSocia()
        {
            return numeroSeguroSocia;
        }

        public virtual double calcularIngresos()
        {

            int totalIngresos = 0;
            return totalIngresos;
        }

    } // fin clase 

    class EmpleadoPorHoras : Empleado{

        private double sueldo;
        private double horas;

        public EmpleadoPorHoras(string nombre, string apellMaterno, string apellPaterno, int
        numeroSeguroSocia, double sueldo, double horas) : base(nombre, apellMaterno, apellPaterno,
        numeroSeguroSocia)
        {

            this.sueldo = sueldo;
            this.horas = horas;
        }

        public double getHoras()
        {
            return horas;
        }

        public double getSueldo()
        {
            return sueldo;
        }

        public override double calcularIngresos()
        {

            double totalIngresos = 0;

            if (getHoras() <= 40)
            {

                totalIngresos = getSueldo() * getHoras();

            }
            else
            {

                totalIngresos = 40 * getSueldo() + (getHoras() - 40) * getSueldo() * 1.5;
            }

            return totalIngresos;
        }

    }



}
