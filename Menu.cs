using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_studies
{
    internal class Menu
    {
        Servico servico = new Servico();

        private string opcaoUsuario;

        public void IniciarPrograma()
        {
            ExibirMenuInicial();
        }

        private void ExibirMenuInicial()
        {
            Console.WriteLine("(1) Cadastrar funcionário \n Visualizar usuário(s) \n Editar usuário " +
                "\n Deletar usuário");

            opcaoUsuario = ReceberOpcaoUsuario();

            EscolherMenu(opcaoUsuario);
        }

        private string ReceberOpcaoUsuario()
        {
            string inputOpcaoUsuario = null;

            while (string.IsNullOrEmpty(inputOpcaoUsuario))
            {
                inputOpcaoUsuario = Console.ReadLine();

                if (string.IsNullOrEmpty(inputOpcaoUsuario))
                {
                    Console.WriteLine("A entrada não pode ser nula");
                }
            }
            return inputOpcaoUsuario!;
        }

        private void EscolherMenu(string opcaoUsuario)
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ExibirMenuCadastro();
                    break;
                default:
                    Console.WriteLine("Funcionalidade não implementada");
                    Thread.Sleep(1000);
                    break;
            }
        }

        private void ExibirMenuCadastro()
        {
            Console.WriteLine("Informe o nome do funcionário");
            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine("Informe o vínculo empregatício do funcionário \n (1) CLT \n (2) Não Possui (Estágio)");
            string vinculoEmpregaticioUsuario = Console.ReadLine();

            Console.WriteLine("Informe a matrícula do funcionário");
            string matriculaFuncionario = Console.ReadLine();

            //Serviço precisa ser público pro código funcionar? Alterar isso, serviço é um objeto
            servico.ValidarFuncionario(nomeFuncionario, vinculoEmpregaticioUsuario, matriculaFuncionario);
        }
    }
}