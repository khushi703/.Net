using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28lab2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CheckTextBox2Value()
        {
            if (int.TryParse(TextBox2.Text, out int value2) && value2 == 0)
            {
                TextBox2.BackColor = System.Drawing.Color.Red;  
                Button5.Enabled = false;                        
            }

        }
        protected void addition(object sender, EventArgs e)
        {
            string input1 = TextBox1.Text;
            string input2 = TextBox2.Text;
            TextBox3.Text = "";
            if (int.TryParse(input1, out int value1) && int.TryParse(input2, out int value2))
            {
                int sum = value1 + value2;
                TextBox3.Text = sum.ToString(); 
            }
            else
            {
                TextBox3.Text = "Invalid input";
            }
        }
        protected void subtraction(object sender, EventArgs e)
        {
            string input1 = TextBox1.Text;
            string input2 = TextBox2.Text;
            TextBox3.Text = "";
            if (int.TryParse(input1, out int value1) && int.TryParse(input2, out int value2))
            {
                int sum = value1 - value2;
                TextBox3.Text = sum.ToString(); 
            }
            else
            {
                TextBox3.Text = "Invalid input";
            }
        }
        protected void multiplication(object sender, EventArgs e)
        {
            string input1 = TextBox1.Text;
            string input2 = TextBox2.Text;
            TextBox3.Text = "";
            if (int.TryParse(input1, out int value1) && int.TryParse(input2, out int value2))
            {
                int sum = value1 * value2;
                TextBox3.Text = sum.ToString();
            }
            else
            {
                TextBox3.Text = "Invalid input";
            }
        }
        protected void division(object sender, EventArgs e)
        {
            
            string input1 = TextBox1.Text;
            string input2 = TextBox2.Text;
            TextBox3.Text = "";
            if (int.TryParse(input1, out int value1) && int.TryParse(input2, out int value2))
            {

                int sum = value1 / value2;
                TextBox3.Text = sum.ToString(); 
            }
            else
            {
                TextBox3.Text = "Invalid input";
            }
        }
    }
}