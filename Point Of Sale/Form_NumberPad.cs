using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Point_Of_Sale
{
    public partial class Form_NumberPad : KryptonForm
    {
        // return vatiable for user inserted value
        public double Form_Return = 1;

        public Form_NumberPad()
        {
            InitializeComponent();
        }

        // close the form
        private void Btn_Escape_Click(object sender, EventArgs e)
        {
            
            Form_Return = -1;
            this.Close();
        }

        /// check if null or lessthan or equals to the 0 then return 1
        /// otherwise return value inside the form
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Value.Text == "" && int.Parse(Txt_Value.Text) < 0)
                {
                    Form_Return = 1;
                }
                else
                {
                    Form_Return = double.Parse(Txt_Value.Text);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // only insert numbers and one decimal
        private void Txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        // clear one number from the value
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            if(Txt_Value.Text.Length > 0)
            {
                Txt_Value.Text = Txt_Value.Text.Remove(Txt_Value.Text.Length - 1);
            }
        }

        // insert clicked number to the value
        private void Number_Pad_Click(object sender, EventArgs e)
        {
            Button Clicked_Btn = sender as Button;
            Txt_Value.Text += Clicked_Btn.Text;
        }

    }
}
