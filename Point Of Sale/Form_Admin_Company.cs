using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Point_Of_Sale
{
    public partial class Form_Admin_Company : Form
    {
        public Form_Admin_Company()
        {
            InitializeComponent();
        }
        
        // path for the app data in the documents (User/MyDocument/PointOfSale)
        readonly private string UserPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PointOfSale");
        
        // Show password when user click on show password button
        private void Btn_Password_Show_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Password_Show.Image = new Bitmap(Properties.Resources.show_eye);
            Txt_Admin_Password.PasswordChar = '\0';
        }

        // hide password when user release mouse click
        private void Btn_Password_Show_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_Password_Show.Image = new Bitmap(Properties.Resources.hide_eye);
            Txt_Admin_Password.PasswordChar = '*';
        }

        readonly private Class_User User = new Class_User();

        // update company details when click on the update button
        private void Btn_Company_Update_Click(object sender, EventArgs e)
        {
            // path for text file stored inside document (User/MyDocument/PointOfSale/Company.txt)
            string TxtPath = Path.Combine(UserPath, "Company.Txt");
            try
            {
                if (Txt_Name.Text != "" && Txt_Address.Text != "" && Txt_Email.Text != "" && Txt_Phone.Text != "" && Txt_Admin_Password.Text != "")
                {
                    // delete text file and insert data to new text file
                    File.Delete(TxtPath);
                    User.Update_Admin(Txt_Admin_Password.Text);
                    using (StreamWriter TextFile = File.AppendText(TxtPath))
                    {
                        TextFile.WriteLine(Txt_Name.Text);
                        TextFile.WriteLine(Txt_Address.Text);
                        TextFile.WriteLine(Txt_Email.Text);
                        TextFile.WriteLine(Txt_Phone.Text);
                    }
                    ReadData();
                }
                else
                {
                    MessageBox.Show("All the Fields are Required", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // read data from the text file and update form data and update admin password
        private void ReadData()
        {
            string TxtPath = Path.Combine(UserPath, "Company.Txt");
            try
            {
                string[] Lines = File.ReadAllLines(TxtPath);
                if (File.Exists(TxtPath)){
                    Txt_Name.Text = Lines[0];
                    Txt_Address.Text = Lines[1];
                    Txt_Email.Text = Lines[2];
                    Txt_Phone.Text = Lines[3];
                }
                else
                {
                    MessageBox.Show("Error loading Please restart the application", "Reading error");
                }
                Txt_Admin_Password.Text = User.Retrieve_Admin_Password();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // load company data and admin password to the form
        private void Form_Admin_Company_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        // change company logo
        private void Btn_Select_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png) | *.png"
            };
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Image Logo;
                Logo = Image.FromFile(FileDialog.FileName);
                Picture_Logo.Image = Logo;
                Picture_Logo.Image.Save(Path.Combine(UserPath, "Logo.png"));
            }
        }
    }
}
