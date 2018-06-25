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
    public partial class FrmMecanicaSelecionar : Form
    {
        public FrmMecanicaSelecionar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dataGridMecanica.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        Boolean PressionarID = true;
        Permissao_Numeros ID = new Permissao_Numeros();
        Permissao_Letras Nome = new Permissao_Letras();

        private void FrmMecanicaSelecionar_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonPesquisarMecanica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisarMecanica.Text))
            {

                MessageBox.Show("Digite o ID ou Nome");

                if (string.IsNullOrEmpty(textBoxPesquisarMecanica.Text))
                {
                    textBoxPesquisarMecanica.Focus();
                }
            }
            else
                if (radioButtonIdMecanica.Checked == true)
                {
                    MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();
                    MecanicaColecao mecanicaColecao = new MecanicaColecao();
                    mecanicaColecao = mecanicaNegocios.ConsultarPorId(int.Parse(textBoxPesquisarMecanica.Text));

                    dataGridMecanica.DataSource = null;
                    dataGridMecanica.DataSource = mecanicaColecao;

                    dataGridMecanica.Update();
                    dataGridMecanica.Refresh();

                }
                else

                    if (radioButtonNomeMecanica.Checked == true)
                    {

                        MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();
                        MecanicaColecao mecanicaColecao = new MecanicaColecao();
                        mecanicaColecao = mecanicaNegocios.ConsultarPorNome(textBoxPesquisarMecanica.Text);

                        dataGridMecanica.DataSource = null;
                        dataGridMecanica.DataSource = mecanicaColecao;

                        dataGridMecanica.Update();
                        dataGridMecanica.Refresh();

                    }

            buttonAtualizar.Enabled = true;
            
        }

        private void AtualizarGrid()
        {
            MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();
            MecanicaColecao mecanicaColecao = new MecanicaColecao();
            mecanicaColecao = mecanicaNegocios.ConsultarPorNome(textBoxPesquisarMecanica.Text);

            dataGridMecanica.DataSource = null;
            dataGridMecanica.DataSource = mecanicaColecao;

            dataGridMecanica.Update();
            dataGridMecanica.Refresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonExcluirMecanica_Click(object sender, EventArgs e)
        {
            //verificar se tem linha selecionado
            if (dataGridMecanica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Mecânica selecionada!");
                return;
            }

            // Pergunta se realmente deseja realizar a ação

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmar exclusão de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar mecanica

            Mecanica mecanicaSelecionado = (dataGridMecanica.SelectedRows[0].DataBoundItem as Mecanica);

            //Instancia
            MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();

            //Metodo Excluir

            string retorno = mecanicaNegocios.Excluir(mecanicaSelecionado);
            try
            {
                int ID_MECANICA = Convert.ToInt32(retorno);

                MessageBox.Show("Mecânica excluida com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionarMecanica_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Adicionar?", "Confirmar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //Instanciar formulario cadastro
            FrmCadastrarMecanica frmCadastrarMecanica = new FrmCadastrarMecanica(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmCadastrarMecanica.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonEditarMecanica_Click(object sender, EventArgs e)
        {
            DialogResult rsd = MessageBox.Show("Tem certeza que deseja Editar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsd == DialogResult.No)
            {
                return;
            }
            
            //verificar se tem linha selecionado
            if (dataGridMecanica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Mecânica selecionada!");
                return;
            }

            //Pegar mecanica

            Mecanica mecanicaSelecionado = (dataGridMecanica.SelectedRows[0].DataBoundItem as Mecanica);

            FrmCadastrarMecanica frmCadastrarMecanica = new FrmCadastrarMecanica(AcaoNaTela.Alterar, mecanicaSelecionado);
            DialogResult resultado = frmCadastrarMecanica.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }

        private void buttonConsultarMecanica_Click(object sender, EventArgs e)
        {
          
            //verificar se tem linha selecionado
            if (dataGridMecanica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Mecânica Selecionada!");
                return;
            }

            //Pegar mecanica

            Mecanica mecanicaSelecionado = (dataGridMecanica.SelectedRows[0].DataBoundItem as Mecanica);

            FrmCadastrarMecanica frmCadastrarMecanica = new FrmCadastrarMecanica(AcaoNaTela.Consultar, mecanicaSelecionado);
            frmCadastrarMecanica.ShowDialog();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            textBoxPesquisarMecanica.Clear();
            AtualizarGrid();

        }

        private void radioButtonIdMecanica_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonIdMecanica.Text = "ID";
        }

        private void radioButtonNomeMecanica_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonNomeMecanica.Text = "Nome";
        }

        private void textBoxPesquisarMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PressionarID)
            {
                ID.Apenas_Numeros(e);
            }
            else
            {
               
            }
        }

        private void radioButtonIdMecanica_Click(object sender, EventArgs e)
        {
            PressionarID = true;
            textBoxPesquisarMecanica.Clear();
        }

        private void radioButtonNomeMecanica_Click(object sender, EventArgs e)
        {
            PressionarID = false;
            textBoxPesquisarMecanica.Clear();
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
