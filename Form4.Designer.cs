namespace Academia
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.textBoxsenhalogin = new System.Windows.Forms.TextBox();
            this.buttonesquecersenha = new System.Windows.Forms.Button();
            this.buttonsair = new System.Windows.Forms.Button();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Location = new System.Drawing.Point(148, 34);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxlogin.TabIndex = 2;
            // 
            // textBoxsenhalogin
            // 
            this.textBoxsenhalogin.Location = new System.Drawing.Point(148, 74);
            this.textBoxsenhalogin.Name = "textBoxsenhalogin";
            this.textBoxsenhalogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxsenhalogin.TabIndex = 3;
            // 
            // buttonesquecersenha
            // 
            this.buttonesquecersenha.Location = new System.Drawing.Point(119, 191);
            this.buttonesquecersenha.Name = "buttonesquecersenha";
            this.buttonesquecersenha.Size = new System.Drawing.Size(108, 24);
            this.buttonesquecersenha.TabIndex = 4;
            this.buttonesquecersenha.Text = "Esqueci a senha";
            this.buttonesquecersenha.UseVisualStyleBackColor = true;
            // 
            // buttonsair
            // 
            this.buttonsair.Location = new System.Drawing.Point(67, 125);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(106, 40);
            this.buttonsair.TabIndex = 5;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = true;
            // 
            // buttonentrar
            // 
            this.buttonentrar.Location = new System.Drawing.Point(179, 125);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(106, 40);
            this.buttonentrar.TabIndex = 6;
            this.buttonentrar.Text = "Entrar";
            this.buttonentrar.UseVisualStyleBackColor = true;
            this.buttonentrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonentrar);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.buttonesquecersenha);
            this.Controls.Add(this.textBoxsenhalogin);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.TextBox textBoxsenhalogin;
        private System.Windows.Forms.Button buttonesquecersenha;
        private System.Windows.Forms.Button buttonsair;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}