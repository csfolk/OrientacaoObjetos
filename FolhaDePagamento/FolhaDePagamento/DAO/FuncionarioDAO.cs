using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.DAO
{
    class FuncionarioDAO
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        public static bool CadastrarFuncionario(Funcionario funcionario)
        {
            if (BuscarFuncionarioPorCpf(funcionario) != null)
            {
                return false;
            }
            funcionarios.Add(funcionario);
            return true;
        }

        public static Funcionario BuscarFuncionarioPorCpf(Funcionario cliente)
        {
            foreach (Funcionario funcionarioCadastrado in funcionarios)
            {
                if (funcionarioCadastrado.Cpf.Equals(cliente.Cpf))
                {
                    return funcionarioCadastrado;
                }
            }
            return null;
        }
        public static List<Funcionario> RetornarFuncionarios()
        {
            return funcionarios;
        }
    }
}
