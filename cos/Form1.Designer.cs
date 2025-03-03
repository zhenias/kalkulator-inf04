
using static System.Net.Mime.MediaTypeNames;

namespace cos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void zmianaliczby(string tekst) 
        {
            textBox1.Text += tekst;
        }

        private void dodaj()
        {
            textBox1.Text += "+";
        }

        private void odej()
        {
            textBox1.Text += "-";
        }

        private void dziel()
        {
            textBox1.Text += "/";
        }

        private void mnoz()
        {
            textBox1.Text += "*";
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            textBox1 = new TextBox();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new System.Drawing.Font("Calibri", 17.25F);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 61);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new System.Drawing.Font("Calibri", 17.25F);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(93, 79);
            button2.Name = "button2";
            button2.Size = new Size(75, 61);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new System.Drawing.Font("Calibri", 17.25F);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(12, 146);
            button3.Name = "button3";
            button3.Size = new Size(75, 61);
            button3.TabIndex = 2;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Font = new System.Drawing.Font("Calibri", 17.25F);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(174, 79);
            button4.Name = "button4";
            button4.Size = new Size(75, 61);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.Font = new System.Drawing.Font("Calibri", 17.25F);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(93, 146);
            button5.Name = "button5";
            button5.Size = new Size(75, 58);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.Font = new System.Drawing.Font("Calibri", 17.25F);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(174, 146);
            button6.Name = "button6";
            button6.Size = new Size(75, 58);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Green;
            button7.Font = new System.Drawing.Font("Calibri", 17.25F);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(12, 213);
            button7.Name = "button7";
            button7.Size = new Size(75, 55);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Green;
            button8.Font = new System.Drawing.Font("Calibri", 17.25F);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(93, 210);
            button8.Name = "button8";
            button8.Size = new Size(75, 58);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Green;
            button9.Font = new System.Drawing.Font("Calibri", 17.25F);
            button9.ForeColor = SystemColors.Control;
            button9.Location = new Point(174, 210);
            button9.Name = "button9";
            button9.Size = new Size(75, 58);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Gray;
            button10.Font = new System.Drawing.Font("Calibri", 17.25F);
            button10.ForeColor = Color.White;
            button10.Location = new Point(336, 79);
            button10.Name = "button10";
            button10.Size = new Size(52, 138);
            button10.TabIndex = 9;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button1_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gray;
            button11.Font = new System.Drawing.Font("Calibri", 17.25F);
            button11.ForeColor = Color.White;
            button11.Location = new Point(255, 146);
            button11.Name = "button11";
            button11.Size = new Size(75, 58);
            button11.TabIndex = 10;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button1_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Gray;
            button12.Font = new System.Drawing.Font("Calibri", 17.25F);
            button12.ForeColor = Color.White;
            button12.Location = new Point(255, 210);
            button12.Name = "button12";
            button12.Size = new Size(75, 55);
            button12.TabIndex = 11;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button1_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gray;
            button13.Font = new System.Drawing.Font("Calibri", 17.25F);
            button13.ForeColor = Color.White;
            button13.Location = new Point(255, 79);
            button13.Name = "button13";
            button13.Size = new Size(75, 61);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 17F);
            textBox1.Location = new Point(12, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 45);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button14
            // 
            button14.BackColor = Color.Blue;
            button14.Font = new System.Drawing.Font("Calibri", 17.25F);
            button14.ForeColor = Color.White;
            button14.Location = new Point(336, 223);
            button14.Name = "button14";
            button14.Size = new Size(52, 104);
            button14.TabIndex = 14;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = false;
            button14.Click += wynik_wyczaruj;
            // 
            // button15
            // 
            button15.BackColor = Color.Red;
            button15.Font = new System.Drawing.Font("Calibri", 17.25F);
            button15.ForeColor = Color.White;
            button15.Location = new Point(255, 271);
            button15.Name = "button15";
            button15.Size = new Size(75, 56);
            button15.TabIndex = 15;
            button15.Text = "C";
            button15.UseVisualStyleBackColor = false;
            button15.Click += czyscBtn;
            // 
            // button16
            // 
            button16.BackColor = Color.Green;
            button16.Font = new System.Drawing.Font("Calibri", 17.25F);
            button16.ForeColor = SystemColors.Control;
            button16.Location = new Point(174, 271);
            button16.Name = "button16";
            button16.Size = new Size(75, 56);
            button16.TabIndex = 16;
            button16.Text = ".";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button1_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Green;
            button17.Font = new System.Drawing.Font("Calibri", 17.25F);
            button17.ForeColor = SystemColors.Control;
            button17.Location = new Point(12, 271);
            button17.Name = "button17";
            button17.Size = new Size(156, 56);
            button17.TabIndex = 17;
            button17.Text = "0";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 339);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(textBox1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(415, 378);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(415, 378);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kalkulator :)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox textBox1;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
    
}
