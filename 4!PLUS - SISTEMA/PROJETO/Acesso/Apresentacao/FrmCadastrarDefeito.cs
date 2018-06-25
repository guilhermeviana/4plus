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
    public partial class FrmCadastrarDefeito : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        //Construtor
        public FrmCadastrarDefeito (AcaoNaTela acaoNaTela, Defeito defeito)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            acaoNaTelaSelecionada = acaoNaTela;

            if(acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Defeito";
                
            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar defeitos
                this.Text = "Alterar Defeito";
                textBoxCodigo.Text = defeito.ID_DEFEITO.ToString();
                textBoxCodigo.Enabled = false;
                textBoxNomeDefeito.Text = defeito.NOME_DEFEITO;
                textBoxDescricaoDefeito.Text = defeito.DESCRIÇÃO;
                textBoxValorDefeito.Text = defeito.VALOR;

            }

            if (acaoNaTela == AcaoNaTela.Consultar)
            {                
                this.Text = "Consultar Defeito";
                textBoxCodigo.Text = defeito.ID_DEFEITO.ToString();
                textBoxCodigo.Enabled = false;
                textBoxNomeDefeito.Text = defeito.NOME_DEFEITO;
                textBoxDescricaoDefeito.Text = defeito.DESCRIÇÃO;
                textBoxValorDefeito.Text = defeito.VALOR;

                //Desabilitar


                textBoxNomeDefeito.Enabled = false; 
                textBoxNomeDefeito.TabStop = false;

                textBoxDescricaoDefeito.Enabled = false;
                textBoxDescricaoDefeito.TabStop = false;

                textBoxValorDefeito.Enabled = false;
                textBoxValorDefeito.TabStop = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Focus();

            }

        }
        Permissao_Letras Defeito = new Permissao_Letras();
        Permissao_Numeros Valor = new Permissao_Numeros();

        //INSERIR.......................
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomeDefeito.Text) || string.IsNullOrEmpty(textBoxDescricaoDefeito.Text) || string.IsNullOrEmpty(textBoxValorDefeito.Text))
            {

                MessageBox.Show("Campos não preenchidos!");

                if (string.IsNullOrEmpty(textBoxNomeDefeito.Text))
                {
                    textBoxNomeDefeito.Focus();
                }
                else
                if (string.IsNullOrEmpty(textBoxDescricaoDefeito.Text))
                {
                    textBoxDescricaoDefeito.Focus();
                }
                else
                if (string.IsNullOrEmpty(textBoxValorDefeito.Text))
                {
                    textBoxValorDefeito.Focus();
                }

            }

            else
            { 
           
            if(acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Defeito defeito = new Defeito();

                

                defeito.NOME_DEFEITO = textBoxNomeDefeito.Text;
                defeito.DESCRIÇÃO = textBoxDescricaoDefeito.Text;
                defeito.VALOR = textBoxValorDefeito.Text;
               

                DefeitoNegocios defeitoNegocios = new DefeitoNegocios();

                DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = defeitoNegocios.Inserir(defeito);

                
                try
                {
                    int ID_DEFEITO = Convert.ToInt32(retorno);

                    MessageBox.Show("Defeito inserido com sucesso! ID: " + ID_DEFEITO.ToString());
                    this.DialogResult = DialogResult.Yes;
                    
                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }
            }

                //ALTERAR.........................
            else 
                if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Defeito defeito = new Defeito();

                defeito.ID_DEFEITO = Convert.ToInt32(textBoxCodigo.Text);
                defeito.NOME_DEFEITO = textBoxNomeDefeito.Text;
                defeito.DESCRIÇÃO = textBoxDescricaoDefeito.Text;
                defeito.VALOR = textBoxValorDefeito.Text;

                DefeitoNegocios defeitoNegocios = new DefeitoNegocios();
                DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = defeitoNegocios.Alterar(defeito);

                try
                {
                    int ID_DEFEITO = Convert.ToInt32(retorno);

                    MessageBox.Show("Defeito/ID: " + ID_DEFEITO.ToString() + " Alterado com sucesso!" );
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            
            }
        }

        //CANCELAR........................
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FrmCadastrarDefeito_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNomeDefeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Defeito.Apenas_letras(e);

        }

        private void textBoxValorDefeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valor.Apenas_Numeros(e);
        }
        public void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }
        }

        private void textBoxValorDefeito_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref textBoxValorDefeito);
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
