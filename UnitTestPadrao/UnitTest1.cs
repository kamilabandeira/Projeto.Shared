using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Shared;
using System;

namespace UnitTestPadrao
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Inicializar() 
        {
            //usuario = new Usuario();
        }

        [TestMethod]
        public void VerificaIdadeDeRisco_Idade18Anos_ResultadoTrue()
        {
            int idade = 18;
            bool resultado = Helper.verificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void VerificaIdadeDeRisco_Idade15Anos_ResultadoFalse()
        {
            int idade = 15;
            bool resultado = Helper.verificaNomeDeRisco(idade);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void TestarNomeRisco()
        {
            string nome = "Kamila";
            bool resultado = Helper.verificaNomeDeRisco(nome);
            Assert.IsTrue(resultado);
        }
    }
}


// Trabalhar com objeto e quise inicializar 