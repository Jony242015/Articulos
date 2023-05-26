using POO2.Entities;
using POO2.Services;
using System;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Pedir();
            persona.Imprimir();
            
        }
    }
}
