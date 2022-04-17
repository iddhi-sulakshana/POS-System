using System;
using System.Windows.Forms;

namespace Point_Of_Sale
{
    public partial class Form_User_Input : Form
    {
        public Form_User_Input()
        {
            InitializeComponent();
        }

        // check from other forms if cancelled
        public bool Cancel;

        // close the form
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            this.Close();
        }

        // set values for the question and answer by using title and value as parameters
        public void Set_Values(string Title, string Value)
        {
            Cancel = false;
            Lbl_Title.Text = Title;
            Txt_Answer.Text = Value;
        }

        // return value for the user inserted value
        public string Get_Value()
        {
            return Txt_Answer.Text;
        }
    }
}
