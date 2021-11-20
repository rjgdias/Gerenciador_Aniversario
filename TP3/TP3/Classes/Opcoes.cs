using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP3.Classes
{
    class Opcoes
    {
        #region Menu
        public static void Menu()
        {
            bool menu = true;
            string opcao;
            do
            {
                Console.WriteLine("\nGerenciador de aniversários"
                    + "\n1 - Adicionar pessoas"
                    + "\n2 - Buscar pessoa"
                    + "\n3 - Sair");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        AdicionarPessoas();
                        break;
                    case "2":
                        BuscarPessoas();
                        break;
                    case "3":
                        menu = false;
                        Console.WriteLine("Aperte alguma tecla para sair.");
                        break;
                    default:
                        break;
                }
            } while (menu);
        }
        #endregion
        #region Adicionar
        public static void AdicionarPessoas()
        {
            string nome, sobrenome;
            DateTime dataNascimento;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();

            do
                Console.WriteLine("Digite sua data de nascimento: (dd/mm/yy)");
            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento));
            Console.WriteLine($"\nNome:{nome} {sobrenome}" +
                $"\nData de nascimento: {dataNascimento.ToString("d")}" +
                $"\nSeus dados estão corretos? (S / N)");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                Pessoa pessoa = new Pessoa()
                {
                    Nome = nome,
                    Sobrenome = sobrenome,
                    Data = dataNascimento
                };
                PessoaMetodos.CadastrarUsuario(pessoa);
                Console.WriteLine("\nUsuário cadastrado com sucesso!");
            }
            else
                Console.WriteLine("\nUsuário não cadastrado!"
                    + "\nTente novamente!");
            Console.Clear(); Console.ReadLine();
        }
        #endregion
        #region Buscar
        public static void BuscarPessoas()
        {
            List<Pessoa> usuarios;
            Console.WriteLine("Digite o nome de usuário que deseja buscar:");
            string nome = Console.ReadLine().ToUpper();
            int index = 0;
            int escolha;
            usuarios = PessoaMetodos.BuscarPessoas(nome);

            if (!usuarios.Any())
                Console.WriteLine("Usuário não encontrado");
            else
            {
                foreach (var pessoa in usuarios)
                {
                    Console.WriteLine($"{index} - {pessoa.Nome} {pessoa.Sobrenome}");
                    index++;
                }
                do
                    Console.WriteLine("Escolha um usuário:");
                while (!int.TryParse(Console.ReadLine(), out escolha));
                if (escolha < usuarios.Count)
                    Console.WriteLine(PessoaMetodos.ExibirCadastros(usuarios[escolha]));
                else
                    Console.WriteLine("Opção inválida!");
            }
            Console.Clear(); Console.ReadLine();
        }
        #endregion
        #region Lista
        
        #endregion
    }
}