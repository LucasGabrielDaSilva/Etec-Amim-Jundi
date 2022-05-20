namespace Atividade_3
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
            this.btnmensagem = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btntrocar = new System.Windows.Forms.Button();
            this.btnrestaurar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblsobrenome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmensagem
            // 
            this.btnmensagem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmensagem.Location = new System.Drawing.Point(164, 223);
            this.btnmensagem.Name = "btnmensagem";
            this.btnmensagem.Size = new System.Drawing.Size(99, 49);
            this.btnmensagem.TabIndex = 0;
            this.btnmensagem.Text = "Mensagem";
            this.btnmensagem.UseVisualStyleBackColor = true;
            this.btnmensagem.Click += new System.EventHandler(this.btnmensagem_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(280, 223);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(96, 49);
            this.btnapagar.TabIndex = 1;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(395, 223);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(99, 49);
            this.btnfechar.TabIndex = 2;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Location = new System.Drawing.Point(164, 291);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(96, 49);
            this.btnalterar.TabIndex = 3;
            this.btnalterar.Text = "Alterar Cor Do Form";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btntrocar
            // 
            this.btntrocar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrocar.Location = new System.Drawing.Point(280, 291);
            this.btntrocar.Name = "btntrocar";
            this.btntrocar.Size = new System.Drawing.Size(99, 49);
            this.btntrocar.TabIndex = 4;
            this.btntrocar.Text = "Trocar Dados";
            this.btntrocar.UseVisualStyleBackColor = true;
            this.btntrocar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnrestaurar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestaurar.Location = new System.Drawing.Point(395, 291);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(99, 49);
            this.btnrestaurar.TabIndex = 5;
            this.btnrestaurar.Text = "Restaurar Cor do Form";
            this.btnrestaurar.UseVisualStyleBackColor = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(266, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(125, 20);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(266, 151);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(125, 20);
            this.txtsobrenome.TabIndex = 7;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(161, 110);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(54, 18);
            this.lblnome.TabIndex = 8;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // lblsobrenome
            // 
            this.lblsobrenome.AutoSize = true;
            this.lblsobrenome.Font = new System.Drawing.Font("Arial Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsobrenome.Location = new System.Drawing.Point(161, 153);
            this.lblsobrenome.Name = "lblsobrenome";
            this.lblsobrenome.Size = new System.Drawing.Size(94, 18);
            this.lblsobrenome.TabIndex = 9;
            this.lblsobrenome.Text = "Sobrenome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsobrenome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnrestaurar);
            this.Controls.Add(this.btntrocar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnmensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmensagem;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btntrocar;
        private System.Windows.Forms.Button btnrestaurar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblsobrenome;
    }
}

