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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            textBoxId = new TextBox();
            Id = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(121, 184);
            button1.Name = "button1";
            button1.Size = new Size(193, 25);
            button1.TabIndex = 0;
            button1.Text = "Inserir Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(28, 10);
            Nome.Name = "Nome";
            Nome.Size = new Size(52, 19);
            Nome.TabIndex = 1;
            Nome.Text = "Nome*";
            // 
            // textBoxSobrenome
            // 
            textBoxSobrenome.Cursor = Cursors.IBeam;
            textBoxSobrenome.Location = new Point(121, 59);
            textBoxSobrenome.Name = "textBoxSobrenome";
            textBoxSobrenome.Size = new Size(359, 25);
            textBoxSobrenome.TabIndex = 2;
            // 
            // sobrenome
            // 
            sobrenome.AutoSize = true;
            sobrenome.Location = new Point(28, 59);
            sobrenome.Name = "sobrenome";
            sobrenome.Size = new Size(85, 19);
            sobrenome.TabIndex = 3;
            sobrenome.Text = "Sobrenome*";
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Location = new Point(28, 113);
            cpf.Name = "cpf";
            cpf.Size = new Size(36, 19);
            cpf.TabIndex = 4;
            cpf.Text = "Cpf*";
            // 
            // button2
            // 
            button2.Location = new Point(351, 184);
            button2.Name = "button2";
            button2.Size = new Size(129, 25);
            button2.TabIndex = 5;
            button2.Text = "Alterar Registro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.Location = new Point(121, 10);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(359, 25);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Cursor = Cursors.IBeam;
            textBoxCPF.Location = new Point(121, 113);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(100, 25);
            textBoxCPF.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 229);
            dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(121, 238);
            button3.Name = "button3";
            button3.Size = new Size(193, 25);
            button3.TabIndex = 9;
            button3.Text = "Consutar todos  registro";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBoxId
            // 
            textBoxId.Cursor = Cursors.IBeam;
            textBoxId.Location = new Point(300, 110);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(66, 25);
            textBoxId.TabIndex = 10;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(257, 113);
            Id.Name = "Id";
            Id.Size = new Size(23, 19);
            Id.TabIndex = 11;
            Id.Text = "ID";
            // 
            // button4
            // 
            button4.Location = new Point(351, 238);
            button4.Name = "button4";
            button4.Size = new Size(129, 25);
            button4.TabIndex = 12;
            button4.Text = "Deletar Registro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(28, 238);
            button5.Name = "button5";
            button5.Size = new Size(91, 25);
            button5.TabIndex = 13;
            button5.Text = "Consulta ID";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 510);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Id);
            Controls.Add(textBoxId);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxCPF);
            Controls.Add(textBoxNome);
            Controls.Add(button2);
            Controls.Add(cpf);
            Controls.Add(sobrenome);
            Controls.Add(textBoxSobrenome);
            Controls.Add(Nome);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBoxId;
        private Label Id;
        private Button button4;
        private Button button5;
    }
}
