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
    public partial class FrmVeiculoSelecionar : Form
    {
        public FrmVeiculoSelecionar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridVeiculo.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Boolean PressionarID = true;
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Placa = new Permissao_Letras();


        private void FrmVeiculoSelecionar_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisar.Text))
            {

                MessageBox.Show("Digite o ID ou Placa");

                if (string.IsNullOrEmpty(textBoxPesquisar.Text))
                {
                    textBoxPesquisar.Focus();
                }
            }
            else
                if (radioButtonIdVeiculo.Checked == true)
                {
                    VeiculoNegocios veiculoNegocios = new VeiculoNegocios();
                    VeiculoColecao veiculoColecao = new VeiculoColecao();
                    veiculoColecao = veiculoNegocios.ConsultarPorId(int.Parse(textBoxPesquisar.Text));

                    dataGridVeiculo.DataSource = null;
                    dataGridVeiculo.DataSource = veiculoColecao;

                    dataGridVeiculo.Update();
                    dataGridVeiculo.Refresh();

                }
                else

                    if (radioButtonPlacaVeiculo.Checked == true)
                    {
                        VeiculoNegocios veiculoNegocios = new VeiculoNegocios();
                        VeiculoColecao veiculoColecao = new VeiculoColecao();
                        veiculoColecao = veiculoNegocios.ConsultarPorPlaca(textBoxPesquisar.Text);

                        dataGridVeiculo.DataSource = null;
                        dataGridVeiculo.DataSource = veiculoColecao;

                        dataGridVeiculo.Update();
                        dataGridVeiculo.Refresh();

                    }

            buttonAtualizar.Enabled = true;
        }

        private void AtualizarGrid()
        {
            VeiculoNegocios veiculoNegocios = new VeiculoNegocios();
            VeiculoColecao veiculoColecao = new VeiculoColecao();
            veiculoColecao = veiculoNegocios.ConsultarPorPlaca(textBoxPesquisar.Text);

            dataGridVeiculo.DataSource = null;
            dataGridVeiculo.DataSource = veiculoColecao;

            dataGridVeiculo.Update();
            dataGridVeiculo.Refresh();
        }

        private void buttonVeiculoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                Close();
            }
            
        }

        private void buttonVeiculoExcluir_Click(object sender, EventArgs e)
        {
            //verificar se tem linha selecionado
            if (dataGridVeiculo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Veículo selecionado!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar cliente

            Veiculo veiculoSelecionado = (dataGridVeiculo.SelectedRows[0].DataBoundItem as Veiculo);

            //Instancia
            VeiculoNegocios veiculoNegocios = new VeiculoNegocios();

            //Metodo Excluir

            string retorno = veiculoNegocios.Excluir(veiculoSelecionado);
            try
            {
                int ID_VEICULO = Convert.ToInt32(retorno);

                MessageBox.Show("Veículo excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("O veículo possui alguma ordem de serviço pendente! ", "Não foi possivel excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult resul = MessageBox.Show("Deseja verificar as ordem de serviço desde veículo?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    FrmOrdemSelecionar frmOrdemSelecionar = new FrmOrdemSelecionar();
                    frmOrdemSelecionar.ShowDialog();
                }
            }
        }

        private void buttonVeiculoAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarVeiculo frmCadastrarCliente = new FrmCadastrarVeiculo(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarCliente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }

        }

        private void buttonVeiculoEditar_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }

            //verificar se tem linha selecionado
            if (dataGridVeiculo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Veículo selecionado!");
                return;
            }

            //Pegar cliente

            Veiculo veiculoSelecionado = (dataGridVeiculo.SelectedRows[0].DataBoundItem as Veiculo);

            FrmCadastrarVeiculo frmCadastrarCliente = new FrmCadastrarVeiculo(AcaoNaTela.Alterar, veiculoSelecionado);
            DialogResult resultado = frmCadastrarCliente.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonVeiculoConsultar_Click(object sender, EventArgs e)
        {
            
            //verificar se tem linha selecionado
            if (dataGridVeiculo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Veículo selecionado!");
                return;
            }

            //Pegar veiculo

            Veiculo veiculoSelecionado = (dataGridVeiculo.SelectedRows[0].DataBoundItem as Veiculo);

            FrmCadastrarVeiculo frmCadastrarVeiculo = new FrmCadastrarVeiculo (AcaoNaTela.Consultar, veiculoSelecionado);
            frmCadastrarVeiculo.ShowDialog();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxPesquisar.Clear();
            AtualizarGrid();
        }

        private void radioButtonIdVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonIdVeiculo.Text = "ID";

        }

        private void radioButtonPlacaVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonPlacaVeiculo.Text = "Placa";
        }

        private void textBoxPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PressionarID)
            {
                ID.Apenas_Numeros(e);
            }
            else
            {
              
            }
        }

        private void radioButtonIdVeiculo_Click(object sender, EventArgs e)
        {
            PressionarID = true;
            textBoxPesquisar.Clear();
        }

        private void radioButtonPlacaVeiculo_Click(object sender, EventArgs e)
        {
            PressionarID = false;
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
    }
}
