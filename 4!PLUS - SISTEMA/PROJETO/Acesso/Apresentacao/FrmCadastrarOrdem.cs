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
    public partial class FrmCadastrarOrdem : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;
        Permissao_Numeros VALORMECANICA = new Permissao_Numeros();
        Permissao_Numeros VALOROFICINA = new Permissao_Numeros();
      

        //string teste;
        public FrmCadastrarOrdem(AcaoNaTela acaoNaTela, OrdemServico ordemServico)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            acaoNaTelaSelecionada = acaoNaTela;
            

            if (acaoNaTela == AcaoNaTela.Inserir)
            {

                this.Text = "Inserir Ordem Serviço";
                
             
            }

            if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //carregar clientes
                this.Text = "Alterar Ordem Servico";

                textBoxNumOrdem.Text = ordemServico.ID_OS.ToString();
                textBoxNumOrdem.Enabled = false;
                textBoxIdCliente.Text = ordemServico.ID_CLIENTE.ToString();
                textBoxIdCliente.Enabled = false;
                textBoxIdDefeito.Text = ordemServico.ID_DEFEITO.ToString();
                textBoxIdDefeito.Enabled = false;
                textBoxIdVeiculo.Text = ordemServico.ID_VEICULO.ToString();
                textBoxIdVeiculo.Enabled = false;
                textBoxIdMecanica.Text = ordemServico.ID_MECANICA.ToString();
                textBoxIdMecanica.Enabled = false;
                textBoxData.Text = ordemServico.DATA;
                textBoxData.Enabled = false;
                comboBoxStatus.Text = ordemServico.STATUS_OS;
                comboBoxCliente.Text = ordemServico.NOME_CLIENTE;
                textBox_Cpf.Text = ordemServico.CPF_CLIENTE;
                textBox_Cpf.Enabled = false;
                comboBoxPlaca.Text = ordemServico.PLACA_CLIENTE;
                textBoxMarca.Text = ordemServico.MARCA_CLIENTE;
                textBoxMarca.Enabled = false;
                textBoxModelo.Text = ordemServico.MODELO_CLIENTE;
                textBoxModelo.Enabled = false;
                textBoxAno.Text = ordemServico.ANO_CLIENTE.ToString();
                textBoxAno.Enabled = false;
                comboBoxMecanica.Text = ordemServico.NOME_MECANICA;
                comboBoxDefeito.Text = ordemServico.NOME_DEFEITO;
                comboBoxDefeito.Enabled = false;
                textBoxDescricaoDefeito.Text = ordemServico.DESCRIÇÃO_DEFEITO.ToString();
                textBoxDescricaoDefeito.Enabled = false;
                textBoxValorDefeito.Text = ordemServico.VALOR_DEFEITO;
                textBoxValorDefeito.Enabled = false;
                textBoxValorMecanica.Text = ordemServico.VALOR_MECANICA;
                textBoxValorOficina.Text = ordemServico.VALOR_OFICINA;
                textBoxValorTotal.Text = ordemServico.VALOR_TOTAL;
                textBoxValorTotal.Enabled = false;
                textBoxCadastro.Text = ordemServico.CADASTRO;
                textBoxCadastro.Enabled = false;

            }

            if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Ordem";


                textBoxNumOrdem.Text = ordemServico.ID_OS.ToString();
                textBoxIdCliente.Text = ordemServico.ID_CLIENTE.ToString();
                textBoxIdDefeito.Text = ordemServico.ID_DEFEITO.ToString();
                textBoxIdVeiculo.Text = ordemServico.ID_VEICULO.ToString();
                textBoxIdMecanica.Text = ordemServico.ID_MECANICA.ToString();
                textBoxData.Text = ordemServico.DATA;
                comboBoxStatus.Text = ordemServico.STATUS_OS;
                comboBoxCliente.Text = ordemServico.NOME_CLIENTE;
                textBox_Cpf.Text = ordemServico.CPF_CLIENTE;
                comboBoxPlaca.Text = ordemServico.PLACA_CLIENTE;
                textBoxMarca.Text = ordemServico.MARCA_CLIENTE;
                textBoxModelo.Text = ordemServico.MODELO_CLIENTE;
                textBoxAno.Text = ordemServico.ANO_CLIENTE.ToString();
                comboBoxMecanica.Text = ordemServico.NOME_MECANICA;
                comboBoxDefeito.Text = ordemServico.NOME_DEFEITO;
                textBoxDescricaoDefeito.Text = ordemServico.DESCRIÇÃO_DEFEITO.ToString();
                textBoxValorDefeito.Text = ordemServico.VALOR_DEFEITO;
                textBoxValorMecanica.Text = ordemServico.VALOR_MECANICA;
                textBoxValorOficina.Text = ordemServico.VALOR_OFICINA;
                textBoxValorTotal.Text = ordemServico.VALOR_TOTAL;
                textBoxCadastro.Text = ordemServico.CADASTRO;


                //Desabilitar


                textBoxIdCliente.Enabled = false;
                textBoxIdCliente.TabStop = false;

                textBoxIdDefeito.Enabled = false;
                textBoxIdDefeito.TabStop = false;

                textBoxIdVeiculo.Enabled = false; ;
                textBoxIdVeiculo.TabStop = false;

                textBoxIdMecanica.Enabled = false;
                textBoxIdMecanica.TabStop = false;

                textBoxData.Enabled = false;
                textBoxData.TabStop = false;

                comboBoxStatus.Enabled = false;

                comboBoxCliente.Enabled = false;

                textBox_Cpf.Enabled = false;
                textBox_Cpf.TabStop = false;


                comboBoxPlaca.Enabled = false;

                textBoxMarca.Enabled = false;
                textBoxMarca.TabStop = false;

                textBoxModelo.Enabled = false;
                textBoxModelo.TabStop = false;

                textBoxAno.Enabled = false;
                textBoxAno.TabStop = false;

                comboBoxMecanica.Enabled = false;

                comboBoxDefeito.Enabled = false;

                textBoxDescricaoDefeito.Enabled = false;
                textBoxDescricaoDefeito.TabStop = false;

                textBoxValorDefeito.Enabled = false;
                textBoxValorDefeito.TabStop = false;

                textBoxValorMecanica.ReadOnly = true;
                textBoxValorMecanica.TabStop = false;

                textBoxValorOficina.Enabled = false;
                textBoxValorOficina.TabStop = false;

                textBoxValorTotal.Enabled = false;
                textBoxValorTotal.TabStop = false;

                textBoxCadastro.Enabled = false;
                textBoxCadastro.TabStop = false;

                buttonSalvar.Visible = false;
                buttonCalcular.Visible = false;
                buttonCancelar.Focus();

             


            }
        }

        private void FrmCadastrarOrdem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oFICINADataSet5.VEICULO' table. You can move, or remove it, as needed.
            this.vEICULOTableAdapter1.Fill(this.oFICINADataSet5.VEICULO);
            // TODO: This line of code loads data into the 'oFICINADataSet4.VEICULO' table. You can move, or remove it, as needed.
            this.vEICULOTableAdapter.Fill(this.oFICINADataSet4.VEICULO);
            // TODO: This line of code loads data into the 'oFICINADataSet3.DEFEITO' table. You can move, or remove it, as needed.
            this.dEFEITOTableAdapter.Fill(this.oFICINADataSet3.DEFEITO);
            // TODO: This line of code loads data into the 'oFICINADataSet2.MECANICA' table. You can move, or remove it, as needed.
            this.mECANICATableAdapter.Fill(this.oFICINADataSet2.MECANICA);
            // TODO: This line of code loads data into the 'oFICINADataSet1.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.oFICINADataSet1.CLIENTE);

          
          

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if ((comboBoxCliente.Text != ""))
            {
                if (textBoxData.Text == "")
                {
                    textBoxData.Text = DateTime.Now.ToString();
                }
            }

            if (string.IsNullOrEmpty(textBoxValorMecanica.Text) || string.IsNullOrEmpty(textBoxValorOficina.Text) || string.IsNullOrEmpty(comboBoxStatus.Text) || string.IsNullOrEmpty(textBoxIdCliente.Text) || string.IsNullOrEmpty(textBoxIdMecanica.Text) || string.IsNullOrEmpty(textBoxIdDefeito.Text) || string.IsNullOrEmpty(textBoxAno.Text) || string.IsNullOrEmpty(textBoxIdVeiculo.Text) || string.IsNullOrEmpty(textBoxValorTotal.Text))
            {
                //string.IsNullOrEmpty(textBoxValorOficina.Text) || string.IsNullOrEmpty(comboBoxCliente.Text) || string.IsNullOrEmpty(comboBoxPlaca.Text) || string.IsNullOrEmpty(comboBoxMecanica.Text) || string.IsNullOrEmpty(comboBoxDefeito.Text) ||
                MessageBox.Show("Campos não preenchidos!");

               if (string.IsNullOrEmpty(comboBoxStatus.Text))
                {
                    comboBoxStatus.Focus();
                }
                    else
                if (string.IsNullOrEmpty(textBoxIdCliente.Text))
                {
                    comboBoxCliente.Focus();
                } 
                else  
                    if (string.IsNullOrEmpty(textBoxIdVeiculo.Text))
                {
                   comboBoxPlaca.Focus();
                }
                    else
                if (string.IsNullOrEmpty(textBoxIdMecanica.Text))
                {
                    comboBoxMecanica.Focus();
                }
                else
                    if (string.IsNullOrEmpty(textBoxIdDefeito.Text))
                {
                    comboBoxDefeito.Focus();
                }
                    else
                    if (string.IsNullOrEmpty(textBoxValorMecanica.Text))
                {
                    textBoxValorMecanica.Focus();
                }

                else
                    if (string.IsNullOrEmpty(textBoxValorOficina.Text))
                    {
                        textBoxValorOficina.Focus();
                    }

                else
                    if (string.IsNullOrEmpty(textBoxValorTotal.Text))
                    {
                        textBoxValorTotal.Focus();
                    }
            }

                else
            //INSERIR - VERIFICAÇÃO
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                OrdemServico ordemServico = new OrdemServico();

                ordemServico.ID_CLIENTE = int.Parse(textBoxIdCliente.Text);
                ordemServico.ID_DEFEITO = int.Parse(textBoxIdDefeito.Text);
                ordemServico.ID_VEICULO = int.Parse(textBoxIdVeiculo.Text);
                ordemServico.ID_MECANICA = int.Parse(textBoxIdMecanica.Text);
                ordemServico.DATA = textBoxData.Text;
                ordemServico.STATUS_OS = comboBoxStatus.Text;
                ordemServico.NOME_CLIENTE = comboBoxCliente.Text;
                ordemServico.CPF_CLIENTE = textBox_Cpf.Text;
                ordemServico.PLACA_CLIENTE = comboBoxPlaca.Text;
                ordemServico.MARCA_CLIENTE = textBoxMarca.Text;
                ordemServico.MODELO_CLIENTE = textBoxModelo.Text;
                ordemServico.ANO_CLIENTE = int.Parse(textBoxAno.Text);
                ordemServico.NOME_MECANICA = comboBoxMecanica.Text;
                ordemServico.NOME_DEFEITO = comboBoxDefeito.Text;
                ordemServico.DESCRIÇÃO_DEFEITO = textBoxDescricaoDefeito.Text;
                ordemServico.VALOR_DEFEITO = textBoxValorDefeito.Text;
                ordemServico.VALOR_MECANICA = textBoxValorMecanica.Text;
                ordemServico.VALOR_OFICINA = textBoxValorOficina.Text;
                ordemServico.VALOR_TOTAL = textBoxValorTotal.Text;
                ordemServico.CADASTRO = textBoxCadastro.Text;

        
                OsNegocios osNegocios = new OsNegocios();

                DialogResult rsd = MessageBox.Show("Tem certeza que deseja salvar?", "Confirmar dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = osNegocios.Inserir(ordemServico);



                try
                {
                    if ((comboBoxCliente.Text != ""))
                    {
                        if (textBoxData.Text == "")
                        {
                            textBoxData.Text = DateTime.Now.ToString();
                        }
                    }

                    int ID_OS = Convert.ToInt32(retorno);

                    MessageBox.Show("Ordem de Serviço inserida com sucesso! ID: " + ID_OS.ToString());
                    this.DialogResult = DialogResult.Yes;
                    
                    

                }
                catch
                {
                    MessageBox.Show("Não foi possivel inserir! " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.No;
                }
            }

                //ALTERAR.........................
            else
            if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                OrdemServico ordemServico = new OrdemServico();

                ordemServico.ID_OS = int.Parse(textBoxNumOrdem.Text);
                ordemServico.ID_CLIENTE = int.Parse(textBoxIdCliente.Text);
                ordemServico.ID_DEFEITO = int.Parse(textBoxIdDefeito.Text);
                ordemServico.ID_VEICULO = int.Parse(textBoxIdVeiculo.Text);
                ordemServico.ID_MECANICA = int.Parse(textBoxIdMecanica.Text);
                ordemServico.DATA = textBoxData.Text;
                ordemServico.STATUS_OS = comboBoxStatus.Text;
                ordemServico.NOME_CLIENTE = comboBoxCliente.Text;
                ordemServico.CPF_CLIENTE = textBox_Cpf.Text;
                ordemServico.PLACA_CLIENTE = comboBoxPlaca.Text;
                ordemServico.MARCA_CLIENTE = textBoxMarca.Text;
                ordemServico.MODELO_CLIENTE = textBoxModelo.Text;
                ordemServico.ANO_CLIENTE = int.Parse(textBoxAno.Text);
                ordemServico.NOME_MECANICA = comboBoxMecanica.Text;
                ordemServico.NOME_DEFEITO = comboBoxDefeito.Text;
                ordemServico.DESCRIÇÃO_DEFEITO = textBoxDescricaoDefeito.Text;
                ordemServico.VALOR_DEFEITO = textBoxValorDefeito.Text;
                ordemServico.VALOR_MECANICA = textBoxValorMecanica.Text;
                ordemServico.VALOR_OFICINA = textBoxValorOficina.Text;
                ordemServico.VALOR_TOTAL = textBoxValorTotal.Text;
                ordemServico.CADASTRO = textBoxCadastro.Text;

                OsNegocios osNegocios = new OsNegocios();
                DialogResult rsd = MessageBox.Show("Tem certeza que deseja alterar?", "Confirmar alteração de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rsd == DialogResult.No)
                {
                    return;
                }
                string retorno = osNegocios.Alterar(ordemServico);

                try
                {
                    int ID_OS = Convert.ToInt32(retorno);

                    MessageBox.Show("Ordem de Serviço/ID: " + ID_OS.ToString() + " Alterado com sucesso!");
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja cancelar está requisição?", "Finalizar operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            textBoxIdCliente.Text = ObterPorNome(comboBoxCliente.Text);
            textBox_Cpf.Text = CPF(comboBoxCliente.Text);
            //laço para prencher o comboBox /////////////////////
            comboBoxPlaca.SelectedValue = ObterPlaca(comboBoxCliente.Text);
            ////////////////////////////////////////////////
        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
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
            string sql = "SELECT  NOME,  ID_CLIENTE FROM CLIENTE WHERE NOME = @NOME";
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

        public string CPF(string NOME)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string CPF = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME, CPF FROM CLIENTE WHERE NOME = @NOME";
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
                CPF = leitor["CPF"].ToString();
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return CPF;
        }

        public string ObterPlaca(string NOME_CLIENTE)
        {
            
            
            //instância da string que receberá o nome e será retornada
            string PLACA = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser executado 
            string sql = "SELECT PLACA FROM VEICULO WHERE NOME_CLIENTE = @NOME_CLIENTE";
        

            //monto o comando
            SqlCommand cmd1 = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd1.Parameters.AddWithValue("@NOME_CLIENTE", NOME_CLIENTE);
            //abro a conexão
            conn.Open();
            //instancio o leitor
            //DataSet ds = new DataSet();
            //SqlDataAdapter data = new SqlDataAdapter(cmd);
            //data.Fill(ds);
            
            SqlDataReader leitor = cmd1.ExecuteReader();

            if (leitor.HasRows)
            {
                    //MessageBox.Show(leitor.VisibleFieldCount.ToString());
                comboBoxPlaca.Items.Clear();
                while(leitor.Read())
                {
                    comboBoxPlaca.Items.Add(leitor[0].ToString());
                    //MessageBox.Show(leitor[0].ToString());
                }
                    
                    
                    //comboBoxPlaca.Items.Add("dfhfghfg");
                    
            
                
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return PLACA;
        }

        private void sELECT_NOME_CLIENTE_FROM_dbo_VEICULOToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vEICULOTableAdapter.SELECT_NOME_CLIENTE_FROM_dbo_VEICULO(this.oFICINADataSet4.VEICULO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdVeiculo.Text = ObterIdPlaca(comboBoxPlaca.Text);
            textBoxMarca.Text = ObterMarcaVeiculo(comboBoxPlaca.Text);
            textBoxModelo.Text = ObterModeloVeiculo(comboBoxPlaca.Text);
            textBoxAno.Text = ObterAnoVeiculo(comboBoxPlaca.Text);

        }
        public string ObterIdPlaca(string PLACA)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string ID_VEICULO = ("");
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT PLACA, ID_VEICULO FROM VEICULO WHERE PLACA = @PLACA";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@PLACA", PLACA);
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
                ID_VEICULO = Convert.ToString(leitor["ID_VEICULO"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return ID_VEICULO.ToString();
        }

        private void comboBoxMecanica_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdMecanica.Text = ObterIdMecanica(comboBoxMecanica.Text);

        }

        public string ObterIdMecanica(string NOME_MECANICA)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string ID_MECANICA = ("");
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME_MECANICA, ID_MECANICA FROM MECANICA WHERE NOME_MECANICA = @NOME_MECANICA";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@NOME_MECANICA", NOME_MECANICA);
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
                ID_MECANICA = Convert.ToString(leitor["ID_MECANICA"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return ID_MECANICA.ToString();
        }

        private void comboBoxDefeito_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdDefeito.Text = ObterIdDefeito(comboBoxDefeito.Text);
            textBoxDescricaoDefeito.Text = ObterDescricao(comboBoxDefeito.Text);
            textBoxValorDefeito.Text = ObterValor(comboBoxDefeito.Text);
        }

        public string ObterIdDefeito(string NOME_DEFEITO)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string ID_DEFEITO = ("");
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME_DEFEITO, ID_DEFEITO FROM DEFEITO WHERE NOME_DEFEITO = @NOME_DEFEITO";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@NOME_DEFEITO", NOME_DEFEITO);
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
                ID_DEFEITO = Convert.ToString(leitor["ID_DEFEITO"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return ID_DEFEITO.ToString();
        }

        public string ObterDescricao(string NOME_DEFEITO)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string DESCRIÇÃO = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME_DEFEITO, DESCRIÇÃO FROM DEFEITO WHERE NOME_DEFEITO = @NOME_DEFEITO";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@NOME_DEFEITO", NOME_DEFEITO);
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
                DESCRIÇÃO = Convert.ToString(leitor["DESCRIÇÃO"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return DESCRIÇÃO.ToString();
        }

        public string ObterValor(string NOME_DEFEITO)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string VALOR = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT NOME_DEFEITO, VALOR FROM DEFEITO WHERE NOME_DEFEITO = @NOME_DEFEITO";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@NOME_DEFEITO", NOME_DEFEITO);
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
                VALOR = Convert.ToString(leitor["VALOR"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return VALOR.ToString();
        }

        public string ObterMarcaVeiculo(string PLACA)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string MARCA = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT PLACA, MARCA FROM VEICULO WHERE PLACA = @PLACA";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@PLACA", PLACA);
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
                MARCA = Convert.ToString(leitor["MARCA"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return MARCA.ToString();
        }


        public string ObterModeloVeiculo(string PLACA)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string MODELO = "";
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT PLACA, MODELO FROM VEICULO WHERE PLACA = @PLACA";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@PLACA", PLACA);
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
                MODELO = Convert.ToString(leitor["MODELO"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return MODELO.ToString();
        }

        public string ObterAnoVeiculo(string PLACA)
        {

            //instância da string que 
            //receberá o nome e será retornada
            string ANO = ("");
            //instância da conexão
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OFICINA;Integrated Security=True");
            //string com o comando a ser
            //executado 
            string sql = "SELECT PLACA, ANO FROM VEICULO WHERE PLACA = @PLACA";
            //monto o comando
            SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
            //preencho o parâmetro do comando      
            cmd.Parameters.AddWithValue("@PLACA", PLACA);
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
                ANO = Convert.ToString(leitor["ANO"]);
            }
            //fecho conexão
            conn.Close();
            //retorno a string
            return ANO.ToString();
        }


        private void textBoxDescricaoDefeito_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValorTotal_TextChanged(object sender, EventArgs e)
        {
         
            Moeda(ref textBoxValorTotal);
            
            textBoxValorTotal.Font = new Font(textBoxValorTotal.Font.FontFamily, 16);

            textBoxValorTotal.ForeColor = Color.Blue;
            textBoxValorTotal.TextAlign =  HorizontalAlignment.Center;
            

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxValorMecanica.Text) || string.IsNullOrEmpty(textBoxValorOficina.Text) || string.IsNullOrEmpty(textBoxValorDefeito.Text))
            {
                  MessageBox.Show("Valores não preenchidos!");
                  if (string.IsNullOrEmpty(textBoxValorDefeito.Text))
                  {
                      textBoxValorDefeito.Focus();
                  }
                  else
                 if (string.IsNullOrEmpty(textBoxValorMecanica.Text))
                {
                    textBoxValorMecanica.Focus();
                }
                else
                     if (string.IsNullOrEmpty(textBoxValorOficina.Text))
                {
                    textBoxValorOficina.Focus();
                }
            }
             
            
                 double valor1 = double.Parse(textBoxValorDefeito.Text);
                 double valor2 = double.Parse(textBoxValorMecanica.Text);
                 double valor3 = double.Parse(textBoxValorOficina.Text);
                 double soma = valor1 + valor2 + valor3;
                textBoxValorTotal.Text = soma.ToString();
                 
          
            
           
            
        }

        public void Moeda (ref TextBox txt)
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

        private void textBoxValorMecanica_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref textBoxValorMecanica);
        }

        private void textBoxValorOficina_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref textBoxValorOficina);
        }

        private void textBoxNumOrdem_TextChanged(object sender, EventArgs e)
        {
           
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

        private void textBoxValorMecanica_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALORMECANICA.Apenas_Numeros(e);
        }

        private void textBoxValorOficina_KeyPress(object sender, KeyPressEventArgs e)
        {
            VALOROFICINA.Apenas_Numeros(e);
        }
    }
}
        
              
            

