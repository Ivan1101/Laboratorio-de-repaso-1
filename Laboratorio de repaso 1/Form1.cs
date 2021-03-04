using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_repaso_1
{
    public partial class Form1 : Form
    {
        List<Empleado> empleados = new List<Empleado>();
         List<Asistencia> asistencias = new List<Asistencia>();
        public Form1()
        {
            InitializeComponent();
        }
        public void guardar_datos(string archivo) {
            FileStream stream = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            //foreach (var p in empleados)
            //{
            //    writer.WriteLine(p.Codigo);
            //    writer.WriteLine(p.Nombre);
            //    writer.WriteLine(p.SueldoHora);
            //}

            for (int x = 0; x < empleados.Count; x++)
            {
                writer.WriteLine(empleados[x].Codigo);
                writer.WriteLine(empleados[x].Nombre);
                writer.WriteLine(empleados[x].SueldoHora);
            }

            writer.Close();
        }
        private void leer_datos()
        {
            FileStream stream = new FileStream("Empleados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
     while (reader.Peek() > -1)
            {
                Empleado personaTemp = new Empleado();

                personaTemp.Codigo = Convert.ToInt32(reader.ReadLine());
                personaTemp.Nombre = reader.ReadLine();
                personaTemp.SueldoHora = Convert.ToInt32(reader.ReadLine());

                empleados.Add(personaTemp);

            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
        public void guardar2(string archivo1)
        {
            FileStream stream1 = new FileStream(archivo1, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer1 = new StreamWriter(stream1);

            //foreach (var p in asistencias)
            //{
            //    writer.WriteLine(p.Codigo);
            //    writer.WriteLine(p.Nombre);
            //    writer.WriteLine(p.SueldoHora);
            //}

            for (int x = 0; x < asistencias.Count; x++)
            {
                writer1.WriteLine(asistencias[x].Codigo);
                writer1.WriteLine(asistencias[x].Horas);
                writer1.WriteLine(asistencias[x].Mes);
            }

            writer1.Close();
        }
        private void leer2 (){
            FileStream stream1 = new FileStream("Asistencias.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            while (reader1.Peek() > -1)
            {
                Asistencia asistenciatemp = new Asistencia();
               
                asistenciatemp.Codigo = Convert.ToInt32(reader1.ReadLine());
                asistenciatemp.Horas = Convert.ToInt32(reader1.ReadLine());
                asistenciatemp.Mes = reader1.ReadLine();

                asistencias.Add(asistenciatemp);

            }
          //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader1.Close();
        }
        public void Mostrar()
        {
            dataGridView1_Empleado.DataSource = null;
            dataGridView1_Empleado.DataSource = empleados;
            dataGridView1_Empleado.Refresh();
            dataGridView2_Asistencia.DataSource = null;
            dataGridView2_Asistencia.DataSource = asistencias;
            dataGridView2_Asistencia.Refresh();
        }
        
        void limpiar_campos()
        {
            textCodigo.Text = "";
            textNombre.Text = "";
            textsueldohora.Text = "";
            textBoxHoras.Text = "";
            textBoxMes.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleadotemp = new Empleado();
                Asistencia asistenciatemp = new Asistencia();
                empleadotemp.Codigo = Convert.ToInt32(textCodigo.Text);
                //Int32.Parse(textCodigo.Text);
                empleadotemp.Nombre = textNombre.Text;
                empleadotemp.SueldoHora = Convert.ToInt32(textsueldohora.Text);
                asistenciatemp.Codigo = Convert.ToInt32(textCodigo.Text);
                asistenciatemp.Horas = Convert.ToInt32(textBoxHoras.Text);
                asistenciatemp.Mes = textBoxMes.Text;

                empleados.Add(empleadotemp);
                asistencias.Add(asistenciatemp);
                 guardar_datos("Empleados.txt");
                guardar2("Asistencias.txt");
                limpiar_campos();
            }
            catch(Exception )
            {
    MessageBox.Show("No se han llenado todos los datos", "Mi Mesaje Predeterminado", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer_datos();
            leer2();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
