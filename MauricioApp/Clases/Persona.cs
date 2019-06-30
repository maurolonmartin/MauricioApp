using System;
using System.Collections.Generic;
using System.Text;

namespace MauricioApp.Clases
{
    public class Persona
    {
        public string Nombre;
        public string Apellido;
        public string Apodo;
        public Moto Moto;
        public DateTime FechaNacimiento;
        private decimal Sueldo;

        public Persona(string nombre, string apellido, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string Presentarse()
        {
            return "Hola mi nombre es: " + Nombre + " y mi apodo es: " + Apodo;
        }

        public int ObtenerEdad()
        {
            int edad = (DateTime.Now.Year - FechaNacimiento.Year);
            return edad;
        }

        public string SaberSiEsAdinerado()
        {
            CalcularSueldo();

            if (Sueldo > 35000000)
            {
                return "Es adinerado";
            }
            else
            {
                return "Es pobre";
            }
         
        }

        private void CalcularSueldo()
        {
            Sueldo = (ObtenerEdad() * 1000000);
           
        }
    }
}
