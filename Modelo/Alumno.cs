using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion.Modelo
{
    public class Alumno
    {
        private string nombre, apellido, apellido2;
        private int dni;

        public Alumno() 
        { 
            
        }

        public Alumno(string nombre, string apellido, string apellido2, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.apellido2 = apellido2;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
