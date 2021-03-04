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
        public Form1()
        {
            InitializeComponent();
        }
        void guardar_datos() {
            FileStream stream = new FileStream("Empleados.txt", FileMode.OpenOrCreate, FileAccess.Write);

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
        private void Mostrar()
        {
            dataGridView1_Empleado.DataSource = null;
            dataGridView1_Empleado.DataSource = empleados;
            dataGridView1_Empleado.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleadotemp = new Empleado();
                empleadotemp.Codigo = Convert.ToInt32(textCodigo.Text);
                //Int32.Parse(textCodigo.Text);
                empleadotemp.Nombre = textNombre.Text;
                empleadotemp.SueldoHora = Convert.ToInt32(textsueldohora.Text);

                empleados.Add(empleadotemp);
                guardar_datos();
                textCodigo.Text = "";
                textNombre.Text = "";
                textsueldohora.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se han llenado todos los datos" + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer_datos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
