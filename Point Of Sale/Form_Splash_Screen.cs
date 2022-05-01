using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Diagnostics;

namespace Point_Of_Sale
{
    public partial class Form_Splash_Screen : KryptonForm
    {
        public Form_Splash_Screen()
        {
            InitializeComponent();
        }

        private bool Finished = false, Skip = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!Skip)
            {
                Circle_Progress_1.Percentage += 1;
                Flat_Progress_1.Value = Circle_Progress_1.Percentage;
                Flat_Progress_2.Value = Circle_Progress_1.Percentage;
            }
            if(Circle_Progress_1.Percentage == 60 && !Finished)
            {
                Skip = true;
            }
            switch (Lbl_Loading.Text.Split(' ').Length)
            {
                case 1:
                    Lbl_Loading.Text = "LOADING .";
                    break;
                case 2:
                    Lbl_Loading.Text = "LOADING . .";
                    break;
                case 3:
                    Lbl_Loading.Text = "LOADING . . .";
                    break;
                default:
                    Lbl_Loading.Text = "LOADING";
                    break;
            }
            if (Finished)
            {
                Skip = false;
                Timer1.Interval = 15;
            }
            if(Circle_Progress_1.Percentage == 100 && Finished)
            {
                Timer1.Stop();
                this.Close();
            }
        }

        private void Form_Splash_Screen_Load(object sender, EventArgs e)
        {
            Circle_Progress_1.Percentage = 0;
            Flat_Progress_1.Value = Flat_Progress_2.Value = 0;
            Timer1.Start();
            // start another process in new thread
            Task.Run(() =>
            {
                if (Pre_Requirements())
                {
                    Finished = true;
                }
                else
                {
                    Environment.Exit(0);
                }
            });
        }

        // check all the pre requirements before load the system
        private bool Pre_Requirements()
        {
            Class_Database DB = new Class_Database();
            bool success = DB.TestConnection();
            if (!success)
            {
                Timer1.Stop();
                /// after install in C drive some access are restricted for database file
                /// in that case use process called change permission to get access for the
                /// database files in the same directory
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), "ChangePermissions.exe"))
                    {
                        UseShellExecute = true,
                        Verb = "runas"
                    };
                    Process.Start(startInfo);
                }
                catch
                {
                    MessageBox.Show("Please run as administrator to remove this error");
                }
                DialogResult result = MessageBox.Show("Error Cant Connect to the database Please Restart the Application", "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    System.Threading.Thread.Sleep(500);
                    Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "Point Of Sale.exe"));
                }
                return false;
            }
            string TxtPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PointOfSale");
            if (!Directory.Exists(TxtPath))
            {
                Directory.CreateDirectory(TxtPath);
            }
            string LogoPath = Path.Combine(TxtPath, "Logo.png");
            TxtPath = Path.Combine(TxtPath, "Company.txt");
            if (!File.Exists(TxtPath))
            {
                using (StreamWriter TextFile = File.AppendText(TxtPath))
                {
                    TextFile.WriteLine("Company");
                    TextFile.WriteLine("Company, Company City, Company Country.");
                    TextFile.WriteLine("info@company.org");
                    TextFile.WriteLine("011 123 4567");
                }
            }
            if (!File.Exists(LogoPath))
            {
                Image Logo = Properties.Resources.company_logo;
                Logo.Save(LogoPath);
            }
            System.Threading.Thread.Sleep(500);
            return true;
        }
    }
}
