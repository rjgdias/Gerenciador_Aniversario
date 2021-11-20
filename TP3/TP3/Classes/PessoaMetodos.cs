using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Classes
{
    public class PessoaMetodos
    {
        private static List<Pessoa> ListarPessoas = new List<Pessoa>();
        public static void CadastrarUsuario(Pessoa pessoa)
        {
            if (pessoa != null)
                ListarPessoas.Add(pessoa);
        }
        public static List<Pessoa> BuscarPessoas(string busca)
        {
            List<Pessoa> usuario = new List<Pessoa>();
            foreach (var pessoa in ListarPessoas)
            {
                if (pessoa.Nome.Contains(busca) || pessoa.Sobrenome.Contains(busca))
                    usuario.Add(pessoa);
            }
            return usuario;
        }
        public static string ExibirCadastros(Pessoa pessoa)
        {
            string dados = $"\nNome completo: {pessoa.Nome} {pessoa.Sobrenome}" +
                $"\nData de Nascimento: {pessoa.Data.ToString("d")}" +
                $"\nFaltam {pessoa.CalcularDat()} dias para seu próximo aniversário";
            return dados;
        }
    }
}
