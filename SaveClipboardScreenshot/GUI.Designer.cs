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
            this.Settings_Tab = new System.Windows.Forms.TabPage();
            this.Button_SelectDirectory = new System.Windows.Forms.Button();
            this.ComboBox_Suffix = new System.Windows.Forms.ComboBox();
            this.TextBox_Directory = new System.Windows.Forms.TextBox();
            this.Label_Suffix = new System.Windows.Forms.Label();
            this.Label_SaveDirectory = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.Settings_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Action_Tab);
            this.TabControl.Controls.Add(this.Settings_Tab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(465, 92);
            this.TabControl.TabIndex = 0;
            // 
            // Action_Tab
            // 
            this.Action_Tab.Location = new System.Drawing.Point(4, 22);
            this.Action_Tab.Name = "Action_Tab";
            this.Action_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Action_Tab.Size = new System.Drawing.Size(457, 66);
            this.Action_Tab.TabIndex = 0;
            this.Action_Tab.Text = "Action";
            this.Action_Tab.UseVisualStyleBackColor = true;
            // 
            // Settings_Tab
            // 
            this.Settings_Tab.Controls.Add(this.Button_SelectDirectory);
            this.Settings_Tab.Controls.Add(this.ComboBox_Suffix);
            this.Settings_Tab.Controls.Add(this.TextBox_Directory);
            this.Settings_Tab.Controls.Add(this.Label_Suffix);
            this.Settings_Tab.Controls.Add(this.Label_SaveDirectory);
            this.Settings_Tab.Location = new System.Drawing.Point(4, 22);
            this.Settings_Tab.Name = "Settings_Tab";
            this.Settings_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_Tab.Size = new System.Drawing.Size(457, 66);
            this.Settings_Tab.TabIndex = 1;
            this.Settings_Tab.Text = "Settings";
            this.Settings_Tab.UseVisualStyleBackColor = true;
            // 
            // Button_SelectDirectory
            // 
            this.Button_SelectDirectory.Location = new System.Drawing.Point(345, 30);
            this.Button_SelectDirectory.Name = "Button_SelectDirectory";
            this.Button_SelectDirectory.Size = new System.Drawing.Size(106, 23);
            this.Button_SelectDirectory.TabIndex = 4;
            this.Button_SelectDirectory.Text = "Select Directory";
            this.Button_SelectDirectory.UseVisualStyleBackColor = true;
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
            // ClipboardToScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 113);
            this.Controls.Add(this.TabControl);
            this.Name = "ClipboardToScreenshot";
            this.Text = "Clipboard to Screenshot";
            this.TabControl.ResumeLayout(false);
            this.Settings_Tab.ResumeLayout(false);
            this.Settings_Tab.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

