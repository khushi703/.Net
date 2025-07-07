using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28lab2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CalculateOperation(object sender, CommandEventArgs e)
        {
            string input1 = TextBox1.Text;
            string input2 = TextBox2.Text;
            TextBox3.Text = "";

            if (int.TryParse(input1, out int value1) && int.TryParse(input2, out int value2))
            {
                try
                {
                    int result = 0;

                    switch (e.CommandArgument.ToString())
                    {
                        case "add":
                            result = value1 + value2;
                            break;
                        case "subtract":
                            result = value1 - value2;
                            break;
                        case "multiply":
                            result = value1 * value2;
                            break;
                        case "divide":
                            if (value2 == 0)
                            {
                                TextBox3.Text = "Cannot divide by zero";
                                return;
                            }
                            result = value1 / value2;
                            break;
                    }

                    TextBox3.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    TextBox3.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                TextBox3.Text = "Invalid input";
            }
        }
    }
}
