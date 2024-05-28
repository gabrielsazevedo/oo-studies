using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_studies
{
    internal class FolhaDePagamento
    {
        private decimal saldo;

        public void Calcular(IRemuneravel funcionario)
        {
            saldo = funcionario.Remuneracao();
            Console.WriteLine(saldo);
        }
    }
}
