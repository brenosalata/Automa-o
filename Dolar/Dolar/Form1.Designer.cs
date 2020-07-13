namespace Dolar
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(65, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver Cotação  ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dolar Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Euro Atual";
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(302, 40);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 6;
            this.txtDolar.Text = "R$";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(302, 116);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 7;
            this.txtEuro.Text = "R$";
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(408, 40);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(35, 20);
            this.btnDolar.TabIndex = 9;
            this.btnDolar.Text = "=";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(408, 118);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(35, 20);
            this.btnEuro.TabIndex = 10;
            this.btnEuro.Text = "=";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(463, 43);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(10, 13);
            this.lblDolar.TabIndex = 11;
            this.lblDolar.Text = "-";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(463, 122);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(10, 13);
            this.lblEuro.TabIndex = 12;
            this.lblEuro.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Converter para real";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 259);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label label5;
    }
}

