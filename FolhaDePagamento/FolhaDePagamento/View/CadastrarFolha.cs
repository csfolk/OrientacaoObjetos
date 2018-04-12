using FolhaDePagamento.DAO;
using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.View
{
    class CadastrarFolha
    {
        public static void Executar()
        {
            Folha folha = new Folha();
            Console.Clear();
            Console.WriteLine("  -- CADASTRAR FOLHA DE PAGAMENTO -- \n");
            Console.WriteLine("Digite o CPF do funcionário:");
            folha.Funcionario.Cpf = Console.ReadLine();
            folha.Funcionario = FuncionarioDAO.BuscarFuncionarioPorCpf(folha.Funcionario);
            if (folha.Funcionario != null)
            {
                Console.WriteLine("Digite o mês da folha de pagamento:");
                folha.Mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o ano da folha de pagamento:");
                folha.Ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de horas trabalhadas da folha de pagamento:");
                folha.QuantidadeHoras = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o valor da hora trabalhada da folha de pagamento:");
                folha.ValorHora = Convert.ToDouble(Console.ReadLine());
                if (FolhaDAO.CadastrarFolha(folha))
                {
                    Console.WriteLine("Folha cadastrada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Essa folha já existe!");
                }
            }
            else
            {
                Console.WriteLine("Esse funcionário não existe!");
            }
        }
    }
}
