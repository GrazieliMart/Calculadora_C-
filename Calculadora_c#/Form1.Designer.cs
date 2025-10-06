namespace Calculadora_c_
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
            txtResultado = new TextBox();
            btnZero = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnUm = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnSubtracao = new Button();
            btnSoma = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(11, 32);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(223, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(231, 233, 200);
            btnZero.Cursor = Cursors.Hand;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.ForeColor = Color.Olive;
            btnZero.Location = new Point(12, 297);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(108, 51);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.FromArgb(231, 233, 200);
            btnDois.Cursor = Cursors.Hand;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDois.ForeColor = Color.Olive;
            btnDois.Location = new Point(69, 240);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(51, 51);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.FromArgb(231, 233, 200);
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTres.ForeColor = Color.Olive;
            btnTres.Location = new Point(126, 240);
            btnTres.Name = "btnTres";
            btnTres.RightToLeft = RightToLeft.No;
            btnTres.Size = new Size(51, 51);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.FromArgb(231, 233, 200);
            btnUm.Cursor = Cursors.Hand;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUm.ForeColor = Color.Olive;
            btnUm.Location = new Point(12, 240);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(51, 51);
            btnUm.TabIndex = 4;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.FromArgb(231, 233, 200);
            btnQuatro.Cursor = Cursors.Hand;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuatro.ForeColor = Color.Olive;
            btnQuatro.Location = new Point(12, 183);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(51, 51);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.FromArgb(231, 233, 200);
            btnCinco.Cursor = Cursors.Hand;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCinco.ForeColor = Color.Olive;
            btnCinco.Location = new Point(69, 183);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(51, 51);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.FromArgb(231, 233, 200);
            btnSeis.Cursor = Cursors.Hand;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeis.ForeColor = Color.Olive;
            btnSeis.Location = new Point(126, 183);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(51, 51);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.FromArgb(231, 233, 200);
            btnSete.Cursor = Cursors.Hand;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSete.ForeColor = Color.Olive;
            btnSete.Location = new Point(12, 126);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(51, 51);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.FromArgb(231, 233, 200);
            btnOito.Cursor = Cursors.Hand;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOito.ForeColor = Color.Olive;
            btnOito.Location = new Point(69, 126);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(51, 51);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.FromArgb(231, 233, 200);
            btnNove.Cursor = Cursors.Hand;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNove.ForeColor = Color.Olive;
            btnNove.Location = new Point(126, 126);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(51, 51);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(231, 233, 200);
            btnVirgula.Cursor = Cursors.Hand;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = Color.Olive;
            btnVirgula.Location = new Point(126, 297);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.RightToLeft = RightToLeft.No;
            btnVirgula.Size = new Size(51, 51);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(231, 233, 200);
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = Color.Olive;
            btnIgual.Location = new Point(183, 183);
            btnIgual.Name = "btnIgual";
            btnIgual.RightToLeft = RightToLeft.No;
            btnIgual.Size = new Size(51, 165);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.FromArgb(231, 233, 200);
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubtracao.ForeColor = Color.Olive;
            btnSubtracao.Location = new Point(183, 69);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.RightToLeft = RightToLeft.No;
            btnSubtracao.Size = new Size(51, 51);
            btnSubtracao.TabIndex = 13;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(231, 233, 200);
            btnSoma.Cursor = Cursors.Hand;
            btnSoma.FlatStyle = FlatStyle.Flat;
            btnSoma.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSoma.ForeColor = Color.Olive;
            btnSoma.Location = new Point(183, 126);
            btnSoma.Name = "btnSoma";
            btnSoma.RightToLeft = RightToLeft.No;
            btnSoma.Size = new Size(51, 51);
            btnSoma.TabIndex = 14;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(231, 233, 200);
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicacao.ForeColor = Color.Olive;
            btnMultiplicacao.Location = new Point(126, 69);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.RightToLeft = RightToLeft.No;
            btnMultiplicacao.Size = new Size(51, 51);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(231, 233, 200);
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivisao.ForeColor = Color.Olive;
            btnDivisao.Location = new Point(69, 69);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.RightToLeft = RightToLeft.No;
            btnDivisao.Size = new Size(51, 51);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(231, 233, 200);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.Olive;
            btnLimpar.Location = new Point(12, 69);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.RightToLeft = RightToLeft.No;
            btnLimpar.Size = new Size(51, 51);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(25, 33);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 19;
            lblOperacao.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 233, 200);
            ClientSize = new Size(251, 383);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnUm);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnDois;
        private Button btnTres;
        private Button btnUm;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnSubtracao;
        private Button btnSoma;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label lblOperacao;
    }
}
