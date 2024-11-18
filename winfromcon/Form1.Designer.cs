namespace winfromcon
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(402, 173);
            button1.Name = "button1";
            button1.Size = new Size(169, 76);
            button1.TabIndex = 0;
            button1.Text = "ปิดโปรเเกรม";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(304, 87);
            button2.Name = "button2";
            button2.Size = new Size(365, 31);
            button2.TabIndex = 1;
            button2.Text = "เปิดไฟ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // button3
            // 
            button3.Location = new Point(304, 124);
            button3.Name = "button3";
            button3.Size = new Size(365, 31);
            button3.TabIndex = 2;
            button3.Text = "ปิดไฟ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // label1
            // 
            label1.ForeColor = Color.Red;
            label1.Location = new Point(387, 30);
            label1.Name = "label1";
            label1.Size = new Size(197, 33);
            label1.TabIndex = 3;
            label1.Text = "มหาวิทยาลัยราชฎัทอุดรธานี";
            label1.Click += label1_Click;
            label1.MouseLeave += label1_MouseLeave;
            label1.MouseHover += label1_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "0.000000000000000000";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(985, 498);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "windowfromcontorl";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private TextBox textBox1;
    }
}
