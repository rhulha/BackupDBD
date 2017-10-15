namespace BackupDBD
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
            this.backup = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonOpenTargetDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(12, 249);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(354, 23);
            this.backup.TabIndex = 0;
            this.backup.Text = "Backup Dead by Daylight";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(599, 216);
            this.textBox.TabIndex = 1;
            // 
            // buttonOpenTargetDir
            // 
            this.buttonOpenTargetDir.Location = new System.Drawing.Point(384, 249);
            this.buttonOpenTargetDir.Name = "buttonOpenTargetDir";
            this.buttonOpenTargetDir.Size = new System.Drawing.Size(227, 23);
            this.buttonOpenTargetDir.TabIndex = 2;
            this.buttonOpenTargetDir.Text = "Öffne Backup Ordner";
            this.buttonOpenTargetDir.UseVisualStyleBackColor = true;
            this.buttonOpenTargetDir.Click += new System.EventHandler(this.buttonOpenTargetDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 284);
            this.Controls.Add(this.buttonOpenTargetDir);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.backup);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup DBD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonOpenTargetDir;
    }
}

