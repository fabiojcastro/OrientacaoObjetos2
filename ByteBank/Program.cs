using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("123.456.789");
            pedro.Nome = "pedro";

            Diretor roberta = new Diretor("123.456.789");
            roberta.Nome = "roberta";

            Auxiliar igor = new Auxiliar("123.456.789");
            igor.Nome = "igor";

            Gerente camila = new Gerente("123.456.789");
            camila.Nome = "camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
            gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }

    }
}

