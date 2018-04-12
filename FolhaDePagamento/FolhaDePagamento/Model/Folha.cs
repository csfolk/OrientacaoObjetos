using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.Model
{
    class Folha
    {
        public Folha()
        {
            Funcionario = new Funcionario();
        }
        public Funcionario Funcionario { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public double ValorHora { get; set; }
        public int QuantidadeHoras { get; set; }
    }
}
