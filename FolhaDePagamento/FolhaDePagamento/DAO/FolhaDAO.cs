using FolhaDePagamento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.DAO
{
    class FolhaDAO
    {
        private static List<Folha> folhas = new List<Folha>();

        public static bool CadastrarFolha(Folha folha)
        {
            if (BuscarFolhaPorMesAnoCpf(folha) != null)
            {
                return false;
            }
            folhas.Add(folha);
            return true;
        }

        public static Folha BuscarFolhaPorMesAnoCpf(Folha folha)
        {
            foreach (Folha folhaCadastrada in folhas)
            {
                if (folhaCadastrada.Funcionario.Cpf.Equals(folha.Funcionario.Cpf) && 
                    folhaCadastrada.Ano == folha.Ano && folhaCadastrada.Mes == folha.Mes)
                {
                    return folhaCadastrada;
                }
            }
            return null;
        }

        public static List<Folha> BuscarFolhaPorMesAno(Folha folha)
        {
            List<Folha> folhasAux = new List<Folha>();
            foreach (Folha folhaCadastrada in folhas)
            {
                if(folhaCadastrada.Ano == folha.Ano && folhaCadastrada.Mes == folha.Mes)
                {
                    folhasAux.Add(folhaCadastrada);
                }
            }
            return folhasAux;
        }
        public static List<Folha> RetornarFolhas()
        {
            return folhas;
        }
    }
}
