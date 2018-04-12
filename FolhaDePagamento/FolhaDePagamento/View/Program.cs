using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaDePagamento.View
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dados.Inicializar();
            //Cliente c;
            int op = 5;
            do
            {
                Console.Clear();
                Console.WriteLine(" -- FOLHA DE PAGAMENTOS -- \n");
                Console.WriteLine("1 - Cadastrar funcionário");
                Console.WriteLine("2 - Cadastrar folha de pagamento");
                Console.WriteLine("3 - Consultar folha de pagamento");
                Console.WriteLine("4 - Listar folhas de pagamento");
                Console.WriteLine("0 - Sair\n");
                Console.WriteLine("Escolha uma opção:");

                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CadastrarFuncionario.Executar();
                        break;
                    case 2:
                        CadastrarFolha.Executar();
                        break;
                    case 3:
                        ConsultarFolha.Executar();
                        break;
                    case 4:
                        ConsultarFolhas.Executar();
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar...");
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
