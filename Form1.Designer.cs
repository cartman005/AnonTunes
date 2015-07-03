namespace AnonTunes
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
            this.wipeButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // wipeButton
            // 
            this.wipeButton.Location = new System.Drawing.Point(306, 91);
            this.wipeButton.Name = "wipeButton";
            this.wipeButton.Size = new System.Drawing.Size(165, 52);
            this.wipeButton.TabIndex = 2;
            this.wipeButton.Text = "Wipe";
            this.wipeButton.UseVisualStyleBackColor = true;
            this.wipeButton.Click += new System.EventHandler(this.wipeButton_Click);
            // 
            // pathButton
            // 
            this.pathButton.Location = new System.Drawing.Point(639, 21);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(117, 45);
            this.pathButton.TabIndex = 1;
            this.pathButton.Text = "Browse";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(12, 21);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(621, 45);
            this.pathText.TabIndex = 1;
            this.pathText.Click += new System.EventHandler(this.pathLabel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(739, 13);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 154);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.pathButton);
            this.Controls.Add(this.wipeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wipeButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Label pathText;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

