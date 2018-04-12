using FolhaDePagamento.DAO;
using FolhaDePagamento.Model;
using FolhaDePagamento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.View
{
    class CadastrarFuncionario
    {
        public static void Executar()
        {
            Funcionario funcionario = new Funcionario();
            Console.Clear();
            Console.WriteLine("  -- CADASTRAR FUNCIONÁRIO -- \n");
            Console.WriteLine("Digite o nome do funcionário:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do funcionário:");
            funcionario.Cpf = Console.ReadLine();
            if (Validar.Cpf(funcionario.Cpf))
            {
                if (FuncionarioDAO.CadastrarFuncionario(funcionario))
                {
                    Console.WriteLine("Funcionário cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Funcionário já existente!");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }
        }
    }
}
