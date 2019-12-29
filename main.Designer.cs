namespace ChangeLog_Generator
{
    partial class main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.NewFileButton = new System.Windows.Forms.Button();
            this.DocumentationButton = new System.Windows.Forms.Button();
            this.AboutAppButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(17, 16);
            this.NewFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(208, 28);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // DocumentationButton
            // 
            this.DocumentationButton.Location = new System.Drawing.Point(16, 52);
            this.DocumentationButton.Margin = new System.Windows.Forms.Padding(4);
            this.DocumentationButton.Name = "DocumentationButton";
            this.DocumentationButton.Size = new System.Drawing.Size(209, 28);
            this.DocumentationButton.TabIndex = 2;
            this.DocumentationButton.UseVisualStyleBackColor = true;
            this.DocumentationButton.Click += new System.EventHandler(this.DocumentationButton_Click);
            // 
            // AboutAppButton
            // 
            this.AboutAppButton.Location = new System.Drawing.Point(17, 87);
            this.AboutAppButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutAppButton.Name = "AboutAppButton";
            this.AboutAppButton.Size = new System.Drawing.Size(208, 28);
            this.AboutAppButton.TabIndex = 3;
            this.AboutAppButton.UseVisualStyleBackColor = true;
            this.AboutAppButton.Click += new System.EventHandler(this.ApoutAppButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 130);
            this.Controls.Add(this.AboutAppButton);
            this.Controls.Add(this.DocumentationButton);
            this.Controls.Add(this.NewFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeLog Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button DocumentationButton;
        private System.Windows.Forms.Button AboutAppButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

