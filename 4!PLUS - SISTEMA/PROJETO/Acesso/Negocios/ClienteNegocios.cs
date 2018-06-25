using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //Instanciar = Criar novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            {

            
            acessoDadosSqlServer.LimparParamentros();
            acessoDadosSqlServer.AdicionarParametros("@NOME", cliente.NOME);
            acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
            acessoDadosSqlServer.AdicionarParametros("@CEP", cliente.CEP);
            acessoDadosSqlServer.AdicionarParametros("@ENDEREÇO", cliente.ENDEREÇO);
            acessoDadosSqlServer.AdicionarParametros("@NUMERO", cliente.NUMERO);
            acessoDadosSqlServer.AdicionarParametros("@COMPLEMENTO", cliente.COMPLEMENTO);
            acessoDadosSqlServer.AdicionarParametros("@BAIRRO", cliente.BAIRRO);
            acessoDadosSqlServer.AdicionarParametros("@CIDADE", cliente.CIDADE);
            acessoDadosSqlServer.AdicionarParametros("@UF", cliente.UF);
            acessoDadosSqlServer.AdicionarParametros("@TEL_RESIDENCIAL", cliente.TEL_RESIDENCIAL);
            acessoDadosSqlServer.AdicionarParametros("@TEL_CELULAR", cliente.TEL_CELULAR);
            acessoDadosSqlServer.AdicionarParametros("@EMAIL", cliente.EMAIL);

            string ID_CLIENTE = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure,"uspClienteInserir").ToString();
            
            return ID_CLIENTE;
           }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", cliente.ID_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@NOME", cliente.NOME);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cliente.CPF);
                acessoDadosSqlServer.AdicionarParametros("@CEP", cliente.CEP);
                acessoDadosSqlServer.AdicionarParametros("@ENDEREÇO", cliente.ENDEREÇO);
                acessoDadosSqlServer.AdicionarParametros("@NUMERO", cliente.NUMERO);
                acessoDadosSqlServer.AdicionarParametros("@COMPLEMENTO", cliente.COMPLEMENTO);
                acessoDadosSqlServer.AdicionarParametros("@BAIRRO", cliente.BAIRRO);
                acessoDadosSqlServer.AdicionarParametros("@CIDADE", cliente.CIDADE);
                acessoDadosSqlServer.AdicionarParametros("@UF", cliente.UF);
                acessoDadosSqlServer.AdicionarParametros("@TEL_RESIDENCIAL", cliente.TEL_RESIDENCIAL);
                acessoDadosSqlServer.AdicionarParametros("@TEL_CELULAR", cliente.TEL_CELULAR);
                acessoDadosSqlServer.AdicionarParametros("@EMAIL", cliente.EMAIL);
                string ID_CLIENTE = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();
                return ID_CLIENTE;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir (Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", cliente.ID_CLIENTE);
                string ID_CLIENTE = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                return ID_CLIENTE;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public ClienteColecao ConsultarPorNome(string NOME)
        {

             try
            {
               //Criar coleção nova de clientes 
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME", NOME);
              


                // TABELA DE DADOS
                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                 //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                 //Linha de Dados

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    Cliente cliente = new Cliente();
                    cliente.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    cliente.NOME = Convert.ToString(linha["NOME"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.CEP = Convert.ToString(linha["CEP"]);
                    cliente.ENDEREÇO = Convert.ToString(linha["ENDEREÇO"]);
                    cliente.NUMERO = Convert.ToInt32(linha["NUMERO"]);
                    cliente.COMPLEMENTO = Convert.ToString(linha["COMPLEMENTO"]);
                    cliente.BAIRRO = Convert.ToString(linha["BAIRRO"]);
                    cliente.CIDADE = Convert.ToString(linha["CIDADE"]);
                    cliente.UF = Convert.ToString(linha["UF"]);
                    cliente.TEL_RESIDENCIAL = Convert.ToString(linha["TEL_RESIDENCIAL"]);
                    cliente.TEL_CELULAR = Convert.ToString(linha["TEL_CELULAR"]);
                    cliente.EMAIL = Convert.ToString(linha["EMAIL"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }

        public ClienteColecao ConsultarPorId(int ID_CLIENTE)
        {
            try
            {
                ClienteColecao clienteColecao = new ClienteColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", ID_CLIENTE);

                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorID");

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    cliente.NOME = Convert.ToString(linha["NOME"]);
                    cliente.CPF = Convert.ToString(linha["CPF"]);
                    cliente.CEP = Convert.ToString(linha["CEP"]);
                    cliente.ENDEREÇO = Convert.ToString(linha["ENDEREÇO"]);
                    cliente.NUMERO = Convert.ToInt32(linha["NUMERO"]);
                    cliente.COMPLEMENTO = Convert.ToString(linha["COMPLEMENTO"]);
                    cliente.BAIRRO = Convert.ToString(linha["BAIRRO"]);
                    cliente.CIDADE = Convert.ToString(linha["CIDADE"]);
                    cliente.UF = Convert.ToString(linha["UF"]);
                    cliente.TEL_RESIDENCIAL = Convert.ToString(linha["TEL_RESIDENCIAL"]);
                    cliente.TEL_CELULAR = Convert.ToString(linha["TEL_CELULAR"]);
                    cliente.EMAIL = Convert.ToString(linha["EMAIL"]);

                    clienteColecao.Add(cliente);
                }

                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }
    }
}
