using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Informe as notas:");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine("A media das notas informadas eh:" + media);












        }
    }
}
