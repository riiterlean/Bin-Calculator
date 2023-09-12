using System;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace calc
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
            button3.FlatAppearance.BorderSize = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string number = textBox1.Text;

            int decimalValue = 0;
            int binaryBase = 2;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = number[i] - '0';
                int positionValue = digit * (int)(Math.Pow(binaryBase, number.Length - 1 - i));
                decimalValue += positionValue;
            }
            if (decimalValue == 0)
            {
                textBox1.Clear();
            }
            textBox2.Text = decimalValue.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1, Keys.OemMinus };

            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                try
                {
                    if (textBox2.Text == "")
                    {
                        textBox1.Text = "";
                        return;
                    }
                    else
                    {
                        int decimalNumber = (int)Convert.ToInt32(textBox2.Text);

                        textBox1.Text = Convert.ToString(decimalNumber, 2);

                        if (textBox1.Text == "")
                        {
                            textBox2.Clear();
                        }
                    }
                }
                catch (ArithmeticException ex)
                {
                    //MessageBox.Show("The entered number is to big", "ArithmeticException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "2147483647";
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}