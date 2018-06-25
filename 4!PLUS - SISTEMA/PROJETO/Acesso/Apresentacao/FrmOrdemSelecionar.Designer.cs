namespace Apresentacao
{
    partial class FrmOrdemSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdemSelecionar));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPesquisarOrdem = new System.Windows.Forms.TextBox();
            this.radioButtonId = new System.Windows.Forms.RadioButton();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonAdicionarOrdem = new System.Windows.Forms.Button();
            this.buttonEditarOrdem = new System.Windows.Forms.Button();
            this.buttonExcluirOrdem = new System.Windows.Forms.Button();
            this.buttonConsultarOrdem = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridPrincipal = new System.Windows.Forms.DataGridView();
            this.iDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACACLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCACLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEMECANICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDEFEITODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFICINADataSet9 = new Apresentacao.OFICINADataSet9();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oSTableAdapter = new Apresentacao.OFICINADataSet9TableAdapters.OSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet9)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesquisarOrdem
            // 
            this.textBoxPesquisarOrdem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisarOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisarOrdem.Location = new System.Drawing.Point(308, 31);
            this.textBoxPesquisarOrdem.Multiline = true;
            this.textBoxPesquisarOrdem.Name = "textBoxPesquisarOrdem";
            this.textBoxPesquisarOrdem.Size = new System.Drawing.Size(372, 26);
            this.textBoxPesquisarOrdem.TabIndex = 0;
            this.textBoxPesquisarOrdem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPesquisarOrdem_KeyPress);
            // 
            // radioButtonId
            // 
            this.radioButtonId.AutoSize = true;
            this.radioButtonId.Checked = true;
            this.radioButtonId.Location = new System.Drawing.Point(21, 25);
            this.radioButtonId.Name = "radioButtonId";
            this.radioButtonId.Size = new System.Drawing.Size(126, 17);
            this.radioButtonId.TabIndex = 1;
            this.radioButtonId.TabStop = true;
            this.radioButtonId.Text = "ID/Ordem de Serviço";
            this.radioButtonId.UseVisualStyleBackColor = true;
            this.radioButtonId.CheckedChanged += new System.EventHandler(this.radioButtonId_CheckedChanged);
            this.radioButtonId.Click += new System.EventHandler(this.radioButtonId_Click);
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Location = new System.Drawing.Point(153, 25);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(90, 17);
            this.radioButtonCliente.TabIndex = 2;
            this.radioButtonCliente.Text = "Nome/Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            this.radioButtonCliente.CheckedChanged += new System.EventHandler(this.radioButtonCliente_CheckedChanged);
            this.radioButtonCliente.Click += new System.EventHandler(this.radioButtonCliente_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPesquisar.BackgroundImage")));
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPesquisar.Location = new System.Drawing.Point(677, 31);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(35, 26);
            this.buttonPesquisar.TabIndex = 3;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAtualizar.BackgroundImage")));
            this.buttonAtualizar.Enabled = false;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizar.Location = new System.Drawing.Point(727, 31);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(35, 26);
            this.buttonAtualizar.TabIndex = 4;
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonAdicionarOrdem
            // 
            this.buttonAdicionarOrdem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdicionarOrdem.BackgroundImage")));
            this.buttonAdicionarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarOrdem.Location = new System.Drawing.Point(198, 411);
            this.buttonAdicionarOrdem.Name = "buttonAdicionarOrdem";
            this.buttonAdicionarOrdem.Size = new System.Drawing.Size(120, 29);
            this.buttonAdicionarOrdem.TabIndex = 6;
            this.buttonAdicionarOrdem.UseVisualStyleBackColor = true;
            this.buttonAdicionarOrdem.Click += new System.EventHandler(this.buttonAdicionarOrdem_Click);
            // 
            // buttonEditarOrdem
            // 
            this.buttonEditarOrdem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditarOrdem.BackgroundImage")));
            this.buttonEditarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditarOrdem.Location = new System.Drawing.Point(324, 411);
            this.buttonEditarOrdem.Name = "buttonEditarOrdem";
            this.buttonEditarOrdem.Size = new System.Drawing.Size(120, 29);
            this.buttonEditarOrdem.TabIndex = 7;
            this.buttonEditarOrdem.UseVisualStyleBackColor = true;
            this.buttonEditarOrdem.Click += new System.EventHandler(this.buttonEditarOrdem_Click);
            // 
            // buttonExcluirOrdem
            // 
            this.buttonExcluirOrdem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExcluirOrdem.BackgroundImage")));
            this.buttonExcluirOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExcluirOrdem.Location = new System.Drawing.Point(450, 411);
            this.buttonExcluirOrdem.Name = "buttonExcluirOrdem";
            this.buttonExcluirOrdem.Size = new System.Drawing.Size(120, 29);
            this.buttonExcluirOrdem.TabIndex = 8;
            this.buttonExcluirOrdem.UseVisualStyleBackColor = true;
            this.buttonExcluirOrdem.Click += new System.EventHandler(this.buttonExcluirOrdem_Click);
            // 
            // buttonConsultarOrdem
            // 
            this.buttonConsultarOrdem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConsultarOrdem.BackgroundImage")));
            this.buttonConsultarOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConsultarOrdem.Location = new System.Drawing.Point(22, 411);
            this.buttonConsultarOrdem.Name = "buttonConsultarOrdem";
            this.buttonConsultarOrdem.Size = new System.Drawing.Size(170, 29);
            this.buttonConsultarOrdem.TabIndex = 9;
            this.buttonConsultarOrdem.UseVisualStyleBackColor = true;
            this.buttonConsultarOrdem.Click += new System.EventHandler(this.buttonConsultarOrdem_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.Location = new System.Drawing.Point(642, 411);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridPrincipal
            // 
            this.dataGridPrincipal.AllowUserToAddRows = false;
            this.dataGridPrincipal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPrincipal.AutoGenerateColumns = false;
            this.dataGridPrincipal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOSDataGridViewTextBoxColumn,
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.cADASTRODataGridViewTextBoxColumn,
            this.sTATUSOSDataGridViewTextBoxColumn,
            this.nOMECLIENTEDataGridViewTextBoxColumn,
            this.cPFCLIENTEDataGridViewTextBoxColumn,
            this.pLACACLIENTEDataGridViewTextBoxColumn,
            this.mARCACLIENTEDataGridViewTextBoxColumn,
            this.mODELOCLIENTEDataGridViewTextBoxColumn,
            this.aNOCLIENTEDataGridViewTextBoxColumn,
            this.nOMEMECANICADataGridViewTextBoxColumn,
            this.nOMEDEFEITODataGridViewTextBoxColumn,
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn,
            this.vALORTOTALDataGridViewTextBoxColumn});
            this.dataGridPrincipal.DataSource = this.oSBindingSource;
            this.dataGridPrincipal.Location = new System.Drawing.Point(22, 86);
            this.dataGridPrincipal.MultiSelect = false;
            this.dataGridPrincipal.Name = "dataGridPrincipal";
            this.dataGridPrincipal.ReadOnly = true;
            this.dataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPrincipal.Size = new System.Drawing.Size(740, 300);
            this.dataGridPrincipal.TabIndex = 12;
            // 
            // iDOSDataGridViewTextBoxColumn
            // 
            this.iDOSDataGridViewTextBoxColumn.DataPropertyName = "ID_OS";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            this.iDOSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDOSDataGridViewTextBoxColumn.HeaderText = "ID/OS";
            this.iDOSDataGridViewTextBoxColumn.Name = "iDOSDataGridViewTextBoxColumn";
            this.iDOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDOSDataGridViewTextBoxColumn.Width = 60;
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iDCLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID/Cliente";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDCLIENTEDataGridViewTextBoxColumn.Width = 60;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dATADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dATADataGridViewTextBoxColumn.HeaderText = "Data Emissão";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dATADataGridViewTextBoxColumn.Width = 130;
            // 
            // cADASTRODataGridViewTextBoxColumn
            // 
            this.cADASTRODataGridViewTextBoxColumn.DataPropertyName = "CADASTRO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cADASTRODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cADASTRODataGridViewTextBoxColumn.HeaderText = "Cadastrado por";
            this.cADASTRODataGridViewTextBoxColumn.Name = "cADASTRODataGridViewTextBoxColumn";
            this.cADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            this.cADASTRODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cADASTRODataGridViewTextBoxColumn.Width = 175;
            // 
            // sTATUSOSDataGridViewTextBoxColumn
            // 
            this.sTATUSOSDataGridViewTextBoxColumn.DataPropertyName = "STATUS_OS";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sTATUSOSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.sTATUSOSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.sTATUSOSDataGridViewTextBoxColumn.Name = "sTATUSOSDataGridViewTextBoxColumn";
            this.sTATUSOSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSOSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sTATUSOSDataGridViewTextBoxColumn.Width = 150;
            // 
            // nOMECLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOME_CLIENTE";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nOMECLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nOMECLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nOMECLIENTEDataGridViewTextBoxColumn.Name = "nOMECLIENTEDataGridViewTextBoxColumn";
            this.nOMECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMECLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nOMECLIENTEDataGridViewTextBoxColumn.Width = 175;
            // 
            // cPFCLIENTEDataGridViewTextBoxColumn
            // 
            this.cPFCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CPF_CLIENTE";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cPFCLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.cPFCLIENTEDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFCLIENTEDataGridViewTextBoxColumn.Name = "cPFCLIENTEDataGridViewTextBoxColumn";
            this.cPFCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFCLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPFCLIENTEDataGridViewTextBoxColumn.Width = 80;
            // 
            // pLACACLIENTEDataGridViewTextBoxColumn
            // 
            this.pLACACLIENTEDataGridViewTextBoxColumn.DataPropertyName = "PLACA_CLIENTE";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pLACACLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.pLACACLIENTEDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.pLACACLIENTEDataGridViewTextBoxColumn.Name = "pLACACLIENTEDataGridViewTextBoxColumn";
            this.pLACACLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLACACLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mARCACLIENTEDataGridViewTextBoxColumn
            // 
            this.mARCACLIENTEDataGridViewTextBoxColumn.DataPropertyName = "MARCA_CLIENTE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mARCACLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.mARCACLIENTEDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.mARCACLIENTEDataGridViewTextBoxColumn.Name = "mARCACLIENTEDataGridViewTextBoxColumn";
            this.mARCACLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mARCACLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mODELOCLIENTEDataGridViewTextBoxColumn
            // 
            this.mODELOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "MODELO_CLIENTE";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mODELOCLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.mODELOCLIENTEDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.mODELOCLIENTEDataGridViewTextBoxColumn.Name = "mODELOCLIENTEDataGridViewTextBoxColumn";
            this.mODELOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mODELOCLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // aNOCLIENTEDataGridViewTextBoxColumn
            // 
            this.aNOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ANO_CLIENTE";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aNOCLIENTEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.aNOCLIENTEDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.aNOCLIENTEDataGridViewTextBoxColumn.Name = "aNOCLIENTEDataGridViewTextBoxColumn";
            this.aNOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNOCLIENTEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.aNOCLIENTEDataGridViewTextBoxColumn.Width = 80;
            // 
            // nOMEMECANICADataGridViewTextBoxColumn
            // 
            this.nOMEMECANICADataGridViewTextBoxColumn.DataPropertyName = "NOME_MECANICA";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nOMEMECANICADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.nOMEMECANICADataGridViewTextBoxColumn.HeaderText = "Mecânica";
            this.nOMEMECANICADataGridViewTextBoxColumn.Name = "nOMEMECANICADataGridViewTextBoxColumn";
            this.nOMEMECANICADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEMECANICADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nOMEMECANICADataGridViewTextBoxColumn.Width = 160;
            // 
            // nOMEDEFEITODataGridViewTextBoxColumn
            // 
            this.nOMEDEFEITODataGridViewTextBoxColumn.DataPropertyName = "NOME_DEFEITO";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nOMEDEFEITODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.nOMEDEFEITODataGridViewTextBoxColumn.HeaderText = "Defeito";
            this.nOMEDEFEITODataGridViewTextBoxColumn.Name = "nOMEDEFEITODataGridViewTextBoxColumn";
            this.nOMEDEFEITODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEDEFEITODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nOMEDEFEITODataGridViewTextBoxColumn.Width = 130;
            // 
            // dESCRIÇÃODEFEITODataGridViewTextBoxColumn
            // 
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.DataPropertyName = "DESCRIÇÃO_DEFEITO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.Name = "dESCRIÇÃODEFEITODataGridViewTextBoxColumn";
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dESCRIÇÃODEFEITODataGridViewTextBoxColumn.Width = 150;
            // 
            // vALORTOTALDataGridViewTextBoxColumn
            // 
            this.vALORTOTALDataGridViewTextBoxColumn.DataPropertyName = "VALOR_TOTAL";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vALORTOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.vALORTOTALDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.vALORTOTALDataGridViewTextBoxColumn.Name = "vALORTOTALDataGridViewTextBoxColumn";
            this.vALORTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORTOTALDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vALORTOTALDataGridViewTextBoxColumn.Width = 80;
            // 
            // oSBindingSource
            // 
            this.oSBindingSource.DataMember = "OS";
            this.oSBindingSource.DataSource = this.oFICINADataSet9;
            // 
            // oFICINADataSet9
            // 
            this.oFICINADataSet9.DataSetName = "OFICINADataSet9";
            this.oFICINADataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonCliente);
            this.groupBox1.Controls.Add(this.radioButtonId);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 58);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pesquisa";
            // 
            // oSTableAdapter
            // 
            this.oSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOrdemSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridPrincipal);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConsultarOrdem);
            this.Controls.Add(this.buttonExcluirOrdem);
            this.Controls.Add(this.buttonEditarOrdem);
            this.Controls.Add(this.buttonAdicionarOrdem);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisarOrdem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdemSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4! Plus - Ordem de Serviço";
            this.Load += new System.EventHandler(this.FrmOrdemSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet9)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisarOrdem;
        private System.Windows.Forms.RadioButton radioButtonId;
        private System.Windows.Forms.RadioButton radioButtonCliente;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonAdicionarOrdem;
        private System.Windows.Forms.Button buttonEditarOrdem;
        private System.Windows.Forms.Button buttonExcluirOrdem;
        private System.Windows.Forms.Button buttonConsultarOrdem;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridPrincipal;
        private OFICINADataSet9 oFICINADataSet9;
        private System.Windows.Forms.BindingSource oSBindingSource;
        private OFICINADataSet9TableAdapters.OSTableAdapter oSTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACACLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCACLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELOCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNOCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEMECANICADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDEFEITODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIÇÃODEFEITODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORTOTALDataGridViewTextBoxColumn;
    }
}