using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_COLA_CONSOLA
{
    internal class Program
    {
       public static  Cola cola = new Cola();

        static void Main(string[] args)
        {
            int op = 0;

            do
            {




                Console.WriteLine("Bienvenido al programa!");
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Buscar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Listar");
                Console.WriteLine("6. cantidad, promedio y numero mayor");
                Console.WriteLine("7. Vistazo");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Ingrese una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: InsertarEstatura(); Console.ReadKey();Console.Clear(); break;
                    case 2: Buscar(); Console.ReadKey(); Console.Clear(); break;
                    case 3: Modificar(); Console.ReadKey(); Console.Clear(); break;
                    case 4: EliminarEstatura(); Console.ReadKey(); Console.Clear(); break;
                    case 5: ListarEstatura(); Console.ReadKey(); Console.Clear(); break;
                    case 6: CantidadEstatura(); Console.ReadKey(); Console.Clear(); break;
                    case 7:Vistazo(); Console.ReadKey(); Console.Clear(); break;
                    case 8: Console.WriteLine("Saliste :D"); Console.Clear(); break;
                    default: Console.WriteLine("Ingrese opcion valida"); break;

                }
            } while (op != 8);
        }
        public static void InsertarEstatura()
        {
            Console.WriteLine("Ingrese estatura");
            double esta= double.Parse(Console.ReadLine());
            cola.Insertar(esta);
        }
        public static void Buscar()
        {
            Console.WriteLine("Digite numero a buscar: ");
            double buscar= double.Parse(Console.ReadLine());
            if (cola.Buscar(buscar) == true)
            {
                Console.WriteLine("Dato encontrado");
            }
            else Console.WriteLine("Dato no encontrado");
        }

        public static void Modificar() 
        {
            Console.WriteLine("Ingrese la estatura a modificar: ");
                double esta= double.Parse (Console.ReadLine());
            if(cola.Buscar(esta) == true)
            {
                Console.WriteLine("Ingrese el dato a modificar: ");
                double nuevodato= double.Parse(Console.ReadLine());
                cola.Modificar(esta, nuevodato);
            }
            else Console.WriteLine("Estatura no existe");
        }
        public static void EliminarEstatura() 
        {
            cola.Eliminar();
        }
        public static void ListarEstatura() 
        {
            cola.Listar();
        }
        public static void CantidadEstatura() 
        {
            cola.Cantidad();
        }
        public static void Vistazo() 
        {
            cola.Vistazo();
        }
    }
}