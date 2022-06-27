namespace WinForms_MazeGame
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_stop = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbl_stop);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 415);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label22.Location = new System.Drawing.Point(145, 382);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(181, 33);
            this.label22.TabIndex = 23;
            this.label22.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label21
            // 
            this.label21.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label21.Location = new System.Drawing.Point(486, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 96);
            this.label21.TabIndex = 22;
            this.label21.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label20
            // 
            this.label20.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label20.Location = new System.Drawing.Point(3, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 32);
            this.label20.TabIndex = 21;
            this.label20.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label19
            // 
            this.label19.Image = global::WinForms_MazeGame.Properties.Resources.wall;
            this.label19.Location = new System.Drawing.Point(-5, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 109);
            this.label19.TabIndex = 20;
            this.label19.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label18
            // 
            this.label18.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label18.Location = new System.Drawing.Point(98, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 80);
            this.label18.TabIndex = 19;
            this.label18.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // lbl_stop
            // 
            this.lbl_stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_stop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_stop.Location = new System.Drawing.Point(656, 367);
            this.lbl_stop.Name = "lbl_stop";
            this.lbl_stop.Size = new System.Drawing.Size(157, 48);
            this.lbl_stop.TabIndex = 18;
            this.lbl_stop.Text = "STOP";
            this.lbl_stop.MouseEnter += new System.EventHandler(this.lbl_stop_MouseEnter);
            // 
            // label12
            // 
            this.label12.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label12.Location = new System.Drawing.Point(587, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 33);
            this.label12.TabIndex = 17;
            this.label12.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label17
            // 
            this.label17.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label17.Location = new System.Drawing.Point(139, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(228, 25);
            this.label17.TabIndex = 16;
            this.label17.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label16
            // 
            this.label16.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label16.Location = new System.Drawing.Point(364, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 31);
            this.label16.TabIndex = 15;
            this.label16.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label15
            // 
            this.label15.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label15.Location = new System.Drawing.Point(139, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(228, 25);
            this.label15.TabIndex = 14;
            this.label15.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label14
            // 
            this.label14.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label14.Location = new System.Drawing.Point(689, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 168);
            this.label14.TabIndex = 13;
            this.label14.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label13
            // 
            this.label13.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label13.Location = new System.Drawing.Point(587, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 168);
            this.label13.TabIndex = 12;
            this.label13.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label11
            // 
            this.label11.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label11.Location = new System.Drawing.Point(421, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 10;
            this.label11.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label10
            // 
            this.label10.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label10.Location = new System.Drawing.Point(364, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 160);
            this.label10.TabIndex = 9;
            this.label10.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label9
            // 
            this.label9.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label9.Location = new System.Drawing.Point(474, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 139);
            this.label9.TabIndex = 8;
            this.label9.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label8
            // 
            this.label8.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label8.Location = new System.Drawing.Point(205, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 33);
            this.label8.TabIndex = 7;
            this.label8.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label7
            // 
            this.label7.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label7.Location = new System.Drawing.Point(327, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 33);
            this.label7.TabIndex = 6;
            this.label7.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label6
            // 
            this.label6.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 36);
            this.label6.TabIndex = 5;
            this.label6.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label5
            // 
            this.label5.Image = global::WinForms_MazeGame.Properties.Resources.wall2;
            this.label5.Location = new System.Drawing.Point(0, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 34);
            this.label5.TabIndex = 4;
            this.label5.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label4
            // 
            this.label4.Image = global::WinForms_MazeGame.Properties.Resources.wall;
            this.label4.Location = new System.Drawing.Point(473, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 90);
            this.label4.TabIndex = 3;
            this.label4.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label3
            // 
            this.label3.Image = global::WinForms_MazeGame.Properties.Resources.wall;
            this.label3.Location = new System.Drawing.Point(297, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 158);
            this.label3.TabIndex = 2;
            this.label3.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label2
            // 
            this.label2.Image = global::WinForms_MazeGame.Properties.Resources.wall;
            this.label2.Location = new System.Drawing.Point(134, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 155);
            this.label2.TabIndex = 1;
            this.label2.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // label1
            // 
            this.label1.Image = global::WinForms_MazeGame.Properties.Resources.wall;
            this.label1.Location = new System.Drawing.Point(0, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 184);
            this.label1.TabIndex = 0;
            this.label1.MouseEnter += new System.EventHandler(this.label19_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label lbl_stop;
        private Label label12;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}