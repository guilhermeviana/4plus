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
   public  class DefeitoNegocios
    {
        //Instanciar = Criar novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Defeito defeito)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME_DEFEITO", defeito.NOME_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@DESCRIÇÃO", defeito.DESCRIÇÃO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR", defeito.VALOR);


                string ID_DEFEITO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDefeitoInserir").ToString();

                return ID_DEFEITO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Defeito defeito)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_DEFEITO", defeito.ID_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@NOME_DEFEITO", defeito.NOME_DEFEITO);
                acessoDadosSqlServer.AdicionarParametros("@DESCRIÇÃO", defeito.DESCRIÇÃO);
                acessoDadosSqlServer.AdicionarParametros("@VALOR", defeito.VALOR);


                string ID_DEFEITO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDefeitoAlterar").ToString();

                return ID_DEFEITO;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir(Defeito defeito)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_DEFEITO", defeito.ID_DEFEITO);
                string ID_DEFEITO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDefeitoExcluir").ToString();
                return ID_DEFEITO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DefeitoColecao DefeitoConsultarPorNome(string NOME_DEFEITO)
        {

            try
            {
                //Criar coleção nova de clientes 
                DefeitoColecao defeitoColecao = new DefeitoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME_DEFEITO", NOME_DEFEITO);



                // TABELA DE DADOS
                DataTable dataTableDefeito = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDefeitoConsultarPorNome");

                //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                //Linha de Dados

                foreach (DataRow linha in dataTableDefeito.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    Defeito defeito = new Defeito();

                    defeito.ID_DEFEITO = Convert.ToInt32(linha["ID_DEFEITO"]);
                    defeito.NOME_DEFEITO = Convert.ToString(linha["NOME_DEFEITO"]);
                    defeito.DESCRIÇÃO= Convert.ToString(linha["DESCRIÇÃO"]);
                    defeito.VALOR = Convert.ToString(linha["VALOR"]);
     

                    defeitoColecao.Add(defeito);
                }

                return defeitoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o Defeito por nome. Detalhes: " + ex.Message);
            }
        }

        public DefeitoColecao ConsultarDefeitoPorID(int ID_DEFEITO)
        {
            try
            {
                DefeitoColecao defeitoColecao = new DefeitoColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_DEFEITO", ID_DEFEITO);

                DataTable dataTableDefeito = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDefeitoConsultarPorID");

                foreach (DataRow linha in dataTableDefeito.Rows)
                {
                    Defeito defeito = new Defeito();

                    defeito.ID_DEFEITO = Convert.ToInt32(linha["ID_DEFEITO"]);
                    defeito.NOME_DEFEITO = Convert.ToString(linha["NOME_DEFEITO"]);
                    defeito.DESCRIÇÃO = Convert.ToString(linha["DESCRIÇÃO"]);
                    defeito.VALOR = Convert.ToString(linha["VALOR"]);

                    defeitoColecao.Add(defeito);
                }

                return defeitoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o Defeito por Id. Detalhes: " + ex.Message);
            }
        }
    }
}
