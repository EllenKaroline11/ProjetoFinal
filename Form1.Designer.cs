namespace Academia
{
    partial class Form1Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonprof = new System.Windows.Forms.RadioButton();
            this.radioButtonalu = new System.Windows.Forms.RadioButton();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttoncadast = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsair = new System.Windows.Forms.Button();
            this.radioButtonprofessor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academia 3VS";
            // 
            // radioButtonprof
            // 
            this.radioButtonprof.AutoSize = true;
            this.radioButtonprof.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonprof.Location = new System.Drawing.Point(3658, 106);
            this.radioButtonprof.Name = "radioButtonprof";
            this.radioButtonprof.Size = new System.Drawing.Size(87, 24);
            this.radioButtonprof.TabIndex = 2;
            this.radioButtonprof.TabStop = true;
            this.radioButtonprof.Text = "Professor";
            this.radioButtonprof.UseVisualStyleBackColor = true;
            this.radioButtonprof.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonalu
            // 
            this.radioButtonalu.AutoSize = true;
            this.radioButtonalu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonalu.Location = new System.Drawing.Point(246, 106);
            this.radioButtonalu.Name = "radioButtonalu";
            this.radioButtonalu.Size = new System.Drawing.Size(64, 24);
            this.radioButtonalu.TabIndex = 2;
            this.radioButtonalu.TabStop = true;
            this.radioButtonalu.Text = "Aluno";
            this.radioButtonalu.UseVisualStyleBackColor = true;
            this.radioButtonalu.CheckedChanged += new System.EventHandler(this.radioButtonalu_CheckedChanged);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(84, 206);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 33);
            this.buttonlogin.TabIndex = 3;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            // 
            // buttoncadast
            // 
            this.buttoncadast.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncadast.Location = new System.Drawing.Point(246, 206);
            this.buttoncadast.Name = "buttoncadast";
            this.buttoncadast.Size = new System.Drawing.Size(75, 33);
            this.buttoncadast.TabIndex = 3;
            this.buttoncadast.Text = "Cadastro";
            this.buttoncadast.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aberto 24 Horas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonsair
            // 
            this.buttonsair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsair.Location = new System.Drawing.Point(170, 275);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(75, 33);
            this.buttonsair.TabIndex = 5;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = true;
            // 
            // radioButtonprofessor
            // 
            this.radioButtonprofessor.AutoSize = true;
            this.radioButtonprofessor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonprofessor.Location = new System.Drawing.Point(95, 106);
            this.radioButtonprofessor.Name = "radioButtonprofessor";
            this.radioButtonprofessor.Size = new System.Drawing.Size(87, 24);
            this.radioButtonprofessor.TabIndex = 6;
            this.radioButtonprofessor.TabStop = true;
            this.radioButtonprofessor.Text = "Professor";
            this.radioButtonprofessor.UseVisualStyleBackColor = true;
            // 
            // Form1Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 375);
            this.Controls.Add(this.radioButtonprofessor);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoncadast);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.radioButtonalu);
            this.Controls.Add(this.radioButtonprof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonprof;
        private System.Windows.Forms.RadioButton radioButtonalu;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttoncadast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.RadioButton radioButtonprofessor;
    }
}

