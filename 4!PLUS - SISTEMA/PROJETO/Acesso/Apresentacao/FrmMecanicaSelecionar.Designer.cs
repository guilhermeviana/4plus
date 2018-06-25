namespace Apresentacao
{
    partial class FrmMecanicaSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMecanicaSelecionar));
            this.dataGridMecanica = new System.Windows.Forms.DataGridView();
            this.ColCodMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCnpjMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCepMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEnderecoMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComplementoMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairroMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidadeMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUfMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelComercialMecanica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPesquisarMecanica = new System.Windows.Forms.Button();
            this.buttonEditarMecanica = new System.Windows.Forms.Button();
            this.buttonConsultarMecanica = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluirMecanica = new System.Windows.Forms.Button();
            this.buttonAdicionarMecanica = new System.Windows.Forms.Button();
            this.textBoxPesquisarMecanica = new System.Windows.Forms.TextBox();
            this.radioButtonIdMecanica = new System.Windows.Forms.RadioButton();
            this.radioButtonNomeMecanica = new System.Windows.Forms.RadioButton();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecanica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMecanica
            // 
            this.dataGridMecanica.AllowUserToAddRows = false;
            this.dataGridMecanica.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridMecanica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMecanica.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridMecanica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMecanica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodMecanica,
            this.ColNomeMecanica,
            this.ColCnpjMecanica,
            this.ColCepMecanica,
            this.ColEnderecoMecanica,
            this.ColNumMecanica,
            this.ColComplementoMecanica,
            this.ColBairroMecanica,
            this.ColCidadeMecanica,
            this.ColUfMecanica,
            this.ColTelComercialMecanica});
            this.dataGridMecanica.Location = new System.Drawing.Point(23, 76);
            this.dataGridMecanica.MultiSelect = false;
            this.dataGridMecanica.Name = "dataGridMecanica";
            this.dataGridMecanica.ReadOnly = true;
            this.dataGridMecanica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMecanica.Size = new System.Drawing.Size(740, 300);
            this.dataGridMecanica.TabIndex = 0;
            // 
            // ColCodMecanica
            // 
            this.ColCodMecanica.DataPropertyName = "ID_MECANICA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            this.ColCodMecanica.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColCodMecanica.HeaderText = "ID";
            this.ColCodMecanica.Name = "ColCodMecanica";
            this.ColCodMecanica.ReadOnly = true;
            this.ColCodMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCodMecanica.Width = 60;
            // 
            // ColNomeMecanica
            // 
            this.ColNomeMecanica.DataPropertyName = "NOME_MECANICA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNomeMecanica.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColNomeMecanica.HeaderText = "Razão Social";
            this.ColNomeMecanica.Name = "ColNomeMecanica";
            this.ColNomeMecanica.ReadOnly = true;
            this.ColNomeMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNomeMecanica.Width = 170;
            // 
            // ColCnpjMecanica
            // 
            this.ColCnpjMecanica.DataPropertyName = "CNPJ";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCnpjMecanica.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCnpjMecanica.HeaderText = "CNPJ";
            this.ColCnpjMecanica.Name = "ColCnpjMecanica";
            this.ColCnpjMecanica.ReadOnly = true;
            this.ColCnpjMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCnpjMecanica.Width = 150;
            // 
            // ColCepMecanica
            // 
            this.ColCepMecanica.DataPropertyName = "CEP";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.ColCepMecanica.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCepMecanica.HeaderText = "CEP";
            this.ColCepMecanica.Name = "ColCepMecanica";
            this.ColCepMecanica.ReadOnly = true;
            this.ColCepMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCepMecanica.Width = 110;
            // 
            // ColEnderecoMecanica
            // 
            this.ColEnderecoMecanica.DataPropertyName = "ENDEREÇO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEnderecoMecanica.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColEnderecoMecanica.HeaderText = "Endereço";
            this.ColEnderecoMecanica.Name = "ColEnderecoMecanica";
            this.ColEnderecoMecanica.ReadOnly = true;
            this.ColEnderecoMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEnderecoMecanica.Width = 170;
            // 
            // ColNumMecanica
            // 
            this.ColNumMecanica.DataPropertyName = "NUMERO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNumMecanica.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColNumMecanica.HeaderText = "N°";
            this.ColNumMecanica.Name = "ColNumMecanica";
            this.ColNumMecanica.ReadOnly = true;
            this.ColNumMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNumMecanica.Width = 60;
            // 
            // ColComplementoMecanica
            // 
            this.ColComplementoMecanica.DataPropertyName = "COMPLEMENTO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColComplementoMecanica.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColComplementoMecanica.HeaderText = "Complemento";
            this.ColComplementoMecanica.Name = "ColComplementoMecanica";
            this.ColComplementoMecanica.ReadOnly = true;
            this.ColComplementoMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColComplementoMecanica.Width = 80;
            // 
            // ColBairroMecanica
            // 
            this.ColBairroMecanica.DataPropertyName = "BAIRRO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBairroMecanica.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColBairroMecanica.HeaderText = "Bairro";
            this.ColBairroMecanica.Name = "ColBairroMecanica";
            this.ColBairroMecanica.ReadOnly = true;
            this.ColBairroMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBairroMecanica.Width = 120;
            // 
            // ColCidadeMecanica
            // 
            this.ColCidadeMecanica.DataPropertyName = "CIDADE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCidadeMecanica.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColCidadeMecanica.HeaderText = "Cidade";
            this.ColCidadeMecanica.Name = "ColCidadeMecanica";
            this.ColCidadeMecanica.ReadOnly = true;
            this.ColCidadeMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCidadeMecanica.Width = 120;
            // 
            // ColUfMecanica
            // 
            this.ColUfMecanica.DataPropertyName = "UF";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUfMecanica.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColUfMecanica.HeaderText = "UF";
            this.ColUfMecanica.Name = "ColUfMecanica";
            this.ColUfMecanica.ReadOnly = true;
            this.ColUfMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColUfMecanica.Width = 60;
            // 
            // ColTelComercialMecanica
            // 
            this.ColTelComercialMecanica.DataPropertyName = "TEL_COMERCIAL";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTelComercialMecanica.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColTelComercialMecanica.HeaderText = "Tel Comercial";
            this.ColTelComercialMecanica.Name = "ColTelComercialMecanica";
            this.ColTelComercialMecanica.ReadOnly = true;
            this.ColTelComercialMecanica.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTelComercialMecanica.Width = 80;
            // 
            // buttonPesquisarMecanica
            // 
            this.buttonPesquisarMecanica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisarMecanica.BackgroundImage")));
            this.buttonPesquisarMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisarMecanica.Location = new System.Drawing.Point(677, 27);
            this.buttonPesquisarMecanica.Name = "buttonPesquisarMecanica";
            this.buttonPesquisarMecanica.Size = new System.Drawing.Size(35, 26);
            this.buttonPesquisarMecanica.TabIndex = 2;
            this.buttonPesquisarMecanica.UseVisualStyleBackColor = true;
            this.buttonPesquisarMecanica.Click += new System.EventHandler(this.buttonPesquisarMecanica_Click);
            // 
            // buttonEditarMecanica
            // 
            this.buttonEditarMecanica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarMecanica.BackgroundImage")));
            this.buttonEditarMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditarMecanica.Location = new System.Drawing.Point(275, 407);
            this.buttonEditarMecanica.Name = "buttonEditarMecanica";
            this.buttonEditarMecanica.Size = new System.Drawing.Size(120, 29);
            this.buttonEditarMecanica.TabIndex = 7;
            this.buttonEditarMecanica.UseVisualStyleBackColor = true;
            this.buttonEditarMecanica.Click += new System.EventHandler(this.buttonEditarMecanica_Click);
            // 
            // buttonConsultarMecanica
            // 
            this.buttonConsultarMecanica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConsultarMecanica.BackgroundImage")));
            this.buttonConsultarMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultarMecanica.Location = new System.Drawing.Point(149, 407);
            this.buttonConsultarMecanica.Name = "buttonConsultarMecanica";
            this.buttonConsultarMecanica.Size = new System.Drawing.Size(120, 29);
            this.buttonConsultarMecanica.TabIndex = 6;
            this.buttonConsultarMecanica.UseVisualStyleBackColor = true;
            this.buttonConsultarMecanica.Click += new System.EventHandler(this.buttonConsultarMecanica_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(643, 407);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluirMecanica
            // 
            this.buttonExcluirMecanica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluirMecanica.BackgroundImage")));
            this.buttonExcluirMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluirMecanica.Location = new System.Drawing.Point(401, 407);
            this.buttonExcluirMecanica.Name = "buttonExcluirMecanica";
            this.buttonExcluirMecanica.Size = new System.Drawing.Size(120, 29);
            this.buttonExcluirMecanica.TabIndex = 8;
            this.buttonExcluirMecanica.UseVisualStyleBackColor = true;
            this.buttonExcluirMecanica.Click += new System.EventHandler(this.buttonExcluirMecanica_Click);
            // 
            // buttonAdicionarMecanica
            // 
            this.buttonAdicionarMecanica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarMecanica.BackgroundImage")));
            this.buttonAdicionarMecanica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarMecanica.Location = new System.Drawing.Point(23, 407);
            this.buttonAdicionarMecanica.Name = "buttonAdicionarMecanica";
            this.buttonAdicionarMecanica.Size = new System.Drawing.Size(120, 29);
            this.buttonAdicionarMecanica.TabIndex = 5;
            this.buttonAdicionarMecanica.UseVisualStyleBackColor = true;
            this.buttonAdicionarMecanica.Click += new System.EventHandler(this.buttonAdicionarMecanica_Click);
            // 
            // textBoxPesquisarMecanica
            // 
            this.textBoxPesquisarMecanica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisarMecanica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisarMecanica.Location = new System.Drawing.Point(208, 27);
            this.textBoxPesquisarMecanica.Multiline = true;
            this.textBoxPesquisarMecanica.Name = "textBoxPesquisarMecanica";
            this.textBoxPesquisarMecanica.Size = new System.Drawing.Size(472, 26);
            this.textBoxPesquisarMecanica.TabIndex = 1;
            this.textBoxPesquisarMecanica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisarMecanica_KeyPress);
            // 
            // radioButtonIdMecanica
            // 
            this.radioButtonIdMecanica.AutoSize = true;
            this.radioButtonIdMecanica.Checked = true;
            this.radioButtonIdMecanica.Location = new System.Drawing.Point(24, 19);
            this.radioButtonIdMecanica.Name = "radioButtonIdMecanica";
            this.radioButtonIdMecanica.Size = new System.Drawing.Size(36, 17);
            this.radioButtonIdMecanica.TabIndex = 0;
            this.radioButtonIdMecanica.TabStop = true;
            this.radioButtonIdMecanica.Text = "ID";
            this.radioButtonIdMecanica.UseVisualStyleBackColor = true;
            this.radioButtonIdMecanica.CheckedChanged += new System.EventHandler(this.radioButtonIdMecanica_CheckedChanged);
            this.radioButtonIdMecanica.Click += new System.EventHandler(this.radioButtonIdMecanica_Click);
            // 
            // radioButtonNomeMecanica
            // 
            this.radioButtonNomeMecanica.AutoSize = true;
            this.radioButtonNomeMecanica.Location = new System.Drawing.Point(84, 19);
            this.radioButtonNomeMecanica.Name = "radioButtonNomeMecanica";
            this.radioButtonNomeMecanica.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNomeMecanica.TabIndex = 1;
            this.radioButtonNomeMecanica.Text = "Nome";
            this.radioButtonNomeMecanica.UseVisualStyleBackColor = true;
            this.radioButtonNomeMecanica.CheckedChanged += new System.EventHandler(this.radioButtonNomeMecanica_CheckedChanged);
            this.radioButtonNomeMecanica.Click += new System.EventHandler(this.radioButtonNomeMecanica_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.Enabled = false;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(728, 27);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 26);
            this.buttonAtualizar.TabIndex = 3;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonNomeMecanica);
            this.groupBox1.Controls.Add(this.radioButtonIdMecanica);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // FrmMecanicaSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.textBoxPesquisarMecanica);
            this.Controls.Add(this.buttonAdicionarMecanica);
            this.Controls.Add(this.buttonExcluirMecanica);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConsultarMecanica);
            this.Controls.Add(this.buttonEditarMecanica);
            this.Controls.Add(this.buttonPesquisarMecanica);
            this.Controls.Add(this.dataGridMecanica);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMecanicaSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4! Plus - Mecânica";
            this.Load += new System.EventHandler(this.FrmMecanicaSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMecanica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMecanica;
        private System.Windows.Forms.Button buttonPesquisarMecanica;
        private System.Windows.Forms.Button buttonEditarMecanica;
        private System.Windows.Forms.Button buttonConsultarMecanica;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluirMecanica;
        private System.Windows.Forms.Button buttonAdicionarMecanica;
        private System.Windows.Forms.TextBox textBoxPesquisarMecanica;
        private System.Windows.Forms.RadioButton radioButtonIdMecanica;
        private System.Windows.Forms.RadioButton radioButtonNomeMecanica;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCnpjMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCepMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEnderecoMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComplementoMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairroMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidadeMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUfMecanica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelComercialMecanica;
    }
}