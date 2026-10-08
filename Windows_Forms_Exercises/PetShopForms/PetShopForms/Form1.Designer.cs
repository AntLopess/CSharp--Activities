namespace PetShopForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            lblIdade = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnCadastrar = new Button();
            lstAnimais = new ListBox();
            btnFazerSom = new Button();
            btnRemover = new Button();
            lblQuantidade = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(45, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 23);
            txtNome.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(45, 131);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(43, 23);
            txtIdade.TabIndex = 2;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(46, 104);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(39, 15);
            lblIdade.TabIndex = 3;
            lblIdade.Text = "Idade:";
            lblIdade.Click += label1_Click_1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(45, 172);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            lblTipo.Click += label1_Click_2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "Passaro" });
            cmbTipo.Location = new Point(47, 201);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(47, 249);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lstAnimais
            // 
            lstAnimais.FormattingEnabled = true;
            lstAnimais.ItemHeight = 15;
            lstAnimais.Location = new Point(47, 293);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.Size = new Size(120, 94);
            lstAnimais.TabIndex = 7;
            lstAnimais.SelectedIndexChanged += lstAnimais_SelectedIndexChanged;
            // 
            // btnFazerSom
            // 
            btnFazerSom.Location = new Point(200, 293);
            btnFazerSom.Name = "btnFazerSom";
            btnFazerSom.Size = new Size(75, 23);
            btnFazerSom.TabIndex = 8;
            btnFazerSom.Text = "Fazer Som";
            btnFazerSom.UseVisualStyleBackColor = true;
            btnFazerSom.Click += btnFazerSom_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(200, 322);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 9;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(47, 401);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(38, 15);
            lblQuantidade.TabIndex = 10;
            lblQuantidade.Text = "label1";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 440);
            Controls.Add(lblQuantidade);
            Controls.Add(btnRemover);
            Controls.Add(btnFazerSom);
            Controls.Add(lstAnimais);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblIdade);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label lblIdade;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnCadastrar;
        private ListBox lstAnimais;
        private Button btnFazerSom;
        private Button btnRemover;
        private Label lblQuantidade;
    }
}
