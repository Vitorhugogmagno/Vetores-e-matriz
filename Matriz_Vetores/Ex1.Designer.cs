namespace Matriz_Vetores
{
    partial class Ex1
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
            lblA = new Label();
            txtA = new TextBox();
            btnapresentar = new Button();
            btnadicionar = new Button();
            txtapresentarA = new TextBox();
            txtapresentarB = new TextBox();
            btnLimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblA.Location = new Point(293, 49);
            lblA.Name = "lblA";
            lblA.Size = new Size(228, 19);
            lblA.TabIndex = 0;
            lblA.Text = "Digite 15 valores de um vetor A:";
            // 
            // txtA
            // 
            txtA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtA.Location = new Point(591, 46);
            txtA.Name = "txtA";
            txtA.Size = new Size(223, 27);
            txtA.TabIndex = 1;
            // 
            // btnapresentar
            // 
            btnapresentar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnapresentar.Location = new Point(299, 159);
            btnapresentar.Name = "btnapresentar";
            btnapresentar.Size = new Size(307, 38);
            btnapresentar.TabIndex = 2;
            btnapresentar.Text = "Apresentar Vetores:";
            btnapresentar.UseVisualStyleBackColor = true;
            btnapresentar.Click += btnapresentar_Click;
            // 
            // btnadicionar
            // 
            btnadicionar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnadicionar.Location = new Point(349, 95);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(174, 38);
            btnadicionar.TabIndex = 3;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // txtapresentarA
            // 
            txtapresentarA.Enabled = false;
            txtapresentarA.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtapresentarA.Location = new Point(271, 249);
            txtapresentarA.Multiline = true;
            txtapresentarA.Name = "txtapresentarA";
            txtapresentarA.Size = new Size(543, 71);
            txtapresentarA.TabIndex = 4;
            txtapresentarA.Visible = false;
            // 
            // txtapresentarB
            // 
            txtapresentarB.Enabled = false;
            txtapresentarB.Font = new Font("Calibri", 12F, FontStyle.Bold);
            txtapresentarB.Location = new Point(271, 326);
            txtapresentarB.Multiline = true;
            txtapresentarB.Name = "txtapresentarB";
            txtapresentarB.Size = new Size(543, 70);
            txtapresentarB.TabIndex = 5;
            txtapresentarB.Visible = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLimpar.Location = new Point(48, 481);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(234, 51);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnvoltar.Location = new Point(353, 481);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(234, 51);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 580);
            Controls.Add(btnvoltar);
            Controls.Add(btnLimpar);
            Controls.Add(txtapresentarB);
            Controls.Add(txtapresentarA);
            Controls.Add(btnadicionar);
            Controls.Add(btnapresentar);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Ex1";
            Text = "Ex1";
            Load += Ex1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Button btnapresentar;
        private Button btnadicionar;
        private TextBox txtapresentarA;
        private TextBox txtapresentarB;
        private Button btnLimpar;
        private Button btnvoltar;
    }
}