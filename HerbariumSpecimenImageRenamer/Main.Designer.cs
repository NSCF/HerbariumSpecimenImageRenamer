namespace HerbariumSpecimenImageRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.txtExcelFile = new System.Windows.Forms.TextBox();
            this.openDocFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 21);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(486, 65);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // btnRenameFiles
            // 
            this.btnRenameFiles.Enabled = false;
            this.btnRenameFiles.Location = new System.Drawing.Point(82, 161);
            this.btnRenameFiles.Name = "btnRenameFiles";
            this.btnRenameFiles.Size = new System.Drawing.Size(317, 48);
            this.btnRenameFiles.TabIndex = 1;
            this.btnRenameFiles.Text = "Rename Files";
            this.btnRenameFiles.UseVisualStyleBackColor = true;
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Location = new System.Drawing.Point(12, 120);
            this.txtExcelFile.Name = "txtExcelFile";
            this.txtExcelFile.Size = new System.Drawing.Size(484, 20);
            this.txtExcelFile.TabIndex = 10;
            // 
            // openDocFileButton
            // 
            this.openDocFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openDocFileButton.BackgroundImage")));
            this.openDocFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openDocFileButton.Location = new System.Drawing.Point(174, 80);
            this.openDocFileButton.Name = "openDocFileButton";
            this.openDocFileButton.Size = new System.Drawing.Size(43, 30);
            this.openDocFileButton.TabIndex = 9;
            this.openDocFileButton.UseVisualStyleBackColor = true;
            this.openDocFileButton.Click += new System.EventHandler(this.openDocFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose the Excel file:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 221);
            this.Controls.Add(this.txtExcelFile);
            this.Controls.Add(this.openDocFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenameFiles);
            this.Controls.Add(this.lblDescription);
            this.Name = "Main";
            this.Text = "Rename files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.TextBox txtExcelFile;
        private System.Windows.Forms.Button openDocFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

