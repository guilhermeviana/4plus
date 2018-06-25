
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace que contem classes que manipulam os dados
using System.Data;
using System.Data.SqlClient;

using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar Conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //Paramentros que vão para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParamentros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParamentro, object valorParamentro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParamentro, valorParamentro));
        }

        //Persistencia - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType,string nomeStoredProcedureOuTextoSql)
        {
            try //tente
            {

            //Criar Conexão
            SqlConnection sqlConnection = CriarConexao();
            //Abrir Conexão
            sqlConnection.Open();
            //Criar o Comando que vai levar a informação para o banco
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar a na conexão
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
            sqlCommand.CommandTimeout = 7200; //Segundos

            //Adicionar oa paramentros do comando
            foreach (SqlParameter sqlParamenter in sqlParameterCollection)
            {
                sqlCommand.Parameters.Add(new SqlParameter(sqlParamenter.ParameterName, sqlParamenter.Value));
            }

            //Executar o comando, ou seja, mandar o comando ir até o banco de dados
            return sqlCommand.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        //Consultar registros do banco de dados

        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try //tente
            {

                //Criar Conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexão
                sqlConnection.Open();
                //Criar o Comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do comando (dentro da caixa que vai trafegar a na conexão
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Segundos

                //Adicionar oa paramentros do comando
                foreach (SqlParameter sqlParamenter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParamenter.ParameterName, sqlParamenter.Value));
                }

                //Adaptador conversão dos registros de comando do banco para o projeto
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = tabela de dados vazia onde colocarei os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco, assim buscando os dados e o adaptador irá preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        
    }
}
