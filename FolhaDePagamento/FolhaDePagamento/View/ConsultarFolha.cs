using FolhaDePagamento.DAO;
using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasOsorioB.Utils;

namespace FolhaDePagamento.View
{
    class ConsultarFolha
    {
        public static void Executar()
        {
            Folha folha = new Folha();
            Console.Clear();
            Console.WriteLine("  -- CONSULTAR FOLHA DE PAGAMENTO -- \n");
            Console.WriteLine("Digite o CPF do funcionário:");
            folha.Funcionario.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o mês da folha de pagamento:");
            folha.Mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano da folha de pagamento:");
            folha.Ano = Convert.ToInt32(Console.ReadLine());
            folha = FolhaDAO.BuscarFolhaPorMesAnoCpf(folha);
            if (folha != null)
            {
                Console.WriteLine("\nNome: " + folha.Funcionario.Nome);
                double bruto = Calcular.CalcularSalarioBruto(folha.QuantidadeHoras, folha.ValorHora);
                Console.WriteLine("\tSalário bruto: " + bruto.ToString("C2"));
                Console.WriteLine("\tIRRF: " + Calcular.CalcularIRRF(bruto).ToString("C2"));
                Console.WriteLine("\tINSS: " + Calcular.CalcularINSS(bruto).ToString("C2"));
                Console.WriteLine("\tFGTS: " + Calcular.CalcularFGTS(bruto).ToString("C2"));
                double liquido = Calcular.CalcularSalarioLiquido(
                        bruto,
                        Calcular.CalcularINSS(bruto),
                        Calcular.CalcularFGTS(bruto));
                Console.WriteLine("\tSalário Líquido: " + liquido.ToString("C2"));
            }
            else
            {
                Console.WriteLine("Essa folha não existe!");
            }
        }
    }
}