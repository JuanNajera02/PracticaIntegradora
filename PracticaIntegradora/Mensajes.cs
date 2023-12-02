using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PracticaIntegradora
{
    public partial class Mensajes : Form
    {
        public Mensajes()
        {
            InitializeComponent();
        }

        private void btn_mensaje_Click(object sender, EventArgs e)
        {
            try
            {
                //Crear socket 
                // IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName()); 
                // IPAddress ipAddress = ipHostInfo.AddressList[0];  juanpa02
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("172.20.10.6"), 8888);
                Socket socket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket1.Connect(remoteEP); //Conectarse a Asociar IP y puerto para enviar informacion 
                String mensaje1 = txt_mensaje.Text;
                byte[] msg = Encoding.ASCII.GetBytes(mensaje1+"<E0F>"); //Codificar cadena de texto a enviar 
                int bytesSent = socket1.Send(msg); //Enviar cadena a través del socket 
                MessageBox.Show("Mensaje enviado exitosamente");
                socket1.Shutdown(SocketShutdown.Both);
                socket1.Close(); //Cerrar el socket 
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
