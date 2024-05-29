namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cola cola = new Cola();
            Console.WriteLine("Colocando 5 elementos en la cola");
            cola.Encolar(3);
            cola.Encolar(34);
            cola.Encolar(56);
            cola.Encolar(10);
            cola.Encolar(7);
            cola.Show();

            Console.WriteLine("Retirando elementos de la cola");
            cola.Desencolar();
            cola.Show();
            cola.Desencolar();
            cola.Show();

            Console.WriteLine("Se va a retirar un nodo mas, con el valor de {0}", cola.DesencolarValor());
            cola.Show();
            Console.ReadLine();
        }
    }
}