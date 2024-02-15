using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirMayusculaMinuscula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este codigo sirve para  cambiar las cadenas a mayuscula o minuscula segun sea el 
            // caso

            Console.WriteLine("Registro de ingreso nuevo \n");
            


            Console.Write("Por favor, ingresa tu nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Por favor, ingresa tu correo electronico: ");
            string email = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Por favor verifica la informacion \n");

            // metodo ToUpper()
            Console.WriteLine("Convertivos tu Nombre a mayuscula {0}", nombre.ToUpper());
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("Tu nombre ha sido convertido a mayuscula y era {0}\n", nombre);

            Console.WriteLine("*******************************************************\n");

            // metodo ToUpper()
            Console.WriteLine("Convertivos tu email a minuscula {0}\n", email.ToLower());
            Console.WriteLine("Tu email ha sido convertido a minuscula y era {0}", email);
            Console.ReadKey();
            Console.Clear();

            // Existen dos metods pero para cambiar unicamente un char
            // Char.ToUpper()
            // Char.ToLower()







        }
    }
}
