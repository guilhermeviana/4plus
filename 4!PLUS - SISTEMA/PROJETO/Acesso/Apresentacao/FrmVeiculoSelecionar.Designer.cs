namespace Apresentacao
{
    partial class FrmVeiculoSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculoSelecionar));
            this.dataGridVeiculo = new System.Windows.Forms.DataGridView();
            this.ColCodVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCombustivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonVeiculoAdicionar = new System.Windows.Forms.Button();
            this.buttonVeiculoEditar = new System.Windows.Forms.Button();
            this.buttonVeiculoExcluir = new System.Windows.Forms.Button();
            this.buttonVeiculoConsultar = new System.Windows.Forms.Button();
            this.buttonVeiculoCancelar = new System.Windows.Forms.Button();
            this.radioButtonIdVeiculo = new System.Windows.Forms.RadioButton();
            this.radioButtonPlacaVeiculo = new System.Windows.Forms.RadioButton();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridVeiculo
            // 
            this.dataGridVeiculo.AllowUserToAddRows = false;
            this.dataGridVeiculo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridVeiculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVeiculo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodVeiculo,
            this.ColCodCliente,
            this.ColNomeCliente,
            this.ColPlaca,
            this.ColMarca,
            this.ColAno,
            this.ColCor,
            this.CodModelo,
            this.ColCombustivel});
            this.dataGridVeiculo.Location = new System.Drawing.Point(22, 73);
            this.dataGridVeiculo.MultiSelect = false;
            this.dataGridVeiculo.Name = "dataGridVeiculo";
            this.dataGridVeiculo.ReadOnly = true;
            this.dataGridVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVeiculo.Size = new System.Drawing.Size(740, 300);
            this.dataGridVeiculo.TabIndex = 4;
            // 
            // ColCodVeiculo
            // 
            this.ColCodVeiculo.DataPropertyName = "ID_VEICULO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            this.ColCodVeiculo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColCodVeiculo.HeaderText = "ID Veiculo";
            this.ColCodVeiculo.Name = "ColCodVeiculo";
            this.ColCodVeiculo.ReadOnly = true;
            this.ColCodVeiculo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCodVeiculo.Width = 65;
            // 
            // ColCodCliente
            // 
            this.ColCodCliente.DataPropertyName = "ID_CLIENTE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.ColCodCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCodCliente.HeaderText = "ID Cliente";
            this.ColCodCliente.Name = "ColCodCliente";
            this.ColCodCliente.ReadOnly = true;
            this.ColCodCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColNomeCliente
            // 
            this.ColNomeCliente.DataPropertyName = "NOME_CLIENTE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNomeCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColNomeCliente.HeaderText = "Cliente";
            this.ColNomeCliente.Name = "ColNomeCliente";
            this.ColNomeCliente.ReadOnly = true;
            this.ColNomeCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNomeCliente.Width = 200;
            // 
            // ColPlaca
            // 
            this.ColPlaca.DataPropertyName = "PLACA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColPlaca.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColPlaca.HeaderText = "Placa";
            this.ColPlaca.Name = "ColPlaca";
            this.ColPlaca.ReadOnly = true;
            this.ColPlaca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColMarca
            // 
            this.ColMarca.DataPropertyName = "MARCA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColMarca.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            this.ColMarca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColAno
            // 
            this.ColAno.DataPropertyName = "ANO";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColAno.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColAno.HeaderText = "Ano";
            this.ColAno.Name = "ColAno";
            this.ColAno.ReadOnly = true;
            this.ColAno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColCor
            // 
            this.ColCor.DataPropertyName = "COR";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCor.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColCor.HeaderText = "Cor";
            this.ColCor.Name = "ColCor";
            this.ColCor.ReadOnly = true;
            this.ColCor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CodModelo
            // 
            this.CodModelo.DataPropertyName = "MODELO";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodModelo.DefaultCellStyle = dataGridViewCellStyle9;
            this.CodModelo.HeaderText = "Modelo";
            this.CodModelo.Name = "CodModelo";
            this.CodModelo.ReadOnly = true;
            this.CodModelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColCombustivel
            // 
            this.ColCombustivel.DataPropertyName = "COMBUSTIVEL";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCombustivel.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColCombustivel.HeaderText = "Combustivel";
            this.ColCombustivel.Name = "ColCombustivel";
            this.ColCombustivel.ReadOnly = true;
            this.ColCombustivel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisar.Location = new System.Drawing.Point(210, 27);
            this.textBoxPesquisar.Multiline = true;
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(468, 26);
            this.textBoxPesquisar.TabIndex = 1;
            this.textBoxPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisar_KeyPress);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.BackgroundImage")));
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Location = new System.Drawing.Point(673, 27);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(35, 26);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonVeiculoAdicionar
            // 
            this.buttonVeiculoAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVeiculoAdicionar.BackgroundImage")));
            this.buttonVeiculoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVeiculoAdicionar.Location = new System.Drawing.Point(22, 406);
            this.buttonVeiculoAdicionar.Name = "buttonVeiculoAdicionar";
            this.buttonVeiculoAdicionar.Size = new System.Drawing.Size(120, 29);
            this.buttonVeiculoAdicionar.TabIndex = 5;
            this.buttonVeiculoAdicionar.UseVisualStyleBackColor = true;
            this.buttonVeiculoAdicionar.Click += new System.EventHandler(this.buttonVeiculoAdicionar_Click);
            // 
            // buttonVeiculoEditar
            // 
            this.buttonVeiculoEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVeiculoEditar.BackgroundImage")));
            this.buttonVeiculoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVeiculoEditar.Location = new System.Drawing.Point(148, 406);
            this.buttonVeiculoEditar.Name = "buttonVeiculoEditar";
            this.buttonVeiculoEditar.Size = new System.Drawing.Size(120, 29);
            this.buttonVeiculoEditar.TabIndex = 6;
            this.buttonVeiculoEditar.UseVisualStyleBackColor = true;
            this.buttonVeiculoEditar.Click += new System.EventHandler(this.buttonVeiculoEditar_Click);
            // 
            // buttonVeiculoExcluir
            // 
            this.buttonVeiculoExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVeiculoExcluir.BackgroundImage")));
            this.buttonVeiculoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVeiculoExcluir.Location = new System.Drawing.Point(400, 406);
            this.buttonVeiculoExcluir.Name = "buttonVeiculoExcluir";
            this.buttonVeiculoExcluir.Size = new System.Drawing.Size(120, 29);
            this.buttonVeiculoExcluir.TabIndex = 8;
            this.buttonVeiculoExcluir.UseVisualStyleBackColor = true;
            this.buttonVeiculoExcluir.Click += new System.EventHandler(this.buttonVeiculoExcluir_Click);
            // 
            // buttonVeiculoConsultar
            // 
            this.buttonVeiculoConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVeiculoConsultar.BackgroundImage")));
            this.buttonVeiculoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVeiculoConsultar.Location = new System.Drawing.Point(274, 406);
            this.buttonVeiculoConsultar.Name = "buttonVeiculoConsultar";
            this.buttonVeiculoConsultar.Size = new System.Drawing.Size(120, 29);
            this.buttonVeiculoConsultar.TabIndex = 7;
            this.buttonVeiculoConsultar.UseVisualStyleBackColor = true;
            this.buttonVeiculoConsultar.Click += new System.EventHandler(this.buttonVeiculoConsultar_Click);
            // 
            // buttonVeiculoCancelar
            // 
            this.buttonVeiculoCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVeiculoCancelar.BackgroundImage")));
            this.buttonVeiculoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVeiculoCancelar.Location = new System.Drawing.Point(642, 406);
            this.buttonVeiculoCancelar.Name = "buttonVeiculoCancelar";
            this.buttonVeiculoCancelar.Size = new System.Drawing.Size(120, 29);
            this.buttonVeiculoCancelar.TabIndex = 9;
            this.buttonVeiculoCancelar.UseVisualStyleBackColor = true;
            this.buttonVeiculoCancelar.Click += new System.EventHandler(this.buttonVeiculoCancelar_Click);
            // 
            // radioButtonIdVeiculo
            // 
            this.radioButtonIdVeiculo.AutoSize = true;
            this.radioButtonIdVeiculo.Checked = true;
            this.radioButtonIdVeiculo.Location = new System.Drawing.Point(21, 19);
            this.radioButtonIdVeiculo.Name = "radioButtonIdVeiculo";
            this.radioButtonIdVeiculo.Size = new System.Drawing.Size(36, 17);
            this.radioButtonIdVeiculo.TabIndex = 0;
            this.radioButtonIdVeiculo.TabStop = true;
            this.radioButtonIdVeiculo.Text = "ID";
            this.radioButtonIdVeiculo.UseVisualStyleBackColor = true;
            this.radioButtonIdVeiculo.CheckedChanged += new System.EventHandler(this.radioButtonIdVeiculo_CheckedChanged);
            this.radioButtonIdVeiculo.Click += new System.EventHandler(this.radioButtonIdVeiculo_Click);
            // 
            // radioButtonPlacaVeiculo
            // 
            this.radioButtonPlacaVeiculo.AutoSize = true;
            this.radioButtonPlacaVeiculo.Location = new System.Drawing.Point(80, 20);
            this.radioButtonPlacaVeiculo.Name = "radioButtonPlacaVeiculo";
            this.radioButtonPlacaVeiculo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPlacaVeiculo.TabIndex = 1;
            this.radioButtonPlacaVeiculo.Text = "Placa";
            this.radioButtonPlacaVeiculo.UseVisualStyleBackColor = true;
            this.radioButtonPlacaVeiculo.CheckedChanged += new System.EventHandler(this.radioButtonPlacaVeiculo_CheckedChanged);
            this.radioButtonPlacaVeiculo.Click += new System.EventHandler(this.radioButtonPlacaVeiculo_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.Enabled = false;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(727, 27);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 26);
            this.buttonAtualizar.TabIndex = 3;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonPlacaVeiculo);
            this.groupBox1.Controls.Add(this.radioButtonIdVeiculo);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // FrmVeiculoSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonVeiculoCancelar);
            this.Controls.Add(this.buttonVeiculoConsultar);
            this.Controls.Add(this.buttonVeiculoExcluir);
            this.Controls.Add(this.buttonVeiculoEditar);
            this.Controls.Add(this.buttonVeiculoAdicionar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.dataGridVeiculo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVeiculoSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4! Plus - Veículos";
            this.Load += new System.EventHandler(this.FrmVeiculoSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVeiculo;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonVeiculoAdicionar;
        private System.Windows.Forms.Button buttonVeiculoEditar;
        private System.Windows.Forms.Button buttonVeiculoExcluir;
        private System.Windows.Forms.Button buttonVeiculoConsultar;
        private System.Windows.Forms.Button buttonVeiculoCancelar;
        private System.Windows.Forms.RadioButton radioButtonIdVeiculo;
        private System.Windows.Forms.RadioButton radioButtonPlacaVeiculo;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCombustivel;
    }
}

