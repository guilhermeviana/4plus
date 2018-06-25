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
    public partial class FrmUsuarioSelecionar : Form
    {
        public FrmUsuarioSelecionar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridUsuario.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Nome = new Permissao_Letras();
        Boolean PressionadoID = true;

        private void FrmUsuarioSelecionar_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisar.Text))
            {

                MessageBox.Show("Digite o ID ou Nome");

                if (string.IsNullOrEmpty(textBoxPesquisar.Text))
                {
                    textBoxPesquisar.Focus();
                }
            }
            else
            
            if (radioButtonPesquisarId.Checked == true)
            {
                UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                UsuarioColecao usuarioColecao = new UsuarioColecao();
                usuarioColecao = usuarioNegocios.ConsultarUsuarioPorID(int.Parse(textBoxPesquisar.Text));

                dataGridUsuario.DataSource = null;
                dataGridUsuario.DataSource = usuarioColecao;

                dataGridUsuario.Update();
                dataGridUsuario.Refresh();

            }
            else

                if (radioButtonPesquisarUsuario.Checked == true)
                {
                    UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
                    UsuarioColecao usuarioColecao = new UsuarioColecao();
                    usuarioColecao = usuarioNegocios.UsuarioConsultarPorNome(textBoxPesquisar.Text);

                    dataGridUsuario.DataSource = null;
                    dataGridUsuario.DataSource = usuarioColecao;

                    dataGridUsuario.Update();
                    dataGridUsuario.Refresh();

                }

            buttonAtualizar.Enabled = true;
            
        }

        private void AtualizarGrid()
        {
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();
            UsuarioColecao usuarioColecao = new UsuarioColecao();
            usuarioColecao = usuarioNegocios.UsuarioConsultarPorNome(textBoxPesquisar.Text);

            dataGridUsuario.DataSource = null;
            dataGridUsuario.DataSource = usuarioColecao;

            dataGridUsuario.Update();
            dataGridUsuario.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem linha selecionado
            if (dataGridUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuário selecionado!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar cliente

            Usuario usuarioSelecionado = (dataGridUsuario.SelectedRows[0].DataBoundItem as Usuario);

            //Instancia
            UsuarioNegocios usuarioNegocios = new UsuarioNegocios();

            //Metodo Excluir

            string retorno = usuarioNegocios.Excluir(usuarioSelecionado);
            try
            {
                int ID_USUARIO = Convert.ToInt32(retorno);

                MessageBox.Show("Usuário excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir.Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarUsuario frmCadastrarUsuario = new FrmCadastrarUsuario(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarUsuario.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }
            //verificar se tem linha selecionado
            if (dataGridUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuário selecionado!");
                return;
            }

            //Pegar Defeito

            Usuario usuarioSelecionado = (dataGridUsuario.SelectedRows[0].DataBoundItem as Usuario);

            FrmCadastrarUsuario frmCadastrarUsuario = new FrmCadastrarUsuario(AcaoNaTela.Alterar, usuarioSelecionado);
            DialogResult resultado = frmCadastrarUsuario.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxPesquisar.Clear();
            AtualizarGrid();
        }

        private void textBoxPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PressionadoID)
            {
                ID.Apenas_Numeros(e);
            }
            else
            {
                Nome.Apenas_letras(e);
            }
        }

        private void radioButtonPesquisarId_Click(object sender, EventArgs e)
        {
            PressionadoID = true;
            textBoxPesquisar.Clear();
        }

        private void radioButtonPesquisarUsuario_Click(object sender, EventArgs e)
        {
            PressionadoID = false;
            textBoxPesquisar.Clear();
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

        private void radioButtonPesquisarId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPesquisarUsuario_CheckedChanged(object sender, EventArgs e)
        {

        }
   
    }
}
