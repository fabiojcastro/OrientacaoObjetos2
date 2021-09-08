using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonifica()
        {
            return Salario * 0.5;
        }


    }
}
