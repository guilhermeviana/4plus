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
    public partial class FrmCadastrarMecanica : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;
     
        Permissao_Numeros CNPJ = new Permissao_Numeros();
        Permissao_Numeros CEP_Mecanica = new Permissao_Numeros();
        Permissao_Letras Endereco_Mecanica = new Permissao_Letras();
        Permissao_Numeros Numero_Mecanica = new Permissao_Numeros();
        Permissao_Letras Bairoo_Mecanica = new Permissao_Letras();
        Permissao_Letras Cidade_Mecanica = new Permissao_Letras();
        Permissao_Letras UF_Mecanica = new Permissao_Letras();
        Permissao_Numeros Telefone_Mecanica = new Permissao_Numeros();
    




        public FrmCadastrarMecanica(AcaoNaTela acaoNaTela, Mecanica mecanica)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Mecanica";
               

            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar clientes
                this.Text = "Alterar Mecanica";

                textBoxIdMecanica.Text = mecanica.ID_MECANICA.ToString();
                textBoxIdMecanica.Enabled = false;
                textBoxNomeMecanica.Text = mecanica.NOME_MECANICA;
                textBoxCnpjMecanica.Text = mecanica.CNPJ;
                textBoxCnpjMecanica.Enabled = false;
                textBoxCepMecanica.Text = mecanica.CEP;
                textBoxEnderecoMecanica.Text = mecanica.ENDEREÇO;
                textBoxNumMecanica.Text = mecanica.NUMERO.ToString();
                textBoxComplementoMecanica.Text = mecanica.COMPLEMENTO;
                textBoxBairroMecanica.Text = mecanica.BAIRRO;
                textBoxCidadeMecanica.Text = mecanica.CIDADE;
                textBoxUfMecanica.Text = mecanica.UF;
                textBoxTelMecanica.Text = mecanica.TEL_COMERCIAL;
               

            }

            if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Mecanica";

                textBoxIdMecanica.Text = mecanica.ID_MECANICA.ToString();
                textBoxNomeMecanica.Text = mecanica.NOME_MECANICA;
                textBoxCnpjMecanica.Text = mecanica.CNPJ;
                textBoxCepMecanica.Text = mecanica.CEP;
                textBoxEnderecoMecanica.Text = mecanica.ENDEREÇO;
                textBoxNumMecanica.Text = mecanica.NUMERO.ToString();
                textBoxComplementoMecanica.Text = mecanica.COMPLEMENTO;
                textBoxBairroMecanica.Text = mecanica.BAIRRO;
                textBoxCidadeMecanica.Text = mecanica.CIDADE;
                textBoxUfMecanica.Text = mecanica.UF;
                textBoxTelMecanica.Text = mecanica.TEL_COMERCIAL;

                buttonPesquisarCep.Visible = false;
               

                //Desabilitar


                textBoxNomeMecanica.Enabled = false;
                textBoxNomeMecanica.TabStop = false;

                textBoxCnpjMecanica.Enabled = false;
                textBoxCnpjMecanica.TabStop = false;

                textBoxCepMecanica.Enabled = false; ;
                textBoxCepMecanica.TabStop = false;

                textBoxEnderecoMecanica.Enabled = false;
                textBoxEnderecoMecanica.TabStop = false;

                textBoxNumMecanica.Enabled = false;
                textBoxNumMecanica.TabStop = false;

                textBoxComplementoMecanica.Enabled = false;
                textBoxComplementoMecanica.TabStop = false;

                textBoxBairroMecanica.Enabled = false;
                textBoxBairroMecanica.TabStop = false;

                textBoxCidadeMecanica.Enabled = false;
                textBoxCidadeMecanica.TabStop = false;

                textBoxUfMecanica.Enabled = false;
                textBoxUfMecanica.TabStop = false;

                textBoxTelMecanica.Enabled = false;
                textBoxTelMecanica.TabStop = false;

                buttonSalvarMecanica.Visible = false;
                buttonCancelarCadastro.Focus();

            }
        }

        private void FrmCadastrarMecanica_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvarMecanica_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNomeMecanica.Text) || string.IsNullOrEmpty(textBoxCnpjMecanica.Text) || string.IsNullOrEmpty(textBoxCepMecanica.Text) || string.IsNullOrEmpty(textBoxNumMecanica.Text))
            {

                MessageBox.Show("Campos não preenchidos!");

                if (string.IsNullOrEmpty(textBoxNomeMecanica.Text))
                {
                    textBoxNomeMecanica.Focus();
                }
                else
                    if (string.IsNullOrEmpty(textBoxCnpjMecanica.Text))
                    {
                        textBoxCnpjMecanica.Focus();
                    }
                    else
                        if (string.IsNullOrEmpty(textBoxCepMecanica.Text))
                        {
                            textBoxCepMecanica.Focus();
                        }

                    else
                        if (string.IsNullOrEmpty(textBoxNumMecanica.Text))
                        {
                            textBoxNumMecanica.Focus();
                        }

            }

            else
            {
                //Verificacao
                if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                {
                    Mecanica mecanica = new Mecanica();
                    mecanica.NOME_MECANICA = textBoxNomeMecanica.Text;
                    mecanica.CNPJ = textBoxCnpjMecanica.Text;
                    mecanica.CEP = textBoxCepMecanica.Text;
                    mecanica.ENDEREÇO = textBoxEnderecoMecanica.Text;
                    mecanica.NUMERO = int.Parse(textBoxNumMecanica.Text);
                    mecanica.COMPLEMENTO = textBoxComplementoMecanica.Text;
                    mecanica.BAIRRO = textBoxBairroMecanica.Text;
                    mecanica.CIDADE = textBoxCidadeMecanica.Text;
                    mecanica.UF = textBoxUfMecanica.Text;
                    mecanica.TEL_COMERCIAL = textBoxTelMecanica.Text;

                    MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();

                    DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rsd == DialogResult.No)
                    {
                        return;
                    }
                    string retorno = mecanicaNegocios.Inserir(mecanica);


                    try
                    {
                        int ID_MECANICA = Convert.ToInt32(retorno);

                        MessageBox.Show("Mecânica inserida com sucesso! ID: " + ID_MECANICA.ToString());
                        this.DialogResult = DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Mecânica já cadastrado no sistema ", "Não foi possivel inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.No;
                    }
                }



                    //ALTERAR.........................
                else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                {
                    Mecanica mecanica = new Mecanica();
                    mecanica.ID_MECANICA = Convert.ToInt32(textBoxIdMecanica.Text);
                    mecanica.NOME_MECANICA = textBoxNomeMecanica.Text;
                    mecanica.CNPJ = textBoxCnpjMecanica.Text.ToString();
                    mecanica.CEP = textBoxCepMecanica.Text.ToString();
                    mecanica.ENDEREÇO = textBoxEnderecoMecanica.Text;
                    mecanica.NUMERO = int.Parse(textBoxNumMecanica.Text);
                    mecanica.COMPLEMENTO = textBoxComplementoMecanica.Text;
                    mecanica.BAIRRO = textBoxBairroMecanica.Text;
                    mecanica.CIDADE = textBoxCidadeMecanica.Text;
                    mecanica.UF = textBoxUfMecanica.Text;
                    mecanica.TEL_COMERCIAL = textBoxTelMecanica.Text;

                    MecanicaNegocios mecanicaNegocios = new MecanicaNegocios();
                    DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rsd == DialogResult.No)
                    {
                        return;
                    }
                    string retorno = mecanicaNegocios.Alterar(mecanica);

                    try
                    {
                        int ID_MECANICA = Convert.ToInt32(retorno);

                        MessageBox.Show("Mecânica/ID: " + ID_MECANICA.ToString() + " Alterada com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }

            }
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
             
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        
        }

        //CEP
        private void buttonPesquisarCep_Click_1(object sender, EventArgs e)
        {
            labelCepResultado.Visible = true;

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
            .Replace("@cep", textBoxCepMecanica.Text);

            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            labelCepResultado.Text = ds.Tables[0].Rows[0][1].ToString();

            textBoxEnderecoMecanica.Text = (ds.Tables[0].Rows[0][5]) + (" ") + (ds.Tables[0].Rows[0][6]).ToString();
            textBoxBairroMecanica.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxCidadeMecanica.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxUfMecanica.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void textBoxIdMecanica_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxCnpjMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            CNPJ.Apenas_Numeros(e);
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCnpjMecanica.TextLength)
                {
                    case 0:
                        textBoxCnpjMecanica.Text = "";
                        break;
                    case 2:
                        textBoxCnpjMecanica.Text = textBoxCnpjMecanica.Text + ".";
                        textBoxCnpjMecanica.SelectionStart = 4;
                        break;

                    case 6:
                        textBoxCnpjMecanica.Text = textBoxCnpjMecanica.Text + ".";
                        textBoxCnpjMecanica.SelectionStart = 8;
                        break;

                    case 10:
                        textBoxCnpjMecanica.Text = textBoxCnpjMecanica.Text + "/";
                        textBoxCnpjMecanica.SelectionStart = 11;
                        break;

                    case 15:
                        textBoxCnpjMecanica.Text = textBoxCnpjMecanica.Text + "-";
                        textBoxCnpjMecanica.SelectionStart = 16;
                        break;
                }
            }
        }

        private void textBoxCepMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            CEP_Mecanica.Apenas_Numeros(e);
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (textBoxCepMecanica.TextLength)
                {
                    case 0:
                        textBoxCepMecanica.Text = "";
                        break;

                    case 5:
                        textBoxCepMecanica.Text = textBoxCepMecanica.Text + ".";
                        textBoxCepMecanica.SelectionStart = 6;
                        break;

                }
            }

        }

        private void textBoxEnderecoMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Endereco_Mecanica.Apenas_letras(e);

        }

        private void textBoxNumMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numero_Mecanica.Apenas_Numeros(e);

        }

        private void textBoxComplementoMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {            
        }

        private void textBoxBairroMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bairoo_Mecanica.Apenas_letras(e);
        }

        private void textBoxCidadeMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cidade_Mecanica.Apenas_letras(e);
        }

        private void textBoxUfMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            UF_Mecanica.Apenas_letras(e);
            textBoxUfMecanica.MaxLength = 2;

        }

        private void textBoxTelMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            Telefone_Mecanica.Apenas_Numeros(e);
            textBoxTelMecanica.MaxLength = 8;

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
