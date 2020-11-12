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
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenu
            // 
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFile});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(616, 24);
            this.uxMenu.TabIndex = 0;
            this.uxMenu.Text = "menuStrip1";
            // 
            // uxFile
            // 
            this.uxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenFile});
            this.uxFile.Name = "uxFile";
            this.uxFile.Size = new System.Drawing.Size(37, 20);
            this.uxFile.Text = "File";
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.Name = "uxOpenFile";
            this.uxOpenFile.Size = new System.Drawing.Size(180, 22);
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
            this.uxCompute.Location = new System.Drawing.Point(218, 349);
            this.uxCompute.Name = "uxCompute";
            this.uxCompute.Size = new System.Drawing.Size(181, 88);
            this.uxCompute.TabIndex = 1;
            this.uxCompute.Text = "Compute";
            this.uxCompute.UseVisualStyleBackColor = true;
            // 
            // uxFileName
            // 
            this.uxFileName.Location = new System.Drawing.Point(92, 54);
            this.uxFileName.Name = "uxFileName";
            this.uxFileName.Size = new System.Drawing.Size(372, 20);
            this.uxFileName.TabIndex = 2;
            // 
            // uxFileSelectedLabel
            // 
            this.uxFileSelectedLabel.AutoSize = true;
            this.uxFileSelectedLabel.Location = new System.Drawing.Point(12, 57);
            this.uxFileSelectedLabel.Name = "uxFileSelectedLabel";
            this.uxFileSelectedLabel.Size = new System.Drawing.Size(74, 13);
            this.uxFileSelectedLabel.TabIndex = 3;
            this.uxFileSelectedLabel.Text = "Selected File: ";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 493);
            this.Controls.Add(this.uxFileSelectedLabel);
            this.Controls.Add(this.uxFileName);
            this.Controls.Add(this.uxCompute);
            this.Controls.Add(this.uxMenu);
            this.MainMenuStrip = this.uxMenu;
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
    }
}

