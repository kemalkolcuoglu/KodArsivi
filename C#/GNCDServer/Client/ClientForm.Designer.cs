namespace Client
{
    partial class ClientForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_Ekle = new System.Windows.Forms.Button();
			this.btn_Duzenle = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.rb_ID = new System.Windows.Forms.RadioButton();
			this.rb_Tel = new System.Windows.Forms.RadioButton();
			this.rb_AD = new System.Windows.Forms.RadioButton();
			this.txt_filtre = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(166, 25);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(445, 301);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btn_Ekle
			// 
			this.btn_Ekle.Location = new System.Drawing.Point(166, 332);
			this.btn_Ekle.Name = "btn_Ekle";
			this.btn_Ekle.Size = new System.Drawing.Size(100, 38);
			this.btn_Ekle.TabIndex = 16;
			this.btn_Ekle.Text = "EKLE";
			this.btn_Ekle.UseVisualStyleBackColor = true;
			this.btn_Ekle.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_Duzenle
			// 
			this.btn_Duzenle.Location = new System.Drawing.Point(272, 332);
			this.btn_Duzenle.Name = "btn_Duzenle";
			this.btn_Duzenle.Size = new System.Drawing.Size(100, 38);
			this.btn_Duzenle.TabIndex = 17;
			this.btn_Duzenle.Text = "DÜZENLE";
			this.btn_Duzenle.UseVisualStyleBackColor = true;
			this.btn_Duzenle.Click += new System.EventHandler(this.button2_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(378, 332);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 38);
			this.button5.TabIndex = 18;
			this.button5.Text = "SİL";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.bt_sil_Click);
			// 
			// rb_ID
			// 
			this.rb_ID.AutoSize = true;
			this.rb_ID.Location = new System.Drawing.Point(631, 38);
			this.rb_ID.Name = "rb_ID";
			this.rb_ID.Size = new System.Drawing.Size(36, 17);
			this.rb_ID.TabIndex = 19;
			this.rb_ID.TabStop = true;
			this.rb_ID.Tag = "ID";
			this.rb_ID.Text = "ID";
			this.rb_ID.UseVisualStyleBackColor = true;
			this.rb_ID.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_Tel
			// 
			this.rb_Tel.AutoSize = true;
			this.rb_Tel.Location = new System.Drawing.Point(631, 61);
			this.rb_Tel.Name = "rb_Tel";
			this.rb_Tel.Size = new System.Drawing.Size(74, 17);
			this.rb_Tel.TabIndex = 20;
			this.rb_Tel.TabStop = true;
			this.rb_Tel.Tag = "Telefon";
			this.rb_Tel.Text = "TELEFON";
			this.rb_Tel.UseVisualStyleBackColor = true;
			this.rb_Tel.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_AD
			// 
			this.rb_AD.AutoSize = true;
			this.rb_AD.Location = new System.Drawing.Point(631, 84);
			this.rb_AD.Name = "rb_AD";
			this.rb_AD.Size = new System.Drawing.Size(80, 17);
			this.rb_AD.TabIndex = 21;
			this.rb_AD.TabStop = true;
			this.rb_AD.Tag = "Ad_Soyad";
			this.rb_AD.Text = "AD SOYAD";
			this.rb_AD.UseVisualStyleBackColor = true;
			this.rb_AD.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// txt_filtre
			// 
			this.txt_filtre.Location = new System.Drawing.Point(631, 107);
			this.txt_filtre.Name = "txt_filtre";
			this.txt_filtre.Size = new System.Drawing.Size(100, 20);
			this.txt_filtre.TabIndex = 22;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(631, 131);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 38);
			this.button6.TabIndex = 23;
			this.button6.Text = "FİLTRELE";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.bt_filtrele_Click);
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 394);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.txt_filtre);
			this.Controls.Add(this.rb_AD);
			this.Controls.Add(this.rb_Tel);
			this.Controls.Add(this.rb_ID);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btn_Duzenle);
			this.Controls.Add(this.btn_Ekle);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ClientForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Duzenle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton rb_ID;
        private System.Windows.Forms.RadioButton rb_Tel;
        private System.Windows.Forms.RadioButton rb_AD;
        private System.Windows.Forms.TextBox txt_filtre;
        private System.Windows.Forms.Button button6;
    }
}

