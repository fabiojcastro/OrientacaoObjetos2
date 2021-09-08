using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer");
        }
        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }
        public override double GetBonifica()
        {
            return Salario * 0.17;
        }
    }
}
