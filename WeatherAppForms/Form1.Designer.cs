namespace WeatherAppForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSehir = new TextBox();
            btnAra = new Button();
            lblSehirAdi = new Label();
            lblSicaklik = new Label();
            lblHissedilen = new Label();
            SuspendLayout();
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(63, 77);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(128, 23);
            txtSehir.TabIndex = 0;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(253, 77);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(154, 28);
            btnAra.TabIndex = 1;
            btnAra.Text = "Hava Durumunu Getir";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // lblSehirAdi
            // 
            lblSehirAdi.AutoSize = true;
            lblSehirAdi.Location = new Point(63, 174);
            lblSehirAdi.Name = "lblSehirAdi";
            lblSehirAdi.Size = new Size(16, 15);
            lblSehirAdi.TabIndex = 2;
            lblSehirAdi.Text = "...";
            // 
            // lblSicaklik
            // 
            lblSicaklik.AutoSize = true;
            lblSicaklik.Location = new Point(63, 211);
            lblSicaklik.Name = "lblSicaklik";
            lblSicaklik.Size = new Size(16, 15);
            lblSicaklik.TabIndex = 3;
            lblSicaklik.Text = "...";
            // 
            // lblHissedilen
            // 
            lblHissedilen.AutoSize = true;
            lblHissedilen.Location = new Point(63, 249);
            lblHissedilen.Name = "lblHissedilen";
            lblHissedilen.Size = new Size(16, 15);
            lblHissedilen.TabIndex = 4;
            lblHissedilen.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHissedilen);
            Controls.Add(lblSicaklik);
            Controls.Add(lblSehirAdi);
            Controls.Add(btnAra);
            Controls.Add(txtSehir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSehir;
        private Button btnAra;
        private Label lblSehirAdi;
        private Label lblSicaklik;
        private Label lblHissedilen;
    }
}
