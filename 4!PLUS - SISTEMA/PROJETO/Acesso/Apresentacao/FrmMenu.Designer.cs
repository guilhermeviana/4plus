namespace Apresentacao
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.barraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.labelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelNomePc = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mecanicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            this.barraStatusPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelData,
            this.labelIP,
            this.labelNomePc,
            this.labelVersao,
            this.labelUsuario});
            this.barraStatusPrincipal.Location = new System.Drawing.Point(0, 340);
            this.barraStatusPrincipal.Name = "barraStatusPrincipal";
            this.barraStatusPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.barraStatusPrincipal.Size = new System.Drawing.Size(1452, 22);
            this.barraStatusPrincipal.TabIndex = 1;
            this.barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelData
            // 
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(329, 17);
            this.labelData.Spring = true;
            this.labelData.Text = "toolStripStatusLabel3";
            // 
            // labelIP
            // 
            this.labelIP.BackColor = System.Drawing.Color.Yellow;
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(329, 17);
            this.labelIP.Spring = true;
            this.labelIP.Text = "toolStripStatusLabel1";
            // 
            // labelNomePc
            // 
            this.labelNomePc.Name = "labelNomePc";
            this.labelNomePc.Size = new System.Drawing.Size(329, 17);
            this.labelNomePc.Spring = true;
            this.labelNomePc.Text = "toolStripStatusLabel2";
            // 
            // labelVersao
            // 
            this.labelVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelVersao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.labelVersao.ForeColor = System.Drawing.Color.Black;
            this.labelVersao.ImageTransparentColor = System.Drawing.Color.Red;
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(329, 17);
            this.labelVersao.Spring = true;
            this.labelVersao.Text = "4! Plus - Versão 1.0";
            this.labelVersao.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // labelUsuario
            // 
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(118, 17);
            this.labelUsuario.Text = "toolStripStatusLabel1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Snow;
            this.menuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPrincipal.BackgroundImage")));
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuPrincipal.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.menuCliente,
            this.mecanicaToolStripMenuItem,
            this.veiculoToolStripMenuItem,
            this.defeitoToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem,
            this.históricosToolStripMenuItem,
            this.menuSair,
            this.toolStripMenuItem1});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.Size = new System.Drawing.Size(1452, 54);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuáriosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(174, 50);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.ForeColor = System.Drawing.Color.DimGray;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.menuCliente.Size = new System.Drawing.Size(166, 50);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.Click += new System.EventHandler(this.menuCliente_Click);
            // 
            // mecanicaToolStripMenuItem
            // 
            this.mecanicaToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mecanicaToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.mecanicaToolStripMenuItem.Name = "mecanicaToolStripMenuItem";
            this.mecanicaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.mecanicaToolStripMenuItem.Size = new System.Drawing.Size(186, 50);
            this.mecanicaToolStripMenuItem.Text = "Mecânicas";
            this.mecanicaToolStripMenuItem.Click += new System.EventHandler(this.mecanicaToolStripMenuItem_Click);
            // 
            // veiculoToolStripMenuItem
            // 
            this.veiculoToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veiculoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.veiculoToolStripMenuItem.Name = "veiculoToolStripMenuItem";
            this.veiculoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.veiculoToolStripMenuItem.Size = new System.Drawing.Size(170, 50);
            this.veiculoToolStripMenuItem.Text = "Veículos";
            this.veiculoToolStripMenuItem.Click += new System.EventHandler(this.veiculoToolStripMenuItem_Click);
            // 
            // defeitoToolStripMenuItem
            // 
            this.defeitoToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defeitoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.defeitoToolStripMenuItem.Name = "defeitoToolStripMenuItem";
            this.defeitoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.defeitoToolStripMenuItem.Size = new System.Drawing.Size(169, 50);
            this.defeitoToolStripMenuItem.Text = "Defeitos";
            this.defeitoToolStripMenuItem.Click += new System.EventHandler(this.defeitoToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordemDeServiçoToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(249, 50);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // históricosToolStripMenuItem
            // 
            this.históricosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem1});
            this.históricosToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.históricosToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.históricosToolStripMenuItem.Name = "históricosToolStripMenuItem";
            this.históricosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.históricosToolStripMenuItem.Size = new System.Drawing.Size(184, 50);
            this.históricosToolStripMenuItem.Text = "Históricos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem1
            // 
            this.ordemDeServiçoToolStripMenuItem1.Name = "ordemDeServiçoToolStripMenuItem1";
            this.ordemDeServiçoToolStripMenuItem1.Size = new System.Drawing.Size(232, 30);
            this.ordemDeServiçoToolStripMenuItem1.Text = "Ordem de Serviço";
            this.ordemDeServiçoToolStripMenuItem1.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem1_Click);
            // 
            // menuSair
            // 
            this.menuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuSair.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSair.ForeColor = System.Drawing.Color.DimGray;
            this.menuSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuSair.Name = "menuSair";
            this.menuSair.Padding = new System.Windows.Forms.Padding(75, 10, 10, 10);
            this.menuSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuSair.Size = new System.Drawing.Size(132, 50);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.sairToolStripMenuItem.Text = "Logout";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 50);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1452, 362);
            this.Controls.Add(this.barraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - 4! Plus ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.barraStatusPrincipal.ResumeLayout(false);
            this.barraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem veiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecanicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel labelIP;
        private System.Windows.Forms.ToolStripStatusLabel labelNomePc;
        private System.Windows.Forms.ToolStripStatusLabel labelData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel labelUsuario;
        private System.Windows.Forms.ToolStripMenuItem históricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}