namespace calculator
{
    partial class Base
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.Base_btn_seven = new System.Windows.Forms.Button();
            this.Base_textbox_result = new System.Windows.Forms.TextBox();
            this.Base_btn_eight = new System.Windows.Forms.Button();
            this.Base_btn_nine = new System.Windows.Forms.Button();
            this.Base_btn_divides = new System.Windows.Forms.Button();
            this.Base_btn_clearentry = new System.Windows.Forms.Button();
            this.Base_btn_clear = new System.Windows.Forms.Button();
            this.Base_btn_times = new System.Windows.Forms.Button();
            this.Base_btn_six = new System.Windows.Forms.Button();
            this.Base_btn_five = new System.Windows.Forms.Button();
            this.Base_btn_four = new System.Windows.Forms.Button();
            this.Base_btn_minus = new System.Windows.Forms.Button();
            this.Base_btn_three = new System.Windows.Forms.Button();
            this.Base_btn_two = new System.Windows.Forms.Button();
            this.Base_btn_one = new System.Windows.Forms.Button();
            this.Base_btn_equal = new System.Windows.Forms.Button();
            this.Base_btn_plus = new System.Windows.Forms.Button();
            this.Base_btn_dot = new System.Windows.Forms.Button();
            this.Base_btn_zero = new System.Windows.Forms.Button();
            this.Base_lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Base_btn_seven
            // 
            this.Base_btn_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_seven.Location = new System.Drawing.Point(12, 65);
            this.Base_btn_seven.Name = "Base_btn_seven";
            this.Base_btn_seven.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_seven.TabIndex = 0;
            this.Base_btn_seven.Text = "7";
            this.Base_btn_seven.UseVisualStyleBackColor = true;
            this.Base_btn_seven.Click += new System.EventHandler(this.button_click);
            this.Base_btn_seven.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_textbox_result
            // 
            this.Base_textbox_result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Base_textbox_result.Enabled = false;
            this.Base_textbox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_textbox_result.Location = new System.Drawing.Point(12, 32);
            this.Base_textbox_result.Name = "Base_textbox_result";
            this.Base_textbox_result.Size = new System.Drawing.Size(199, 24);
            this.Base_textbox_result.TabIndex = 1;
            this.Base_textbox_result.Text = "0";
            this.Base_textbox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Base_textbox_result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_textbox_result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_eight
            // 
            this.Base_btn_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_eight.Location = new System.Drawing.Point(53, 65);
            this.Base_btn_eight.Name = "Base_btn_eight";
            this.Base_btn_eight.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_eight.TabIndex = 2;
            this.Base_btn_eight.Text = "8";
            this.Base_btn_eight.UseVisualStyleBackColor = true;
            this.Base_btn_eight.Click += new System.EventHandler(this.button_click);
            this.Base_btn_eight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_nine
            // 
            this.Base_btn_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_nine.Location = new System.Drawing.Point(94, 65);
            this.Base_btn_nine.Name = "Base_btn_nine";
            this.Base_btn_nine.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_nine.TabIndex = 3;
            this.Base_btn_nine.Text = "9";
            this.Base_btn_nine.UseVisualStyleBackColor = true;
            this.Base_btn_nine.Click += new System.EventHandler(this.button_click);
            this.Base_btn_nine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_divides
            // 
            this.Base_btn_divides.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_divides.Location = new System.Drawing.Point(135, 65);
            this.Base_btn_divides.Name = "Base_btn_divides";
            this.Base_btn_divides.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_divides.TabIndex = 4;
            this.Base_btn_divides.Text = "/";
            this.Base_btn_divides.UseVisualStyleBackColor = true;
            this.Base_btn_divides.Click += new System.EventHandler(this.operator_click);
            this.Base_btn_divides.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_divides.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_clearentry
            // 
            this.Base_btn_clearentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_clearentry.Location = new System.Drawing.Point(176, 65);
            this.Base_btn_clearentry.Name = "Base_btn_clearentry";
            this.Base_btn_clearentry.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_clearentry.TabIndex = 5;
            this.Base_btn_clearentry.Text = "CE";
            this.Base_btn_clearentry.UseVisualStyleBackColor = true;
            this.Base_btn_clearentry.Click += new System.EventHandler(this.Base_btn_clearentry_Click);
            this.Base_btn_clearentry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_clearentry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_clear
            // 
            this.Base_btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_clear.Location = new System.Drawing.Point(176, 106);
            this.Base_btn_clear.Name = "Base_btn_clear";
            this.Base_btn_clear.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_clear.TabIndex = 10;
            this.Base_btn_clear.Text = "C";
            this.Base_btn_clear.UseVisualStyleBackColor = true;
            this.Base_btn_clear.Click += new System.EventHandler(this.Base_btn_clear_Click);
            this.Base_btn_clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_times
            // 
            this.Base_btn_times.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_times.Location = new System.Drawing.Point(135, 106);
            this.Base_btn_times.Name = "Base_btn_times";
            this.Base_btn_times.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_times.TabIndex = 9;
            this.Base_btn_times.Text = "*";
            this.Base_btn_times.UseVisualStyleBackColor = true;
            this.Base_btn_times.Click += new System.EventHandler(this.operator_click);
            this.Base_btn_times.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_times.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_six
            // 
            this.Base_btn_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_six.Location = new System.Drawing.Point(94, 106);
            this.Base_btn_six.Name = "Base_btn_six";
            this.Base_btn_six.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_six.TabIndex = 8;
            this.Base_btn_six.Text = "6";
            this.Base_btn_six.UseVisualStyleBackColor = true;
            this.Base_btn_six.Click += new System.EventHandler(this.button_click);
            this.Base_btn_six.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_five
            // 
            this.Base_btn_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_five.Location = new System.Drawing.Point(53, 106);
            this.Base_btn_five.Name = "Base_btn_five";
            this.Base_btn_five.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_five.TabIndex = 7;
            this.Base_btn_five.Text = "5";
            this.Base_btn_five.UseVisualStyleBackColor = true;
            this.Base_btn_five.Click += new System.EventHandler(this.button_click);
            this.Base_btn_five.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_four
            // 
            this.Base_btn_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_four.Location = new System.Drawing.Point(12, 106);
            this.Base_btn_four.Name = "Base_btn_four";
            this.Base_btn_four.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_four.TabIndex = 6;
            this.Base_btn_four.Text = "4";
            this.Base_btn_four.UseVisualStyleBackColor = true;
            this.Base_btn_four.Click += new System.EventHandler(this.button_click);
            this.Base_btn_four.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_minus
            // 
            this.Base_btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_minus.Location = new System.Drawing.Point(135, 147);
            this.Base_btn_minus.Name = "Base_btn_minus";
            this.Base_btn_minus.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_minus.TabIndex = 14;
            this.Base_btn_minus.Text = "-";
            this.Base_btn_minus.UseVisualStyleBackColor = true;
            this.Base_btn_minus.Click += new System.EventHandler(this.operator_click);
            this.Base_btn_minus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_three
            // 
            this.Base_btn_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_three.Location = new System.Drawing.Point(94, 147);
            this.Base_btn_three.Name = "Base_btn_three";
            this.Base_btn_three.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_three.TabIndex = 13;
            this.Base_btn_three.Text = "3";
            this.Base_btn_three.UseVisualStyleBackColor = true;
            this.Base_btn_three.Click += new System.EventHandler(this.button_click);
            this.Base_btn_three.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_two
            // 
            this.Base_btn_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_two.Location = new System.Drawing.Point(53, 147);
            this.Base_btn_two.Name = "Base_btn_two";
            this.Base_btn_two.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_two.TabIndex = 12;
            this.Base_btn_two.Text = "2";
            this.Base_btn_two.UseVisualStyleBackColor = true;
            this.Base_btn_two.Click += new System.EventHandler(this.button_click);
            this.Base_btn_two.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_one
            // 
            this.Base_btn_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_one.Location = new System.Drawing.Point(12, 147);
            this.Base_btn_one.Name = "Base_btn_one";
            this.Base_btn_one.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_one.TabIndex = 11;
            this.Base_btn_one.Text = "1";
            this.Base_btn_one.UseVisualStyleBackColor = true;
            this.Base_btn_one.Click += new System.EventHandler(this.button_click);
            this.Base_btn_one.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_equal
            // 
            this.Base_btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_equal.Location = new System.Drawing.Point(176, 147);
            this.Base_btn_equal.Name = "Base_btn_equal";
            this.Base_btn_equal.Size = new System.Drawing.Size(35, 76);
            this.Base_btn_equal.TabIndex = 20;
            this.Base_btn_equal.Text = "=";
            this.Base_btn_equal.UseVisualStyleBackColor = true;
            this.Base_btn_equal.Click += new System.EventHandler(this.Base_btn_equal_Click);
            this.Base_btn_equal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_equal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_plus
            // 
            this.Base_btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_plus.Location = new System.Drawing.Point(135, 188);
            this.Base_btn_plus.Name = "Base_btn_plus";
            this.Base_btn_plus.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_plus.TabIndex = 19;
            this.Base_btn_plus.Text = "+";
            this.Base_btn_plus.UseVisualStyleBackColor = true;
            this.Base_btn_plus.Click += new System.EventHandler(this.operator_click);
            this.Base_btn_plus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_dot
            // 
            this.Base_btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_dot.Location = new System.Drawing.Point(94, 188);
            this.Base_btn_dot.Name = "Base_btn_dot";
            this.Base_btn_dot.Size = new System.Drawing.Size(35, 35);
            this.Base_btn_dot.TabIndex = 18;
            this.Base_btn_dot.Text = ".";
            this.Base_btn_dot.UseVisualStyleBackColor = true;
            this.Base_btn_dot.Click += new System.EventHandler(this.Base_btn_dot_Click);
            this.Base_btn_dot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_dot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_btn_zero
            // 
            this.Base_btn_zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base_btn_zero.Location = new System.Drawing.Point(12, 188);
            this.Base_btn_zero.Name = "Base_btn_zero";
            this.Base_btn_zero.Size = new System.Drawing.Size(76, 35);
            this.Base_btn_zero.TabIndex = 16;
            this.Base_btn_zero.Text = "0";
            this.Base_btn_zero.UseVisualStyleBackColor = true;
            this.Base_btn_zero.Click += new System.EventHandler(this.button_click);
            this.Base_btn_zero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.Base_btn_zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            // 
            // Base_lbl_result
            // 
            this.Base_lbl_result.AutoSize = true;
            this.Base_lbl_result.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Base_lbl_result.Location = new System.Drawing.Point(11, 16);
            this.Base_lbl_result.Name = "Base_lbl_result";
            this.Base_lbl_result.Size = new System.Drawing.Size(0, 13);
            this.Base_lbl_result.TabIndex = 21;
            // 
            // Base
            // 
            this.AcceptButton = this.Base_btn_equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(224, 234);
            this.Controls.Add(this.Base_lbl_result);
            this.Controls.Add(this.Base_btn_equal);
            this.Controls.Add(this.Base_btn_plus);
            this.Controls.Add(this.Base_btn_dot);
            this.Controls.Add(this.Base_btn_zero);
            this.Controls.Add(this.Base_btn_minus);
            this.Controls.Add(this.Base_btn_three);
            this.Controls.Add(this.Base_btn_two);
            this.Controls.Add(this.Base_btn_one);
            this.Controls.Add(this.Base_btn_clear);
            this.Controls.Add(this.Base_btn_times);
            this.Controls.Add(this.Base_btn_six);
            this.Controls.Add(this.Base_btn_five);
            this.Controls.Add(this.Base_btn_four);
            this.Controls.Add(this.Base_btn_clearentry);
            this.Controls.Add(this.Base_btn_divides);
            this.Controls.Add(this.Base_btn_nine);
            this.Controls.Add(this.Base_btn_eight);
            this.Controls.Add(this.Base_textbox_result);
            this.Controls.Add(this.Base_btn_seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_keyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_keyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Base_btn_seven;
        private System.Windows.Forms.TextBox Base_textbox_result;
        private System.Windows.Forms.Button Base_btn_eight;
        private System.Windows.Forms.Button Base_btn_nine;
        private System.Windows.Forms.Button Base_btn_divides;
        private System.Windows.Forms.Button Base_btn_clearentry;
        private System.Windows.Forms.Button Base_btn_clear;
        private System.Windows.Forms.Button Base_btn_times;
        private System.Windows.Forms.Button Base_btn_six;
        private System.Windows.Forms.Button Base_btn_five;
        private System.Windows.Forms.Button Base_btn_four;
        private System.Windows.Forms.Button Base_btn_minus;
        private System.Windows.Forms.Button Base_btn_three;
        private System.Windows.Forms.Button Base_btn_two;
        private System.Windows.Forms.Button Base_btn_one;
        private System.Windows.Forms.Button Base_btn_equal;
        private System.Windows.Forms.Button Base_btn_plus;
        private System.Windows.Forms.Button Base_btn_dot;
        private System.Windows.Forms.Button Base_btn_zero;
        private System.Windows.Forms.Label Base_lbl_result;
    }
}

