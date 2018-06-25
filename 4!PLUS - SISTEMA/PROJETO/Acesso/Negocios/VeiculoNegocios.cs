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
    public class VeiculoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Veiculo veiculo)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();

                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", veiculo.ID_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@PLACA", veiculo.PLACA);
                acessoDadosSqlServer.AdicionarParametros("@MARCA", veiculo.MARCA);
                acessoDadosSqlServer.AdicionarParametros("@MODELO", veiculo.MODELO);
                acessoDadosSqlServer.AdicionarParametros("@ANO", veiculo.ANO);
                acessoDadosSqlServer.AdicionarParametros("@COR", veiculo.COR);
                acessoDadosSqlServer.AdicionarParametros("@COMBUSTIVEL", veiculo.COMBUSTIVEL);
                acessoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", veiculo.NOME_CLIENTE);
    

                string ID_VEICULO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoInserir").ToString();

                return ID_VEICULO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Veiculo veiculo)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_VEICULO", veiculo.ID_VEICULO);
                acessoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", veiculo.ID_CLIENTE);
                acessoDadosSqlServer.AdicionarParametros("@PLACA", veiculo.PLACA);
                acessoDadosSqlServer.AdicionarParametros("@MARCA", veiculo.MARCA);
                acessoDadosSqlServer.AdicionarParametros("@MODELO", veiculo.MODELO);
                acessoDadosSqlServer.AdicionarParametros("@ANO", veiculo.ANO);
                acessoDadosSqlServer.AdicionarParametros("@COR", veiculo.COR);
                acessoDadosSqlServer.AdicionarParametros("@COMBUSTIVEL", veiculo.COMBUSTIVEL);
                acessoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", veiculo.NOME_CLIENTE);

   
                string ID_VEICULO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoAlterar").ToString();
                return ID_VEICULO;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir(Veiculo veiculo)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_VEICULO", veiculo.ID_VEICULO);
                string ID_VEICULO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVeiculoExcluir").ToString();
                return ID_VEICULO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public VeiculoColecao ConsultarPorPlaca(string PLACA)
        {

            try
            {
                //Criar coleção nova de clientes 
                VeiculoColecao veiculoColecao = new VeiculoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@PLACA", PLACA);

                // TABELA DE DADOS
                DataTable dataTableVeiculo = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspVeiculoConsultarPorPlaca");

                //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                //Linha de Dados

                foreach (DataRow linha in dataTableVeiculo.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    Veiculo veiculo = new Veiculo();

                    veiculo.ID_VEICULO = Convert.ToInt32(linha["ID_VEICULO"]);
                    veiculo.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    veiculo.PLACA = Convert.ToString(linha["PLACA"]);
                    veiculo.MARCA = Convert.ToString(linha["MARCA"]);
                    veiculo.MODELO = Convert.ToString(linha["MODELO"]);
                    veiculo.ANO = Convert.ToInt32(linha["ANO"]);
                    veiculo.COR = Convert.ToString(linha["COR"]);
                    veiculo.COMBUSTIVEL = Convert.ToString(linha["COMBUSTIVEL"]);
                    veiculo.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);

                    



                    veiculoColecao.Add(veiculo);
                }

                return veiculoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o veiculo por placa. Detalhes: " + ex.Message);
            }
        } //MODIFICAR PARA NOME

        public VeiculoColecao ConsultarPorId(int ID_VEICULO)
        {
            try
            {
                VeiculoColecao veiculoColecao = new VeiculoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_VEICULO", ID_VEICULO);

                DataTable dataTableVeiculo = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspVeiculoConsultarPorID");

                foreach (DataRow linha in dataTableVeiculo.Rows)
                {
                    Veiculo veiculo = new Veiculo();

                    veiculo.ID_VEICULO = Convert.ToInt32(linha["ID_VEICULO"]);
                    veiculo.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    veiculo.PLACA = Convert.ToString(linha["PLACA"]);
                    veiculo.MARCA = Convert.ToString(linha["MARCA"]);
                    veiculo.MODELO = Convert.ToString(linha["MODELO"]);
                    veiculo.ANO = Convert.ToInt32(linha["ANO"]);
                    veiculo.COR = Convert.ToString(linha["COR"]);
                    veiculo.COMBUSTIVEL = Convert.ToString(linha["COMBUSTIVEL"]);
                    veiculo.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);

                    veiculoColecao.Add(veiculo);
                }

                return veiculoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o veiculo pelo codigo. Detalhes: " + ex.Message);
            }
        }
    }
}
