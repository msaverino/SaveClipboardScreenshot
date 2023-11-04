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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Suffix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TabControl.Size = new System.Drawing.Size(465, 206);
            this.TabControl.TabIndex = 0;
            // 
            // Action_Tab
            // 
            this.Action_Tab.Location = new System.Drawing.Point(4, 22);
            this.Action_Tab.Name = "Action_Tab";
            this.Action_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Action_Tab.Size = new System.Drawing.Size(457, 180);
            this.Action_Tab.TabIndex = 0;
            this.Action_Tab.Text = "Action";
            this.Action_Tab.UseVisualStyleBackColor = true;
            // 
            // Settings_Tab
            // 
            this.Settings_Tab.Controls.Add(this.button1);
            this.Settings_Tab.Controls.Add(this.comboBox1);
            this.Settings_Tab.Controls.Add(this.textBox1);
            this.Settings_Tab.Controls.Add(this.Label_Suffix);
            this.Settings_Tab.Controls.Add(this.label1);
            this.Settings_Tab.Location = new System.Drawing.Point(4, 22);
            this.Settings_Tab.Name = "Settings_Tab";
            this.Settings_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Settings_Tab.Size = new System.Drawing.Size(457, 180);
            this.Settings_Tab.TabIndex = 1;
            this.Settings_Tab.Text = "Settings";
            this.Settings_Tab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Directory:";
            // 
            // ClipboardToScreenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 230);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Suffix;
        private System.Windows.Forms.Label label1;
    }
}

