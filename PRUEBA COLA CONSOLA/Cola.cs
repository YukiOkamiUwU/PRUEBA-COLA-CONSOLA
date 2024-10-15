using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_COLA_CONSOLA
{
    internal class Cola
    {

        Nodo pri, ulti = null;
        int cantidad = 0;

        public Cola()
        {
            pri = null;
            ulti= null;
        }

        public void Insertar(double esta) 
        {
            Nodo nuevo= new Nodo();
            nuevo.Estatura = esta;
            if(Buscar(esta)==true) { Console.WriteLine("Dato ya existe"); }
            else if (pri==null) 
            { 
                pri = nuevo;
                ulti = nuevo;
                ulti.Siguiente = null;
            }
            else 
            {
                ulti.Siguiente= nuevo;
                ulti= nuevo;
                ulti.Siguiente= null;
            }
            cantidad++;
        }
        public bool Buscar(double dato) 
        {
            Nodo actual = pri;
            while(actual!=null) 
            {
                if(actual.Estatura==dato) 
                {
                    return true;
                }
                actual=actual.Siguiente;
            }return false;
        }

        public void Modificar( double d1, double d2) 
        {
            Nodo actual=pri;
            while(actual!=null) 
            {
                if(actual.Estatura==d1) { actual.Estatura = d2; }
                actual=actual.Siguiente;
            }
        }
        public void Eliminar() 
        {
            if(pri==null) { Console.WriteLine("La cola esta vacia!"); }
            else 
            {
                pri = pri.Siguiente;
                Console.WriteLine("Dato desencolado");
            }
            cantidad--;
        }
        public void Listar() 
        {
            Nodo actual= pri;
            if (pri != null)
            {
                while (actual != null)
                {
                    Console.WriteLine("{0}", actual.Estatura);
                    actual = actual.Siguiente;
                }
            }
            else Console.WriteLine("La cola esta vacia");
        }
        public void Cantidad() 
        {
            Nodo actual= pri;
            int cantidad=0;
            double suma = 0.0;
            double mayor = actual.Estatura;

            while (actual != null) 
            {
                cantidad++;
                suma+= actual.Estatura; 

                if(actual.Estatura>mayor) 
                {
                    mayor =actual.Estatura;
                }
                actual = actual.Siguiente;

            }
            Console.WriteLine("La cola tiene: "+ cantidad+ " , El promedio es: "+suma/cantidad+", El dato mayor es: "+mayor);
            Console.ReadKey();
        }
        public double Vistazo()
        {
            if (pri == null)
            {
                Console.WriteLine("Cola Vacia");
                return -1;
            }
            else Console.WriteLine("Ultimo elemento: {0}" ,pri.Estatura);
            return pri.Estatura;
        }
    }
}
