using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_Admin_Users : Form
    {
        public Form_Admin_Users()
        {
            InitializeComponent();
        }

        readonly Class_User User = new Class_User();

        // store previously clicked panel and clicked id
        private Panel PreviouslyClicked = new Panel();
        private int Selected = -1;

        // load users to the user product loader
        private void Form_Admin_Users_Load(object sender, EventArgs e)
        {
            Update_User_List();
        }

        // insert user to the user product loader by using id, name, password as parameters
        private void Insert_User(int Number, string Name, string Password)
        {
            Panel ChildUser = new Panel
            {
                Name = $"Panel_User_{Number}",
                Dock = DockStyle.Top,
                Height = 50
            };
            Font font = new Font("Arial", 18);
            // Create Label Name
            Label LblName = new Label
            {
                Name = $"User_Label_Name_{Number}",
                Font = font,
                Text = Name,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.White
            };
            LblName.Click += User_Label_Clicked;
            // Create TxtBox Password
            TextBox TxtPassword = new TextBox
            {
                Name = $"User_Txt_Password_{Number}",
                PasswordChar = '*',
                Font = font,
                Text = Password,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(51, 51, 51),
                BorderStyle = BorderStyle.None,
                ForeColor = Color.White,
                ReadOnly = true,
                TabStop = false
            };
            TxtPassword.Click += User_Label_Clicked;
            // Create Show Button 
            Button BtnShow = new Button
            {
                Name = $"User_Show_Btn_{Number}",
                BackgroundImage = new Bitmap(Properties.Resources.hide_eye),
                BackgroundImageLayout = ImageLayout.Zoom,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };
            BtnShow.MouseDown += Show_Password;
            BtnShow.MouseUp += Hide_Password;

            //Create Table Panel
            TableLayoutPanel Table = new TableLayoutPanel
            {
                Name = $"Table_User_Details_{Number}",
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3
            };
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48));
            Table.Controls.Add(LblName, 0, 0);
            Table.Controls.Add(TxtPassword, 1, 0);
            Table.Controls.Add(BtnShow, 2, 0);

            // Insert to Main Panel
            ChildUser.Controls.Add(Table);
            Panel_User_Loader.Controls.Add(ChildUser);
            Panel_User_Loader.Controls.SetChildIndex(ChildUser, 0);
        }
        
        // show password when user click on the show password button
        private void Show_Password(object sender, MouseEventArgs e)
        {
            Button Clicked = sender as Button;
            Clicked.BackgroundImage = new Bitmap(Properties.Resources.show_eye);
            TextBox ClickedTextBox = Clicked.Parent.Controls[1] as TextBox;
            ClickedTextBox.PasswordChar = '\0';
        }

        // hide password when user release mouse click
        private void Hide_Password(object sender, MouseEventArgs e)
        {
            Button Clicked = sender as Button;
            Clicked.BackgroundImage = new Bitmap(Properties.Resources.hide_eye);
            TextBox ClickedTextBox = Clicked.Parent.Controls[1] as TextBox;
            ClickedTextBox.PasswordChar = '*';
        }

        // change clicked status to the current clicked label
        private void User_Label_Clicked(object sender, EventArgs e)
        {
            PreviouslyClicked.BackColor = Color.FromArgb(51, 51, 51);
            if (sender.GetType().Name == "Label")
            {
                Label Clicked = sender as Label;
                Selected = int.Parse(Clicked.Name.Split('_')[3]);
                Clicked.Parent.BackColor = Color.FromArgb(65, 70, 200);
                PreviouslyClicked = Clicked.Parent as Panel;
            }
            else if(sender.GetType().Name == "TextBox")
            {
                TextBox Clicked = sender as TextBox;
                Selected = int.Parse(Clicked.Name.Split('_')[3]);
                Clicked.Parent.BackColor = Color.FromArgb(65, 70, 200);
                PreviouslyClicked = Clicked.Parent as Panel;
            }
            Update_Buttons();
        }

        // delete selected user from the database and reload the user list
        private void Btn_User_Delete_Click(object sender, EventArgs e)
        {
            DialogResult UserAccept = MessageBox.Show("Are you sure you want to delete this", "Deleting Item", MessageBoxButtons.YesNo);
            if (UserAccept == DialogResult.Yes)
            {
                User.Delete_User(Selected);
                Update_User_List();
            }
        }

        // update buttons based on the clicked status
        private void Update_Buttons()
        {
            if(Selected != -1)
            {
                Btn_User_Edit.Enabled = true;
                Btn_User_Delete.Enabled = true;
                Btn_User_Edit.BackColor = Color.FromArgb(31, 31, 31);
                Btn_User_Delete.BackColor = Color.FromArgb(215, 0, 0); 
            }
            else
            {
                Btn_User_Edit.Enabled = false;
                Btn_User_Delete.Enabled = false;
                Btn_User_Edit.BackColor = Color.FromArgb(51,51,51);
                Btn_User_Delete.BackColor = Color.FromArgb(255, 60, 60);
            }
        }

        /// edit selected user details in the database by using user inserted 
        /// values for name and password
        private void Btn_User_Edit_Click(object sender, EventArgs e)
        {
            // used for get user inputs
            Form_User_Input GetInput = new Form_User_Input();
            GetInput.Set_Values("Username", "Password", PreviouslyClicked.Controls[0].Text, PreviouslyClicked.Controls[1].Text);
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                if (User.Is_UserName_Exist(GetInput.Get_Value1()))
                {
                    MessageBox.Show("Username already exist");
                }
                else
                {
                    User.Update_User(Selected, GetInput.Get_Value1(), GetInput.Get_Value2());
                    Update_User_List();
                }
            }
        }

        /// insert user to the database by using user inserted values for
        /// name and password
        private void Btn_User_Add_Click(object sender, EventArgs e)
        {

            // used for get user inputs
            Form_User_Input GetInput = new Form_User_Input();
            GetInput.Set_Values("Username", "Password");
            GetInput.ShowDialog();
            if (!GetInput.Cancel)
            {
                if (User.Is_UserName_Exist(GetInput.Get_Value1()))
                {
                    MessageBox.Show("Username already exist");
                }
                else
                {
                    User.Insert_User(GetInput.Get_Value1(), GetInput.Get_Value2());
                    Update_User_List();
                }
            }
        }

        /// update user list in the user loader panel by getting user
        /// list from the database
        private void Update_User_List()
        {
            PreviouslyClicked = new Panel();
            Selected = -1;
            Panel_User_Loader.Controls.Clear();
            List<UserStruct> Users = User.Retrieve_Users();
            foreach(UserStruct User in Users)
            {
                Insert_User(User.Id, User.Name, User.Password);
            }
            Update_Buttons();
        } 
    }
}
