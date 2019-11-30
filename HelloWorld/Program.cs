using System;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Teste();
            teste.AlterarNome("Eduardo");

            Console.WriteLine($"Hello World {teste.Nome}");
        }
    }   
}


