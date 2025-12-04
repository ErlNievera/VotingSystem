namespace VotingSystem
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            panelMain = new Panel();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 19);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 0;
            label1.Text = "Voting System";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btn5);
            panel2.Controls.Add(btn4);
            panel2.Controls.Add(btn3);
            panel2.Controls.Add(btn2);
            panel2.Controls.Add(btn1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 497);
            panel2.TabIndex = 1;
            // 
            // btn5
            // 
            btn5.AutoSize = true;
            btn5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn5.Dock = DockStyle.Top;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(0, 124);
            btn5.Name = "btn5";
            btn5.Size = new Size(250, 31);
            btn5.TabIndex = 4;
            btn5.Text = "Logout";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.AutoSize = true;
            btn4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn4.Dock = DockStyle.Top;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(0, 93);
            btn4.Name = "btn4";
            btn4.Size = new Size(250, 31);
            btn4.TabIndex = 3;
            btn4.Text = "Results";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.AutoSize = true;
            btn3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn3.Dock = DockStyle.Top;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(0, 62);
            btn3.Name = "btn3";
            btn3.Size = new Size(250, 31);
            btn3.TabIndex = 2;
            btn3.Text = "Candidates";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.AutoSize = true;
            btn2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn2.Dock = DockStyle.Top;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(0, 31);
            btn2.Name = "btn2";
            btn2.Size = new Size(250, 31);
            btn2.TabIndex = 1;
            btn2.Text = "Vote";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.AutoSize = true;
            btn1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn1.Dock = DockStyle.Top;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(0, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(250, 31);
            btn1.TabIndex = 0;
            btn1.Text = "Dashboard";
            btn1.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(comboBox1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(755, 497);
            panelMain.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 577);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn5;
        private Panel panelMain;
        private ComboBox comboBox1;
    }
}
