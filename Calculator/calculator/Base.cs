    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    namespace calculator
    {
        public partial class Base : Form
        {
            public Base()
            {
                InitializeComponent();
            }

            string operation = "";
            double result = 0;
            bool add2ndnumber;

            //manage numbers button click
            private void button_click(object sender, EventArgs e)
            {
                //hide the first zero number or enter 2nd number or nan values or infinity values
                if ((Base_textbox_result.Text == "0") || (add2ndnumber) || (Base_textbox_result.Text == "NaN") || (Base_textbox_result.Text == "Infinity"))
                {
                    Base_textbox_result.Clear();
                }

                add2ndnumber = false;

                //display number button when click
                Button b = sender as Button;
                Base_textbox_result.Text = Base_textbox_result.Text + b.Text;
            }

            // manage operators button click
            private void operator_click(object sender, EventArgs e)
            {
                Button b = sender as Button;

                if (result != 0)
                {
                    Base_btn_equal.PerformClick();
                    add2ndnumber = true;
                    operation = b.Text;
                    Base_lbl_result.Text = result + " " + operation;
                }
                else
                {
                    operation = b.Text;
                    result = Convert.ToDouble(Base_textbox_result.Text);
                    add2ndnumber = true;
                    Base_lbl_result.Text = result + " " + operation;
                }
            }   

            //manage clear entry button
            private void Base_btn_clearentry_Click(object sender, EventArgs e)
            {
                Base_textbox_result.Text = "0";
            }

            //manage clear button
            private void Base_btn_clear_Click(object sender, EventArgs e)
            {
                Base_textbox_result.Text = "0";
                Base_lbl_result.Text = "";
                result = 0;
            }

            //manage dot button
            private void Base_btn_dot_Click(object sender, EventArgs e)
            {
                Button b = sender as Button;

                if (!Base_textbox_result.Text.Contains("."))
                {
                    Base_textbox_result.Text = Base_textbox_result.Text + b.Text;
                }
            }

            // manage equal click button
            private void Base_btn_equal_Click(object sender, EventArgs e)
            {
              Base_lbl_result.Text = "";

               switch (operation)
                {
                    case "+":
                        Base_textbox_result.Text = (result + Convert.ToDouble(Base_textbox_result.Text)).ToString();
                        break;

                    case "-":
                        Base_textbox_result.Text = (result - Convert.ToDouble(Base_textbox_result.Text)).ToString();
                        break;

                    case "*":
                        Base_textbox_result.Text = (result * Convert.ToDouble(Base_textbox_result.Text)).ToString();
                        break;

                    case "/":
                        Base_textbox_result.Text = (result / Convert.ToDouble(Base_textbox_result.Text)).ToString();

                        if (Base_textbox_result.Text.Contains ("Infinity"))
                       {
                           MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                           
                       }
                        break;

                    default:
                        break;
                }

                result = Convert.ToDouble(Base_textbox_result.Text);
            //  operation = "";
            }

            // manage key in using keyboard
            private void button_keyPress(object sender, KeyPressEventArgs e)
            {
                switch (e.KeyChar.ToString())
                {
                    case "0":
                        Base_btn_zero.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "1":
                        Base_btn_one.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "2":
                        Base_btn_two.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "3":
                        Base_btn_three.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "4":
                        Base_btn_four.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "5":
                        Base_btn_five.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "6":
                        Base_btn_six.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "7":
                        Base_btn_seven.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "8":
                        Base_btn_eight.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "9":
                        Base_btn_nine.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case ".":
                        Base_btn_dot.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "+":
                        Base_btn_plus.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "-":
                        Base_btn_minus.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "*":
                        Base_btn_times.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "/":
                        Base_btn_divides.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    case "=":
                        Base_btn_equal.PerformClick();
                        Base_btn_equal.Focus();
                        break;

                    default:
                        break;
                }
            }
            // manage key in of escape and delete
            private void button_keyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Base_btn_clear.PerformClick();
                    Base_btn_equal.Focus(); 
                }
    
                if (e.KeyCode == Keys.Delete)
                {
                    Base_btn_clearentry.PerformClick();
                    Base_btn_equal.Focus();
                }
            }

    }
}
