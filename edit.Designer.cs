namespace ChangeLog_Generator
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBox_naglowek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_info_dod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_info_zap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_info_dodatk = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExitButton.Location = new System.Drawing.Point(16, 523);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Zamknij";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_naglowek
            // 
            this.textBox_naglowek.AcceptsTab = true;
            this.textBox_naglowek.AllowDrop = true;
            this.textBox_naglowek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_naglowek.Location = new System.Drawing.Point(16, 31);
            this.textBox_naglowek.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_naglowek.Multiline = true;
            this.textBox_naglowek.Name = "textBox_naglowek";
            this.textBox_naglowek.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_naglowek.Size = new System.Drawing.Size(219, 80);
            this.textBox_naglowek.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "1. Nagłówek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "2. Informacje o dodanych funkcjach:";
            // 
            // textBox_info_dod
            // 
            this.textBox_info_dod.AcceptsTab = true;
            this.textBox_info_dod.AllowDrop = true;
            this.textBox_info_dod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_info_dod.Location = new System.Drawing.Point(16, 154);
            this.textBox_info_dod.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_info_dod.Multiline = true;
            this.textBox_info_dod.Name = "textBox_info_dod";
            this.textBox_info_dod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_dod.Size = new System.Drawing.Size(219, 78);
            this.textBox_info_dod.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 51);
            this.label5.TabIndex = 7;
            this.label5.Text = "3. Zapowiedziane zmainy\r\nw następnej wersji\r\n(zostawić puste, jeśli nie potrzebne" +
    "):";
            // 
            // textBox_info_zap
            // 
            this.textBox_info_zap.AcceptsTab = true;
            this.textBox_info_zap.AllowDrop = true;
            this.textBox_info_zap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_info_zap.Location = new System.Drawing.Point(16, 303);
            this.textBox_info_zap.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_info_zap.Multiline = true;
            this.textBox_info_zap.Name = "textBox_info_zap";
            this.textBox_info_zap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_zap.Size = new System.Drawing.Size(219, 78);
            this.textBox_info_zap.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 390);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "4. Informacje dodatkowe\r\n(zostawić puste, jeśli nie potrzebne):";
            // 
            // textBox_info_dodatk
            // 
            this.textBox_info_dodatk.AcceptsTab = true;
            this.textBox_info_dodatk.AllowDrop = true;
            this.textBox_info_dodatk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_info_dodatk.Location = new System.Drawing.Point(16, 426);
            this.textBox_info_dodatk.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_info_dodatk.Multiline = true;
            this.textBox_info_dodatk.Name = "textBox_info_dodatk";
            this.textBox_info_dodatk.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_dodatk.Size = new System.Drawing.Size(219, 89);
            this.textBox_info_dodatk.TabIndex = 10;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(136, 523);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 28);
            this.GenerateButton.TabIndex = 11;
            this.GenerateButton.Text = "Generuj";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 560);
            this.ControlBox = false;
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.textBox_info_dodatk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_info_zap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_info_dod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_naglowek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 607);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLog Generator - Create file";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox textBox_naglowek;
        public System.Windows.Forms.TextBox textBox_info_dod;
        public System.Windows.Forms.TextBox textBox_info_zap;
        public System.Windows.Forms.TextBox textBox_info_dodatk;
    }
}