using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente");
        }

        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }
        public override double GetBonifica()
        {
            return Salario * 0.25;
        }


    }
}
