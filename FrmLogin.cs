using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apresentacao
{
    public partial class FrmLogin : Form
    {
        //Responsavel pelo Nivel de Acesso
        public static string NivelAcesso;

        //Responsavel por mostrar quem esta conectado no sistema
        public static string usuarioConectado;
        SqlConnection conn = new SqlConnection(@"Data Source=GUILHERME-PC;Initial Catalog=OFICINA;Integrated Security=True");

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oFICINADataSet11USUARIO.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter2.Fill(this.oFICINADataSet11USUARIO.USUARIO);
            // TODO: This line of code loads data into the 'oFICINADataSet8.USUARIO' table. You can move, or remove it, as needed.
           
           
            this.uSUARIOTableAdapter2.Fill(this.oFICINADataSet11USUARIO.USUARIO);
            
            
            // TODO: This line of code loads data into the 'oFICINADataSet7.USUARIO' table. You can move, or remove it, as needed.
         //  this.uSUARIOTableAdapter.Fill(this.oFICINADataSet7.USUARIO);
            comboBoxUsuario.SelectedIndex = -1;
            comboBoxNivelAcesso.SelectedIndex = -1;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Sair?", "Finzaliar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
              
            } 

        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar ser os campos estão preenchidos
                if ((comboBoxUsuario.Text != "") && (comboBoxNivelAcesso.Text != "") && (textBoxSenha.Text != ""))
                {
                    //Responsavel pelo Comando Sql
                    SqlCommand comm = new SqlCommand("Select * From USUARIO Where USUARIO = @USUARIO and " +
                        "SENHA = @SENHA and NIVEL_ACESSO = @NIVEL_ACESSO", conn);

                    //Parametizar os codigos
                    comm.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = comboBoxUsuario.Text;
                    comm.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = textBoxSenha.Text;
                    comm.Parameters.Add("@NIVEL_ACESSO", SqlDbType.VarChar).Value = comboBoxNivelAcesso.Text;

                    //Abre a conexão
                    conn.Open();

                    SqlDataReader reader = null;
                    //lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    //Se tiver coisa pra lê faça:
                    if (reader.Read())
                    {
                        //Variaveil usuarioConectado recebe campo usuarioComboBox.Text
                        usuarioConectado = comboBoxUsuario.Text;

                        //Variavei nivelAcesso recebe o campo nivelAcessoComboBox.Text
                        NivelAcesso = comboBoxNivelAcesso.Text;

                        //Declara a variavel que recebe o formulario frmTelaPrinciapal
                        FrmMenu menu = new FrmMenu();
                        //Esconde o formulario Tela de Login
                        this.Hide();
                        //Mostrar o formulario frmTelaPrinciapl
                        menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas",
                        "Aviso de Segurança",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Todos os Campos são Obrigatórios!",
                   "Aviso de Segurança",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                //Gerar a exceção
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Finalizar tarefa
                conn.Close();
            }
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oFICINADataSet8BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
