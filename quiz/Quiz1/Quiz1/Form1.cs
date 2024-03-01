using System;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            if (radioBtn1.Checked == true)
            {
                double result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                labVal.Text = result.ToString();

            }
            else if (radioBtn2.Checked == true)
            {
                double result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                labVal.Text = result.ToString();
            }
            else if (radioBtn3.Checked == true)
            {
                double result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                labVal.Text = result.ToString();
            }
            else
            {
                if (Convert.ToInt32(textBox2.Text) != 0)
                {
                    double result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                    labVal.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Error occured", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addlist.Items.Add(labVal.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
