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
            if(Txt_Answer1.Text.Trim() == "" || Txt_Answer2.Text.Trim() == "" || (Txt_Answer3.Visible == true && Txt_Answer3.Text.Trim() == ""))
            {
                MessageBox.Show("All Fields are required");
                return;
            }
            this.Close();
        }
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
            this.Close();
        }

        // set values for the question and answer by using title and value as parameters
        public void Set_Values(string Question1, string Question2, string Question3, string Answer1, string Answer2, string Answer3)
        {
            Set_Values(Question1, Question2, Answer1, Answer2);
            Set_Values(Question1, Question2, Question3);
            Txt_Answer3.Text = Answer3;
        }
        public void Set_Values(string Question1, string Question2, string Answer1, string Answer2)
        {
            Set_Values(Question1, Question2);
            Txt_Answer1.Text = Answer1;
            Txt_Answer2.Text = Answer2;
        }
        public void Set_Values(string Question1, string Question2, string Question3)
        {
            Set_Values(Question1, Question2);
            Lbl_Question3.Text = Question3;
            Lbl_Question3.Visible = true;
            Txt_Answer3.Visible = true;
        }
        public void Set_Values(string Question1, string Question2)
        {
            Cancel = false;
            Lbl_Question1.Text = Question1;
            Lbl_Question2.Text = Question2;
            Lbl_Question3.Visible = false;
            Txt_Answer3.Visible = false;
        }

        // return value for the user inserted value
        public string Get_Value1()
        {
            return Txt_Answer1.Text;
        }
        public string Get_Value2()
        {
            return Txt_Answer2.Text;
        }
        public string Get_Value3()
        {
            return Txt_Answer3.Text;
        }
    }
}
