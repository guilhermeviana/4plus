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
    public class MecanicaNegocios
    {
        //Instanciar = Criar novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Mecanica mecanica)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME_MECANICA", mecanica.NOME_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", mecanica.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@CEP", mecanica.CEP);
                acessoDadosSqlServer.AdicionarParametros("@ENDEREÇO", mecanica.ENDEREÇO);
                acessoDadosSqlServer.AdicionarParametros("@NUMERO", mecanica.NUMERO);
                acessoDadosSqlServer.AdicionarParametros("@COMPLEMENTO", mecanica.COMPLEMENTO);
                acessoDadosSqlServer.AdicionarParametros("@BAIRRO", mecanica.BAIRRO);
                acessoDadosSqlServer.AdicionarParametros("@CIDADE", mecanica.CIDADE);
                acessoDadosSqlServer.AdicionarParametros("@UF", mecanica.UF);
                acessoDadosSqlServer.AdicionarParametros("@TEL_COMERCIAL", mecanica.TEL_COMERCIAL);


                string ID_MECANICA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMecanicaInserir").ToString();

                return ID_MECANICA;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Mecanica mecanica)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_MECANICA", mecanica.ID_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@NOME_MECANICA", mecanica.NOME_MECANICA);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", mecanica.CNPJ);
                acessoDadosSqlServer.AdicionarParametros("@CEP", mecanica.CEP);
                acessoDadosSqlServer.AdicionarParametros("@ENDEREÇO", mecanica.ENDEREÇO);
                acessoDadosSqlServer.AdicionarParametros("@NUMERO", mecanica.NUMERO);
                acessoDadosSqlServer.AdicionarParametros("@COMPLEMENTO", mecanica.COMPLEMENTO);
                acessoDadosSqlServer.AdicionarParametros("@BAIRRO", mecanica.BAIRRO);
                acessoDadosSqlServer.AdicionarParametros("@CIDADE", mecanica.CIDADE);
                acessoDadosSqlServer.AdicionarParametros("@UF", mecanica.UF);
                acessoDadosSqlServer.AdicionarParametros("@TEL_COMERCIAL", mecanica.TEL_COMERCIAL);

                string ID_MECANICA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMecanicaAlterar").ToString();
                return ID_MECANICA;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir(Mecanica mecanica)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_MECANICA", mecanica.ID_MECANICA);
                string ID_MECANICA = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMecanicaExcluir").ToString();
                return ID_MECANICA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public MecanicaColecao ConsultarPorNome(string NOME_MECANICA)
        {

            try
            {
                //Criar coleção nova de clientes 
                MecanicaColecao mecanicaColecao = new MecanicaColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@NOME_MECANICA", NOME_MECANICA);



                // TABELA DE DADOS
                DataTable dataTableMecanica = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMecanicaConsultarPorNome");

                //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                //Linha de Dados

                foreach (DataRow linha in dataTableMecanica.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    Mecanica mecanica = new Mecanica();

                    mecanica.ID_MECANICA = Convert.ToInt32(linha["ID_MECANICA"]);
                    mecanica.NOME_MECANICA = Convert.ToString(linha["NOME_MECANICA"]);
                    mecanica.CNPJ = Convert.ToString(linha["CNPJ"]);
                    mecanica.CEP = Convert.ToString(linha["CEP"]);
                    mecanica.ENDEREÇO = Convert.ToString(linha["ENDEREÇO"]);
                    mecanica.NUMERO = Convert.ToInt32(linha["NUMERO"]);
                    mecanica.COMPLEMENTO = Convert.ToString(linha["COMPLEMENTO"]);
                    mecanica.BAIRRO = Convert.ToString(linha["BAIRRO"]);
                    mecanica.CIDADE = Convert.ToString(linha["CIDADE"]);
                    mecanica.UF = Convert.ToString(linha["UF"]);
                    mecanica.TEL_COMERCIAL = Convert.ToString(linha["TEL_COMERCIAL"]);

                    mecanicaColecao.Add(mecanica);
                }

                return mecanicaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar a mecanica por nome. Detalhes: " + ex.Message);
            }
        }

        public MecanicaColecao ConsultarPorId(int ID_MECANICA)
        {
            try
            {
                MecanicaColecao mecanicaColecao = new MecanicaColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_MECANICA", ID_MECANICA);

                DataTable dataTableMecanica = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspMecanicaConsultarPorID");

                foreach (DataRow linha in dataTableMecanica.Rows)
                {
                    Mecanica mecanica = new Mecanica();

                    mecanica.ID_MECANICA = Convert.ToInt32(linha["ID_MECANICA"]);
                    mecanica.NOME_MECANICA = Convert.ToString(linha["NOME_MECANICA"]);
                    mecanica.CNPJ = Convert.ToString(linha["CNPJ"]);
                    mecanica.CEP = Convert.ToString(linha["CEP"]);
                    mecanica.ENDEREÇO = Convert.ToString(linha["ENDEREÇO"]);
                    mecanica.NUMERO = Convert.ToInt32(linha["NUMERO"]);
                    mecanica.COMPLEMENTO = Convert.ToString(linha["COMPLEMENTO"]);
                    mecanica.BAIRRO = Convert.ToString(linha["BAIRRO"]);
                    mecanica.CIDADE = Convert.ToString(linha["CIDADE"]);
                    mecanica.UF = Convert.ToString(linha["UF"]);
                    mecanica.TEL_COMERCIAL = Convert.ToString(linha["TEL_COMERCIAL"]);

                    mecanicaColecao.Add(mecanica);
                }

                return mecanicaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar a mecanica por id. Detalhes: " + ex.Message);
            }
        }

    }
}
