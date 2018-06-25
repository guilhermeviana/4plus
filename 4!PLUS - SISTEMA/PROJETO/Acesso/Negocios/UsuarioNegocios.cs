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
    public class UsuarioNegocios
    {
          //Instanciar = Criar novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@USUARIO", usuario.USUARIO);
                acessoDadosSqlServer.AdicionarParametros("@SENHA", usuario.SENHA);
                acessoDadosSqlServer.AdicionarParametros("@NIVEL_ACESSO", usuario.NIVEL_ACESSO);


                string ID_USUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioInserir").ToString();

                return ID_USUARIO;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Usuario usuario)
        {
            try
            {


                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_USUARIO", usuario.ID_USUARIO);
                acessoDadosSqlServer.AdicionarParametros("@USUARIO", usuario.USUARIO);
                acessoDadosSqlServer.AdicionarParametros("@SENHA", usuario.SENHA);
                acessoDadosSqlServer.AdicionarParametros("@NIVEL_ACESSO", usuario.NIVEL_ACESSO);


                string ID_USUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterar").ToString();

                return ID_USUARIO;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_USUARIO", usuario.ID_USUARIO);
                string ID_USUARIO = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioExcluir").ToString();
                return ID_USUARIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public UsuarioColecao UsuarioConsultarPorNome(string USUARIO)
        {

            try
            {
                //Criar coleção nova de clientes 
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@USUARIO", USUARIO);



                // TABELA DE DADOS
                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultarPorNome");

                //Transformar em uma coleção cliente, cada linha do datatable é um cliente
                //Linha de Dados

                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    //Criar Cliente, colocar os dados na linha, adicionar ele na coleção
                    Usuario usuario = new Usuario();

                    usuario.ID_USUARIO = Convert.ToInt32(linha["ID_USUARIO"]);
                    usuario.USUARIO = Convert.ToString(linha["USUARIO"]);
                    usuario.SENHA= Convert.ToString(linha["SENHA"]);
                    usuario.NIVEL_ACESSO = Convert.ToString(linha["NIVEL_ACESSO"]);
     

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o Usuario por nome. Detalhes: " + ex.Message);
            }
        }

        public UsuarioColecao ConsultarUsuarioPorID(int ID_USUARIO)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDadosSqlServer.LimparParamentros();
                acessoDadosSqlServer.AdicionarParametros("@ID_USUARIO", ID_USUARIO);

                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultarPorID");

                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.ID_USUARIO = Convert.ToInt32(linha["ID_USUARIO"]);
                    usuario.USUARIO = Convert.ToString(linha["USUARIO"]);
                    usuario.SENHA = Convert.ToString(linha["SENHA"]);
                    usuario.NIVEL_ACESSO = Convert.ToString(linha["NIVEL_ACESSO"]);

                    usuarioColecao.Add(usuario);
                }

                return usuarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o Defeito por Id. Detalhes: " + ex.Message);
            }
        }
    }
}
