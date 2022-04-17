using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Point_Of_Sale
{
    public partial class Form_Admin : KryptonForm
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        
        // used for store previously clicked button in the menu
        Button PreviousClicked = new Button();
        
        /// clicked on the menu item cheange previous clicked button to default and clicked
        /// button to the clciked color and assign clicked to previously clicked and check
        /// what is clicked by using switch case and display relevent form as child form
        /// or else close the form
        private void Btn_Menu_Clicked(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;
            PreviousClicked.BackColor = Color.FromArgb(41, 41, 41);
            Clicked.BackColor = Color.FromArgb(65, 70, 200);
            PreviousClicked = Clicked;
            switch (int.Parse(Clicked.Name.Split('_')[2]))
            {
                case 1:
                    Open_Child_Form(new Form_Admin_Reports());
                    break;
                case 2:
                    Open_Child_Form(new Form_Admin_Users());
                    break;
                case 3:
                    Open_Child_Form(new Form_Admin_Customers());
                    break;
                case 4:
                    Open_Child_Form(new Form_Admin_Products());
                    break;
                case 5:
                    Open_Child_Form(new Form_Admin_Company());
                    break;
                case 6:
                    this.Close();
                    break;
            }
        }
        
        // display child form inside main form by using form as parameter
        public void Open_Child_Form(Form Child_Form)
        {
            Panel_Dashboard_Form_Loader.Controls.Clear();
            Child_Form.FormBorderStyle = FormBorderStyle.None;
            Child_Form.Dock = DockStyle.Fill;
            Child_Form.TopLevel = false;
            Child_Form.TopMost = true;
            Child_Form.AutoSize = false;
            Child_Form.AutoScaleMode = AutoScaleMode.None;
            Panel_Dashboard_Form_Loader.Controls.Add(Child_Form);
            Child_Form.Show();
        }
        
        // load default child form when loading the main form and assign values for prevclicked
        private void Form_Admin_Load(object sender, EventArgs e)
        {
            Open_Child_Form(new Form_Admin_Reports());
            Btn_Report_1.BackColor = Color.FromArgb(65, 70, 200);
            PreviousClicked = Btn_Report_1;
        }
    }
}
