using System;

namespace Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}