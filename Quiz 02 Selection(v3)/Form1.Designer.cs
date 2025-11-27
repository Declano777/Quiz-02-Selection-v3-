namespace Quiz_02_Selection_v3_
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            q1TextBox = new TextBox();
            q1Button = new Button();
            q1OutputLabel = new Label();
            label7 = new Label();
            label8 = new Label();
            q2OutputLabel = new Label();
            q2Button = new Button();
            q2TextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label12 = new Label();
            q3OutputLabel = new Label();
            q3Button = new Button();
            q3TextBox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label17 = new Label();
            label18 = new Label();
            ageTextBox = new TextBox();
            q4Button = new Button();
            parentTextBox = new Label();
            label20 = new Label();
            textBox2 = new TextBox();
            timeTextBox = new TextBox();
            label21 = new Label();
            q4OutputLabel = new Label();
            bonusButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 15.75F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 28);
            label1.TabIndex = 0;
            label1.Text = "Quiz 02 - Selection";
            // 
            // label2
            // 
            label2.Location = new Point(0, 42);
            label2.Name = "label2";
            label2.Size = new Size(294, 27);
            label2.TabIndex = 1;
            label2.Text = "Q01 - Simple if (2 marks)";
            // 
            // label3
            // 
            label3.Location = new Point(0, 78);
            label3.Name = "label3";
            label3.Size = new Size(405, 166);
            label3.TabIndex = 2;
            label3.Text = "The user is asked the last name of Canada’s prime minister.  If they correctly enter ‘Carney’ then output ‘CORRECT’ in q1OutputLabel.";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(431, 0);
            label4.Name = "label4";
            label4.Size = new Size(10, 803);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.Location = new Point(0, 147);
            label5.Name = "label5";
            label5.Size = new Size(425, 27);
            label5.TabIndex = 4;
            label5.Text = "--------------------------------------------------";
            // 
            // label6
            // 
            label6.Location = new Point(0, 174);
            label6.Name = "label6";
            label6.Size = new Size(175, 61);
            label6.TabIndex = 5;
            label6.Text = "What is the last name of Canada's Prime Minister?";
            // 
            // q1TextBox
            // 
            q1TextBox.Location = new Point(168, 189);
            q1TextBox.Name = "q1TextBox";
            q1TextBox.Size = new Size(100, 31);
            q1TextBox.TabIndex = 6;
            // 
            // q1Button
            // 
            q1Button.Location = new Point(309, 180);
            q1Button.Name = "q1Button";
            q1Button.Size = new Size(96, 43);
            q1Button.TabIndex = 7;
            q1Button.Text = "Code Me!";
            q1Button.UseVisualStyleBackColor = true;
            q1Button.Click += q1Button_Click;
            // 
            // q1OutputLabel
            // 
            q1OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q1OutputLabel.Location = new Point(0, 244);
            q1OutputLabel.Name = "q1OutputLabel";
            q1OutputLabel.Size = new Size(425, 38);
            q1OutputLabel.TabIndex = 8;
            // 
            // label7
            // 
            label7.Location = new Point(0, 291);
            label7.Name = "label7";
            label7.Size = new Size(294, 27);
            label7.TabIndex = 9;
            label7.Text = "Q02 - If .. Else (3 marks)";
            // 
            // label8
            // 
            label8.Location = new Point(12, 310);
            label8.Name = "label8";
            label8.Size = new Size(405, 161);
            label8.TabIndex = 10;
            label8.Text = "The user is asked if they like the Toronto Maple Leafs (y/n).  If they say yes, the output should be “Go Leafs Go!”.  If they say no (n), the output should be ‘BOOOOO!’";
            // 
            // q2OutputLabel
            // 
            q2OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q2OutputLabel.Location = new Point(0, 503);
            q2OutputLabel.Name = "q2OutputLabel";
            q2OutputLabel.Size = new Size(425, 38);
            q2OutputLabel.TabIndex = 15;
            // 
            // q2Button
            // 
            q2Button.Location = new Point(309, 439);
            q2Button.Name = "q2Button";
            q2Button.Size = new Size(96, 43);
            q2Button.TabIndex = 14;
            q2Button.Text = "Code Me!";
            q2Button.UseVisualStyleBackColor = true;
            q2Button.Click += q2Button_Click;
            // 
            // q2TextBox
            // 
            q2TextBox.Location = new Point(168, 448);
            q2TextBox.Name = "q2TextBox";
            q2TextBox.Size = new Size(100, 31);
            q2TextBox.TabIndex = 13;
            // 
            // label10
            // 
            label10.Location = new Point(0, 433);
            label10.Name = "label10";
            label10.Size = new Size(175, 61);
            label10.TabIndex = 12;
            label10.Text = "Do you like the Toronto Maple Leafs (y/n)?";
            // 
            // label11
            // 
            label11.Location = new Point(0, 406);
            label11.Name = "label11";
            label11.Size = new Size(425, 27);
            label11.TabIndex = 11;
            label11.Text = "--------------------------------------------------";
            // 
            // label9
            // 
            label9.Location = new Point(447, 1);
            label9.Name = "label9";
            label9.Size = new Size(400, 27);
            label9.TabIndex = 16;
            label9.Text = "Q03 - Multiple Decisions (5 marks)";
            // 
            // label12
            // 
            label12.Location = new Point(447, 42);
            label12.Name = "label12";
            label12.Size = new Size(637, 166);
            label12.TabIndex = 17;
            label12.Text = resources.GetString("label12.Text");
            // 
            // q3OutputLabel
            // 
            q3OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q3OutputLabel.Location = new Point(447, 229);
            q3OutputLabel.Name = "q3OutputLabel";
            q3OutputLabel.Size = new Size(584, 38);
            q3OutputLabel.TabIndex = 23;
            // 
            // q3Button
            // 
            q3Button.Location = new Point(802, 180);
            q3Button.Name = "q3Button";
            q3Button.Size = new Size(96, 43);
            q3Button.TabIndex = 22;
            q3Button.Text = "Code Me!";
            q3Button.UseVisualStyleBackColor = true;
            q3Button.Click += q3Button_Click;
            // 
            // q3TextBox
            // 
            q3TextBox.Location = new Point(679, 188);
            q3TextBox.Name = "q3TextBox";
            q3TextBox.Size = new Size(100, 31);
            q3TextBox.TabIndex = 21;
            // 
            // label15
            // 
            label15.Location = new Point(447, 188);
            label15.Name = "label15";
            label15.Size = new Size(226, 35);
            label15.TabIndex = 20;
            label15.Text = "What grade are you in?";
            // 
            // label16
            // 
            label16.Location = new Point(447, 163);
            label16.Name = "label16";
            label16.Size = new Size(676, 27);
            label16.TabIndex = 19;
            label16.Text = "-------------------------------------------------------------------------------------------------------------";
            // 
            // label14
            // 
            label14.Location = new Point(447, 291);
            label14.Name = "label14";
            label14.Size = new Size(584, 27);
            label14.TabIndex = 24;
            label14.Text = "Q04 - Compound If's (5 marks) ICS3U only - bonus for ICS3C";
            // 
            // label17
            // 
            label17.Location = new Point(447, 267);
            label17.Name = "label17";
            label17.Size = new Size(637, 141);
            label17.TabIndex = 25;
            label17.Text = resources.GetString("label17.Text");
            // 
            // label18
            // 
            label18.Location = new Point(447, 446);
            label18.Name = "label18";
            label18.Size = new Size(226, 35);
            label18.TabIndex = 26;
            label18.Text = "How old are you?";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(774, 440);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 31);
            ageTextBox.TabIndex = 27;
            // 
            // q4Button
            // 
            q4Button.Location = new Point(913, 467);
            q4Button.Name = "q4Button";
            q4Button.Size = new Size(96, 43);
            q4Button.TabIndex = 28;
            q4Button.Text = "Code Me!";
            q4Button.UseVisualStyleBackColor = true;
            q4Button.Click += q4Button_Click;
            // 
            // parentTextBox
            // 
            parentTextBox.Location = new Point(447, 479);
            parentTextBox.Name = "parentTextBox";
            parentTextBox.Size = new Size(272, 35);
            parentTextBox.TabIndex = 29;
            parentTextBox.Text = "Are you with a parent (y/n)?";
            // 
            // label20
            // 
            label20.Location = new Point(447, 518);
            label20.Name = "label20";
            label20.Size = new Size(300, 35);
            label20.TabIndex = 30;
            label20.Text = "Is the movie before 8 PM (y/n)?";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(774, 480);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 31);
            textBox2.TabIndex = 31;
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(774, 515);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(100, 31);
            timeTextBox.TabIndex = 32;
            // 
            // label21
            // 
            label21.Location = new Point(447, 419);
            label21.Name = "label21";
            label21.Size = new Size(676, 27);
            label21.TabIndex = 33;
            label21.Text = "-------------------------------------------------------------------------------------------------------------";
            // 
            // q4OutputLabel
            // 
            q4OutputLabel.BorderStyle = BorderStyle.FixedSingle;
            q4OutputLabel.Location = new Point(447, 553);
            q4OutputLabel.Name = "q4OutputLabel";
            q4OutputLabel.Size = new Size(584, 38);
            q4OutputLabel.TabIndex = 34;
            // 
            // bonusButton
            // 
            bonusButton.Location = new Point(99, 553);
            bonusButton.Name = "bonusButton";
            bonusButton.Size = new Size(205, 60);
            bonusButton.TabIndex = 36;
            bonusButton.Text = "Click here for a bonus question!";
            bonusButton.UseVisualStyleBackColor = true;
            bonusButton.Click += bonusButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1135, 802);
            Controls.Add(bonusButton);
            Controls.Add(q4OutputLabel);
            Controls.Add(label21);
            Controls.Add(timeTextBox);
            Controls.Add(textBox2);
            Controls.Add(label20);
            Controls.Add(parentTextBox);
            Controls.Add(q4Button);
            Controls.Add(ageTextBox);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(q3OutputLabel);
            Controls.Add(q3Button);
            Controls.Add(q3TextBox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(q2OutputLabel);
            Controls.Add(q2Button);
            Controls.Add(q2TextBox);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(q1OutputLabel);
            Controls.Add(q1Button);
            Controls.Add(q1TextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Quiz 02 - V3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox q1TextBox;
        private Button q1Button;
        private Label q1OutputLabel;
        private Label label7;
        private Label label8;
        private Label q2OutputLabel;
        private Button q2Button;
        private TextBox q2TextBox;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label12;
        private Label q3OutputLabel;
        private Button q3Button;
        private TextBox q3TextBox;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label17;
        private Label label18;
        private TextBox ageTextBox;
        private Button q4Button;
        private Label parentTextBox;
        private Label label20;
        private TextBox textBox2;
        private TextBox timeTextBox;
        private Label label21;
        private Label q4OutputLabel;
        private Button bonusButton;
    }
}
