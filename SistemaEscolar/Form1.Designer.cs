namespace SistemaEscolar
{
    partial class formCadastroAlunos
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
            lblTitulo = new Label();
            lblNome = new Label();
            txtNascimento = new TextBox();
            dtpNascimento = new DateTimePicker();
            lblNascimento = new Label();
            lblCPF = new Label();
            mtbCpf = new MaskedTextBox();
            lblEndereço = new Label();
            textBox1 = new TextBox();
            lblEmail = new Label();
            textBox2 = new TextBox();
            lblTelefone = new Label();
            mtbTelefone = new MaskedTextBox();
            rbFem = new RadioButton();
            comboBox1 = new ComboBox();
            rbMasc = new RadioButton();
            rbOutro = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnCasdastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(405, 57);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Alunos";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(129, 141);
            lblNome.Margin = new Padding(5, 0, 5, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(128, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome Completo:";
            // 
            // txtNascimento
            // 
            txtNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNascimento.Location = new Point(129, 169);
            txtNascimento.Margin = new Padding(5);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(312, 29);
            txtNascimento.TabIndex = 2;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascimento.Location = new Point(129, 246);
            dtpNascimento.Margin = new Padding(5);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(311, 27);
            dtpNascimento.TabIndex = 3;
            // 
            // lblNascimento
            // 
            lblNascimento.AutoSize = true;
            lblNascimento.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNascimento.Location = new Point(129, 218);
            lblNascimento.Margin = new Padding(5, 0, 5, 0);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(156, 23);
            lblNascimento.TabIndex = 4;
            lblNascimento.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCPF.Location = new Point(129, 297);
            lblCPF.Margin = new Padding(5, 0, 5, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(43, 23);
            lblCPF.TabIndex = 5;
            lblCPF.Text = "CPF:";
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(129, 323);
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(187, 33);
            mtbCpf.TabIndex = 6;
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereço.Location = new Point(517, 141);
            lblEndereço.Margin = new Padding(5, 0, 5, 0);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(81, 23);
            lblEndereço.TabIndex = 7;
            lblEndereço.Text = "Endereço:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(516, 169);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 29);
            textBox1.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(517, 213);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 23);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(517, 241);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 29);
            textBox2.TabIndex = 10;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefone.Location = new Point(129, 374);
            lblTelefone.Margin = new Padding(5, 0, 5, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(75, 23);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone:";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(129, 400);
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(187, 33);
            mtbTelefone.TabIndex = 12;
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Font = new Font("Sitka Subheading", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            rbFem.Location = new Point(20, 25);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(98, 28);
            rbFem.TabIndex = 14;
            rbFem.TabStop = true;
            rbFem.Text = "Feminino";
            rbFem.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Primeira série A", "Primeira série B", "Primeira série C", "Segunda série A", "Segunda série B", "Segunda série C", "Terceira série A", "Terceira série B", "Terceira série C" });
            comboBox1.Location = new Point(641, 322);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 29);
            comboBox1.TabIndex = 15;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Font = new Font("Sitka Subheading", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            rbMasc.Location = new Point(20, 62);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(105, 28);
            rbMasc.TabIndex = 16;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbOutro
            // 
            rbOutro.AutoSize = true;
            rbOutro.Font = new Font("Sitka Subheading", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point);
            rbOutro.Location = new Point(20, 95);
            rbOutro.Name = "rbOutro";
            rbOutro.Size = new Size(72, 28);
            rbOutro.TabIndex = 17;
            rbOutro.TabStop = true;
            rbOutro.Text = "Outro";
            rbOutro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(rbMasc);
            groupBox1.Controls.Add(rbOutro);
            groupBox1.Controls.Add(rbFem);
            groupBox1.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(405, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(140, 136);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(640, 296);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 19;
            label1.Text = "Série:";
            // 
            // btnCasdastrar
            // 
            btnCasdastrar.BackColor = Color.PaleGreen;
            btnCasdastrar.FlatStyle = FlatStyle.Popup;
            btnCasdastrar.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCasdastrar.ForeColor = Color.Black;
            btnCasdastrar.Location = new Point(693, 398);
            btnCasdastrar.Name = "btnCasdastrar";
            btnCasdastrar.Size = new Size(99, 35);
            btnCasdastrar.TabIndex = 20;
            btnCasdastrar.Text = "Cadastrar";
            btnCasdastrar.UseVisualStyleBackColor = false;
            // 
            // formCadastroAlunos
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 601);
            Controls.Add(btnCasdastrar);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(mtbTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(textBox2);
            Controls.Add(lblEmail);
            Controls.Add(textBox1);
            Controls.Add(lblEndereço);
            Controls.Add(mtbCpf);
            Controls.Add(lblCPF);
            Controls.Add(lblNascimento);
            Controls.Add(dtpNascimento);
            Controls.Add(txtNascimento);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "formCadastroAlunos";
            Text = "Cadastro Alunos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNascimento;
        private DateTimePicker dtpNascimento;
        private Label lblNascimento;
        private Label lblCPF;
        private MaskedTextBox mtbCpf;
        private Label lblEndereço;
        private TextBox textBox1;
        private Label lblEmail;
        private TextBox textBox2;
        private Label lblTelefone;
        private MaskedTextBox mtbTelefone;
        private RadioButton rbFem;
        private ComboBox comboBox1;
        private RadioButton rbMasc;
        private RadioButton rbOutro;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnCasdastrar;
    }
}