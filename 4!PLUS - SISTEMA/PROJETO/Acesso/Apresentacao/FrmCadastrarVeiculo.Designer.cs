namespace Apresentacao
{
    partial class FrmCadastrarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarVeiculo));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxCor = new System.Windows.Forms.ComboBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oFICINADataSet = new Apresentacao.OFICINADataSet();
            this.cLIENTETableAdapter = new Apresentacao.OFICINADataSetTableAdapters.CLIENTETableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.BackgroundImage")));
            this.buttonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(356, 327);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(60, 57);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(441, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(60, 57);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(26, 47);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 18);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente/Condutor";
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.BackColor = System.Drawing.Color.Silver;
            this.textBoxIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdCliente.Enabled = false;
            this.textBoxIdCliente.Location = new System.Drawing.Point(29, 54);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(60, 20);
            this.textBoxIdCliente.TabIndex = 1;
            this.textBoxIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Placa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Marca";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ano";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "CITROËN ",
            "FIAT ",
            "FORD ",
            "GM-CHEVROLET ",
            "HONDA ",
            "HYUNDAI ",
            "JAC ",
            "KIA MOTORS ",
            "NISSAN ",
            "PEUGEOT ",
            "RENAULT ",
            "TOYOTA, ",
            "VW – VOLKSWAGEN ",
            "ACURA ",
            "AGRALE ",
            "ALFA ROMEO ",
            "AM GEN ",
            "ASIA MOTORS ",
            "ASTON MARTIN ",
            "AUDI ",
            "BMW ",
            "BRM ",
            "BUGGY ",
            "BUGRE ",
            "CARDILLAC ",
            "CBT JIPE ",
            "CHANA ",
            "CHANGAN ",
            "CHREY ",
            "CHRYSLER ",
            "CROSS LANDER ",
            "DAEWOO ",
            "DAIHATSU ",
            "DKW VEMAG ",
            "DODGE ",
            "EFFA ",
            "ENGESA ",
            "ENVEMO ",
            "FERRARI ",
            "FIBRAVAN ",
            "FOTON ",
            "FABER ",
            "GEELY ",
            "GREAT WALL ",
            "GURGEL ",
            "HAFEI ",
            "ISUZUL ",
            "JAGUAR ",
            "JEEP ",
            "JINBEI ",
            "JPX ",
            "LADA ",
            "LAMBORGHINI ",
            "LAND ROVER ",
            "LANDWIND ",
            "LENUS ",
            "LIFAN ",
            "LOBINI ",
            "LOTUS ",
            "MAHINDRA ",
            "MASERATI ",
            "MATRA ",
            "MAZDA ",
            "MERCEDES-BENZ ",
            "MERCURY ",
            "MG ",
            "MINI ",
            "MITSUBISHI ",
            "MIURA ",
            "PLYMOUTH ",
            "PONTIAC ",
            "PORSCHE ",
            "PUMA ",
            "RELY ",
            "ROLLS-ROYCE ",
            "ROVER ",
            "SAAB ",
            "SATURN ",
            "SEAT ",
            "SHINERAY ",
            "SMART ",
            "SSANGYONG ",
            "SUBARU ",
            "SUZUKI ",
            "TAC ",
            "TROLLER ",
            "VOLVO ",
            "WALE ",
            "WALK"});
            this.comboBoxMarca.Location = new System.Drawing.Point(196, 61);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(143, 21);
            this.comboBoxMarca.TabIndex = 5;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // comboBoxCor
            // 
            this.comboBoxCor.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCor.FormattingEnabled = true;
            this.comboBoxCor.Items.AddRange(new object[] {
            "AMARELO",
            "AZUL",
            "BRANCO",
            "CASTANHO-AVERMELHADO",
            "CINZA",
            "DOURADO",
            "ÍNDICO",
            "LARANJA",
            "MARROM",
            "PINK",
            "PRATA",
            "PRETO",
            "ROXO",
            "TURQUESA",
            "VERDE",
            "VERMELHO",
            "OUTROS"});
            this.comboBoxCor.Location = new System.Drawing.Point(149, 119);
            this.comboBoxCor.Name = "comboBoxCor";
            this.comboBoxCor.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCor.TabIndex = 11;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxCombustivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "ÁLCOOL",
            "DIESEL",
            "GAS",
            "GASOLINA"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(328, 118);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(161, 21);
            this.comboBoxCombustivel.TabIndex = 13;
            this.comboBoxCombustivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxCombustivel_SelectedIndexChanged);
            // 
            // textBoxAno
            // 
            this.textBoxAno.BackColor = System.Drawing.Color.LightGray;
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.Location = new System.Drawing.Point(29, 120);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(93, 20);
            this.textBoxAno.TabIndex = 9;
            this.textBoxAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAno_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cor";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(325, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Combustivel";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.Silver;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(29, 62);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(60, 20);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.BackColor = System.Drawing.Color.LightGray;
            this.textBoxModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxModelo.Location = new System.Drawing.Point(365, 62);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(124, 20);
            this.textBoxModelo.TabIndex = 7;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxCliente.DataSource = this.cLIENTEBindingSource;
            this.comboBoxCliente.DisplayMember = "NOME";
            this.comboBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(107, 54);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(232, 21);
            this.comboBoxCliente.TabIndex = 3;
            this.comboBoxCliente.ValueMember = "NOME";
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.oFICINADataSet;
            // 
            // oFICINADataSet
            // 
            this.oFICINADataSet.DataSetName = "OFICINADataSet";
            this.oFICINADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIdCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Condutor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxPlaca);
            this.groupBox2.Controls.Add(this.comboBoxCombustivel);
            this.groupBox2.Controls.Add(this.comboBoxCor);
            this.groupBox2.Controls.Add(this.textBoxAno);
            this.groupBox2.Controls.Add(this.comboBoxMarca);
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxModelo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Veículo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.BackColor = System.Drawing.Color.Silver;
            this.textBoxPlaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlaca.Location = new System.Drawing.Point(108, 62);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(68, 20);
            this.textBoxPlaca.TabIndex = 14;
            this.textBoxPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlaca_KeyPress_1);
            // 
            // FrmCadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Veículo";
            this.Load += new System.EventHandler(this.FrmCadastrarVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oFICINADataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxCor;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private OFICINADataSet oFICINADataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private OFICINADataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textBoxPlaca;
    }
}