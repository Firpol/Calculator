namespace Калькулятор
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n8 = new Button();
            n7 = new Button();
            n9 = new Button();
            n0 = new Button();
            Clear = new Button();
            Dot = new Button();
            Equal = new Button();
            Add = new Button();
            Sub = new Button();
            Div = new Button();
            Mult = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Location = new Point(25, 70);
            n1.Name = "n1";
            n1.Size = new Size(40, 30);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += N1_Click;
            // 
            // n2
            // 
            n2.Location = new Point(71, 70);
            n2.Name = "n2";
            n2.Size = new Size(40, 30);
            n2.TabIndex = 1;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += N2_Click;
            // 
            // n3
            // 
            n3.Location = new Point(117, 70);
            n3.Name = "n3";
            n3.Size = new Size(40, 30);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += N2_Click;
            // 
            // n4
            // 
            n4.Location = new Point(25, 106);
            n4.Name = "n4";
            n4.Size = new Size(40, 30);
            n4.TabIndex = 3;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += N4_Click;
            // 
            // n5
            // 
            n5.Location = new Point(71, 106);
            n5.Name = "n5";
            n5.Size = new Size(40, 30);
            n5.TabIndex = 4;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += N5_Click;
            // 
            // n6
            // 
            n6.Location = new Point(117, 106);
            n6.Name = "n6";
            n6.Size = new Size(40, 30);
            n6.TabIndex = 5;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += N6_Click;
            // 
            // n8
            // 
            n8.Location = new Point(71, 142);
            n8.Name = "n8";
            n8.Size = new Size(40, 30);
            n8.TabIndex = 6;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += N8_Click;
            // 
            // n7
            // 
            n7.Location = new Point(25, 142);
            n7.Name = "n7";
            n7.Size = new Size(40, 30);
            n7.TabIndex = 7;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += N7_Click;
            // 
            // n9
            // 
            n9.Location = new Point(117, 142);
            n9.Name = "n9";
            n9.Size = new Size(40, 30);
            n9.TabIndex = 8;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += N7_Click;
            // 
            // n0
            // 
            n0.Location = new Point(71, 178);
            n0.Name = "n0";
            n0.Size = new Size(40, 30);
            n0.TabIndex = 9;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += N0_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(117, 178);
            Clear.Name = "Clear";
            Clear.Size = new Size(40, 30);
            Clear.TabIndex = 10;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Dot
            // 
            Dot.Location = new Point(25, 178);
            Dot.Name = "Dot";
            Dot.Size = new Size(40, 30);
            Dot.TabIndex = 11;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += Dot_Click;
            // 
            // Equal
            // 
            Equal.Location = new Point(71, 214);
            Equal.Name = "Equal";
            Equal.Size = new Size(86, 30);
            Equal.TabIndex = 12;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Add
            // 
            Add.Location = new Point(184, 70);
            Add.Name = "Add";
            Add.Size = new Size(40, 30);
            Add.TabIndex = 13;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(184, 106);
            Sub.Name = "Sub";
            Sub.Size = new Size(40, 30);
            Sub.TabIndex = 14;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Div
            // 
            Div.Location = new Point(184, 142);
            Div.Name = "Div";
            Div.Size = new Size(40, 30);
            Div.TabIndex = 15;
            Div.Text = "/";
            Div.UseVisualStyleBackColor = true;
            Div.Click += Div_Click;
            // 
            // Mult
            // 
            Mult.Location = new Point(184, 178);
            Mult.Name = "Mult";
            Mult.Size = new Size(40, 30);
            Mult.TabIndex = 16;
            Mult.Text = "*";
            Mult.UseVisualStyleBackColor = true;
            Mult.Click += Mult_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 17;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 276);
            Controls.Add(textBox1);
            Controls.Add(Mult);
            Controls.Add(Div);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(Equal);
            Controls.Add(Dot);
            Controls.Add(Clear);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n7);
            Controls.Add(n8);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n8;
        private Button n7;
        private Button n9;
        private Button n0;
        private Button Clear;
        private Button Dot;
        private Button Equal;
        private Button Add;
        private Button Sub;
        private Button Div;
        private Button Mult;
        private TextBox textBox1;
    }
}
