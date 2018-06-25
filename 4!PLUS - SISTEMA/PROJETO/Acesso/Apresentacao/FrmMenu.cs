using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (FrmLogin.NivelAcesso == "OPERADOR")
            {
                //Nível de Operador não podera cadastrar usuário
                usuáriosToolStripMenuItem.Visible = false;
            }

            //Mostrar o usuário conectado
            labelUsuario.Text = "Usuário: " + FrmLogin.usuarioConectado;

            timer1_Tick(e, e);

            string myHost = System.Net.Dns.GetHostName();
            labelNomePc.Text = "Nome do PC: " + myHost;

            //Mostrar o IP do usuário
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                //Mostar o IP
                labelIP.Text = "IP: " + myIP;

            }
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClienteSelecionar frmClienteSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmClienteSelecionar)
                    {
                        frmClienteSelecionar = (FrmClienteSelecionar)frm;
                        break;
                    }
                }
                if (frmClienteSelecionar == null)
                {
                    frmClienteSelecionar = new FrmClienteSelecionar();
                    frmClienteSelecionar.MdiParent = this;
                    frmClienteSelecionar.Show();
                }

                frmClienteSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            
          

        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVeiculoSelecionar frmVeiculoSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmVeiculoSelecionar)
                    {
                        frmVeiculoSelecionar = (FrmVeiculoSelecionar)frm;
                        break;
                    }
                }
                if (frmVeiculoSelecionar == null)
                {
                    frmVeiculoSelecionar = new FrmVeiculoSelecionar();
                    frmVeiculoSelecionar.MdiParent = this;
                    frmVeiculoSelecionar.Show();
                }

                frmVeiculoSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
    
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmOrdemSelecionar frmOrdemSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmOrdemSelecionar)
                    {
                        frmOrdemSelecionar = (FrmOrdemSelecionar)frm;
                        break;
                    }
                }
                if (frmOrdemSelecionar == null)
                {
                    frmOrdemSelecionar = new FrmOrdemSelecionar();
                    frmOrdemSelecionar.MdiParent = this;
                    frmOrdemSelecionar.Show();
                }

                frmOrdemSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void mecanicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmMecanicaSelecionar frmMecanicaSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmMecanicaSelecionar)
                    {
                        frmMecanicaSelecionar = (FrmMecanicaSelecionar)frm;
                        break;
                    }
                }
                if (frmMecanicaSelecionar == null)
                {
                    frmMecanicaSelecionar = new FrmMecanicaSelecionar();
                    frmMecanicaSelecionar.MdiParent = this;
                    frmMecanicaSelecionar.Show();
                }

                frmMecanicaSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
           
        }

        private void defeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDefeitoSelecionar frmDefeitoSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmDefeitoSelecionar)
                    {
                        frmDefeitoSelecionar = (FrmDefeitoSelecionar)frm;
                        break;
                    }
                }
                if (frmDefeitoSelecionar == null)
                {
                    frmDefeitoSelecionar = new FrmDefeitoSelecionar();
                    frmDefeitoSelecionar.MdiParent = this;
                    frmDefeitoSelecionar.Show();
                }

                frmDefeitoSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            labelData.Text = "Data: " + dataHora.ToShortDateString() + "  " + dataHora.ToLongTimeString();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUsuarioSelecionar frmUsuarioSelecionar = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is FrmUsuarioSelecionar)
                    {
                        frmUsuarioSelecionar = (FrmUsuarioSelecionar)frm;
                        break;
                    }
                }
                if (frmUsuarioSelecionar == null)
                {
                    frmUsuarioSelecionar = new FrmUsuarioSelecionar();
                    frmUsuarioSelecionar.MdiParent = this;
                    frmUsuarioSelecionar.Show();
                }

                frmUsuarioSelecionar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ser conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                        MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioOs frmRelatorioOs = new FrmRelatorioOs();
            frmRelatorioOs.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioCliente frmRelatorioCliente = new FrmRelatorioCliente();
            frmRelatorioCliente.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja fazer o Logout?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resultado == DialogResult.Yes)
            {
                Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
               
            }
          
        }
    }
}
