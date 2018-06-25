using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmCadastrarUsuario : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmCadastrarUsuario(AcaoNaTela acaoNaTela, Usuario usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Usuario";

            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar defeitos
                this.Text = "Alterar Defeito";

                textBoxId.Text = usuario.ID_USUARIO.ToString();
                textBoxId.Enabled = false;
                textBoxUsuario.Text = usuario.USUARIO;
                textBoxSenha.Text = usuario.SENHA;
                comboBoxNivelAcesso.Text = usuario.NIVEL_ACESSO;

            }

        }

        private void FrmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsuario.Text) || string.IsNullOrEmpty(textBoxSenha.Text) )
            {

                MessageBox.Show("Campos não preenchidos!");

                if (string.IsNullOrEmpty(textBoxUsuario.Text))
                {
                    textBoxUsuario.Focus();
                }
                else
                    if (string.IsNullOrEmpty(textBoxSenha.Text))
                    {
                        textBoxSenha.Focus();
                    }
                

            }

            else
            {

                if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                {
                    Usuario usuario = new Usuario();



                    usuario.USUARIO = textBoxUsuario.Text;
                    usuario.SENHA = textBoxSenha.Text;
                    usuario.NIVEL_ACESSO = comboBoxNivelAcesso.Text;


                    UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

                    DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (rsd == DialogResult.No)
                    {
                        return;
                    }
                    
                    string retorno = usuarioNegocios.Inserir(usuario);

                    try
                    {
                          
                                int ID_USUARIO = Convert.ToInt32(retorno);

                                MessageBox.Show("usuario inserido com sucesso! ID: " + ID_USUARIO.ToString());
                                this.DialogResult = DialogResult.Yes;

                        }

                    catch (Exception ex)
                    {
                        //Caso haja uma exceção será tratada neste código
                        MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
                    }
                }




                    //ALTERAR.........................
                else
                    if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                    {
                        Usuario usuario = new Usuario();

                        usuario.ID_USUARIO = Convert.ToInt32(textBoxId.Text);
                        usuario.USUARIO = textBoxUsuario.Text;
                        usuario.SENHA = textBoxSenha.Text;
                        usuario.NIVEL_ACESSO = comboBoxNivelAcesso.Text;

                        UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                        DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rsd == DialogResult.No)
                        {
                            return;
                        }
                        string retorno = usuarioNegocios.Alterar(usuario);

                        try
                        {
                            int ID_USUARIO = Convert.ToInt32(retorno);

                            MessageBox.Show("Usuário/ID: " + ID_USUARIO.ToString() + " Alterado com sucesso!");
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possivel alterar. Detalhes: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.No;
                        }
                    }

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

    }
}
