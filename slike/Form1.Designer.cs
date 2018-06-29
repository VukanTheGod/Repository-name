namespace slike
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblista = new System.Windows.Forms.ListBox();
            this.txtnovoime = new System.Windows.Forms.TextBox();
            this.btnizaberi = new System.Windows.Forms.Button();
            this.txtimenovo = new System.Windows.Forms.TextBox();
            this.btnnovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(24, 29);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(322, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIme_MouseClick);
            this.txtIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIme_KeyDown_1);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(24, 67);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(322, 473);
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Izaberi novu sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(41, 602);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(0, 16);
            this.lblIme.TabIndex = 4;
            // 
            // lblista
            // 
            this.lblista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblista.FormattingEnabled = true;
            this.lblista.ItemHeight = 15;
            this.lblista.Location = new System.Drawing.Point(374, 228);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(162, 229);
            this.lblista.TabIndex = 5;
            this.lblista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblista_MouseDoubleClick);
            // 
            // txtnovoime
            // 
            this.txtnovoime.Location = new System.Drawing.Point(17, 28);
            this.txtnovoime.Name = "txtnovoime";
            this.txtnovoime.Size = new System.Drawing.Size(163, 20);
            this.txtnovoime.TabIndex = 0;
            // 
            // btnizaberi
            // 
            this.btnizaberi.Location = new System.Drawing.Point(258, 28);
            this.btnizaberi.Name = "btnizaberi";
            this.btnizaberi.Size = new System.Drawing.Size(75, 49);
            this.btnizaberi.TabIndex = 1;
            this.btnizaberi.Text = "Izaberi ime";
            this.btnizaberi.UseVisualStyleBackColor = true;
            // 
            // txtimenovo
            // 
            this.txtimenovo.Location = new System.Drawing.Point(366, 120);
            this.txtimenovo.Name = "txtimenovo";
            this.txtimenovo.Size = new System.Drawing.Size(170, 20);
            this.txtimenovo.TabIndex = 10;
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(404, 159);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(91, 38);
            this.btnnovo.TabIndex = 11;
            this.btnnovo.Text = "Sacuvaj ime nove slike";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 664);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.txtimenovo);
            this.Controls.Add(this.lblista);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ListBox lblista;
        private System.Windows.Forms.Button btnizaberi;
        private System.Windows.Forms.TextBox txtnovoime;
        private System.Windows.Forms.TextBox txtimenovo;
        private System.Windows.Forms.Button btnnovo;
    }
}

