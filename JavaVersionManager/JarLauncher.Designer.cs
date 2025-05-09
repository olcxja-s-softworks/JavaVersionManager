namespace JavaVersionManager
{
    partial class JarLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarLauncher));
            label1 = new Label();
            versionsComboBox = new ComboBox();
            launchButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Java version:";
            // 
            // versionsComboBox
            // 
            versionsComboBox.FormattingEnabled = true;
            versionsComboBox.Location = new Point(88, 11);
            versionsComboBox.Name = "versionsComboBox";
            versionsComboBox.Size = new Size(155, 23);
            versionsComboBox.TabIndex = 1;
            // 
            // launchButton
            // 
            launchButton.Location = new Point(249, 11);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(75, 23);
            launchButton.TabIndex = 2;
            launchButton.Text = "Launch";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += launchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 34);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // JarLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 54);
            Controls.Add(label2);
            Controls.Add(launchButton);
            Controls.Add(versionsComboBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "JarLauncher";
            Text = "Launch .jar file";
            Load += JarLauncher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox versionsComboBox;
        private Button launchButton;
        private Label label2;
    }
}