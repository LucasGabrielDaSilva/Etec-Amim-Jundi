namespace Atv21_02
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.picI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(100, 426);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(81, 40);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Consultar";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(408, 426);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(81, 40);
            this.btnL.TabIndex = 1;
            this.btnL.Text = "Limpar";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(583, 456);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 2;
            this.btnF.Text = "Fechar";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o numero da semana:";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(349, 128);
            this.txtS.MaxLength = 1;
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(140, 20);
            this.txtS.TabIndex = 4;
            this.txtS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtS_KeyPress);
            // 
            // picI
            // 
            this.picI.Location = new System.Drawing.Point(100, 172);
            this.picI.Name = "picI";
            this.picI.Size = new System.Drawing.Size(389, 205);
            this.picI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picI.TabIndex = 5;
            this.picI.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 491);
            this.Controls.Add(this.picI);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.PictureBox picI;
    }
}

