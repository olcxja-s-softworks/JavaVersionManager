using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JavaVersionManager
{
    public partial class JarLauncher : Form
    {
        public static string jarpath = "";

        public static string homedir = "C:\\olcxja\\soft\\javamanager";
        public static string settingsfile = "C:\\olcxja\\soft\\javamanager\\settings.cfg";
        public static string javadir = "";
        public JarLauncher()
        {
            InitializeComponent();
        }

        private void JarLauncher_Load(object sender, EventArgs e)
        {
            label2.Text = jarpath;
            if (!Directory.Exists(homedir))
            {
                Directory.CreateDirectory(homedir);
            }
            if (!File.Exists(settingsfile))
            {
                using (FileStream fs = File.Create(settingsfile))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("javadir|C:\\JavaVersions");

                    fs.Write(info, 0, info.Length);
                }
            }
            foreach (string line in File.ReadAllLines(settingsfile))
            {
                string[] setting = line.Split('|');
                switch (setting[0])
                {
                    case "javadir":
                        javadir = setting[1];
                        break;
                }
            }
            if (!Directory.Exists(javadir))
            {
                Directory.CreateDirectory(javadir);
            }
            refreshversions();
        }
        public void refreshversions()
        {
            string saved = "";

            try
            {
                saved = versionsComboBox.SelectedItem.ToString();
            }
            catch (Exception) { }
            versionsComboBox.Items.Clear();
            foreach (string dir in Directory.GetDirectories(javadir))
            {
                versionsComboBox.Items.Add(Path.GetFileName(dir));
            }
            try
            {
                versionsComboBox.SelectedItem = saved;
            }
            catch (Exception) { }
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            try
            {

                Process.Start(javadir + "\\" + versionsComboBox.SelectedItem.ToString() + "\\bin\\java.exe", $"-jar \"{jarpath}\"");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Launch error");
            }
        }
    }
}
