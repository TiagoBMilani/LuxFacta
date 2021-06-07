using DesafioLuxfacta.ConsoleApplication.Challenges;
using System;

namespace DesafioLuxfacta.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Você pode utilizar o console para testar seus métodos!
            // Modifique o código abaixo a vontade, não há regras para este arquivo!
            var lf = new LuxFacta(10);
            Console.WriteLine(lf.Say());
            Console.Read();
        }
    }
}
