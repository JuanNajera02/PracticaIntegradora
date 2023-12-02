using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticaIntegradora
{
    public partial class Hilos : Form
    {
        public Hilos()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tareas_Click(object sender, EventArgs e)
        {
          

            var trhacer = new TareasHacer();
            var tareas = new Task[10];
            for (int i = 0; i < tareas.Length; i++)
            {
                tareas[i] = Task.Run(() => ActualizarAleatoriamente(trhacer));
            }
            Task.WaitAll(tareas);

         



        }

        void ActualizarAleatoriamente(TareasHacer tareasHacer1)
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                bool flag = rnd.NextDouble() < 0.5;
                if (flag)
                {

                    string str2 = tareasHacer1.AñadirTarea("Tareas ID: " + i, i);
                    ListViewItem lista = new ListViewItem(str2);
                    lv_tareas.Items.Add(lista);

                }
                else
                {

                    string str2 = tareasHacer1.EliminarTarea("Tareas ID: " + i, i);
                    ListViewItem lista = new ListViewItem(str2);
                    lv_tareas.Items.Remove(lista);


                }

            }


        }

        private void Hilos_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
    public class TareasHacer
    {

        public TareasHacer()
        {
           
        }

        private readonly object
        bloqueo = new object();

        public string[] totalTareas = new string[10];


        public string AñadirTarea(string nombreTarea, int num)
        {
            lock (bloqueo)
            {

               
                string str = totalTareas[num] = nombreTarea;
                return str;

                
            }
        }


        public string EliminarTarea(string nombreTarea, int num)
        {
            lock (bloqueo)
            {

                string str = totalTareas[num] = nombreTarea;
                return str;

            }
        }



    }









}
