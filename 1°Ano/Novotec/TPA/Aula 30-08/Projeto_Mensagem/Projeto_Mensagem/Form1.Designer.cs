namespace Projeto_Mensagem
{
    partial class atvd
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
            this.lbl = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.bntfechar = new System.Windows.Forms.Button();
            this.btncor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl.Location = new System.Drawing.Point(209, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(322, 39);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Clique no botão, OK!";
            this.lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Black;
            this.btnOk.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOk.Location = new System.Drawing.Point(216, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 48);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // bntfechar
            // 
            this.bntfechar.BackColor = System.Drawing.Color.Black;
            this.bntfechar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bntfechar.Location = new System.Drawing.Point(411, 212);
            this.bntfechar.Name = "bntfechar";
            this.bntfechar.Size = new System.Drawing.Size(120, 48);
            this.bntfechar.TabIndex = 3;
            this.bntfechar.Text = "FECHAR";
            this.bntfechar.UseVisualStyleBackColor = false;
            this.bntfechar.Click += new System.EventHandler(this.bntfechar_Click);
            // 
            // btncor
            // 
            this.btncor.BackColor = System.Drawing.Color.Black;
            this.btncor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btncor.Location = new System.Drawing.Point(12, 424);
            this.btncor.Name = "btncor";
            this.btncor.Size = new System.Drawing.Size(119, 43);
            this.btncor.TabIndex = 4;
            this.btncor.Text = "Trocar Cor...";
            this.btncor.UseVisualStyleBackColor = false;
            this.btncor.Click += new System.EventHandler(this.btncor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Restaurar Cor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // atvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(855, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncor);
            this.Controls.Add(this.bntfechar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbl);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "atvd";
            this.Text = "Atividade";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button bntfechar;
        private System.Windows.Forms.Button btncor;
        private System.Windows.Forms.Button button1;
    }
}

