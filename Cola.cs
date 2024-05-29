using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Cola
    {
        public Nodo primero;
        public Nodo ultimo;

        public Cola() {
            primero = ultimo = null;
        }

        public void Encolar(int valor)
        {
            Nodo aux = new Nodo();
            aux.info = valor;
            if (primero == null) { 
                primero = ultimo=aux;
                aux.sgte = null;
            }
            else
            {
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }

        }

        public void Desencolar()
        {
            if(primero == null)
            {
                Console.WriteLine("La cola esta vacia");
            }
            else
            {
                primero = primero.sgte;
            }
        }

        public int DesencolarValor()
        {
            int valor = 0;
            if (primero == null)
            {
                Console.WriteLine("La cola esta vacia");
            }
            else
            {
                valor = primero.info;
                primero = primero.sgte;
            }
            return valor;
        }

        public void Show()
        {
            if (primero == null)
            {
                Console.WriteLine("La cola esta vacia");
            }
            else
            {
                Nodo puntero;
                puntero = primero;
                do {
                    Console.WriteLine("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                }while(puntero != null);
                Console.WriteLine("\n");
            }
        }
    }
}
