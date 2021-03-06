﻿namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.display1 = new System.Windows.Forms.TextBox();
            this.display2 = new System.Windows.Forms.TextBox();
            this.display3 = new System.Windows.Forms.TextBox();
            this.display4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonClearEverything = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonExponent = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonPop = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.BackColor = System.Drawing.SystemColors.Window;
            this.display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display1.Location = new System.Drawing.Point(1, 94);
            this.display1.Name = "display1";
            this.display1.ReadOnly = true;
            this.display1.Size = new System.Drawing.Size(254, 31);
            this.display1.TabIndex = 0;
            this.display1.Text = "0";
            this.display1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display1.TextChanged += new System.EventHandler(this.display1_TextChanged);
            // 
            // display2
            // 
            this.display2.BackColor = System.Drawing.SystemColors.Window;
            this.display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display2.Location = new System.Drawing.Point(1, 63);
            this.display2.Name = "display2";
            this.display2.ReadOnly = true;
            this.display2.Size = new System.Drawing.Size(254, 31);
            this.display2.TabIndex = 25;
            this.display2.Text = "0";
            this.display2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display2.TextChanged += new System.EventHandler(this.display2_TextChanged);
            // 
            // display3
            // 
            this.display3.BackColor = System.Drawing.SystemColors.Window;
            this.display3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display3.Location = new System.Drawing.Point(1, 32);
            this.display3.Name = "display3";
            this.display3.ReadOnly = true;
            this.display3.Size = new System.Drawing.Size(254, 31);
            this.display3.TabIndex = 24;
            this.display3.Text = "0";
            this.display3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display3.TextChanged += new System.EventHandler(this.display3_TextChanged);
            // 
            // display4
            // 
            this.display4.BackColor = System.Drawing.SystemColors.Window;
            this.display4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display4.Location = new System.Drawing.Point(1, 1);
            this.display4.Name = "display4";
            this.display4.ReadOnly = true;
            this.display4.Size = new System.Drawing.Size(254, 31);
            this.display4.TabIndex = 26;
            this.display4.Text = "0";
            this.display4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display4.TextChanged += new System.EventHandler(this.display4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onButtonOneClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(102, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.onButtonTwoClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(153, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.onButtonThreeClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(51, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.onBttonFourClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(102, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.onButtonFiveClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(153, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.onButtonSixClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(51, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.onButtonSevenClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(102, 164);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 40);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.onButtonEightClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(153, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 40);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.onButtonNineClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(51, 281);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(52, 40);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.onButtonZeroClick);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(0, 125);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(52, 40);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.onButtonClearClick);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecimal.Location = new System.Drawing.Point(102, 281);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(52, 40);
            this.buttonDecimal.TabIndex = 12;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = false;
            this.buttonDecimal.Click += new System.EventHandler(this.onButtonDecimalClick);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(153, 281);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(103, 40);
            this.buttonEqual.TabIndex = 13;
            this.buttonEqual.Text = "Enter";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.onButtonEnterClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(204, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(52, 40);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.onButtonAddClick);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(204, 203);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(52, 40);
            this.buttonSubtract.TabIndex = 15;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.onButtonMinusClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(204, 164);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(52, 40);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "X";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.onButtonMultiplyClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(204, 125);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(52, 40);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.onButtonDivideClick);
            // 
            // buttonClearEverything
            // 
            this.buttonClearEverything.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonClearEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEverything.Location = new System.Drawing.Point(51, 125);
            this.buttonClearEverything.Name = "buttonClearEverything";
            this.buttonClearEverything.Size = new System.Drawing.Size(52, 40);
            this.buttonClearEverything.TabIndex = 18;
            this.buttonClearEverything.Text = "CE";
            this.buttonClearEverything.UseVisualStyleBackColor = false;
            this.buttonClearEverything.Click += new System.EventHandler(this.onButtonClearEverythingClick);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(0, 281);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(52, 40);
            this.buttonPlusMinus.TabIndex = 19;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.onButtonPlusMinusClick);
            // 
            // buttonExponent
            // 
            this.buttonExponent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExponent.Location = new System.Drawing.Point(0, 203);
            this.buttonExponent.Name = "buttonExponent";
            this.buttonExponent.Size = new System.Drawing.Size(52, 40);
            this.buttonExponent.TabIndex = 20;
            this.buttonExponent.Text = "xⁿ";
            this.buttonExponent.UseVisualStyleBackColor = false;
            this.buttonExponent.Click += new System.EventHandler(this.onButtonExponentClick);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSqrt.Location = new System.Drawing.Point(0, 164);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(52, 40);
            this.buttonSqrt.TabIndex = 21;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.onButtonSqrtClick);
            // 
            // buttonInverse
            // 
            this.buttonInverse.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInverse.Location = new System.Drawing.Point(0, 242);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(52, 40);
            this.buttonInverse.TabIndex = 22;
            this.buttonInverse.Text = "1/x";
            this.buttonInverse.UseVisualStyleBackColor = false;
            this.buttonInverse.Click += new System.EventHandler(this.onButtonInverseClick);
            // 
            // buttonPop
            // 
            this.buttonPop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPop.Location = new System.Drawing.Point(153, 125);
            this.buttonPop.Name = "buttonPop";
            this.buttonPop.Size = new System.Drawing.Size(52, 40);
            this.buttonPop.TabIndex = 23;
            this.buttonPop.Text = "Pop";
            this.buttonPop.UseVisualStyleBackColor = false;
            this.buttonPop.Click += new System.EventHandler(this.onButtonPopClick);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwap.Location = new System.Drawing.Point(102, 125);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(52, 40);
            this.buttonSwap.TabIndex = 27;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.onButtonSwapClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(256, 321);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonPop);
            this.Controls.Add(this.buttonInverse);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonExponent);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.buttonClearEverything);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display4);
            this.Controls.Add(this.display3);
            this.Controls.Add(this.display2);
            this.Controls.Add(this.display1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display1;
        private System.Windows.Forms.TextBox display2;
        private System.Windows.Forms.TextBox display3;
        private System.Windows.Forms.TextBox display4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonClearEverything;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonExponent;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonPop;
        private System.Windows.Forms.Button buttonSwap;
    }
}

