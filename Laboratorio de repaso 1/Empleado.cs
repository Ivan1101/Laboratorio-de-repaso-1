using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Laboratorio_de_repaso_1
{
    class Empleado
    {
        int codigo;
        string nombre;
        float sueldoHora;
       // DataTable

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float SueldoHora { get => sueldoHora; set => sueldoHora = value; }
    }
}
