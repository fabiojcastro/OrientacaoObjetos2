using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override void AumentaSalario()
        {
            Salario *= 1.1;
        }
        public override double GetBonifica()
        {
            return Salario * 0.2;
        }


    }
}
