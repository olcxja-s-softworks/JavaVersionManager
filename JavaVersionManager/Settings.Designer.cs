namespace JavaVersionManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label1 = new Label();
            javadirTextBox = new TextBox();
            dirhelpButton = new Button();
            saveButton = new Button();
            importhelpButton = new Button();
            importButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Java directory:";
            // 
            // javadirTextBox
            // 
            javadirTextBox.Location = new Point(97, 6);
            javadirTextBox.Name = "javadirTextBox";
            javadirTextBox.Size = new Size(364, 23);
            javadirTextBox.TabIndex = 1;
            // 
            // dirhelpButton
            // 
            dirhelpButton.Location = new Point(542, 6);
            dirhelpButton.Name = "dirhelpButton";
            dirhelpButton.Size = new Size(23, 23);
            dirhelpButton.TabIndex = 2;
            dirhelpButton.Text = "?";
            dirhelpButton.UseVisualStyleBackColor = true;
            dirhelpButton.Click += dirhelpButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(467, 6);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(69, 23);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // importhelpButton
            // 
            importhelpButton.Location = new Point(542, 46);
            importhelpButton.Name = "importhelpButton";
            importhelpButton.Size = new Size(23, 23);
            importhelpButton.TabIndex = 4;
            importhelpButton.Text = "?";
            importhelpButton.UseVisualStyleBackColor = true;
            importhelpButton.Click += importhelpButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(9, 46);
            importButton.Name = "importButton";
            importButton.Size = new Size(176, 23);
            importButton.TabIndex = 5;
            importButton.Text = "Import new Java version";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 81);
            Controls.Add(importButton);
            Controls.Add(importhelpButton);
            Controls.Add(saveButton);
            Controls.Add(dirhelpButton);
            Controls.Add(javadirTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox javadirTextBox;
        private Button dirhelpButton;
        private Button saveButton;
        private Button importhelpButton;
        private Button importButton;
    }
}