
namespace Resto_da_divisão
{
    partial class frmRestoDeDivisao
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
            this.lbldividendo = new System.Windows.Forms.Label();
            this.lblRealizar = new System.Windows.Forms.Button();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.lblResto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldividendo
            // 
            this.lbldividendo.AutoSize = true;
            this.lbldividendo.Location = new System.Drawing.Point(12, 15);
            this.lbldividendo.Name = "lbldividendo";
            this.lbldividendo.Size = new System.Drawing.Size(58, 13);
            this.lbldividendo.TabIndex = 0;
            this.lbldividendo.Text = "Dividendo:";
            // 
            // lblRealizar
            // 
            this.lblRealizar.Location = new System.Drawing.Point(15, 57);
            this.lblRealizar.Name = "lblRealizar";
            this.lblRealizar.Size = new System.Drawing.Size(161, 23);
            this.lblRealizar.TabIndex = 1;
            this.lblRealizar.Text = "Realizar divisão";
            this.lblRealizar.UseVisualStyleBackColor = true;
            this.lblRealizar.Click += new System.EventHandler(this.lblRealizar_Click);
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(76, 12);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 2;
            this.txtDividendo.TextChanged += new System.EventHandler(this.txtDividendo_TextChanged);
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(239, 12);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 4;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(191, 15);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 3;
            this.lblDivisor.Text = "Divisor:";
            // 
            // txtResto
            // 
            this.txtResto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResto.Location = new System.Drawing.Point(239, 57);
            this.txtResto.Name = "txtResto";
            this.txtResto.Size = new System.Drawing.Size(100, 20);
            this.txtResto.TabIndex = 6;
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(191, 60);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(38, 13);
            this.lblResto.TabIndex = 5;
            this.lblResto.Text = "Resto:";
            // 
            // frmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 99);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblRealizar);
            this.Controls.Add(this.lbldividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRestoDeDivisao";
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldividendo;
        private System.Windows.Forms.Button lblRealizar;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Label lblResto;
    }
}

