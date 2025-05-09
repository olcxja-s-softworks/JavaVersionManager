using System.Text;

namespace JavaVersionManager
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        public static string homedir = "C:\\olcxja\\soft\\javamanager";
        public static string settingsfile = "C:\\olcxja\\soft\\javamanager\\settings.cfg";
        public static string javadir = "";

        private void Manager_Load(object sender, EventArgs e)
        {
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
            foreach (string dir in Directory.GetDirectories(javadir))
            {
                versionsCombobox.Items.Add(Path.GetFileName(dir));
            }
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            foreach (string var in currentPath.Split(';'))
            {
                foreach (var item in versionsCombobox.Items)
                {
                    if (var.Contains($"\\JavaVersions\\{item}\\"))
                    {
                        selectedversionlabel.Text = item.ToString();
                    }
                }


            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (versionsCombobox.SelectedItem.ToString().Length > 0)
                {
                    string currentPath1 = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

                    string newpath1 = javadir + "\\" + versionsCombobox.SelectedItem.ToString() + "\\bin";
                    foreach (string var in currentPath1.Split(';'))
                    {
                        if (!var.Contains("\\JavaVersions\\"))
                        {
                            newpath1 = newpath1 + ";" + var;
                        }
                    }
                    Environment.SetEnvironmentVariable("PATH", newpath1, EnvironmentVariableTarget.User);
                    selectedversionlabel.Text = versionsCombobox.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Select java version from list, if you do not see your java version import it from settings");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select java version from list, if you do not see your java version import it from settings");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (versionsCombobox.SelectedItem.ToString().Length > 0)
                {
                    foreach (var item in Directory.GetFiles(javadir + "\\" + versionsCombobox.SelectedItem.ToString(), ".", SearchOption.AllDirectories))
                    {
                        FileInfo file = new FileInfo(item);
                        file.IsReadOnly = false;
                        File.Delete(item);
                    }
                    Directory.Delete(javadir + "\\" + versionsCombobox.SelectedItem.ToString(), true);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error while deleting java version"); }
            refreshversions();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshversions();
        }

        public void refreshversions()
        {
            string saved = "";

            try
            {
                saved = versionsCombobox.SelectedItem.ToString();
            }
            catch (Exception) { }
            versionsCombobox.Items.Clear();
            foreach (string dir in Directory.GetDirectories(javadir))
            {
                versionsCombobox.Items.Add(Path.GetFileName(dir));
            }
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            foreach (string var in currentPath.Split(';'))
            {
                foreach (var item in versionsCombobox.Items)
                {
                    if (var.Contains($"\\JavaVersions\\{item}\\"))
                    {
                        selectedversionlabel.Text = item.ToString();
                    }
                }


            }
            try
            {
                versionsCombobox.SelectedItem = saved;
            }
            catch (Exception) { }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.ShowDialog();
        }
    }
}
