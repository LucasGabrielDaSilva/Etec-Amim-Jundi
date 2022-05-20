namespace Frutas
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btnL = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.imagem1 = new System.Windows.Forms.PictureBox();
            this.imagem2 = new System.Windows.Forms.PictureBox();
            this.imagem3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(271, 16);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Digite um número entre 1 e 12 do mês:";
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(269, 326);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(93, 33);
            this.btnL.TabIndex = 10;
            this.btnL.Text = "Limpar";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(426, 380);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 9;
            this.btnF.Text = "Encerrar";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(356, 67);
            this.txtN.MaxLength = 2;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(87, 20);
            this.txtN.TabIndex = 8;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(121, 326);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(93, 33);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "Consultar";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // imagem1
            // 
            this.imagem1.Location = new System.Drawing.Point(36, 150);
            this.imagem1.Name = "imagem1";
            this.imagem1.Size = new System.Drawing.Size(137, 132);
            this.imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem1.TabIndex = 6;
            this.imagem1.TabStop = false;
            // 
            // imagem2
            // 
            this.imagem2.Location = new System.Drawing.Point(179, 150);
            this.imagem2.Name = "imagem2";
            this.imagem2.Size = new System.Drawing.Size(137, 132);
            this.imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem2.TabIndex = 12;
            this.imagem2.TabStop = false;
            // 
            // imagem3
            // 
            this.imagem3.Location = new System.Drawing.Point(322, 150);
            this.imagem3.Name = "imagem3";
            this.imagem3.Size = new System.Drawing.Size(137, 132);
            this.imagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem3.TabIndex = 13;
            this.imagem3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 406);
            this.Controls.Add(this.imagem3);
            this.Controls.Add(this.imagem2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.imagem1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnL;
        internal System.Windows.Forms.Button btnF;
        internal System.Windows.Forms.TextBox txtN;
        internal System.Windows.Forms.Button btnC;
        internal System.Windows.Forms.PictureBox imagem1;
        private System.Windows.Forms.PictureBox imagem2;
        private System.Windows.Forms.PictureBox imagem3;
    }
}

