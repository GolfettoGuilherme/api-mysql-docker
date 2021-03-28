using System;
namespace Estudo_Api_Com_Banco.Models
{
    public class Aluno
    {

        public Aluno()
        {

        }

        public Aluno(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
