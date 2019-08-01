namespace MTSocket.Forms
{
    partial class Main
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
            this.S_StartStop = new System.Windows.Forms.Button();
            this.S_Debugger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // S_StartStop
            // 
            this.S_StartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.S_StartStop.Location = new System.Drawing.Point(12, 12);
            this.S_StartStop.Name = "S_StartStop";
            this.S_StartStop.Size = new System.Drawing.Size(260, 82);
            this.S_StartStop.TabIndex = 0;
            this.S_StartStop.Text = "Başlat";
            this.S_StartStop.UseVisualStyleBackColor = true;
            this.S_StartStop.Click += new System.EventHandler(this.S_StartStop_Click);
            // 
            // S_Debugger
            // 
            this.S_Debugger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.S_Debugger.Location = new System.Drawing.Point(12, 100);
            this.S_Debugger.Name = "S_Debugger";
            this.S_Debugger.Size = new System.Drawing.Size(260, 82);
            this.S_Debugger.TabIndex = 0;
            this.S_Debugger.Text = "Debugger";
            this.S_Debugger.UseVisualStyleBackColor = true;
            this.S_Debugger.Click += new System.EventHandler(this.S_Debugger_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.S_Debugger);
            this.Controls.Add(this.S_StartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button S_StartStop;
        private System.Windows.Forms.Button S_Debugger;
    }
}