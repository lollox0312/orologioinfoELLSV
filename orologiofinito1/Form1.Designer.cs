namespace orologiofinito1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p12)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p3
            // 
            this.p3.Image = global::orologiofinito1.Properties.Resources.ccccc3;
            this.p3.Location = new System.Drawing.Point(0, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(51, 48);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 9;
            this.p3.TabStop = false;
            // 
            // p9
            // 
            this.p9.Image = global::orologiofinito1.Properties.Resources.ccccc9;
            this.p9.Location = new System.Drawing.Point(0, 0);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(51, 50);
            this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p9.TabIndex = 8;
            this.p9.TabStop = false;
            // 
            // p6
            // 
            this.p6.Image = global::orologiofinito1.Properties.Resources.ccccc6;
            this.p6.Location = new System.Drawing.Point(0, 0);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(51, 48);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 7;
            this.p6.TabStop = false;
            // 
            // p12
            // 
            this.p12.Image = global::orologiofinito1.Properties.Resources.ccccc12;
            this.p12.Location = new System.Drawing.Point(0, 0);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(51, 48);
            this.p12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p12.TabIndex = 2;
            this.p12.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox p12;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p3;
    }
}

