namespace JavaVersionManager
{
    partial class Manager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            label1 = new Label();
            versionsCombobox = new ComboBox();
            setButton = new Button();
            deleteButton = new Button();
            label2 = new Label();
            selectedversionlabel = new Label();
            settingsButton = new Button();
            refreshButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Versions:";
            // 
            // versionsCombobox
            // 
            versionsCombobox.FormattingEnabled = true;
            versionsCombobox.Location = new Point(67, 7);
            versionsCombobox.Name = "versionsCombobox";
            versionsCombobox.Size = new Size(178, 23);
            versionsCombobox.TabIndex = 1;
            // 
            // setButton
            // 
            setButton.Location = new Point(251, 7);
            setButton.Name = "setButton";
            setButton.Size = new Size(54, 23);
            setButton.TabIndex = 2;
            setButton.Text = "Set";
            setButton.UseVisualStyleBackColor = true;
            setButton.Click += setButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(311, 7);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(56, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 41);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Selected Version:";
            // 
            // selectedversionlabel
            // 
            selectedversionlabel.AutoSize = true;
            selectedversionlabel.Location = new Point(112, 41);
            selectedversionlabel.Name = "selectedversionlabel";
            selectedversionlabel.Size = new Size(34, 15);
            selectedversionlabel.TabIndex = 5;
            selectedversionlabel.Text = "none";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(301, 37);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(66, 23);
            settingsButton.TabIndex = 6;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(229, 37);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(66, 23);
            refreshButton.TabIndex = 7;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 66);
            Controls.Add(refreshButton);
            Controls.Add(settingsButton);
            Controls.Add(selectedversionlabel);
            Controls.Add(label2);
            Controls.Add(deleteButton);
            Controls.Add(setButton);
            Controls.Add(versionsCombobox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Manager";
            Text = "Java Version Manager";
            Load += Manager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox versionsCombobox;
        private Button setButton;
        private Button deleteButton;
        private Label label2;
        private Label selectedversionlabel;
        private Button settingsButton;
        private Button refreshButton;
    }
}
