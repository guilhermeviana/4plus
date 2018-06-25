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
    public class OsNegocios
    {
        //Instanciar = Criar novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(OrdemServico ordemServico)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", ordemServico.ID_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@ID_DEFEITO", ordemServico.ID_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@ID_VEICULO", ordemServico.ID_VEICULO);
                acessoDadosSqlServer.AdicionarParametros("@ID_MECANICA", ordemServico.ID_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@DATA", ordemServico.DATA);
                acessoDadosSqlServer.AdicionarParametros("@STATUS_OS", ordemServico.STATUS_OS);
                acessoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", ordemServico.NOME_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@CPF_CLIENTE", ordemServico.CPF_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@PLACA_CLIENTE", ordemServico.PLACA_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@MARCA_CLIENTE", ordemServico.MARCA_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@MODELO_CLIENTE", ordemServico.MODELO_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@ANO_CLIENTE", ordemServico.ANO_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@NOME_MECANICA", ordemServico.NOME_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@NOME_DEFEITO", ordemServico.NOME_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@DESCRIÇÃO_DEFEITO", ordemServico.DESCRIÇÃO_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_DEFEITO", ordemServico.VALOR_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_MECANICA", ordemServico.VALOR_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_OFICINA", ordemServico.VALOR_OFICINA);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_TOTAL", ordemServico.VALOR_OFICINA);
                acessoDadosSqlServer.AdicionarParametros("@CADASTRO", ordemServico.CADASTRO);

                string ID_OS = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOsInserir").ToString();

                return ID_OS;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(OrdemServico ordemServico)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_OS", ordemServico.ID_OS);
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", ordemServico.ID_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@ID_DEFEITO", ordemServico.ID_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@ID_VEICULO", ordemServico.ID_VEICULO);
                acessoDadosSqlServer.AdicionarParametros("@ID_MECANICA", ordemServico.ID_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@DATA", ordemServico.DATA);
                acessoDadosSqlServer.AdicionarParametros("@STATUS_OS", ordemServico.STATUS_OS);
                acessoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", ordemServico.NOME_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@CPF_CLIENTE", ordemServico.CPF_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@PLACA_CLIENTE", ordemServico.PLACA_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@MARCA_CLIENTE", ordemServico.MARCA_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@MODELO_CLIENTE", ordemServico.MODELO_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@ANO_CLIENTE", ordemServico.ANO_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@NOME_MECANICA", ordemServico.NOME_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@NOME_DEFEITO", ordemServico.NOME_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@DESCRIÇÃO_DEFEITO", ordemServico.DESCRIÇÃO_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_DEFEITO", ordemServico.VALOR_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_MECANICA", ordemServico.VALOR_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_OFICINA", ordemServico.VALOR_OFICINA);
                acessoDadosSqlServer.AdicionarParametros("@VALOR_TOTAL", ordemServico.VALOR_OFICINA);
                acessoDadosSqlServer.AdicionarParametros("@CADASTRO", ordemServico.CADASTRO);


                string ID_OS = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOsAlterar").ToString();
                return ID_OS;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir(OrdemServico ordemServico)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_OS", ordemServico.ID_OS);
                string ID_OS = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOsExcluir").ToString();
                return ID_OS;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public OrdemServicoColecao ConsultarPorNome(string NOME_CLIENTE)
        {

            try
            {
                //Criar coleção nova de clientes 
                OrdemServicoColecao ordemServicoColecao = new OrdemServicoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", NOME_CLIENTE);



                // TABELA DE DADOS
                DataTable dataTableOrdemServico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspOsConsultarPorNome");

                //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                //Linha de Dados

                foreach (DataRow linha in dataTableOrdemServico.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    OrdemServico ordemServico = new OrdemServico();

                    ordemServico.ID_OS = Convert.ToInt32(linha["ID_OS"]);
                    ordemServico.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    ordemServico.ID_DEFEITO = Convert.ToInt32(linha["ID_DEFEITO"]);
                    ordemServico.ID_VEICULO = Convert.ToInt32(linha["ID_VEICULO"]);
                    ordemServico.ID_MECANICA = Convert.ToInt32(linha["ID_MECANICA"]);
                    ordemServico.DATA = Convert.ToString(linha["DATA"]);
                    ordemServico.STATUS_OS = Convert.ToString(linha["STATUS_OS"]);
                    ordemServico.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    ordemServico.CPF_CLIENTE = Convert.ToString(linha["CPF_CLIENTE"]);
                    ordemServico.PLACA_CLIENTE = Convert.ToString(linha["PLACA_CLIENTE"]);
                    ordemServico.MARCA_CLIENTE = Convert.ToString(linha["MARCA_CLIENTE"]);
                    ordemServico.MODELO_CLIENTE = Convert.ToString(linha["MODELO_CLIENTE"]);
                    ordemServico.ANO_CLIENTE = Convert.ToInt32(linha["ANO_CLIENTE"]);
                    ordemServico.NOME_MECANICA = Convert.ToString(linha["NOME_MECANICA"]);
                    ordemServico.NOME_DEFEITO = Convert.ToString(linha["NOME_DEFEITO"]);
                    ordemServico.DESCRIÇÃO_DEFEITO = Convert.ToString(linha["DESCRIÇÃO_DEFEITO"]);
                    ordemServico.VALOR_DEFEITO = Convert.ToString(linha["VALOR_DEFEITO"]);
                    ordemServico.VALOR_MECANICA = Convert.ToString(linha["VALOR_MECANICA"]);
                    ordemServico.VALOR_OFICINA = Convert.ToString(linha["VALOR_OFICINA"]);
                    ordemServico.VALOR_TOTAL = Convert.ToString(linha["VALOR_TOTAL"]);
                    ordemServico.CADASTRO = Convert.ToString(linha["CADASTRO"]);

                    ordemServicoColecao.Add(ordemServico);
                }

                return ordemServicoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar a Ordem de Serviço. Detalhes: " + ex.Message);
            }
        }

        public OrdemServicoColecao ConsultarPorId(int ID_OS)
        {
            try
            {
                OrdemServicoColecao ordemServicoColecao = new OrdemServicoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_OS", ID_OS);

                DataTable dataTableOrdemServico = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspOsConsultarPorID");

                foreach (DataRow linha in dataTableOrdemServico.Rows)
                {
                    OrdemServico ordemServico = new OrdemServico();

                    ordemServico.ID_OS = Convert.ToInt32(linha["ID_OS"]);
                    ordemServico.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    ordemServico.ID_DEFEITO = Convert.ToInt32(linha["ID_DEFEITO"]);
                    ordemServico.ID_VEICULO = Convert.ToInt32(linha["ID_VEICULO"]);
                    ordemServico.ID_MECANICA = Convert.ToInt32(linha["ID_MECANICA"]);
                    ordemServico.DATA = Convert.ToString(linha["DATA"]);
                    ordemServico.STATUS_OS = Convert.ToString(linha["STATUS_OS"]);
                    ordemServico.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    ordemServico.CPF_CLIENTE = Convert.ToString(linha["CPF_CLIENTE"]);
                    ordemServico.PLACA_CLIENTE = Convert.ToString(linha["PLACA_CLIENTE"]);
                    ordemServico.MARCA_CLIENTE = Convert.ToString(linha["MARCA_CLIENTE"]);
                    ordemServico.MODELO_CLIENTE = Convert.ToString(linha["MODELO_CLIENTE"]);
                    ordemServico.ANO_CLIENTE = Convert.ToInt32(linha["ANO_CLIENTE"]);
                    ordemServico.NOME_MECANICA = Convert.ToString(linha["NOME_MECANICA"]);
                    ordemServico.NOME_DEFEITO = Convert.ToString(linha["NOME_DEFEITO"]);
                    ordemServico.DESCRIÇÃO_DEFEITO = Convert.ToString(linha["DESCRIÇÃO_DEFEITO"]);
                    ordemServico.VALOR_DEFEITO = Convert.ToString(linha["VALOR_DEFEITO"]);
                    ordemServico.VALOR_MECANICA = Convert.ToString(linha["VALOR_MECANICA"]);
                    ordemServico.VALOR_OFICINA = Convert.ToString(linha["VALOR_OFICINA"]);
                    ordemServico.VALOR_TOTAL = Convert.ToString(linha["VALOR_TOTAL"]);
                    ordemServico.CADASTRO = Convert.ToString(linha["CADASTRO"]);


                    ordemServicoColecao.Add(ordemServico);
                }

                return ordemServicoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome. Detalhes: " + ex.Message);
            }
        }
    }
}
