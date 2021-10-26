using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("123.456.789");
            roberta.Nome = "roberta";
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");

            Gerente camila = new Gerente("123.456.789");
            camila.Nome = "camila";
            camila.Senha = ("abc");
            sistemaInterno.Logar(camila, "abc");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";
            sistemaInterno.Logar(parceiro, "123");


            Console.ReadLine();
        }

    }
}

