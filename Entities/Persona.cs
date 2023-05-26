using POO2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.Entities
{
    public class Persona
    {
        ArticulosP articulos = new ArticulosP();
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public void Pedir()
        {
            Console.WriteLine("Escribe tu nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu numero telefonico: ");
            Telefono = Console.ReadLine();
            Console.WriteLine("Escribe tu correo electronico");
            Correo = Console.ReadLine();  
            Console.Clear();
            articulos.Objetos();
            articulos.Promociones();
        }
        public void Imprimir()
        {
            Console.WriteLine($"Tu nombre es: {Nombre}\nTu numero telefonico es: {Telefono}\nTu correo es: {Correo}");
        }
    }
}
