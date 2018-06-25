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
    public partial class FrmOrdemSelecionar : Form
    {
        public FrmOrdemSelecionar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridPrincipal.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Nome = new Permissao_Letras();
        Boolean PressionadoID = true;

        private void FrmOrdemSelecionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oFICINADataSet9.OS' table. You can move, or remove it, as needed.
            this.oSTableAdapter.Fill(this.oFICINADataSet9.OS);
           
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisarOrdem.Text))
            {

                MessageBox.Show("Digite o ID ou Nome");

                if (string.IsNullOrEmpty(textBoxPesquisarOrdem.Text))
                {
                    textBoxPesquisarOrdem.Focus();
                }
            }
            else
            if (radioButtonId.Checked == true)
            {
                OsNegocios osNegocios = new OsNegocios();
                OrdemServicoColecao ordemServicoColecao = new OrdemServicoColecao();
                ordemServicoColecao = osNegocios.ConsultarPorId(int.Parse(textBoxPesquisarOrdem.Text));

                dataGridPrincipal.DataSource = null;
                dataGridPrincipal.DataSource = ordemServicoColecao;

                dataGridPrincipal.Update();
                dataGridPrincipal.Refresh();
            }
            else

                if (radioButtonCliente.Checked == true)
                { 
  
                    OsNegocios osNegocios = new OsNegocios();
                    OrdemServicoColecao ordemServicoColecao = new OrdemServicoColecao();
                    ordemServicoColecao = osNegocios.ConsultarPorNome(textBoxPesquisarOrdem.Text);

                    dataGridPrincipal.DataSource = null;
                    dataGridPrincipal.DataSource = ordemServicoColecao;

                    dataGridPrincipal.Update();
                    dataGridPrincipal.Refresh();

                }

            buttonAtualizar.Enabled = true;
            
        }

        private void AtualizarGrid()
        {
           OsNegocios osNegocios = new OsNegocios();
                    OrdemServicoColecao ordemServicoColecao = new OrdemServicoColecao();
                    ordemServicoColecao = osNegocios.ConsultarPorNome(textBoxPesquisarOrdem.Text);

                    dataGridPrincipal.DataSource = null;
                    dataGridPrincipal.DataSource = ordemServicoColecao;

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                
                Close();
            }
            
        }

        private void buttonExcluirOrdem_Click(object sender, EventArgs e)
        {
            //verificar se tem linha selecionado
            if(dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Ordem de Serviço selecionada!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar cliente

            OrdemServico ordemServicoSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as OrdemServico);

            //Instancia
            OsNegocios osNegocios = new OsNegocios();
             
            //Metodo Excluir

            string retorno = osNegocios.Excluir(ordemServicoSelecionado);
            try
            {
                int ID_OS = Convert.ToInt32(retorno);

                MessageBox.Show("Ordem de serviço excluida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir.Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionarOrdem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarOrdem frmCadastrarOrdem = new FrmCadastrarOrdem (AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarOrdem.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonEditarOrdem_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }

            //verificar se tem linha selecionado
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Ordem de Serviço selecionada!");
                return;
            }

            //Pegar ordem

            OrdemServico ordemServicoSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as OrdemServico);

            FrmCadastrarOrdem frmCadastrarOrdem = new FrmCadastrarOrdem(AcaoNaTela.Alterar, ordemServicoSelecionado);
            DialogResult resultado = frmCadastrarOrdem.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonConsultarOrdem_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Gerar Orçamento?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }

            //verificar se tem linha selecionado
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Ordem de Serviço selecionada!");
                return;
            }

            //Pegar cliente

            OrdemServico ordemServicoSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as OrdemServico);

            FrmCadastrarOrdem frmCadastrarOrdem = new FrmCadastrarOrdem(AcaoNaTela.Consultar, ordemServicoSelecionado);
            frmCadastrarOrdem.ShowDialog();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxPesquisarOrdem.Clear();
            AtualizarGrid();
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

        private void radioButtonId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonId_Click(object sender, EventArgs e)
        {
            PressionadoID = true;
            textBoxPesquisarOrdem.Clear();
        }

        private void radioButtonCliente_Click(object sender, EventArgs e)
        {
            PressionadoID = false;
            textBoxPesquisarOrdem.Clear();
        }

        private void textBoxPesquisarOrdem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PressionadoID)
            {
                ID.Apenas_Numeros(e);
            }
            else
            {

            }
        }

        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
