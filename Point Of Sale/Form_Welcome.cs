using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_Welcome : KryptonForm
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private readonly Class_User User = new Class_User();

        /// when user click on submit btn checks username and password to login if 
        /// username is admin then redirect to the admin page otherwise register page
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            //checks if username and password is not empty
            if (Txt_UName.Text != "" && Txt_Password.Text != "")
            {
                if (Txt_UName.Text == "admin")
                {
                    if (Txt_Password.Text == User.Retrieve_Admin_Password())
                    {
                        Lbl_Error.Visible = false;
                        Txt_UName.Text = "";
                        Txt_Password.Text = "";
                        this.Hide();
                        new Form_Admin().ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        Lbl_Error.Visible = true;
                    }
                }
                else if (User.Is_Valid_Credentials(Txt_UName.Text, Txt_Password.Text))
                {
                    Lbl_Error.Visible = false;
                    Txt_UName.Text = "";
                    Txt_Password.Text = "";
                    this.Hide();
                    new Form_Register().ShowDialog();
                    this.Show();
                }
                else
                {
                    Lbl_Error.Visible = true;
                }
            }
            //show error message if username or password is empty
            else MessageBox.Show("Please Enter UserName and Password", "Empty Fields!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // show/hide password
        private void Show_Password(object sender, MouseEventArgs e)
        {
            Txt_Password.PasswordChar = '\0';
            Btn_Password_Show.BackgroundImage = new Bitmap(Properties.Resources.hide_eye);
        }
        private void Hide_Password(object sender, MouseEventArgs e)
        {
            Txt_Password.PasswordChar = '*';
            Btn_Password_Show.BackgroundImage = new Bitmap(Properties.Resources.show_eye);
        }
    }
}
