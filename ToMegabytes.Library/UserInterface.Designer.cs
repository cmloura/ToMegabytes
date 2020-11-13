namespace ToMegabytes
{
    partial class UserInterface
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
            this.uxMenu = new System.Windows.Forms.MenuStrip();
            this.uxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxCompute = new System.Windows.Forms.Button();
            this.uxFileName = new System.Windows.Forms.TextBox();
            this.uxFileSelectedLabel = new System.Windows.Forms.Label();
            this.uxNumMB = new System.Windows.Forms.TextBox();
            this.uxNumMBLabel = new System.Windows.Forms.Label();
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenu
            // 
            this.uxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(743, 28);
            this.uxMenu.TabIndex = 0;
            this.uxMenu.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFile});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(46, 24);
            this.uxFile.Text = "File";
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.Name = "uxOpenFile";
            this.uxOpenFile.Size = new System.Drawing.Size(155, 26);
            this.uxOpenFile.Text = "Open File";
            this.uxOpenFile.Click += new System.EventHandler(this.uxOpenFile_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.FileName = "openFileDialog1";
            this.uxOpenDialog.Filter = "\"Text files (*.txt)|*.txt|All files (*.*)|*.*\"";
            // 
            // uxCompute
            // 
            this.uxCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxCompute.Location = new System.Drawing.Point(123, 129);
            this.uxCompute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxCompute.Name = "uxCompute";
            this.uxCompute.Size = new System.Drawing.Size(496, 63);
            this.uxCompute.TabIndex = 1;
            this.uxCompute.Text = "Compute";
            this.uxCompute.UseVisualStyleBackColor = true;
            this.uxCompute.Click += new System.EventHandler(this.uxCompute_Click);
            // 
            // uxFileName
            // 
            this.uxFileName.Location = new System.Drawing.Point(123, 66);
            this.uxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFileName.Name = "uxFileName";
            this.uxFileName.Size = new System.Drawing.Size(495, 22);
            this.uxFileName.TabIndex = 2;
            // 
            // uxFileSelectedLabel
            // 
            this.uxFileSelectedLabel.AutoSize = true;
            this.uxFileSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uxFileSelectedLabel.Location = new System.Drawing.Point(15, 67);
            this.uxFileSelectedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxFileSelectedLabel.Name = "uxFileSelectedLabel";
            this.uxFileSelectedLabel.Size = new System.Drawing.Size(100, 18);
            this.uxFileSelectedLabel.TabIndex = 3;
            this.uxFileSelectedLabel.Text = "Selected File: ";
            // 
            // uxNumMB
            // 
            this.uxNumMB.Location = new System.Drawing.Point(475, 263);
            this.uxNumMB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxNumMB.Name = "uxNumMB";
            this.uxNumMB.Size = new System.Drawing.Size(143, 22);
            this.uxNumMB.TabIndex = 4;
            // 
            // uxNumMBLabel
            // 
            this.uxNumMBLabel.AutoSize = true;
            this.uxNumMBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxNumMBLabel.Location = new System.Drawing.Point(241, 263);
            this.uxNumMBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxNumMBLabel.Name = "uxNumMBLabel";
            this.uxNumMBLabel.Size = new System.Drawing.Size(210, 25);
            this.uxNumMBLabel.TabIndex = 5;
            this.uxNumMBLabel.Text = "Number of Megabytes:";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 350);
            this.Controls.Add(this.uxNumMBLabel);
            this.Controls.Add(this.uxNumMB);
            this.Controls.Add(this.uxFileSelectedLabel);
            this.Controls.Add(this.uxFileName);
            this.Controls.Add(this.uxCompute);
            this.Controls.Add(this.uxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.uxMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserInterface";
            this.Text = "ToMegabytes";
            this.uxMenu.ResumeLayout(false);
            this.uxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFile;
        private System.Windows.Forms.ToolStripMenuItem uxOpenFile;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.Button uxCompute;
        private System.Windows.Forms.TextBox uxFileName;
        private System.Windows.Forms.Label uxFileSelectedLabel;
        private System.Windows.Forms.TextBox uxNumMB;
        private System.Windows.Forms.Label uxNumMBLabel;
    }
}

