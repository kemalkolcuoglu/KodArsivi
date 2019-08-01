namespace Client
{
    partial class Ekle_Düzenle
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
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.btn_Onayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(12, 22);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(100, 20);
            this.txt_Ad.TabIndex = 12;
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(12, 65);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(100, 20);
            this.txt_Tel.TabIndex = 13;
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.Location = new System.Drawing.Point(12, 91);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.Size = new System.Drawing.Size(100, 38);
            this.btn_Onayla.TabIndex = 18;
            this.btn_Onayla.Text = "ONAYLA";
            this.btn_Onayla.UseVisualStyleBackColor = true;
            this.btn_Onayla.Click += new System.EventHandler(this.bt_onayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "AD SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "TELEFON";
            // 
            // Ekle_Düzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(129, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Onayla);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.txt_Tel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(145, 194);
            this.MinimumSize = new System.Drawing.Size(145, 194);
            this.Name = "Ekle_Düzenle";
            this.Text = "Ekle_Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Button btn_Onayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}