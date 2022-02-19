using System.Windows.Forms;

namespace GeradorNumeroProcessoAdministrativo
{
    partial class Principal
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
            this.txtGerar = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGerar
            // 
            this.txtGerar.Location = new System.Drawing.Point(93, 43);
            this.txtGerar.Name = "txtGerar";
            this.txtGerar.ReadOnly = true;
            this.txtGerar.Size = new System.Drawing.Size(335, 20);
            this.txtGerar.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(12, 41);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(411, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerador de número do processo administrativo/judicial para testes do e-Social S-1" +
    "070";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 86);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtGerar);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Social S-1070";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtGerar;
        private Button btnGerar;
        private Label lblTitulo;
    }
}

