namespace Apresentacao
{
    partial class FrmCadastrarDefeito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarDefeito));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNomeDefeito = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoDefeito = new System.Windows.Forms.TextBox();
            this.textBoxValorDefeito = new System.Windows.Forms.TextBox();
            this.labelNomeDefeito = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalvar.BackgroundImage")));
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(210, 293);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(62, 57);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.BackgroundImage")));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(294, 293);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(62, 57);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNomeDefeito
            // 
            this.textBoxNomeDefeito.BackColor = System.Drawing.Color.LightGray;
            this.textBoxNomeDefeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeDefeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeDefeito.Location = new System.Drawing.Point(119, 46);
            this.textBoxNomeDefeito.Name = "textBoxNomeDefeito";
            this.textBoxNomeDefeito.Size = new System.Drawing.Size(256, 20);
            this.textBoxNomeDefeito.TabIndex = 3;
            this.textBoxNomeDefeito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomeDefeito_KeyPress);
            // 
            // textBoxDescricaoDefeito
            // 
            this.textBoxDescricaoDefeito.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDescricaoDefeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricaoDefeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDescricaoDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricaoDefeito.Location = new System.Drawing.Point(17, 33);
            this.textBoxDescricaoDefeito.Multiline = true;
            this.textBoxDescricaoDefeito.Name = "textBoxDescricaoDefeito";
            this.textBoxDescricaoDefeito.Size = new System.Drawing.Size(302, 134);
            this.textBoxDescricaoDefeito.TabIndex = 0;
            // 
            // textBoxValorDefeito
            // 
            this.textBoxValorDefeito.BackColor = System.Drawing.Color.LightGray;
            this.textBoxValorDefeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxValorDefeito.Location = new System.Drawing.Point(37, 293);
            this.textBoxValorDefeito.Name = "textBoxValorDefeito";
            this.textBoxValorDefeito.Size = new System.Drawing.Size(125, 20);
            this.textBoxValorDefeito.TabIndex = 6;
            this.textBoxValorDefeito.TextChanged += new System.EventHandler(this.textBoxValorDefeito_TextChanged);
            this.textBoxValorDefeito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorDefeito_KeyPress);
            // 
            // labelNomeDefeito
            // 
            this.labelNomeDefeito.AutoSize = true;
            this.labelNomeDefeito.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeDefeito.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeDefeito.Location = new System.Drawing.Point(116, 30);
            this.labelNomeDefeito.Name = "labelNomeDefeito";
            this.labelNomeDefeito.Size = new System.Drawing.Size(94, 18);
            this.labelNomeDefeito.TabIndex = 2;
            this.labelNomeDefeito.Text = "*Nome/Defeito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxDescricaoDefeito);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.Silver;
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(37, 46);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(71, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCadastrarDefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 373);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxValorDefeito);
            this.Controls.Add(this.textBoxNomeDefeito);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNomeDefeito);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarDefeito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Defeito";
            this.Load += new System.EventHandler(this.FrmCadastrarDefeito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNomeDefeito;
        private System.Windows.Forms.TextBox textBoxDescricaoDefeito;
        private System.Windows.Forms.TextBox textBoxValorDefeito;
        private System.Windows.Forms.Label labelNomeDefeito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
    }
}