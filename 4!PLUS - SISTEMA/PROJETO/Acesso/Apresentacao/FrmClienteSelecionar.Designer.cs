namespace Apresentacao
{
    partial class FrmClienteSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteSelecionar));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridPrincipal = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColResidencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(206, 26);
            this.textBoxPesquisar.Multiline = true;
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(472, 26);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.TextChanged += new System.EventHandler(this.textBoxPesquisar_TextChanged);
            this.textBoxPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisar_KeyPress);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.BackgroundImage")));
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Location = new System.Drawing.Point(675, 26);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(35, 26);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click_1);
            // 
            // dataGridPrincipal
            // 
            this.dataGridPrincipal.AllowUserToAddRows = false;
            this.dataGridPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPrincipal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNome,
            this.ColCPF,
            this.ColCep,
            this.ColEndereco,
            this.ColNumero,
            this.ColComplemento,
            this.ColBairro,
            this.ColCidade,
            this.ColUf,
            this.ColResidencial,
            this.ColCelular,
            this.ColEmail});
            this.dataGridPrincipal.Location = new System.Drawing.Point(23, 76);
            this.dataGridPrincipal.MultiSelect = false;
            this.dataGridPrincipal.Name = "dataGridPrincipal";
            this.dataGridPrincipal.ReadOnly = true;
            this.dataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrincipal.Size = new System.Drawing.Size(740, 300);
            this.dataGridPrincipal.TabIndex = 4;
            this.dataGridPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPrincipal_CellContentClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.DataPropertyName = "ID_CLIENTE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Format = "#,##0";
            this.ColCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCodigo.Width = 60;
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "NOME";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNome.Width = 175;
            // 
            // ColCPF
            // 
            this.ColCPF.DataPropertyName = "CPF";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCPF.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCPF.HeaderText = "CPF";
            this.ColCPF.Name = "ColCPF";
            this.ColCPF.ReadOnly = true;
            this.ColCPF.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCPF.Width = 110;
            // 
            // ColCep
            // 
            this.ColCep.DataPropertyName = "CEP";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCep.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColCep.HeaderText = "Cep";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            this.ColCep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCep.Width = 110;
            // 
            // ColEndereco
            // 
            this.ColEndereco.DataPropertyName = "ENDEREÇO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEndereco.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColEndereco.HeaderText = "Endereço";
            this.ColEndereco.Name = "ColEndereco";
            this.ColEndereco.ReadOnly = true;
            this.ColEndereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEndereco.Width = 180;
            // 
            // ColNumero
            // 
            this.ColNumero.DataPropertyName = "NUMERO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNumero.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColNumero.HeaderText = "N°";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNumero.Width = 60;
            // 
            // ColComplemento
            // 
            this.ColComplemento.DataPropertyName = "COMPLEMENTO";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColComplemento.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColComplemento.HeaderText = "Complemento";
            this.ColComplemento.Name = "ColComplemento";
            this.ColComplemento.ReadOnly = true;
            this.ColComplemento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColComplemento.Width = 80;
            // 
            // ColBairro
            // 
            this.ColBairro.DataPropertyName = "BAIRRO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBairro.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColBairro.Width = 150;
            // 
            // ColCidade
            // 
            this.ColCidade.DataPropertyName = "CIDADE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCidade.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            this.ColCidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCidade.Width = 150;
            // 
            // ColUf
            // 
            this.ColUf.DataPropertyName = "UF";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUf.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColUf.HeaderText = "UF";
            this.ColUf.Name = "ColUf";
            this.ColUf.ReadOnly = true;
            this.ColUf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColUf.Width = 60;
            // 
            // ColResidencial
            // 
            this.ColResidencial.DataPropertyName = "TEL_RESIDENCIAL";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColResidencial.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColResidencial.HeaderText = "Tel Residencial";
            this.ColResidencial.Name = "ColResidencial";
            this.ColResidencial.ReadOnly = true;
            this.ColResidencial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColCelular
            // 
            this.ColCelular.DataPropertyName = "TEL_CELULAR";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCelular.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColCelular.HeaderText = "Tel Celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.ReadOnly = true;
            this.ColCelular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "EMAIL";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEmail.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColEmail.HeaderText = "E-Mail";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEmail.Width = 150;
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Checked = true;
            this.radioButtonId.Location = new System.Drawing.Point(24, 19);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(36, 17);
            this.radioButtonId.TabIndex = 0;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "ID";
            this.radioButtonId.UseVisualStyleBackColor = true;
            this.radioButtonId.CheckedChanged += new System.EventHandler(this.radioButtonId_CheckedChanged);
            this.radioButtonId.Click += new System.EventHandler(this.radioButtonId_Click);
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(83, 19);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 1;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            this.radioButtonNome.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            this.radioButtonNome.Click += new System.EventHandler(this.radioButtonNome_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(643, 406);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 29);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.BackgroundImage")));
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultar.Location = new System.Drawing.Point(149, 406);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(120, 29);
            this.buttonConsultar.TabIndex = 6;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.BackgroundImage")));
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Location = new System.Drawing.Point(401, 406);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 29);
            this.buttonExcluir.TabIndex = 8;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAlterar.BackgroundImage")));
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlterar.Location = new System.Drawing.Point(275, 406);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(120, 29);
            this.buttonAlterar.TabIndex = 7;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInserir.BackgroundImage")));
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInserir.Location = new System.Drawing.Point(23, 406);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 29);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.Enabled = false;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(728, 26);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 26);
            this.buttonAtualizar.TabIndex = 3;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonId);
            this.groupBox1.Controls.Add(this.radioButtonNome);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // FrmClienteSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridPrincipal);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClienteSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4! Plus - Cliente";
            this.Load += new System.EventHandler(this.FrmClienteSelecionar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridPrincipal;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColResidencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
    }
}