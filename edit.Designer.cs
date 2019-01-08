namespace ChangeLog_Generator
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_naglowek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_info_dod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_info_zap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_info_dodatk = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_naglowek
            // 
            this.textBox_naglowek.AcceptsTab = true;
            this.textBox_naglowek.AllowDrop = true;
            this.textBox_naglowek.Location = new System.Drawing.Point(12, 25);
            this.textBox_naglowek.Multiline = true;
            this.textBox_naglowek.Name = "textBox_naglowek";
            this.textBox_naglowek.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_naglowek.Size = new System.Drawing.Size(165, 66);
            this.textBox_naglowek.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1. Nagłówek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "2. Informacje o dodanych funkcjach:";
            // 
            // textBox_info_dod
            // 
            this.textBox_info_dod.AcceptsTab = true;
            this.textBox_info_dod.AllowDrop = true;
            this.textBox_info_dod.Location = new System.Drawing.Point(12, 125);
            this.textBox_info_dod.Multiline = true;
            this.textBox_info_dod.Name = "textBox_info_dod";
            this.textBox_info_dod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_dod.Size = new System.Drawing.Size(165, 64);
            this.textBox_info_dod.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "3. Zapowiedziane zmainy\r\nw następnej wersji\r\n(zostawić puste, jeśli nie potrzebne" +
    "):";
            // 
            // textBox_info_zap
            // 
            this.textBox_info_zap.AcceptsTab = true;
            this.textBox_info_zap.AllowDrop = true;
            this.textBox_info_zap.Location = new System.Drawing.Point(12, 246);
            this.textBox_info_zap.Multiline = true;
            this.textBox_info_zap.Name = "textBox_info_zap";
            this.textBox_info_zap.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_zap.Size = new System.Drawing.Size(165, 64);
            this.textBox_info_zap.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "4. Informacje dodatkowe\r\n(zostawić puste, jeśli nie potrzebne):";
            // 
            // textBox_info_dodatk
            // 
            this.textBox_info_dodatk.AcceptsTab = true;
            this.textBox_info_dodatk.AllowDrop = true;
            this.textBox_info_dodatk.Location = new System.Drawing.Point(12, 346);
            this.textBox_info_dodatk.Multiline = true;
            this.textBox_info_dodatk.Name = "textBox_info_dodatk";
            this.textBox_info_dodatk.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_info_dodatk.Size = new System.Drawing.Size(165, 73);
            this.textBox_info_dodatk.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_info_dodatk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_info_zap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_info_dod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_naglowek);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLog Generator - Create file";
            this.Load += new System.EventHandler(this.edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox textBox_naglowek;
        public System.Windows.Forms.TextBox textBox_info_dod;
        public System.Windows.Forms.TextBox textBox_info_zap;
        public System.Windows.Forms.TextBox textBox_info_dodatk;
    }
}