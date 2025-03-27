namespace exercicio1bi
{
    partial class frmex1
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
            this.btngerar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngerar
            // 
            this.btngerar.Location = new System.Drawing.Point(163, 278);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(145, 50);
            this.btngerar.TabIndex = 0;
            this.btngerar.Text = "Gerar";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(303, 124);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(118, 24);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "N° Aleatórios";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(384, 278);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtnota.Size = new System.Drawing.Size(62, 50);
            this.txtnota.TabIndex = 2;
            this.txtnota.TextChanged += new System.EventHandler(this.txtnota_TextChanged);
            // 
            // frmex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btngerar);
            this.Name = "frmex1";
            this.Text = "Exercício1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtnota;
    }
}

