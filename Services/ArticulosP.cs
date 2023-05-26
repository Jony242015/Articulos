using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2.Services
{
    public class ArticulosP
    {
        //hola hola
        double total,descuento,art;
        public void Objetos ()
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Precio del articulo " + (i+1) + ": ");
                art = double.Parse(Console.ReadLine());
                total = total + art;
            }
            Console.Clear();
        }
        public void Promociones()
        {
            if (total >= 5000 && total < 8000)
            {
                Console.WriteLine("Felicidades tienes descuento del 10%");
                descuento = total * 0.9;
                Console.WriteLine($"El total con descuento es de {descuento}");
            }
            if (total >= 8000 && total < 10000)
            {
                Console.WriteLine("Felicidades tienes 3 meses sin intereses");
                descuento = total / 3;
                Console.WriteLine($"Tu pago por mes es: {descuento} por 3 meses");
            }
            if (total >= 10000)
            {
                int opcion;
                Console.WriteLine("Felicidades tienes meses sin intereses, eliege entre una de las opciones:");
                Console.WriteLine("1.- 6 MSI | 2.- 12 MSI");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcion == 1)
                {
                    descuento = total / 6;
                    Console.WriteLine("Ha seleccionado a 6 meses sin intereses");
                    Console.WriteLine($"Su pago es de {descuento} por 6 meses");
                }
                else
                {
                    descuento = total / 12;
                    Console.WriteLine($"Ha seleccionado a 12 meses sin intereses");
                    Console.WriteLine($"Tu pago es de: {descuento} por 12 meses");
                }
            }
        }
    }
}
