namespace Revisao
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.btnF = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(80, 230);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 43);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário:";
            this.label1.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário Atual;";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(188, 70);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(128, 20);
            this.txtS.TabIndex = 3;
            // 
            // txtSA
            // 
            this.txtSA.Location = new System.Drawing.Point(188, 119);
            this.txtSA.Name = "txtSA";
            this.txtSA.ReadOnly = true;
            this.txtSA.Size = new System.Drawing.Size(128, 20);
            this.txtSA.TabIndex = 4;
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(735, 461);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(85, 43);
            this.btnF.TabIndex = 5;
            this.btnF.Text = "Fechar";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(230, 230);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(86, 42);
            this.btnL.TabIndex = 6;
            this.btnL.Text = "Limpar";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 516);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.txtSA);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Aumento Salárial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnL;
    }
}

