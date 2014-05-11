namespace DriveSpace
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDirectoryAdd = new System.Windows.Forms.Button();
            this.listDirectories = new System.Windows.Forms.ListBox();
            this.btnDirectoryDelete = new System.Windows.Forms.Button();
            this.btnDirectoryUpdate = new System.Windows.Forms.Button();
            this.driveUsedGraph = new System.Windows.Forms.ProgressBar();
            this.txtDriveTotalSpace = new System.Windows.Forms.TextBox();
            this.lblDriveTotalSpace = new System.Windows.Forms.Label();
            this.lblDriveUsedSpace = new System.Windows.Forms.Label();
            this.txtDriveUsedSpace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDriveUsedSpaceGraphPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDirectoryToolStripMenuItem,
            this.allDirectoriesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDirectoryToolStripMenuItem
            // 
            this.newDirectoryToolStripMenuItem.Name = "newDirectoryToolStripMenuItem";
            this.newDirectoryToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newDirectoryToolStripMenuItem.Text = "New Directory...";
            // 
            // allDirectoriesToolStripMenuItem
            // 
            this.allDirectoriesToolStripMenuItem.Name = "allDirectoriesToolStripMenuItem";
            this.allDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.allDirectoriesToolStripMenuItem.Text = "All Directories";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // btnDirectoryAdd
            // 
            this.btnDirectoryAdd.Location = new System.Drawing.Point(15, 21);
            this.btnDirectoryAdd.Name = "btnDirectoryAdd";
            this.btnDirectoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryAdd.TabIndex = 1;
            this.btnDirectoryAdd.Text = "Add";
            this.btnDirectoryAdd.UseVisualStyleBackColor = true;
            // 
            // listDirectories
            // 
            this.listDirectories.FormattingEnabled = true;
            this.listDirectories.Location = new System.Drawing.Point(108, 21);
            this.listDirectories.Name = "listDirectories";
            this.listDirectories.Size = new System.Drawing.Size(240, 121);
            this.listDirectories.TabIndex = 2;
            // 
            // btnDirectoryDelete
            // 
            this.btnDirectoryDelete.Location = new System.Drawing.Point(15, 79);
            this.btnDirectoryDelete.Name = "btnDirectoryDelete";
            this.btnDirectoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryDelete.TabIndex = 3;
            this.btnDirectoryDelete.Text = "Delete";
            this.btnDirectoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnDirectoryUpdate
            // 
            this.btnDirectoryUpdate.Location = new System.Drawing.Point(15, 50);
            this.btnDirectoryUpdate.Name = "btnDirectoryUpdate";
            this.btnDirectoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryUpdate.TabIndex = 4;
            this.btnDirectoryUpdate.Text = "Update";
            this.btnDirectoryUpdate.UseVisualStyleBackColor = true;
            // 
            // driveUsedGraph
            // 
            this.driveUsedGraph.Location = new System.Drawing.Point(253, 16);
            this.driveUsedGraph.Name = "driveUsedGraph";
            this.driveUsedGraph.Size = new System.Drawing.Size(46, 100);
            this.driveUsedGraph.TabIndex = 5;
            // 
            // txtDriveTotalSpace
            // 
            this.txtDriveTotalSpace.Enabled = false;
            this.txtDriveTotalSpace.Location = new System.Drawing.Point(105, 55);
            this.txtDriveTotalSpace.Name = "txtDriveTotalSpace";
            this.txtDriveTotalSpace.Size = new System.Drawing.Size(100, 20);
            this.txtDriveTotalSpace.TabIndex = 6;
            // 
            // lblDriveTotalSpace
            // 
            this.lblDriveTotalSpace.AutoSize = true;
            this.lblDriveTotalSpace.Location = new System.Drawing.Point(6, 58);
            this.lblDriveTotalSpace.Name = "lblDriveTotalSpace";
            this.lblDriveTotalSpace.Size = new System.Drawing.Size(93, 13);
            this.lblDriveTotalSpace.TabIndex = 7;
            this.lblDriveTotalSpace.Text = "Total Drive Space";
            // 
            // lblDriveUsedSpace
            // 
            this.lblDriveUsedSpace.AutoSize = true;
            this.lblDriveUsedSpace.Location = new System.Drawing.Point(5, 88);
            this.lblDriveUsedSpace.Name = "lblDriveUsedSpace";
            this.lblDriveUsedSpace.Size = new System.Drawing.Size(94, 13);
            this.lblDriveUsedSpace.TabIndex = 8;
            this.lblDriveUsedSpace.Text = "Used Drive Space";
            // 
            // txtDriveUsedSpace
            // 
            this.txtDriveUsedSpace.Enabled = false;
            this.txtDriveUsedSpace.Location = new System.Drawing.Point(105, 85);
            this.txtDriveUsedSpace.Name = "txtDriveUsedSpace";
            this.txtDriveUsedSpace.Size = new System.Drawing.Size(100, 20);
            this.txtDriveUsedSpace.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnDirectoryAdd);
            this.groupBox1.Controls.Add(this.btnDirectoryDelete);
            this.groupBox1.Controls.Add(this.btnDirectoryUpdate);
            this.groupBox1.Controls.Add(this.listDirectories);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.txtDriveLetter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDriveUsedSpaceGraphPercent);
            this.groupBox2.Controls.Add(this.txtDriveTotalSpace);
            this.groupBox2.Controls.Add(this.lblDriveTotalSpace);
            this.groupBox2.Controls.Add(this.driveUsedGraph);
            this.groupBox2.Controls.Add(this.txtDriveUsedSpace);
            this.groupBox2.Controls.Add(this.lblDriveUsedSpace);
            this.groupBox2.Location = new System.Drawing.Point(385, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 140);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drive Info";
            // 
            // lblDriveUsedSpaceGraphPercent
            // 
            this.lblDriveUsedSpaceGraphPercent.AutoSize = true;
            this.lblDriveUsedSpaceGraphPercent.Location = new System.Drawing.Point(270, 122);
            this.lblDriveUsedSpaceGraphPercent.Name = "lblDriveUsedSpaceGraphPercent";
            this.lblDriveUsedSpaceGraphPercent.Size = new System.Drawing.Size(15, 13);
            this.lblDriveUsedSpaceGraphPercent.TabIndex = 10;
            this.lblDriveUsedSpaceGraphPercent.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Drive";
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Enabled = false;
            this.txtDriveLetter.Location = new System.Drawing.Point(105, 26);
            this.txtDriveLetter.Name = "txtDriveLetter";
            this.txtDriveLetter.Size = new System.Drawing.Size(100, 20);
            this.txtDriveLetter.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Drive Space";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.Button btnDirectoryAdd;
        private System.Windows.Forms.ListBox listDirectories;
        private System.Windows.Forms.Button btnDirectoryDelete;
        private System.Windows.Forms.Button btnDirectoryUpdate;
        private System.Windows.Forms.ProgressBar driveUsedGraph;
        private System.Windows.Forms.TextBox txtDriveTotalSpace;
        private System.Windows.Forms.Label lblDriveTotalSpace;
        private System.Windows.Forms.Label lblDriveUsedSpace;
        private System.Windows.Forms.TextBox txtDriveUsedSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDriveUsedSpaceGraphPercent;
    }
}

