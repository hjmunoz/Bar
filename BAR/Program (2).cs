using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que indique si es mayor de edad, puede entrar a un bar y si compra
             * una botella de ron o guaro, entra a zona VIP, ojo tiene que tener cedula, no contraseña. ademas si compra
             * 2 de guaro o ron le encima media.*/
            //variables
            Console.WriteLine("BIENVENIDO AL BAR X, PARA INGRESAR AL BAR DILIGENCIE LA SIGUIENTE INFORMACION:");
            int Edad;
            string Documento;
            string compra;
            int cantidad;
            Console.WriteLine("DIGITE SU EDAD");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DOCUMENTO");
            Documento = Console.ReadLine();
            Console.WriteLine("QUE DESEA COMPRAR");
            compra = (Console.ReadLine());
            Console.WriteLine("DIGITE LA CANTIDAD");
            cantidad = Convert.ToInt32(Console.ReadLine());

            if (Edad >= 18 && Documento == "cc" && compra == "Ron" && cantidad < 2)
            {
                Console.WriteLine("INGRESAR A ZONA VIP");
            }
            else if (Edad >= 18 && Documento == "cc" && compra == "Ron" && cantidad >= 2)
            {
                Console.WriteLine("INGRESA A ZONA VIP Y SE LE ENCIMA MEDIA DE RON");
            }
            else if (Edad >= 18 && Documento == "cc" && compra == "Guaro" && cantidad < 2)
            {
                Console.WriteLine("INGRESA A ZONA VIP");
            }
            else if (Edad >= 18 && Documento == "cc" && compra == "Guaro" && cantidad >= 2)
            {
                Console.WriteLine("INGRESA A ZONA VIP Y SE LE ENCIMA MEDIA DE GUARO");
            }

            Console.ReadKey();
        }
    }
}
