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
        List<Sueldo_total> sueldo_mensual = new List<Sueldo_total>();
        public Form1()
        {
            InitializeComponent();
            bloqueo_botones();
        }
        void bloqueo_botones()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }
        void desbloqueo_botones()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        public void guardar_datos(string archivo) {
            // Se crea el archivo de texto para cargar los datos
            FileStream stream = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            //foreach (var p in empleados)
            //{
            //    writer.WriteLine(p.Codigo);
            //    writer.WriteLine(p.Nombre);
            //    writer.WriteLine(p.SueldoHora);
            //}
            // Se utiliza el ciclo for para ver el orden de como se van a imprimir los datos en el documento
            for (int x = 0; x < empleados.Count; x++)
            {
                writer.WriteLine(empleados[x].Codigo);
                writer.WriteLine(empleados[x].Nombre);
                writer.WriteLine(empleados[x].SueldoHora);
            }

            writer.Close();
        }
        public void guardar_datos2(string archivo)
        { // Se crea el archivo de texto para cargar los datos y el sueldo mensual
            FileStream stream2 = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(stream2);
            // Se utiliza el ciclo for para ver el orden de como se van a imprimir los datos en el documento
            for (int x = 0; x < sueldo_mensual.Count; x++)
            {
                writer2.WriteLine(sueldo_mensual[x].Codigo);
                writer2.WriteLine(sueldo_mensual[x].Nombre);
                writer2.WriteLine(sueldo_mensual[x].Sueldo_mensual);
            }
            writer2.Close();
        }
        private void leer_datos()
        {
            FileStream stream = new FileStream("Empleados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            { // Se instancia la clase cual se va utilizar para agregar los datos de acuerdo a su tipo de dato
                Empleado persona2Temp = new Empleado();
                persona2Temp.Codigo = Convert.ToInt32(reader.ReadLine());
                persona2Temp.Nombre = reader.ReadLine();
                persona2Temp.SueldoHora = float.Parse(reader.ReadLine());
         // Se añaden los datos a lista para que se queden cargados al archivo de texto y aparezacan al principio cuando se corra el pogra
                empleados.Add(persona2Temp);

            }
        //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }
        
        private void leer_datos1()
        {
            FileStream stream2 = new FileStream("Empleadostotal.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(stream2);
            while (reader2.Peek() > -1)
            {
        // Se instancia la clase cual se va utilizar para agregar los datos de acuerdo a su tipo de dato
                Sueldo_total personaTemp = new Sueldo_total();
                personaTemp.Codigo = Convert.ToInt32(reader2.ReadLine());
                personaTemp.Nombre = reader2.ReadLine();
                personaTemp.Sueldo_mensual = Convert.ToInt32(reader2.ReadLine());
         // Se añaden los datos a lista para que se queden cargados al archivo de texto y aparezacan al principio cuando se corra el pogra
                sueldo_mensual.Add(personaTemp);
            }
        //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader2.Close();
        }

        public void guardar2(string archivo1)
        {// Se crea el archivo de texto para cargar la asistencia del empleado
            FileStream stream1 = new FileStream(archivo1, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer1 = new StreamWriter(stream1);

            //foreach (var p in asistencias)
            //{
            //    writer.WriteLine(p.Codigo);
            //    writer.WriteLine(p.Nombre);
            //    writer.WriteLine(p.SueldoHora);
            //}
            // Se utiliza el ciclo for para ver el orden de como se van a imprimir los datos en el documento
            for (int x = 0; x < asistencias.Count; x++)
            {
                writer1.WriteLine(asistencias[x].Codigo);
                writer1.WriteLine(asistencias[x].Horas);
                writer1.WriteLine(asistencias[x].Mes);
            }

            writer1.Close();
        }
        private void leer2() {
            FileStream stream1 = new FileStream("Asistencias.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(stream1);
            while (reader1.Peek() > -1)
            {
        // Se instancia la clase cual se va utilizar para agregar los datos de acuerdo a su tipo de dato
                Asistencia asistenciatemp = new Asistencia();
                asistenciatemp.Codigo = Convert.ToInt32(reader1.ReadLine());
                asistenciatemp.Horas = Convert.ToInt32(reader1.ReadLine());
                asistenciatemp.Mes = reader1.ReadLine();
    // Se añaden los datos a lista para que se queden cargados al archivo de texto y aparezacan al principio cuando se corra el pogra
                asistencias.Add(asistenciatemp);

            }
   //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader1.Close();
        }
        public void Mostrar()
        {
            // Se muestra el codigo, el nombre y el sueldo por hora del empleado
            dataGridView1_Empleado.DataSource = null;
            dataGridView1_Empleado.DataSource = empleados;
            dataGridView1_Empleado.Refresh();
        // Se muestra la asistencia del empleado
            dataGridView2_Asistencia.DataSource = null;
            dataGridView2_Asistencia.DataSource = asistencias;
            dataGridView2_Asistencia.Refresh();
        }
        
        public void Mostrar2()
        { 
            // Se muestra el codigo, el nombre y el sueldo mensual del empleado
            dataGridView1_Empleado.DataSource = null;
            dataGridView1_Empleado.DataSource = sueldo_mensual;
            dataGridView1_Empleado.Refresh();
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
                Sueldo_total empleado_mensual = new Sueldo_total();
                Asistencia asistenciatemp = new Asistencia();
                empleadotemp.Codigo = Convert.ToInt32(textCodigo.Text);
                //Int32.Parse(textCodigo.Text);
                empleadotemp.Nombre = textNombre.Text;
                empleadotemp.SueldoHora = Convert.ToInt32(textsueldohora.Text);
                asistenciatemp.Codigo = Convert.ToInt32(textCodigo.Text);
                asistenciatemp.Horas = Convert.ToInt32(textBoxHoras.Text);
                // Operación para obtener el sueldo mensual del empleado
                empleado_mensual.Sueldo_mensual = empleadotemp.SueldoHora * asistenciatemp.Horas;
                empleado_mensual.Codigo = empleadotemp.Codigo;
                empleado_mensual.Nombre = empleadotemp.Nombre;
                asistenciatemp.Mes = textBoxMes.Text;
            // Se añaden los campos o datos a la lista
                empleados.Add(empleadotemp);
                asistencias.Add(asistenciatemp);
                sueldo_mensual.Add(empleado_mensual);
                // Se añaden a los archivos de texto
                guardar_datos("Empleados.txt");
                guardar2("Asistencias.txt");
                guardar_datos2("Empleadostotal.txt");
                limpiar_campos();
                desbloqueo_botones();
            }
            catch(Exception )
            {
                // Condición para emitir si falta en llenar un campo
    MessageBox.Show("No se han llenado todos los datos", "Mi Mesaje Predeterminado", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer_datos();
            leer2();
            leer_datos1();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {  // Botón de mostrar los datos de los empleados
            Mostrar();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botón para mostrar a los empleados con su sueldo mensual y la asistencia
            dataGridView2_Asistencia.DataSource = null;
            dataGridView2_Asistencia.DataSource = asistencias;
            dataGridView2_Asistencia.Refresh();
            Mostrar2();
        }
    }
}
