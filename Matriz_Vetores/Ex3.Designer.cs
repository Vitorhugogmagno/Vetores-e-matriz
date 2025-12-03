namespace Matriz_Vetores
{
    partial class Ex3
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
            btnadicionar = new Button();
            txtA = new TextBox();
            lblA = new Label();
            btnvoltar = new Button();
            btnLimpar = new Button();
            lblsearch = new Label();
            txtsearch = new TextBox();
            lblinstrucao = new Label();
            lblnum = new Label();
            label1 = new Label();
            txtnum = new TextBox();
            txtcubo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnsearch = new Button();
            SuspendLayout();
            // 
            // btnadicionar
            // 
            btnadicionar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnadicionar.Location = new Point(127, 108);
            btnadicionar.Margin = new Padding(3, 4, 3, 4);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(199, 57);
            btnadicionar.TabIndex = 6;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // txtA
            // 
            txtA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtA.Location = new Point(77, 54);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(305, 27);
            txtA.TabIndex = 5;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblA.Location = new Point(26, 11);
            lblA.Name = "lblA";
            lblA.Size = new Size(228, 19);
            lblA.TabIndex = 4;
            lblA.Text = "Digite 30 valores de um vetor A:";
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnvoltar.Location = new Point(552, 637);
            btnvoltar.Margin = new Padding(3, 4, 3, 4);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(175, 65);
            btnvoltar.TabIndex = 17;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpar.Location = new Point(323, 637);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(175, 65);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Resetar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblsearch.Location = new Point(26, 219);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(222, 19);
            lblsearch.TabIndex = 18;
            lblsearch.Text = "Pesquise o número pelo indice:";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtsearch.Location = new Point(411, 219);
            txtsearch.Margin = new Padding(3, 4, 3, 4);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(123, 27);
            txtsearch.TabIndex = 19;
            // 
            // lblinstrucao
            // 
            lblinstrucao.AutoSize = true;
            lblinstrucao.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblinstrucao.Location = new Point(542, 224);
            lblinstrucao.Name = "lblinstrucao";
            lblinstrucao.Size = new Size(56, 19);
            lblinstrucao.TabIndex = 20;
            lblinstrucao.Text = "(1 - 30)";
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblnum.Location = new Point(553, 399);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(69, 19);
            lblnum.TabIndex = 21;
            lblnum.Text = "Número:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(563, 459);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 22;
            label1.Text = "Cubo:";
            // 
            // txtnum
            // 
            txtnum.Enabled = false;
            txtnum.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtnum.Location = new Point(672, 399);
            txtnum.Margin = new Padding(3, 4, 3, 4);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(123, 27);
            txtnum.TabIndex = 23;
            // 
            // txtcubo
            // 
            txtcubo.Enabled = false;
            txtcubo.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtcubo.Location = new Point(672, 459);
            txtcubo.Margin = new Padding(3, 4, 3, 4);
            txtcubo.Name = "txtcubo";
            txtcubo.Size = new Size(123, 27);
            txtcubo.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(85, 637);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(175, 65);
            button1.TabIndex = 25;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.Location = new Point(1458, 637);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(9, 10);
            button2.TabIndex = 26;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnsearch.Location = new Point(115, 275);
            btnsearch.Margin = new Padding(3, 4, 3, 4);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(265, 49);
            btnsearch.TabIndex = 27;
            btnsearch.Text = "Pesquisar";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(btnsearch);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtcubo);
            Controls.Add(txtnum);
            Controls.Add(label1);
            Controls.Add(lblnum);
            Controls.Add(lblinstrucao);
            Controls.Add(txtsearch);
            Controls.Add(lblsearch);
            Controls.Add(btnvoltar);
            Controls.Add(btnLimpar);
            Controls.Add(btnadicionar);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ex3";
            Text = "Ex3";
            Load += Ex3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadicionar;
        private TextBox txtA;
        private Label lblA;
        private Button btnvoltar;
        private Button btnLimpar;
        private Label lblsearch;
        private TextBox txtsearch;
        private Label lblinstrucao;
        private Label lblnum;
        private Label label1;
        private TextBox txtnum;
        private TextBox txtcubo;
        private Button button1;
        private Button button2;
        private Button btnsearch;
    }
}