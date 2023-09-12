namespace calc
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuBar;
            textBox1.Location = new Point(12, 94);
            textBox1.MaxLength = 31;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 22);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(12, 202);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 22);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 48);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 11;
            label1.Text = "Bin-Calculator";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.minimize;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Dock = DockStyle.Right;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(40, 40, 40);
            button4.Location = new Point(330, 0);
            button4.Name = "button4";
            button4.Size = new Size(30, 48);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.close;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(40, 40, 40);
            button3.Location = new Point(360, 0);
            button3.Name = "button3";
            button3.Size = new Size(30, 48);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(8, 70);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 7;
            label3.Text = "Binary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(8, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 8;
            label4.Text = "Decimal";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 1);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(12, 222);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 1);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 47);
            panel4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(390, 277);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
    }
}