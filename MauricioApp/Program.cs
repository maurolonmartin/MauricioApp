using MauricioApp.Clases;
using System;

namespace MauricioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Saludar());

            Persona mauricio = new Persona("Mauricio","Londoño", new DateTime(1979, 10, 31));
            Persona juan = new Persona("Juan", "Mira", new DateTime(1987, 4, 22));

            VerificarOpulencia(mauricio);
            VerificarOpulencia(juan);

            mauricio.Moto = new Moto();

            mauricio.Moto.Marca = "Auteco";
            mauricio.Moto.Modelo = "2017";
            mauricio.Moto.Cilindraje = "200";

            //Console.WriteLine(
            //    "La moto de Mauricio es de marca: " + mauricio.Moto.Marca +
            //    ", el cilindraje es: " + mauricio.Moto.Cilindraje +
            //    " y el modelo es: " + mauricio.Moto.Modelo);
            //Console.ReadLine();       
        }

        private static void VerificarOpulencia(Persona persona)
        {
            Console.WriteLine(persona.Nombre + " " + persona.SaberSiEsAdinerado());
            Console.ReadLine();

            Console.WriteLine("Por favor indique el apodo de  " + persona.Nombre);
            persona.Apodo = Console.ReadLine();

            Console.WriteLine(persona.Nombre + " " + persona.Apellido + " alias " + persona.Apodo + " Edad: " + persona.ObtenerEdad());
            Console.WriteLine(persona.Nombre + " nacio " + persona.FechaNacimiento.Year + " mes " + persona.FechaNacimiento.Month);
            Console.ReadLine();

            Console.WriteLine(persona.Nombre + " se presenta: " + persona.Presentarse());
            Console.ReadLine();
        }

        private static string Saludar()
        {
            return "Hola que mas, como estas!!!";
        }
    }
}
