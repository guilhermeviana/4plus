using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmCadastrarCliente : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;
        Permissao_Letras Nome = new Permissao_Letras();
        Permissao_Numeros CPF = new Permissao_Numeros();
        Permissao_Numeros CEP = new Permissao_Numeros();
        Permissao_Letras Endereco = new Permissao_Letras();
        Permissao_Numeros Numero = new Permissao_Numeros();
        Permissao_Numeros Celular = new Permissao_Numeros();
        Permissao_Letras Bairro = new Permissao_Letras();
        Permissao_Letras Cidade = new Permissao_Letras();
        Permissao_Letras UF = new Permissao_Letras();
        Permissao_Numeros Residencial = new Permissao_Numeros();
        


        //Construtor
        public FrmCadastrarCliente(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            acaoNaTelaSelecionada = acaoNaTela;

            if(acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";


            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar clientes
                this.Text = "Alterar Cliente";
                textBoxCodigo.Text = cliente.ID_CLIENTE.ToString();
                textBoxCodigo.Enabled = false;
                textBoxNome.Text = cliente.NOME;
                textBoxNome.Enabled = false;
                textBoxCpf.Text = cliente.CPF;
                textBoxCpf.Enabled = false;
                textBoxCep.Text = cliente.CEP;
                textBoxEndereco.Text = cliente.ENDEREÇO;
                textBoxNumero.Text = cliente.NUMERO.ToString();
                textBoxComplemento.Text = cliente.COMPLEMENTO;
                textBoxBairro.Text = cliente.BAIRRO;
                textBoxCidade.Text = cliente.CIDADE;
                textBoxUf.Text = cliente.UF;
                maskedTextBoxCelular.Text = cliente.TEL_CELULAR;
                maskedTextBoxResidencial.Text = cliente.TEL_RESIDENCIAL;
                textBoxEmail.Text = cliente.EMAIL;

            }

            if (acaoNaTela == AcaoNaTela.Consultar)
            {                
                this.Text = "Consultar Cliente";
                textBoxCodigo.Text = cliente.ID_CLIENTE.ToString();
                textBoxNome.Text = cliente.NOME;
                textBoxCpf.Text = cliente.CPF;
                textBoxCep.Text = cliente.CEP;
                textBoxEndereco.Text = cliente.ENDEREÇO;
                textBoxNumero.Text = cliente.NUMERO.ToString();
                textBoxComplemento.Text = cliente.COMPLEMENTO;
                textBoxBairro.Text = cliente.BAIRRO;
                textBoxCidade.Text = cliente.CIDADE;
                textBoxUf.Text = cliente.UF;
                maskedTextBoxCelular.Text = cliente.TEL_CELULAR;
                maskedTextBoxResidencial.Text = cliente.TEL_RESIDENCIAL;
                textBoxEmail.Text = cliente.EMAIL;

                buttonCep.Visible = false;

                //Desabilitar


                textBoxNome.Enabled = false;
                textBoxNome.TabStop = false;

                textBoxCpf.Enabled = false;
                textBoxCpf.TabStop = false;

                textBoxCep.Enabled = false;
                textBoxCep.TabStop = false;

                textBoxEndereco.Enabled = false;
                textBoxEndereco.TabStop = false;

                textBoxNumero.Enabled = false;
                textBoxNumero.TabStop = false;

                textBoxComplemento.Enabled = false;
                textBoxComplemento.TabStop = false;

                textBoxBairro.Enabled = false;
                textBoxBairro.TabStop = false;

                textBoxCidade.Enabled = false;

                textBoxUf.Enabled = false;

                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCelular.TabStop = false;

                maskedTextBoxResidencial.Enabled = false;
                maskedTextBoxResidencial.TabStop = false; ;

                textBoxEmail.Enabled = false;
                textBoxEmail.TabStop = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Focus();

            }

        }

        //INSERIR
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxCpf.Text) || string.IsNullOrEmpty(textBoxCep.Text) || string.IsNullOrEmpty(textBoxNumero.Text))
            {

                MessageBox.Show("Campos não preenchidos!");

                if (string.IsNullOrEmpty(textBoxNome.Text))
                {
                    textBoxNome.Focus();
                }
                else
                if (string.IsNullOrEmpty(textBoxCpf.Text))
                {
                    textBoxCpf.Focus();
                }
                else
                    if (string.IsNullOrEmpty(textBoxCep.Text))
                    {
                        textBoxCep.Focus();
                    }
                    else
                if (string.IsNullOrEmpty(textBoxNumero.Text))
                {
                    textBoxNumero.Focus();
                }

            }

            else
            { 
            //INSERIR - VERIFICAÇÃO
            if(acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Cliente cliente = new Cliente();
                cliente.NOME = textBoxNome.Text;
                cliente.CPF = textBoxCpf.Text.ToString();
                cliente.CEP = textBoxCep.Text.ToString();
                cliente.ENDEREÇO = textBoxEndereco.Text;
                cliente.NUMERO = int.Parse (textBoxNumero.Text);
                cliente.COMPLEMENTO = textBoxComplemento.Text;
                cliente.BAIRRO = textBoxBairro.Text;
                cliente.CIDADE = textBoxCidade.Text;
                cliente.UF = textBoxUf.Text;
                cliente.TEL_CELULAR = maskedTextBoxCelular.Text;
                cliente.TEL_RESIDENCIAL = maskedTextBoxResidencial.Text;
                cliente.EMAIL = textBoxEmail.Text;

                ClienteNegocios clienteNegocios = new ClienteNegocios();

                DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = clienteNegocios.Inserir(cliente);

                
                try
                {
                    int ID_CLIENTE = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente inserido com sucesso! ID: " + ID_CLIENTE.ToString());
                    this.DialogResult = DialogResult.Yes;
                    
                }
                catch
                {
                    MessageBox.Show("Cliente já cadastrado no sistema! ", "Não foi possivel inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }
            }

                //ALTERAR.........................
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Cliente cliente = new Cliente();

                cliente.ID_CLIENTE = Convert.ToInt32(textBoxCodigo.Text);
                cliente.NOME = textBoxNome.Text;
                cliente.CPF = textBoxCpf.Text;
                cliente.CEP = textBoxCep.Text;
                cliente.ENDEREÇO = textBoxEndereco.Text;
                cliente.NUMERO = int.Parse(textBoxNumero.Text);
                cliente.COMPLEMENTO = textBoxComplemento.Text;
                cliente.BAIRRO = textBoxBairro.Text;
                cliente.CIDADE = textBoxCidade.Text;
                cliente.UF = textBoxUf.Text;
                cliente.TEL_CELULAR = maskedTextBoxCelular.Text;
                cliente.TEL_RESIDENCIAL = maskedTextBoxResidencial.Text;
                cliente.EMAIL = textBoxEmail.Text;

                ClienteNegocios clienteNegocios = new ClienteNegocios();
                DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração nos dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = clienteNegocios.Alterar(cliente);

                try
                {
                    int ID_CLIENTE = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente/ID: " + ID_CLIENTE.ToString() + " Alterado com sucesso!" );
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar o cliente ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            
            }
        }

        //CANCELAR
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        //CEP
        private void button1_Click(object sender, EventArgs e)
        {
            labelRetorno.Visible = true;

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
            .Replace("@cep", textBoxCep.Text);

            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            labelRetorno.Text = ds.Tables[0].Rows[0][1].ToString();
     

            textBoxEndereco.Text = (ds.Tables[0].Rows[0][5]) + (" ") + (ds.Tables[0].Rows[0][6]).ToString();
            textBoxBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxCidade.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxUf.Text = ds.Tables[0].Rows[0][2].ToString();
        }



        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxResidencial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {


        }

        private void resultadoCep_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nome.Apenas_letras(e);
        }

        private void textBoxCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            CPF.Apenas_Numeros(e);
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCpf.TextLength)
                {
                    case 0:
                        textBoxCpf.Text = "";
                        break;
                    case 3:
                        textBoxCpf.Text = textBoxCpf.Text + ".";
                        textBoxCpf.SelectionStart = 5;
                        break;

                    case 7:
                        textBoxCpf.Text = textBoxCpf.Text + ".";
                        textBoxCpf.SelectionStart = 9;
                        break;

                    case 11:
                        textBoxCpf.Text = textBoxCpf.Text + "-";
                        textBoxCpf.SelectionStart = 12;
                        break;
                }
            }
        }

        private void textBoxCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            CEP.Apenas_Numeros(e);
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCep.TextLength)
                {
                    case 0:
                        textBoxCep.Text = "";
                        break;

                    case 5:
                        textBoxCep.Text = textBoxCep.Text + ".";
                        textBoxCep.SelectionStart = 6;
                        break;
                        
                }
            }
        }

        private void textBoxEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Endereco.Apenas_letras(e);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numero.Apenas_Numeros(e);
        }

        private void textBoxComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bairro.Apenas_letras(e);
        }

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cidade.Apenas_letras(e);
        }

        private void textBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            UF.Apenas_letras(e);
            textBoxUf.MaxLength = 2;
        }

        private void maskedTextBoxCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Celular.Apenas_Numeros(e);
        }

        private void maskedTextBoxResidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Residencial.Apenas_Numeros(e);
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

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelBairro_Click(object sender, EventArgs e)
        {

        }

        private void labelUf_Click(object sender, EventArgs e)
        {

        }

        private void labelCep_Click(object sender, EventArgs e)
        {

        }

        private void labelCpf_Click(object sender, EventArgs e)
        {

        }

        private void labelCidade_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelComplemento_Click(object sender, EventArgs e)
        {

        }

        private void labelCelular_Click(object sender, EventArgs e)
        {

        }

        private void labelResidencial_Click(object sender, EventArgs e)
        {

        }

        private void labelNumero_Click(object sender, EventArgs e)
        {

        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
