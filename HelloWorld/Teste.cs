 using System;

 namespace HelloWorld
 {
        public class Teste
        {
            public int ID { get; private set; }
            public string Nome { get; private set; }

            public void AlterarNome(string nome)
            {
                Nome = nome;
            }
        }
     
 }