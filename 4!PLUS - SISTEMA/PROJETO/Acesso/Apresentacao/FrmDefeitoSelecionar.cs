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
    public partial class FrmDefeitoSelecionar : Form
    {
        public FrmDefeitoSelecionar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridDefeito.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Nome = new Permissao_Letras();
        Boolean PressionadoID = true;
        private void FrmDefeitoSelecionar_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisarDefeito_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisarDefeito.Text))
            {

                MessageBox.Show("Digite o ID ou Nome");

                if (string.IsNullOrEmpty(textBoxPesquisarDefeito.Text))
                {
                    textBoxPesquisarDefeito.Focus();
                }
            }
            else
            
            if (radioButtonIdDefeito.Checked == true)
            {
                DefeitoNegocios defeitoNegocios = new DefeitoNegocios();
                DefeitoColecao defeitoColecao = new DefeitoColecao();
                defeitoColecao = defeitoNegocios.ConsultarDefeitoPorID(int.Parse(textBoxPesquisarDefeito.Text));

                dataGridDefeito.DataSource = null;
                dataGridDefeito.DataSource = defeitoColecao;

                dataGridDefeito.Update();
                dataGridDefeito.Refresh();

            }
            else

                if (radioButtonNomeDefeito.Checked == true)
                {

                    DefeitoNegocios defeitoNegocios = new DefeitoNegocios();
                    DefeitoColecao defeitoColecao = new DefeitoColecao();
                    defeitoColecao = defeitoNegocios.DefeitoConsultarPorNome(textBoxPesquisarDefeito.Text);

                    dataGridDefeito.DataSource = null;
                    dataGridDefeito.DataSource = defeitoColecao;

                    dataGridDefeito.Update();
                    dataGridDefeito.Refresh();

                }

            buttonAtualizar.Enabled = true;
            
        }

        private void AtualizarGrid()
        {
            DefeitoNegocios defeitoNegocios = new DefeitoNegocios();
            DefeitoColecao defeitoColecao = new DefeitoColecao();
            defeitoColecao = defeitoNegocios.DefeitoConsultarPorNome(textBoxPesquisarDefeito.Text);

            dataGridDefeito.DataSource = null;
            dataGridDefeito.DataSource = defeitoColecao;

            dataGridDefeito.Update();
            dataGridDefeito.Refresh();
        }

        private void buttonCancelarDefeito_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void buttonExcluirDefeito_Click(object sender, EventArgs e)
        {
            //verificar se tem linha selecionado
            if (dataGridDefeito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Defeito selecionado!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar cliente

            Defeito defeitoSelecionado = (dataGridDefeito.SelectedRows[0].DataBoundItem as Defeito);

            //Instancia
            DefeitoNegocios defeitoNegocios = new DefeitoNegocios();

            //Metodo Excluir

            string retorno = defeitoNegocios.Excluir(defeitoSelecionado);
            try
            {
                int ID_DEFEITO = Convert.ToInt32(retorno);

                MessageBox.Show("Defeito excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionarDefeito_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarDefeito frmCadastrarDefeito = new FrmCadastrarDefeito (AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarDefeito.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }

        }

        private void buttonEditarDefeito_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }
            //verificar se tem linha selecionado
            if (dataGridDefeito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Defeito selecionado!");
                return;
            }

            //Pegar Defeito

            Defeito defeitoSelecionado = (dataGridDefeito.SelectedRows[0].DataBoundItem as Defeito);

            FrmCadastrarDefeito frmCadastrarDefeito = new FrmCadastrarDefeito (AcaoNaTela.Alterar, defeitoSelecionado);
            DialogResult resultado = frmCadastrarDefeito.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonConsultarDefeito_Click(object sender, EventArgs e)
        {
           

            //verificar se tem linha selecionado
            if (dataGridDefeito.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Defeito selecionado!");
                return;
            }

            //Pegar Defeito

            Defeito defeitoSelecionado = (dataGridDefeito.SelectedRows[0].DataBoundItem as Defeito);

            FrmCadastrarDefeito frmCadastrarDefeito = new FrmCadastrarDefeito (AcaoNaTela.Consultar, defeitoSelecionado);
            frmCadastrarDefeito.ShowDialog();
        }

        private void radioButtonIdDefeito_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonIdDefeito.Text = "ID";
        }

        private void radioButtonNomeDefeito_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNomeDefeito.Text = "Nome";
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxPesquisarDefeito.Clear();
            AtualizarGrid();
        }

        private void textBoxPesquisarDefeito_KeyPress(object sender, KeyPressEventArgs e)
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

        private void radioButtonIdDefeito_Click(object sender, EventArgs e)
        {
            PressionadoID = true;
            textBoxPesquisarDefeito.Clear();
        }

        private void radioButtonNomeDefeito_Click(object sender, EventArgs e)
        {
            PressionadoID = false;
            textBoxPesquisarDefeito.Clear();
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
