using System;
using Models;
using Connection; 

namespace Repository
{
    public class FuncionarioRepository
    {
        private readonly IConnection connection;

        public FuncionarioRepository(IConnection con) => this.connection = con;

        public bool Add(Funcionario func)
        {
            var sql = $"INSERT INTO FUNCIONARIO VALUES ({func.Id}, '{func.Nome}')";
            return this.connection.ExecuteOnly(sql);
        }
    }
}