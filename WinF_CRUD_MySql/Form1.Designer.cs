namespace WinF_CRUD_MySql
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
            button1 = new Button();
            Nome = new Label();
            textBoxSobrenome = new TextBox();
            sobrenome = new Label();
            cpf = new Label();
            button2 = new Button();
            textBoxNome = new TextBox();
            textBoxCPF = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 210);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 0;
            button1.Text = "Novo Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(28, 9);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 1;
            Nome.Text = "Nome";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Location = new Point(120, 52);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(245, 23);
            textBoxSobrenome.TabIndex = 2;
            // 
            // sobrenome
            // 
            sobrenome.AutoSize = true;
            sobrenome.Location = new Point(28, 60);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(68, 15);
            sobrenome.TabIndex = 3;
            sobrenome.Text = "Sobrenome";
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Location = new Point(28, 100);
            cpf.Name = "cpf";
            cpf.Size = new Size(31, 15);
            cpf.TabIndex = 4;
            cpf.Text = "Cpf*";
            // 
            // button2
            // 
            button2.Location = new Point(216, 210);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 5;
            button2.Text = "Alterar Registro";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(120, 9);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(245, 23);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(120, 100);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(100, 23);
            textBoxCPF.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCPF);
            Controls.Add(textBoxNome);
            Controls.Add(button2);
            Controls.Add(cpf);
            Controls.Add(sobrenome);
            Controls.Add(textBoxSobrenome);
            Controls.Add(Nome);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Nome;
        private TextBox textBoxSobrenome;
        private Label sobrenome;
        private Label cpf;
        private Button button2;
        private TextBox textBoxNome;
        private TextBox textBoxCPF;
    }
}
