using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maverick.Entidades;
using Maverick.Data.Contratos;
using System.Linq;
using Maverick.Data.Implementacao.Repositorios;

namespace Maverick.Data.Tests
{
    [TestClass]
    public class ClienteRepositorioTest
    {
        private IClienteRepositorio repositorio;

        public ClienteRepositorioTest()
        {
            repositorio = new ClienteRepositorio();
        }

        [TestMethod]
        public void TestInserirCliente()
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Nome = "Luiz Guilherme Bandeir",
                    Email = "arkanael@gmail.com",
                    DataCadastro = DateTime.Now
                };

                //Vamos chamar o método Insert do IclienteRepositorio
                repositorio.Insert(cliente);

                //Critério
                Assert.IsTrue(cliente.IdCliente > 0);
            }
            catch (Exception erro)
            {
                Assert.Fail("Falha: " + erro.Message);
            }
        }

        [TestMethod]
        public void TestExcluirCliente()
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Nome = "Luiz Guilherme Bandeira",
                    Email = "arkanael@gmail.com",
                    DataCadastro = DateTime.Now
                };


                repositorio.Insert(cliente);

                repositorio.Delete(cliente);

                //Verificar se o cliente foi excluido
                Assert.IsNull(repositorio.FindById(cliente.IdCliente));

            }
            catch (Exception erro)
            {
                Assert.Fail("Falha: " + erro.Message);
            }
        }

        [TestMethod]
        public void TestAtualizarCliente()
        {
            try
            {

                Cliente cliente = new Cliente
                {
                    Nome = "Luiz Guilherme Bandeira",
                    Email = "arkanael@gmail.com",
                    DataCadastro = DateTime.Now
                };



                repositorio.Insert(cliente);

                //Alterando os dados do cliente.
                cliente.Nome = "Luiz Guilherme Bandeira";
                cliente.Email = "luig.br@gmail.com";

                repositorio.Update(cliente);

                ///Criando um cliente para comparar com o cliente cadastrado
                ///clienteCompara recebe a resultado(cliente) do findById passando o IdCliente
                Cliente clienteCompara = repositorio.FindById(cliente.IdCliente);

                ///<summary>
                ///Compara o cliente.Nome com o clienteCompara.Nome para saber se eles não iguais.
                ///Compara o cliente.Email com o clienteCompara.Email para saber se eles não iguais.
                /// </summary>
                Assert.AreEqual(cliente.Nome, clienteCompara.Nome);
                Assert.AreEqual(cliente.Email, clienteCompara.Email);
            }
            catch (Exception erro)
            {
                Assert.Fail("Falha: " + erro.Message);
            }
        }

        [TestMethod]
        public void TestConsultarClientes()
        {
            try
            {
                Cliente primeiroCliente = new Cliente
                {
                    Nome = "Luiz Guilherme Bandeira",
                    Email = "arkanael@gmail.com",
                    DataCadastro = DateTime.Now
                };

                Cliente segundoCliente = new Cliente
                {
                    Nome = "Sherlock Homes",
                    Email = "homes@gmail.com",
                    DataCadastro = DateTime.Now
                };

                repositorio.Insert(primeiroCliente);
                repositorio.Insert(segundoCliente);

                //Buscar clientes
                List<Cliente> lista = repositorio.FindAll();

                //Verificar se a lista contém os clientes gravados.
                Assert.IsNotNull(lista.FirstOrDefault(c => c.IdCliente == primeiroCliente.IdCliente));
                Assert.IsNotNull(lista.FirstOrDefault(c => c.IdCliente == segundoCliente.IdCliente));
                
            }
            catch (Exception erro)
            {
                Assert.Fail("Falha: " + erro.Message);
            }
        }

        [TestMethod]
        public void TestConsultarPorId()
        {
            try
            {
                Cliente cliente = new Cliente
                {
                    Nome = "Luiz Guilherme Bandeira",
                    Email = "arkanael@gmail.com",
                    DataCadastro = DateTime.Now
                };

                repositorio.Insert(cliente);

                //verifica se o retorna o cliente pelo id.
                Assert.IsNotNull(repositorio.FindById(cliente.IdCliente));

            }
            catch (Exception erro)
            {
                Assert.Fail("Falha: " + erro.Message);
            }
        }
    }
}
