using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace janken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r3;
            int.TryParse(label19.Text, out r3);

            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = false;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            label19.Text = (r3 + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r1, r2;
            int.TryParse(label10.Text, out r1);
            int.TryParse(label15.Text, out r2);

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;

            Random r = new Random();

            int ai = r.Next(1, 4);
            if (ai != 1) 
            {
                if (ai == 2)
                {
                    label3.Visible = false;
                    label5.Visible = false;
                    label4.Visible = true;
                    label6.Visible = true;
                    r1 = r1 + 3;
                    r2 = r2 - 2;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();

                }
                else if (ai == 3)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label7.Visible = true;
                    r1 = r1 - 2;
                    r2 = r2 + 3;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();
                }
            }
            else
            {
                label4.Visible = false;
                label5.Visible = false;
                label3.Visible = true;
                label9.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r1, r2;
            int.TryParse(label10.Text, out r1);
            int.TryParse(label15.Text, out r2);

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;

            Random r = new Random();

            int ai = r.Next(1, 4);
            if (ai != 2)
            {
                if (ai == 1)
                {
                    label4.Visible = false;
                    label5.Visible = false;
                    label3.Visible = true;
                    label7.Visible = true;
                    r1 = r1 - 2;
                    r2 = r2 + 3;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();
                }
                else if (ai == 3)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    label6.Visible = true;
                    r1 = r1 + 3;
                    r2 = r2 - 2;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();
                }
            }
            else
            {
                label3.Visible = false;
                label5.Visible = false;
                label4.Visible = true;
                label9.Visible = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r1, r2;
            int.TryParse(label10.Text, out r1);
            int.TryParse(label15.Text, out r2);

            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;

            Random r = new Random();

            int ai = r.Next(1, 4);
            if (ai != 3)
            {
                if (ai == 1)
                {
                    label4.Visible = false;
                    label5.Visible = false;
                    label3.Visible = true;
                    label6.Visible = true;
                    r1 = r1 + 3;
                    r2 = r2 - 2;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();
                }
                else if (ai == 2)
                {
                    label3.Visible = false;
                    label5.Visible = false;
                    label4.Visible = true;
                    label7.Visible = true;
                    r1 = r1 - 2;
                    r2 = r2 + 3;
                    label10.Text = r1.ToString();
                    label15.Text = r2.ToString();
                }
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label9.Visible = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int r1, r2, r3, r4;
            int.TryParse(label10.Text, out r1);
            int.TryParse(label15.Text, out r2);
            int.TryParse(label19.Text, out r3);
            int.TryParse(label21.Text, out r4);

            if (r3 < r4)
            {
                if (r1 < r2)
                {
                    if (r1 > 0)
                    {
                        button1.Enabled = true;
                        button6.Enabled = false;
                        label2.Visible = false;
                        label8.Visible = true;
                    }
                    else if (r1 <= 0)
                    {
                        button6.Enabled = false;
                        label2.Visible = false;
                        label17.Visible = true;
                    }
                    else
                    {
                        button6.Enabled = false;
                        label2.Visible = false;
                        label18.Visible = true;
                    }
                }
                else
                {
                    if (r2 > 0)
                    {
                        button1.Enabled = true;
                        button6.Enabled = false;
                        label2.Visible = false;
                        label8.Visible = true;
                    }
                    else if (r2 <= 0)
                    {
                        button6.Enabled = false;
                        label2.Visible = false;
                        label16.Visible = true;
                    }
                    else if (r2 <= 0)
                    {
                        button6.Enabled = false;
                        label2.Visible = false;
                        label16.Visible = true;
                    }
                    else
                    {
                        button6.Enabled = false;
                        label2.Visible = false;
                        label18.Visible = true;
                    }

                }
            }
            else if(r1 < r2)
            {
                button6.Enabled = false;
                label2.Visible = false;
                label17.Visible = true;
            }
            else if(r1 > r2)
            {
                button6.Enabled = false;
                label2.Visible = false;
                label16.Visible = true;
            }
            else
            {
                button6.Enabled = false;
                label2.Visible = false;
                label18.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
