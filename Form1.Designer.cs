namespace Wurfel
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
            panel1 = new Panel();
            label8 = new Label();
            six = new Label();
            five = new Label();
            four = new Label();
            three = new Label();
            two = new Label();
            one = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            statusbar = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(six);
            panel1.Controls.Add(five);
            panel1.Controls.Add(four);
            panel1.Controls.Add(three);
            panel1.Controls.Add(two);
            panel1.Controls.Add(one);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 65);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 39);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "Wie oft:";
            // 
            // six
            // 
            six.AutoSize = true;
            six.Location = new Point(277, 39);
            six.Name = "six";
            six.Size = new Size(13, 15);
            six.TabIndex = 12;
            six.Text = "0";
            // 
            // five
            // 
            five.AutoSize = true;
            five.Location = new Point(233, 39);
            five.Name = "five";
            five.Size = new Size(13, 15);
            five.TabIndex = 11;
            five.Text = "0";
            // 
            // four
            // 
            four.AutoSize = true;
            four.Location = new Point(189, 39);
            four.Name = "four";
            four.Size = new Size(13, 15);
            four.TabIndex = 9;
            four.Text = "0";
            // 
            // three
            // 
            three.AutoSize = true;
            three.Location = new Point(145, 39);
            three.Name = "three";
            three.Size = new Size(13, 15);
            three.TabIndex = 10;
            three.Text = "0";
            // 
            // two
            // 
            two.AutoSize = true;
            two.Location = new Point(101, 39);
            two.Name = "two";
            two.Size = new Size(13, 15);
            two.TabIndex = 8;
            two.Text = "0";
            // 
            // one
            // 
            one.AutoSize = true;
            one.Location = new Point(57, 39);
            one.Name = "one";
            one.Size = new Size(13, 15);
            one.TabIndex = 7;
            one.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 7);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 6;
            label7.Text = "Wert:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 7);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 5;
            label6.Text = "6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(233, 7);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 7);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 7);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 3;
            label3.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 7);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 2;
            label2.Text = "2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 7);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 0;
            label1.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 329);
            button1.Name = "button1";
            button1.Size = new Size(326, 23);
            button1.TabIndex = 1;
            button1.Text = "PLAY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(16, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // statusbar
            // 
            statusbar.Dock = DockStyle.Bottom;
            statusbar.Location = new Point(0, 370);
            statusbar.Name = "statusbar";
            statusbar.Size = new Size(350, 15);
            statusbar.TabIndex = 3;
            statusbar.Text = "Gespielt: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 385);
            Controls.Add(statusbar);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Würfel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label six;
        private Label five;
        private Label four;
        private Label three;
        private Label two;
        private Label one;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label statusbar;
    }
}
