namespace SaveClipboardScreenshot
{
    partial class ClipboardToScreenshot
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Action_Tab = new System.Windows.Forms.TabPage();
            this.Button_Save = new System.Windows.Forms.Button();
            this.TextBox_Prefix = new System.Windows.Forms.TextBox();
            this.Label_Prefix = new System.Windows.Forms.Label();
            this.Settings_Tab = new System.Windows.Forms.TabPage();
            this.Label_CreateSubFolder = new System.Windows.Forms.Label();
            this.CheckBox_SubFolder = new System.Windows.Forms.CheckBox();
            this.Button_SelectDirectory = new System.Windows.Forms.Button();
            this.ComboBox_Suffix = new System.Windows.Forms.ComboBox();
            this.TextBox_Directory = new System.Windows.Forms.TextBox();
            this.Label_Suffix = new System.Windows.Forms.Label();
            this.Label_SaveDirectory = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControl.SuspendLayout();
            this.Action_Tab.SuspendLayout();
            this.Settings_Tab.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Action_Tab);
            this.TabControl.Controls.Add(this.Settings_Tab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(465, 109);
            this.TabControl.TabIndex = 0;
            // 
            // Action_Tab
            // 
            this.Action_Tab.Controls.Add(this.Button_Save);
            this.Action_Tab.Controls.Add(this.TextBox_Prefix);
            this.Action_Tab.Controls.Add(this.Label_Prefix);
            this.Action_Tab.Location = new System.Drawing.Point(4, 22);
            this.Action_Tab.Name = "Action_Tab";
            this.Action_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Action_Tab.Size = new System.Drawing.Size(457, 83);
            this.Action_Tab.TabIndex = 0;
            this.Action_Tab.Text = "Action";
            this.Action_Tab.UseVisualStyleBackColor = true;
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(9, 45);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(442, 32);
            this.Button_Save.TabIndex = 2;
            this.Button_Save.Text = "Save Screenshot from Clipboard";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // TextBox_Prefix
            // 
            this.TextBox_Prefix.Location = new System.Drawing.Point(9, 19);
            this.TextBox_Prefix.Name = "TextBox_Prefix";
            this.TextBox_Prefix.Size = new System.Drawing.Size(442, 20);
            this.TextBox_Prefix.TabIndex = 1;
            // 
            // Label_Prefix
            // 
            this.Label_Prefix.AutoSize = true;
            this.Label_Prefix.Location = new System.Drawing.Point(6, 3);
            this.Label_Prefix.Name = "Label_Prefix";
            this.Label_Prefix.Size = new System.Drawing.Size(36, 13);
            this.Label_Prefix.TabIndex = 0;
            this.Label_Prefix.Text = "Prefix:";
            // 
            // Settings_Tab
            // 
            this.Settings_Tab.Controls.Add(this.Label_CreateSubFolder);
            this.Settings_Tab.Controls.Add(this.CheckBox_SubFolder);
            this.Settings_Tab.Controls.Add(this.Button_SelectDirectory);
            this.Settings_Tab.Controls.Add(this.ComboBox_Suffix);
            this.Settings_Tab.Controls.Add(this.TextBox_Directory);
            this.Settings_Tab.Controls.Add(this.Label_Suffix);
            this.Settings_Tab.Controls.Add(this.Label_SaveDirectory);
            this.Settings_Tab.Location = new System.Drawing.Point(4, 22);
            this.Settings_Tab.Name = "Settings_Tab";
            this.Settings_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_Tab.Size = new System.Drawing.Size(457, 83);
            this.Settings_Tab.TabIndex = 1;
            this.Settings_Tab.Text = "Settings";
            this.Settings_Tab.UseVisualStyleBackColor = true;
            // 
            // Label_CreateSubFolder
            // 
            this.Label_CreateSubFolder.AutoSize = true;
            this.Label_CreateSubFolder.Location = new System.Drawing.Point(17, 57);
            this.Label_CreateSubFolder.Name = "Label_CreateSubFolder";
            this.Label_CreateSubFolder.Size = new System.Drawing.Size(66, 13);
            this.Label_CreateSubFolder.TabIndex = 6;
            this.Label_CreateSubFolder.Text = "Sub Folders:";
            // 
            // CheckBox_SubFolder
            // 
            this.CheckBox_SubFolder.AutoSize = true;
            this.CheckBox_SubFolder.Location = new System.Drawing.Point(89, 57);
            this.CheckBox_SubFolder.Name = "CheckBox_SubFolder";
            this.CheckBox_SubFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBox_SubFolder.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_SubFolder.TabIndex = 5;
            this.CheckBox_SubFolder.UseVisualStyleBackColor = true;
            // 
            // Button_SelectDirectory
            // 
            this.Button_SelectDirectory.Location = new System.Drawing.Point(345, 30);
            this.Button_SelectDirectory.Name = "Button_SelectDirectory";
            this.Button_SelectDirectory.Size = new System.Drawing.Size(106, 23);
            this.Button_SelectDirectory.TabIndex = 4;
            this.Button_SelectDirectory.Text = "Select Directory";
            this.Button_SelectDirectory.UseVisualStyleBackColor = true;
            this.Button_SelectDirectory.Click += new System.EventHandler(this.Button_SelectDirectory_Click);
            // 
            // ComboBox_Suffix
            // 
            this.ComboBox_Suffix.FormattingEnabled = true;
            this.ComboBox_Suffix.Location = new System.Drawing.Point(89, 30);
            this.ComboBox_Suffix.Name = "ComboBox_Suffix";
            this.ComboBox_Suffix.Size = new System.Drawing.Size(250, 21);
            this.ComboBox_Suffix.TabIndex = 3;
            // 
            // TextBox_Directory
            // 
            this.TextBox_Directory.Location = new System.Drawing.Point(89, 6);
            this.TextBox_Directory.Name = "TextBox_Directory";
            this.TextBox_Directory.Size = new System.Drawing.Size(362, 20);
            this.TextBox_Directory.TabIndex = 2;
            // 
            // Label_Suffix
            // 
            this.Label_Suffix.AutoSize = true;
            this.Label_Suffix.Location = new System.Drawing.Point(47, 33);
            this.Label_Suffix.Name = "Label_Suffix";
            this.Label_Suffix.Size = new System.Drawing.Size(36, 13);
            this.Label_Suffix.TabIndex = 1;
            this.Label_Suffix.Text = "Suffix:";
            this.Label_Suffix.DoubleClick += new System.EventHandler(this.Label_Suffix_DoubleClick);
            // 
            // Label_SaveDirectory
            // 
            this.Label_SaveDirectory.AutoSize = true;
            this.Label_SaveDirectory.Location = new System.Drawing.Point(3, 9);
            this.Label_SaveDirectory.Name = "Label_SaveDirectory";
            this.Label_SaveDirectory.Size = new System.Drawing.Size(80, 13);
            this.Label_SaveDirectory.TabIndex = 0;
            this.Label_SaveDirectory.Text = "Save Directory:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 129);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(489, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.ToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // ClipboardToScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 151);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabControl);
            this.Name = "ClipboardToScreenshot";
            this.Text = "Clipboard to Screenshot";
            this.Load += new System.EventHandler(this.ClipboardToScreenshot_Load);
            this.TabControl.ResumeLayout(false);
            this.Action_Tab.ResumeLayout(false);
            this.Action_Tab.PerformLayout();
            this.Settings_Tab.ResumeLayout(false);
            this.Settings_Tab.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Action_Tab;
        private System.Windows.Forms.TabPage Settings_Tab;
        private System.Windows.Forms.Button Button_SelectDirectory;
        private System.Windows.Forms.ComboBox ComboBox_Suffix;
        private System.Windows.Forms.TextBox TextBox_Directory;
        private System.Windows.Forms.Label Label_Suffix;
        private System.Windows.Forms.Label Label_SaveDirectory;
        private System.Windows.Forms.Label Label_CreateSubFolder;
        private System.Windows.Forms.CheckBox CheckBox_SubFolder;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.TextBox TextBox_Prefix;
        private System.Windows.Forms.Label Label_Prefix;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
    }
}

