namespace Apresentacao
{
    partial class FrmUsuarioSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioSelecionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.radioButtonPesquisarId = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisarUsuario = new System.Windows.Forms.RadioButton();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNivelAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oFICINADataSet6 = new Apresentacao.OFICINADataSet6();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Apresentacao.OFICINADataSet6TableAdapters.USUARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(208, 26);
            this.textBoxPesquisar.Multiline = true;
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(468, 26);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisar_KeyPress);
            // 
            // radioButtonPesquisarId
            // 
            this.radioButtonPesquisarId.AutoSize = true;
            this.radioButtonPesquisarId.Checked = true;
            this.radioButtonPesquisarId.Location = new System.Drawing.Point(20, 19);
            this.radioButtonPesquisarId.Name = "radioButtonPesquisarId";
            this.radioButtonPesquisarId.Size = new System.Drawing.Size(36, 17);
            this.radioButtonPesquisarId.TabIndex = 0;
            this.radioButtonPesquisarId.TabStop = true;
            this.radioButtonPesquisarId.Text = "ID";
            this.radioButtonPesquisarId.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarId.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarId_CheckedChanged);
            this.radioButtonPesquisarId.Click += new System.EventHandler(this.radioButtonPesquisarId_Click);
            // 
            // radioButtonPesquisarUsuario
            // 
            this.radioButtonPesquisarUsuario.AutoSize = true;
            this.radioButtonPesquisarUsuario.Location = new System.Drawing.Point(75, 19);
            this.radioButtonPesquisarUsuario.Name = "radioButtonPesquisarUsuario";
            this.radioButtonPesquisarUsuario.Size = new System.Drawing.Size(61, 17);
            this.radioButtonPesquisarUsuario.TabIndex = 1;
            this.radioButtonPesquisarUsuario.Text = "Usuário";
            this.radioButtonPesquisarUsuario.UseVisualStyleBackColor = true;
            this.radioButtonPesquisarUsuario.CheckedChanged += new System.EventHandler(this.radioButtonPesquisarUsuario_CheckedChanged);
            this.radioButtonPesquisarUsuario.Click += new System.EventHandler(this.radioButtonPesquisarUsuario_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.BackgroundImage")));
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Location = new System.Drawing.Point(673, 26);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(35, 26);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(730, 26);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 26);
            this.buttonAtualizar.TabIndex = 3;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdicionar.BackgroundImage")));
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionar.Location = new System.Drawing.Point(25, 406);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(120, 29);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditar.Location = new System.Drawing.Point(151, 406);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(120, 29);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluir.BackgroundImage")));
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluir.Location = new System.Drawing.Point(277, 406);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 29);
            this.buttonExcluir.TabIndex = 7;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(645, 406);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 29);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.AllowUserToAddRows = false;
            this.dataGridUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuario.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColUsuario,
            this.ColNivelAcesso,
            this.ColSenha});
            this.dataGridUsuario.Location = new System.Drawing.Point(25, 74);
            this.dataGridUsuario.MultiSelect = false;
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.ReadOnly = true;
            this.dataGridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuario.Size = new System.Drawing.Size(740, 300);
            this.dataGridUsuario.TabIndex = 4;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "ID_USUARIO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            this.ColId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColUsuario
            // 
            this.ColUsuario.DataPropertyName = "USUARIO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColUsuario.HeaderText = "Usuário";
            this.ColUsuario.Name = "ColUsuario";
            this.ColUsuario.ReadOnly = true;
            this.ColUsuario.Width = 200;
            // 
            // ColNivelAcesso
            // 
            this.ColNivelAcesso.DataPropertyName = "NIVEL_ACESSO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNivelAcesso.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColNivelAcesso.HeaderText = "Nivel de Acesso";
            this.ColNivelAcesso.Name = "ColNivelAcesso";
            this.ColNivelAcesso.ReadOnly = true;
            this.ColNivelAcesso.Width = 200;
            // 
            // ColSenha
            // 
            this.ColSenha.DataPropertyName = "SENHA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSenha.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColSenha.HeaderText = "Senha";
            this.ColSenha.Name = "ColSenha";
            this.ColSenha.ReadOnly = true;
            this.ColSenha.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonPesquisarUsuario);
            this.groupBox1.Controls.Add(this.radioButtonPesquisarId);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // oFICINADataSet6
            // 
            this.oFICINADataSet6.DataSetName = "OFICINADataSet6";
            this.oFICINADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.oFICINADataSet6;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUsuarioSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridUsuario);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioSelecionar";
            this.Text = "4! Plus - Usuário";
            this.Load += new System.EventHandler(this.FrmUsuarioSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.RadioButton radioButtonPesquisarId;
        private System.Windows.Forms.RadioButton radioButtonPesquisarUsuario;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridUsuario;
        private OFICINADataSet6 oFICINADataSet6;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private OFICINADataSet6TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNivelAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSenha;
    }
}