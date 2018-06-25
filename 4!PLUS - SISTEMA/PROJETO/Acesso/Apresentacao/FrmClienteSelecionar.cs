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
    public partial class FrmClienteSelecionar : Form
    {
        public FrmClienteSelecionar()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            //Não gerar linha automatica
            dataGridPrincipal.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Boolean PressionadoID = true;
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Nome = new Permissao_Letras();

        private void FrmClienteSelecionar_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click_1(object sender, EventArgs e)
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
            if (radioButtonId.Checked == true)
            {
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                ClienteColecao clienteColecao = new ClienteColecao();
                clienteColecao = clienteNegocios.ConsultarPorId(int.Parse(textBoxPesquisar.Text));

                dataGridPrincipal.DataSource = null;
                dataGridPrincipal.DataSource = clienteColecao;

                dataGridPrincipal.Update();
                dataGridPrincipal.Refresh();
            }
            else

                if (radioButtonNome.Checked == true)
                { 
  
                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    ClienteColecao clienteColecao = new ClienteColecao();
                    clienteColecao = clienteNegocios.ConsultarPorNome(textBoxPesquisar.Text);

                    dataGridPrincipal.DataSource = null;
                    dataGridPrincipal.DataSource = clienteColecao;

                    dataGridPrincipal.Update();
                    dataGridPrincipal.Refresh();

                }

            buttonAtualizar.Enabled = true;
            
        }

        private void AtualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteColecao clienteColecao = new ClienteColecao();
            clienteColecao = clienteNegocios.ConsultarPorNome(textBoxPesquisar.Text);

            dataGridPrincipal.DataSource = null;
            dataGridPrincipal.DataSource = clienteColecao;

            dataGridPrincipal.Update();
            dataGridPrincipal.Refresh();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
            if(dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar cliente

            Cliente clienteSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            //Instancia
            ClienteNegocios clienteNegocios = new ClienteNegocios();
             
            //Metodo Excluir

            string retorno = clienteNegocios.Excluir(clienteSelecionado);
            try
            {
                int ID_CLIENTE = Convert.ToInt32(retorno);

                MessageBox.Show("Cliente excluido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("O Cliente possui Veículo cadastrado no sistema! ", "Não foi possivel excluir o cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult resul = MessageBox.Show("Deseja verificar o Veículo cadastrado deste cliente?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    FrmVeiculoSelecionar frmVeiculoSelecionar = new FrmVeiculoSelecionar();
                    frmVeiculoSelecionar.ShowDialog();
                }
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarCliente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
        
                AtualizarGrid();
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }
            
            //verificar se tem linha selecionado
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!");
                return;
            }

            //Pegar cliente

            Cliente clienteSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(AcaoNaTela.Alterar, clienteSelecionado);
           DialogResult resultado = frmCadastrarCliente.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
           
            //verificar se tem linha selecionado
            if (dataGridPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!");
                return;
            }

            //Pegar cliente

            Cliente clienteSelecionado = (dataGridPrincipal.SelectedRows[0].DataBoundItem as Cliente);

            FrmCadastrarCliente frmCadastrarCliente = new FrmCadastrarCliente(AcaoNaTela.Consultar, clienteSelecionado);
            frmCadastrarCliente.ShowDialog();
        }

        private void FrmClienteSelecionar_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonId_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonId.Text = "ID";
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNome.Text = "Nome";
            
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

            textBoxPesquisar.Clear();    
            AtualizarGrid();

            
        }

        private void radioButtonId_Click(object sender, EventArgs e)
        {
            PressionadoID = true;
            textBoxPesquisar.Clear();
        }

        private void radioButtonNome_Click(object sender, EventArgs e)
        {
            PressionadoID = false;
            textBoxPesquisar.Clear();
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

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
