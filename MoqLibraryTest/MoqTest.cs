using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moqs;
using Repository;
using Models;

namespace MoqLibraryTest
{
    [TestClass]
    public class MoqTest
    {
        [TestMethod]
        // Correct Data
        [DataRow(1, "Jhon")]
        [DataRow(2, "Mary")]
        [DataRow(3, "false")]

        // uncorrect Data
        // [DataRow(1.0, "Joao")]
        // [DataRow(2, true)]
        // [DataRow(3, 'M')]
        // [DataRow(false, "Maria")]
        public void ToInitFuncReturnTrue(int id, string nome)
        {
            MoqConnection con = new MoqConnection();
            FuncionarioRepository repository = new FuncionarioRepository(con);

            Funcionario func = new Funcionario(id, nome);

            bool result = repository.Add(func);
            Assert.IsTrue(result);
        }
    }
}
