using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace JavaVersionManager
{
    internal static class Program
    {
        [DllImport("shell32.dll")]
        internal static extern bool IsUserAnAdmin();

        static bool IsFileExtensionAssociated(string fileExtension, string progID)
        {
            RegistryKey extKey = Registry.ClassesRoot.OpenSubKey(fileExtension);
            if (extKey != null)
            {
                string associatedProgID = extKey.GetValue("") as string;
                extKey.Close();

                return associatedProgID == progID;
            }
            return false;
        }

        [STAThread]
        static void Main(string[] args)
        {
            
            try
            {
                
                if (!Directory.Exists("C:\\olcxja\\soft\\javamanager"))
                {
                    Directory.CreateDirectory("C:\\olcxja\\soft\\javamanager");
                }
   
                File.Copy(Process.GetCurrentProcess().MainModule.FileName, "C:\\olcxja\\soft\\javamanager\\JavaVersionManager.exe", true);

                if (!IsFileExtensionAssociated(".jar", "org.olcxja.jvm"))
                {
                    if (IsUserAnAdmin())
                    {
                        string fileExtension = ".jar";
                        string progID = "org.olcxja.jvm";
                        string applicationPath = "C:\\olcxja\\soft\\javamanager\\JavaVersionManager.exe";
                        RegistryKey extKey = Registry.ClassesRoot.CreateSubKey(fileExtension);
                        extKey.SetValue("", progID);
                        extKey.Close();
                        RegistryKey progIDKey = Registry.ClassesRoot.CreateSubKey(progID);
                        progIDKey.SetValue("", "Java Manager");
                        RegistryKey commandKey = progIDKey.CreateSubKey(@"shell\open\command");
                        commandKey.SetValue("", $"\"{applicationPath}\" \"%1\"");
                        commandKey.Close();
                    }
                    else
                    {
                        MessageBox.Show("If you want to associate .jar file extension with this program, run it as administrator");

                    }
                }
            }
            catch (Exception)
            {
            }





            
            {
                string vars = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
                if (vars.ToUpper().Contains("\\JAVA\\"))
                {
                    if (!IsUserAnAdmin())
                    {
                        MessageBox.Show("Java Environment Variables on administrator level detected. To run, you must first run this program with administrator privileges.\r\n\r\nRemember that this will disable your previous java installations", "Environment Variable Error");
                        Application.Exit();
                        return;
                    }
                    string newpath1 = "";
                    foreach (string var in vars.Split(';'))
                    {
                        if (!var.ToUpper().Contains("\\JAVA\\"))
                        {
                            if (newpath1 == "")
                            {
                                newpath1 = var;
                            }
                            else
                            {
                                newpath1 = newpath1 + ";" + var;
                            }
                        }
                    }
                    Environment.SetEnvironmentVariable("PATH", newpath1, EnvironmentVariableTarget.Machine);
                    MessageBox.Show("Cleaned Java Environment Variables on administrator level!");
                }
            }
            {
                string vars = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
                if (vars.ToUpper().Contains("\\JAVA\\"))
                {
                    string newpath1 = "";
                    foreach (string var in vars.Split(';'))
                    {
                        if (!var.ToUpper().Contains("\\JAVA\\"))
                        {
                            if (newpath1 == "")
                            {
                                newpath1 = var;
                            }
                            else
                            {
                                newpath1 = newpath1 + ";" + var;
                            }
                        }
                    }
                    Environment.SetEnvironmentVariable("PATH", newpath1, EnvironmentVariableTarget.User);
                    MessageBox.Show("Cleaned Java Environment Variables on user level!");
                }
            }
            

            string[] illegalFiles =
            {
                "appletviewer.exe", "extcheck.exe", "idlj.exe", "jabswitch.exe", "jar.exe", "jarsigner.exe", "java-rmi.exe",
                "java.exe", "javac.exe", "javadoc.exe", "javafxpackager.exe", "javah.exe", "javap.exe", "javapackager.exe",
                "javaw.exe", "javaws.exe", "jcmd.exe", "jconsole.exe", "jdb.exe", "jdeps.exe", "jhat.exe", "jinfo.exe",
                "jjs.exe", "jli.dll", "jmap.exe", "jmc.exe", "jmc.ini", "jps.exe", "jrunscript.exe", "jsadebugd.exe",
                "jstack.exe", "jstat.exe", "jstatd.exe", "jvisualvm.exe", "keytool.exe", "kinit.exe", "ktab.exe",
                "native2ascii.exe", "orbd.exe", "pack200.exe", "policytool.exe", "rmic.exe", "rmid.exe", "rmiregistry.exe",
                "schemagen.exe", "serialver.exe", "servertool.exe", "tnameserv.exe", "unpack200.exe", "wsgen.exe",
                "wsimport.exe", "xjc.exe"
            };


            foreach (var file in illegalFiles)
            {
                if (File.Exists("C:\\Windows\\System32\\" + file))
                {
                    if (!IsUserAnAdmin())
                    {
                        MessageBox.Show("Java files in windows detected. To run, you must first run this program with administrator privileges.\r\n\r\nRemember that this will remove your previous java installations", "Java System32 Error");
                        Application.Exit();
                        return;
                    }

                    ProcessStartInfo dsa = new ProcessStartInfo();
                    dsa.CreateNoWindow = true;

                    //deleting via cmd cause File can't access system32 for some reason
                    dsa.WorkingDirectory = "C:\\Windows\\System32";
                    dsa.FileName = "cmd.exe";
                    dsa.Arguments = $"/C del {file}";
                    Process.Start(dsa);
                }
            }
            try
            {
                JarLauncher.jarpath = args[0];
                if (args.Length > 1 && args[1] == "direct")
                {
                    Process.Start("java.exe", "-jar " + JarLauncher.jarpath);
                    Application.Exit();
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new JarLauncher());
            }
            catch (Exception)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Manager());
            }
        }
    }
}