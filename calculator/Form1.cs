using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if(!result_view.Text.Equals("0")) //if just written "0" we dont need write zero again...
            {
                string result_value = result_view.Text + "0";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "1";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "1";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "2";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "2";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "3";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "3";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "4";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "4";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "5";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "5";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "6";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "6";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "7";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "7";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "8";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "8";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Equals("0"))
            {
                string result_value = "9";
                result_view.Text = result_value;
            }
            else
            {
                string result_value = result_view.Text + "9";
                result_view.Text = result_value;
            }
            activate_buttons();
        }

        private void comma_btn_Click(object sender, EventArgs e)
        {
            string result_value = result_view.Text + ",";
            result_view.Text = result_value;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Contains("+")) 
            {
                string[] values = result_view.Text.Split("+");
                float result = float.Parse(values[0]) + float.Parse(values[1]);
                result_view.Text = result + "+";
            }
            else if (result_view.Text.Contains("-"))
            {
                string[] values = result_view.Text.Split("-");
                float result = float.Parse(values[0]) - float.Parse(values[1]);
                result_view.Text = result + "+";
            }
            else if (result_view.Text.Contains("*"))
            {
                string[] values = result_view.Text.Split("*");
                float result = float.Parse(values[0]) * float.Parse(values[1]);
                result_view.Text = result + "+";
            }
            else if (result_view.Text.Contains("/"))
            {
                string[] values = result_view.Text.Split("/");
                float result = float.Parse(values[0]) / float.Parse(values[1]);
                result_view.Text = result + "+";
            }
            else
            {
                string result_value = result_view.Text + "+";
                result_view.Text = result_value;
            }
            passivate_buttons();           
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Contains("-"))
            {
                string[] values = result_view.Text.Split("-");
                float result = float.Parse(values[0]) - float.Parse(values[1]);
                result_view.Text = result + "-";
            }
            else if (result_view.Text.Contains("+"))
            {
                string[] values = result_view.Text.Split("+");
                float result = float.Parse(values[0]) + float.Parse(values[1]);
                result_view.Text = result + "-";
            }            
            else if (result_view.Text.Contains("*"))
            {
                string[] values = result_view.Text.Split("*");
                float result = float.Parse(values[0]) * float.Parse(values[1]);
                result_view.Text = result + "-";
            }
            else if (result_view.Text.Contains("/"))
            {
                string[] values = result_view.Text.Split("/");
                float result = float.Parse(values[0]) / float.Parse(values[1]);
                result_view.Text = result + "-";
            }
            else
            {
                string result_value = result_view.Text + "-";
                result_view.Text = result_value;
            }            
            passivate_buttons();
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Contains("-"))
            {
                string[] values = result_view.Text.Split("-");
                float result = float.Parse(values[0]) - float.Parse(values[1]);
                result_view.Text = result + "*";
            }
            else if (result_view.Text.Contains("+"))
            {
                string[] values = result_view.Text.Split("+");
                float result = float.Parse(values[0]) + float.Parse(values[1]);
                result_view.Text = result + "*";
            }
            else if (result_view.Text.Contains("*"))
            {
                string[] values = result_view.Text.Split("*");
                float result = float.Parse(values[0]) * float.Parse(values[1]);
                result_view.Text = result + "*";
            }
            else if (result_view.Text.Contains("/"))
            {
                string[] values = result_view.Text.Split("/");
                float result = float.Parse(values[0]) / float.Parse(values[1]);
                result_view.Text = result + "*";
            }
            else
            {
                string result_value = result_view.Text + "*";
                result_view.Text = result_value;
                passivate_buttons();
            }            
        }

        private void divorce_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Contains("-"))
            {
                string[] values = result_view.Text.Split("-");
                float result = float.Parse(values[0]) - float.Parse(values[1]);
                result_view.Text = result + "/";
            }
            else if (result_view.Text.Contains("+"))
            {
                string[] values = result_view.Text.Split("+");
                float result = float.Parse(values[0]) + float.Parse(values[1]);
                result_view.Text = result + "/";
            }
            else if (result_view.Text.Contains("*"))
            {
                string[] values = result_view.Text.Split("*");
                float result = float.Parse(values[0]) * float.Parse(values[1]);
                result_view.Text = result + "/";
            }
            else if (result_view.Text.Contains("/"))
            {
                string[] values = result_view.Text.Split("/");
                float result = float.Parse(values[0]) / float.Parse(values[1]);
                result_view.Text = result + "/";
            }
            else
            {
                string result_value = result_view.Text + "/";
                result_view.Text = result_value;
            }            
            passivate_buttons();
        }

        private void clean_btn_Click(object sender, EventArgs e)
        {
            result_view.Text = "0";
            activate_buttons();
        }

        private void backspace_btn_Click(object sender, EventArgs e)
        {
            if(!result_view.Text.Equals("0"))
            {
                if(result_view.Text.Length < 1)
                {
                    result_view.Text = "0";
                }
                else
                {
                    result_view.Text = result_view.Text.Substring(0, result_view.Text.Length - 1);
                }
            }

            if (passivate_buttons())
            {
                activate_buttons();
            }
            if (result_view.Text.EndsWith("+") || result_view.Text.EndsWith("-") ||
                result_view.Text.EndsWith("*") || result_view.Text.EndsWith("/"))
            {
                passivate_buttons();
            }
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            if (result_view.Text.Contains("-"))
            {
                string[] values = result_view.Text.Split("-");
                float result = float.Parse(values[0]) - float.Parse(values[1]);
                result_view.Text = result.ToString();
            }
            else if (result_view.Text.Contains("+"))
            {
                string[] values = result_view.Text.Split("+");
                float result = float.Parse(values[0]) + float.Parse(values[1]);
                result_view.Text = result.ToString();
            }
            else if (result_view.Text.Contains("*"))
            {
                string[] values = result_view.Text.Split("*");
                float result = float.Parse(values[0]) * float.Parse(values[1]);
                result_view.Text = result.ToString();
            }
            else if (result_view.Text.Contains("/"))
            {
                string[] values = result_view.Text.Split("/");
                float result = float.Parse(values[0]) / float.Parse(values[1]);
                result_view.Text = result.ToString();
            }
        }

        private bool passivate_buttons()
        {
            plus_btn.Enabled = false;
            minus_btn.Enabled = false;
            divorce_btn.Enabled = false;
            multiply_btn.Enabled = false;
            comma_btn.Enabled = false;
            if(plus_btn.Enabled == false || 
                minus_btn.Enabled == false || 
                divorce_btn.Enabled == false ||
                multiply_btn.Enabled == false ||
                comma_btn.Enabled == false)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private bool activate_buttons() 
        {
            plus_btn.Enabled = true;
            minus_btn.Enabled = true;
            divorce_btn.Enabled = true;
            multiply_btn.Enabled = true;
            comma_btn.Enabled = true;
            if (plus_btn.Enabled == true ||
                minus_btn.Enabled == true ||
                divorce_btn.Enabled == true ||
                multiply_btn.Enabled == true ||
                comma_btn.Enabled == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
