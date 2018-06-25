using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmCadastrarVeiculo : Form
    {

        AcaoNaTela acaoNaTelaSelecionada;

        public FrmCadastrarVeiculo(AcaoNaTela acaoNaTela, Veiculo veiculo)
        {
            InitializeComponent();
            acaoNaTelaSelecionada = acaoNaTela;
       


            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";
                
            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar clientes
                this.Text = "Alterar Veiculo";
                textBoxId.Text = veiculo.ID_VEICULO.ToString();
                textBoxId.Enabled = false;
                textBoxPlaca.Text = veiculo.PLACA;
                textBoxPlaca.Enabled = false;
                comboBoxMarca.Text = veiculo.MARCA;
                textBoxModelo.Text = veiculo.MODELO;
                textBoxAno.Text = veiculo.ANO.ToString();
                comboBoxCor.Text = veiculo.COR;
                comboBoxCombustivel.Text = veiculo.COMBUSTIVEL;
                textBoxIdCliente.Text = veiculo.ID_CLIENTE.ToString();
                textBoxIdCliente.Enabled = false;
                comboBoxCliente.Text = veiculo.NOME_CLIENTE.ToString();
                comboBoxCliente.Enabled = false;
           

            }

            if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Veiculo";
                textBoxId.Text = veiculo.ID_VEICULO.ToString();
                textBoxPlaca.Text = veiculo.PLACA;
                comboBoxMarca.Text = veiculo.MARCA;
                textBoxModelo.Text = veiculo.MODELO;
                textBoxAno.Text = veiculo.ANO.ToString();
                comboBoxCor.Text = veiculo.COR;
                comboBoxCombustivel.Text = veiculo.COMBUSTIVEL;
                textBoxIdCliente.Text = veiculo.ID_CLIENTE.ToString();
                comboBoxCliente.Text = veiculo.NOME_CLIENTE.ToString();
               


                //Desabilitar


                textBoxPlaca.Enabled = false;
                textBoxPlaca.TabStop = false;


           
                comboBoxMarca.Enabled = false;

                textBoxModelo.Enabled = false;
                textBoxModelo.TabStop = false;

                textBoxAno.Enabled = false;
                textBoxAno.TabStop = false;

               
                comboBoxCor.Enabled = false;

                comboBoxCombustivel.Enabled = false;
                comboBoxCombustivel.Enabled = false;

                textBoxIdCliente.Enabled = false;
                textBoxIdCliente.TabStop = false;

                comboBoxCliente.Enabled = false;
                comboBoxCliente.Enabled = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Focus();

                
              

            }
        }
        Permissao_Numeros Ano_Veiculo = new Permissao_Numeros();
 
        private void FrmCadastrarVeiculo_Load(object sender, EventArgs e)
        { 
           
            // TODO: This line of code loads data into the 'oFICINADataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.oFICINADataSet.CLIENTE);
            
           
        }


        private void button1_Click(object sender, EventArgs e)
        {


            
        }

        public string ObterPorNome(string NOME)
        {
            //instância da string que 
            //receberá o nome e será retornada
            string ID_CLIENTE = ("");
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME, ID_CLIENTE FROM CLIENTE WHERE NOME = @NOME";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@NOME", NOME);
            //abro a conexão
            conn.Open();
            //instancio o leitor
            SqlDataReader leitor = cmd.ExecuteReader();
            //se tiver linhas
            if (leitor.HasRows)
            {
                leitor.Read();
                //variável é preenchida com 
                //o resultado obtido na consulta
                ID_CLIENTE = Convert.ToString(leitor["ID_CLIENTE"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return ID_CLIENTE.ToString();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaca.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(textBoxModelo.Text) || string.IsNullOrEmpty(textBoxAno.Text) || string.IsNullOrEmpty(comboBoxCliente.Text))
            {

                MessageBox.Show("Campos não preenchidos!");

                if (string.IsNullOrEmpty(textBoxPlaca.Text))
                {
                    textBoxPlaca.Focus();
                }
                else
                    if (string.IsNullOrEmpty(comboBoxMarca.Text))
                    {
                        comboBoxMarca.Focus();
                    }
                else
                    if (string.IsNullOrEmpty(textBoxModelo.Text))
                    {
                        textBoxModelo.Focus();
                    }
                 else
                    if (string.IsNullOrEmpty(textBoxAno.Text))
                    {
                        textBoxAno.Focus();
                    }
                    else
                        if (string.IsNullOrEmpty(comboBoxCliente.Text))
                        {
                            comboBoxCliente.Focus();
                        }
            }

            else
            {
                //Verificacao
                if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
                {
                  
                    Veiculo veiculo = new Veiculo();
                    veiculo.PLACA = textBoxPlaca.Text;
                    veiculo.MARCA = comboBoxMarca.Text;
                    veiculo.MODELO = textBoxModelo.Text;
                    veiculo.ANO = int.Parse(textBoxAno.Text);
                    veiculo.COR = comboBoxCor.Text;
                    veiculo.COMBUSTIVEL = comboBoxCombustivel.Text;
                    veiculo.ID_CLIENTE = int.Parse(textBoxIdCliente.Text);
                    veiculo.NOME_CLIENTE = comboBoxCliente.Text;
              

                    VeiculoNegocios veiculoNegocios = new VeiculoNegocios();

                    DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rsd == DialogResult.No)
                    {
                        return;
                    }
                    string retorno = veiculoNegocios.Inserir(veiculo);


                    try
                    {
                        int ID_VEICULO = Convert.ToInt32(retorno);

                        MessageBox.Show("veiculo inserido com sucesso! ID: " + ID_VEICULO.ToString());
                        this.DialogResult = DialogResult.Yes;

                    }
                    catch
                    {
                        MessageBox.Show("Veículo já cadastrado no sistema", "Não foi possivel inserir!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.No;
                    }
                }

                    //ALTERAR.........................
                else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
                {
                    Veiculo veiculo = new Veiculo();

                    veiculo.ID_VEICULO = Convert.ToInt32(textBoxId.Text);
                    veiculo.PLACA = textBoxPlaca.Text;
                    veiculo.MARCA = comboBoxMarca.Text;
                    veiculo.MODELO = textBoxModelo.Text;
                    veiculo.ANO = int.Parse(textBoxAno.Text);
                    veiculo.COR = comboBoxCor.Text;
                    veiculo.COMBUSTIVEL = comboBoxCombustivel.Text;
                    veiculo.ID_CLIENTE = int.Parse(textBoxIdCliente.Text);
                    veiculo.NOME_CLIENTE = comboBoxCliente.Text;


                    VeiculoNegocios veiculoNegocios = new VeiculoNegocios();
                    DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (rsd == DialogResult.No)
                    {
                        return;
                    }
                    string retorno = veiculoNegocios.Alterar(veiculo);

                    try
                    {
                        int ID_VEICULO = Convert.ToInt32(retorno);

                        MessageBox.Show("Veículo/ID: " + ID_VEICULO.ToString() + " Alterado com sucesso!");
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel alterar o veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdCliente.Text = ObterPorNome(comboBoxCliente.Text);
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
          
        }

        private void textBoxAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ano_Veiculo.Apenas_Numeros(e);
        }

        private void comboBoxCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPlaca_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.textBoxPlaca.Mask = "???-0000";
        }

    }
}
