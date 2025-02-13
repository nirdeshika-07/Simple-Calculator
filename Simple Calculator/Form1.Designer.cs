namespace Simple_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Clear = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Add = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Sub = new Button();
            Dot = new Button();
            Zero = new Button();
            Percent = new Button();
            Equal = new Button();
            Start = new Button();
            Divide = new Button();
            Multiply = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("LCDMono", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(12, 54);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(488, 70);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(362, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // Seven
            // 
            Seven.Location = new Point(12, 145);
            Seven.Name = "Seven";
            Seven.Size = new Size(118, 70);
            Seven.TabIndex = 4;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Seven_Click;
            // 
            // Eight
            // 
            Eight.Location = new Point(136, 145);
            Eight.Name = "Eight";
            Eight.Size = new Size(118, 70);
            Eight.TabIndex = 4;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Eight_Click;
            // 
            // Nine
            // 
            Nine.Location = new Point(260, 145);
            Nine.Name = "Nine";
            Nine.Size = new Size(118, 70);
            Nine.TabIndex = 4;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Nine_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Location = new Point(384, 145);
            Clear.Name = "Clear";
            Clear.Size = new Size(118, 70);
            Clear.TabIndex = 4;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Four
            // 
            Four.Location = new Point(12, 221);
            Four.Name = "Four";
            Four.Size = new Size(118, 70);
            Four.TabIndex = 4;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Four_Click;
            // 
            // Five
            // 
            Five.Location = new Point(136, 221);
            Five.Name = "Five";
            Five.Size = new Size(118, 70);
            Five.TabIndex = 4;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Five_Click;
            // 
            // Six
            // 
            Six.Location = new Point(260, 221);
            Six.Name = "Six";
            Six.Size = new Size(118, 70);
            Six.TabIndex = 4;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Six_Click;
            // 
            // Add
            // 
            Add.Location = new Point(384, 221);
            Add.Name = "Add";
            Add.Size = new Size(118, 70);
            Add.TabIndex = 4;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // One
            // 
            One.Location = new Point(12, 297);
            One.Name = "One";
            One.Size = new Size(118, 70);
            One.TabIndex = 4;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += One_Click;
            // 
            // Two
            // 
            Two.Location = new Point(136, 297);
            Two.Name = "Two";
            Two.Size = new Size(118, 70);
            Two.TabIndex = 4;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Two_Click;
            // 
            // Three
            // 
            Three.Location = new Point(260, 297);
            Three.Name = "Three";
            Three.Size = new Size(118, 70);
            Three.TabIndex = 4;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Three_Click;
            // 
            // Sub
            // 
            Sub.Location = new Point(384, 297);
            Sub.Name = "Sub";
            Sub.Size = new Size(118, 70);
            Sub.TabIndex = 4;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            Sub.Click += Sub_Click;
            // 
            // Dot
            // 
            Dot.Location = new Point(12, 373);
            Dot.Name = "Dot";
            Dot.Size = new Size(118, 70);
            Dot.TabIndex = 4;
            Dot.Text = ".";
            Dot.UseVisualStyleBackColor = true;
            Dot.Click += Dot_Click;
            // 
            // Zero
            // 
            Zero.Location = new Point(136, 373);
            Zero.Name = "Zero";
            Zero.Size = new Size(118, 70);
            Zero.TabIndex = 4;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Zero_Click;
            // 
            // Percent
            // 
            Percent.Location = new Point(260, 373);
            Percent.Name = "Percent";
            Percent.Size = new Size(118, 70);
            Percent.TabIndex = 4;
            Percent.Text = "%";
            Percent.UseVisualStyleBackColor = true;
            Percent.Click += Percent_Click;
            // 
            // Equal
            // 
            Equal.Location = new Point(384, 373);
            Equal.Name = "Equal";
            Equal.Size = new Size(118, 146);
            Equal.TabIndex = 4;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = true;
            Equal.Click += Equal_Click;
            // 
            // Start
            // 
            Start.BackColor = Color.Tomato;
            Start.Location = new Point(12, 449);
            Start.Name = "Start";
            Start.Size = new Size(118, 70);
            Start.TabIndex = 4;
            Start.Text = "AC";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(136, 449);
            Divide.Name = "Divide";
            Divide.Size = new Size(118, 70);
            Divide.TabIndex = 4;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(260, 449);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(118, 70);
            Multiply.TabIndex = 4;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += Multiply_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(512, 527);
            Controls.Add(Equal);
            Controls.Add(Sub);
            Controls.Add(Add);
            Controls.Add(Clear);
            Controls.Add(Multiply);
            Controls.Add(Divide);
            Controls.Add(Percent);
            Controls.Add(Zero);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(Start);
            Controls.Add(Six);
            Controls.Add(Dot);
            Controls.Add(Five);
            Controls.Add(One);
            Controls.Add(Nine);
            Controls.Add(Four);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label1;
        private Label label2;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Clear;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Add;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Sub;
        private Button Dot;
        private Button Zero;
        private Button Percent;
        private Button Equal;
        private Button Start;
        private Button Divide;
        private Button Multiply;
    }
}
