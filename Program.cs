using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaracion_y_manipualcionde_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo = "", carrera = "", bienvenido = "";
            do {
                Console.Clear();
                Console.WriteLine("*************MENU DE OPCIONES**************");
                Console.WriteLine("1.Leer código de estudiante y carrera.");
                Console.WriteLine("2. Formar una nueva etiqueta textual con ambos (concatenado).");
                Console.WriteLine("3. Mostrar longitud de caracteres del código, carrera y etiqueta.");
                Console.WriteLine("4. Mostrar el primer y último carácter del código.");
                Console.WriteLine("5. Imprimir la carrera carácter por carácter.");    
                Console.WriteLine("6. Cree una nueva etiqueta de bienvenida agregando \"Periodo: 2026-2“ al final de la carrera.");
                Console.WriteLine("7.salir del menu");
                opcion=int.Parse(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        Console.WriteLine("ingrese el codigo");
                        codigo = Console.ReadLine();
                        Console.WriteLine("carrera: ");
                        carrera=Console.ReadLine();
                        break;
                    case 2:
                        bienvenido = codigo +" |carrera: "+ carrera;
                        Console.WriteLine("etiqueta generada: "+ bienvenido);
                        break;
                    case 3:
                        Console.WriteLine("la longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("la longitud del la carrera es: " + carrera.Length);
                        Console.WriteLine("la longitud del saludo es: " + bienvenido.Length);
                        break;
                    case 4:
                        Console.WriteLine("el primer caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length-1]);
                        break;
                    case 7:
                        Console.WriteLine("saliendo");
                        break;
                    default: Console.WriteLine("opcion no valida");
                        break;
                    
                }
                Console.ReadKey();
            }
            while (opcion !=7);


        }
    }
}
