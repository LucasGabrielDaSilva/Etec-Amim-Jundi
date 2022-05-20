namespace Sistema_Consulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnc = new System.Windows.Forms.Button();
            this.Btnl = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.txtm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite um mes:";
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(83, 147);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(74, 32);
            this.btnc.TabIndex = 2;
            this.btnc.Text = "Calcular";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // Btnl
            // 
            this.Btnl.Location = new System.Drawing.Point(191, 147);
            this.Btnl.Name = "Btnl";
            this.Btnl.Size = new System.Drawing.Size(75, 32);
            this.Btnl.TabIndex = 3;
            this.Btnl.Text = "Limpar";
            this.Btnl.UseVisualStyleBackColor = true;
            this.Btnl.Click += new System.EventHandler(this.Btnl_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(614, 454);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(79, 32);
            this.btnF.TabIndex = 4;
            this.btnF.Text = "Fechar";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(83, 89);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(183, 20);
            this.txtm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 498);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.Btnl);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button Btnl;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.TextBox txtm;
    }
}

