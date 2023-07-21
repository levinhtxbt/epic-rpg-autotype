namespace AutoTyper
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            commandText1 = new TextBox();
            timerAutoType = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            label21 = new Label();
            textBox14 = new TextBox();
            label20 = new Label();
            textBox13 = new TextBox();
            label19 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox7 = new TextBox();
            label18 = new Label();
            textBox11 = new TextBox();
            label17 = new Label();
            textBox10 = new TextBox();
            label16 = new Label();
            textBox9 = new TextBox();
            label15 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            commandText7 = new TextBox();
            label6 = new Label();
            commandText6 = new TextBox();
            label5 = new Label();
            commandText5 = new TextBox();
            label4 = new Label();
            commandText4 = new TextBox();
            label3 = new Label();
            commandText3 = new TextBox();
            label2 = new Label();
            commandText2 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            txtLogs = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 490);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 46);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // commandText1
            // 
            commandText1.Location = new Point(91, 35);
            commandText1.Margin = new Padding(3, 2, 3, 2);
            commandText1.Name = "commandText1";
            commandText1.Size = new Size(175, 23);
            commandText1.TabIndex = 1;
            // 
            // timerAutoType
            // 
            timerAutoType.Enabled = true;
            timerAutoType.Interval = 1000;
            timerAutoType.Tick += timerAutoType_Tick_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(commandText7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(commandText6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(commandText5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(commandText4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(commandText3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(commandText2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(commandText1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 473);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(349, 279);
            label21.Name = "label21";
            label21.Size = new Size(27, 17);
            label21.TabIndex = 44;
            label21.Text = "sec";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(272, 278);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(71, 23);
            textBox14.TabIndex = 43;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(349, 252);
            label20.Name = "label20";
            label20.Size = new Size(27, 17);
            label20.TabIndex = 42;
            label20.Text = "sec";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(272, 251);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(71, 23);
            textBox13.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(349, 225);
            label19.Name = "label19";
            label19.Size = new Size(27, 17);
            label19.TabIndex = 40;
            label19.Text = "sec";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(272, 224);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(71, 23);
            textBox12.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(349, 198);
            label14.Name = "label14";
            label14.Size = new Size(27, 17);
            label14.TabIndex = 38;
            label14.Text = "sec";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(272, 197);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(71, 23);
            textBox7.TabIndex = 37;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(6, 306);
            label18.Name = "label18";
            label18.Size = new Size(63, 17);
            label18.TabIndex = 36;
            label18.Text = "Bot token";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(91, 305);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(252, 154);
            textBox11.TabIndex = 35;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(6, 279);
            label17.Name = "label17";
            label17.Size = new Size(86, 17);
            label17.TabIndex = 34;
            label17.Text = "Command 10";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(91, 278);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(175, 23);
            textBox10.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(6, 252);
            label16.Name = "label16";
            label16.Size = new Size(79, 17);
            label16.TabIndex = 32;
            label16.Text = "Command 9";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(91, 251);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(175, 23);
            textBox9.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(6, 225);
            label15.Name = "label15";
            label15.Size = new Size(79, 17);
            label15.TabIndex = 30;
            label15.Text = "Command 8";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(91, 224);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(175, 23);
            textBox8.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(349, 171);
            label13.Name = "label13";
            label13.Size = new Size(27, 17);
            label13.TabIndex = 27;
            label13.Text = "sec";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(349, 144);
            label12.Name = "label12";
            label12.Size = new Size(27, 17);
            label12.TabIndex = 26;
            label12.Text = "sec";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(349, 117);
            label11.Name = "label11";
            label11.Size = new Size(27, 17);
            label11.TabIndex = 25;
            label11.Text = "sec";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(349, 90);
            label10.Name = "label10";
            label10.Size = new Size(27, 17);
            label10.TabIndex = 24;
            label10.Text = "sec";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(349, 63);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 23;
            label9.Text = "sec";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(349, 36);
            label8.Name = "label8";
            label8.Size = new Size(27, 17);
            label8.TabIndex = 22;
            label8.Text = "sec";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(272, 170);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(71, 23);
            textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(272, 143);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(71, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(272, 116);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(71, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(71, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 23);
            textBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 198);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 14;
            label7.Text = "Command 7";
            // 
            // commandText7
            // 
            commandText7.Location = new Point(91, 197);
            commandText7.Margin = new Padding(3, 2, 3, 2);
            commandText7.Name = "commandText7";
            commandText7.Size = new Size(175, 23);
            commandText7.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 171);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 12;
            label6.Text = "Command 6";
            // 
            // commandText6
            // 
            commandText6.Location = new Point(91, 170);
            commandText6.Margin = new Padding(3, 2, 3, 2);
            commandText6.Name = "commandText6";
            commandText6.Size = new Size(175, 23);
            commandText6.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 144);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 10;
            label5.Text = "Command 5";
            // 
            // commandText5
            // 
            commandText5.Location = new Point(91, 143);
            commandText5.Margin = new Padding(3, 2, 3, 2);
            commandText5.Name = "commandText5";
            commandText5.Size = new Size(175, 23);
            commandText5.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 8;
            label4.Text = "Command 4";
            // 
            // commandText4
            // 
            commandText4.Location = new Point(91, 116);
            commandText4.Margin = new Padding(3, 2, 3, 2);
            commandText4.Name = "commandText4";
            commandText4.Size = new Size(175, 23);
            commandText4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 6;
            label3.Text = "Command 3";
            // 
            // commandText3
            // 
            commandText3.Location = new Point(91, 89);
            commandText3.Margin = new Padding(3, 2, 3, 2);
            commandText3.Name = "commandText3";
            commandText3.Size = new Size(175, 23);
            commandText3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 4;
            label2.Text = "Command 2";
            // 
            // commandText2
            // 
            commandText2.Location = new Point(91, 62);
            commandText2.Margin = new Padding(3, 2, 3, 2);
            commandText2.Name = "commandText2";
            commandText2.Size = new Size(175, 23);
            commandText2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Command 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLogs);
            groupBox2.Location = new Point(418, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 524);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logs";
            // 
            // button2
            // 
            button2.Location = new Point(132, 490);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 46);
            button2.TabIndex = 4;
            button2.Text = "Connect BOT";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtLogs
            // 
            txtLogs.Location = new Point(6, 22);
            txtLogs.Multiline = true;
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.Size = new Size(491, 496);
            txtLogs.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 548);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox commandText1;
        private System.Windows.Forms.Timer timerAutoType;
        private GroupBox groupBox1;
        private Label label1;
        private Label label7;
        private TextBox commandText7;
        private Label label6;
        private TextBox commandText6;
        private Label label5;
        private TextBox commandText5;
        private Label label4;
        private TextBox commandText4;
        private Label label3;
        private TextBox commandText3;
        private Label label2;
        private TextBox commandText2;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
        private Label label21;
        private TextBox textBox14;
        private Label label20;
        private TextBox textBox13;
        private Label label19;
        private TextBox textBox12;
        private Label label14;
        private TextBox textBox7;
        private Label label18;
        private TextBox textBox11;
        private Label label17;
        private TextBox textBox10;
        private Label label16;
        private TextBox textBox9;
        private Label label15;
        private TextBox textBox8;
        private TextBox txtLogs;
    }
}