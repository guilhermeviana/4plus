namespace Apresentacao
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.uSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oFICINADataSet8 = new Apresentacao.OFICINADataSet8();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFICINADataSet7 = new Apresentacao.OFICINADataSet7();
            this.uSUARIOTableAdapter = new Apresentacao.OFICINADataSet7TableAdapters.USUARIOTableAdapter();
            this.uSUARIOTableAdapter1 = new Apresentacao.OFICINADataSet8TableAdapters.USUARIOTableAdapter();
            this.comboBoxNivelAcesso = new System.Windows.Forms.ComboBox();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSUARIOBindingSource1
            // 
            this.uSUARIOBindingSource1.DataMember = "USUARIO";
            this.uSUARIOBindingSource1.DataSource = this.oFICINADataSet8;
            // 
            // oFICINADataSet8
            // 
            this.oFICINADataSet8.DataSetName = "OFICINADataSet8";
            this.oFICINADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.oFICINADataSet7;
            // 
            // oFICINADataSet7
            // 
            this.oFICINADataSet7.DataSetName = "OFICINADataSet7";
            this.oFICINADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // uSUARIOTableAdapter1
            // 
            this.uSUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBoxNivelAcesso
            // 
            this.comboBoxNivelAcesso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivelAcesso.FormattingEnabled = true;
            this.comboBoxNivelAcesso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "OPERADOR"});
            this.comboBoxNivelAcesso.Location = new System.Drawing.Point(194, 31);
            this.comboBoxNivelAcesso.Name = "comboBoxNivelAcesso";
            this.comboBoxNivelAcesso.Size = new System.Drawing.Size(197, 21);
            this.comboBoxNivelAcesso.TabIndex = 0;
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUsuario.DataSource = this.uSUARIOBindingSource1;
            this.comboBoxUsuario.DisplayMember = "USUARIO";
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(194, 81);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(197, 21);
            this.comboBoxUsuario.TabIndex = 1;
            this.comboBoxUsuario.ValueMember = "USUARIO";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(194, 133);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '●';
            this.textBoxSenha.Size = new System.Drawing.Size(197, 20);
            this.textBoxSenha.TabIndex = 2;
            // 
            // buttonConectar
            // 
            this.buttonConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConectar.BackgroundImage")));
            this.buttonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConectar.Location = new System.Drawing.Point(105, 233);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(130, 37);
            this.buttonConectar.TabIndex = 3;
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackgroundImage = global::Apresentacao.Properties.Resources.SA;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Location = new System.Drawing.Point(261, 233);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(130, 37);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Controls.Add(this.buttonConectar);
            this.groupBox1.Controls.Add(this.textBoxSenha);
            this.groupBox1.Controls.Add(this.comboBoxUsuario);
            this.groupBox1.Controls.Add(this.comboBoxNivelAcesso);
            this.groupBox1.Location = new System.Drawing.Point(241, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(937, 719);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OFICINADataSet7 oFICINADataSet7;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private OFICINADataSet7TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private OFICINADataSet8 oFICINADataSet8;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource1;
        private OFICINADataSet8TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxNivelAcesso;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}