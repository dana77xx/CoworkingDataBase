using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDesign
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string noPeople = textBox6.Text;
            string totalHours = textBox3.Text;
            string pickedRoom = "";
            double total = 0;

            foreach (TextBox textBox in new[] { textBox1, textBox2, textBox3, textBox4, textBox6 })
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Please enter a valid value", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                {
                    MessageBox.Show("Please pick a room!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (radioButton1.Checked)
            {
                pickedRoom = "room1";
                total = 100 * int.Parse(totalHours);

            }
            
            else if (radioButton2.Checked)
            {
                pickedRoom = "room2";
                total = 50 * int.Parse(totalHours);

            }
            else if (radioButton3.Checked)
            {
                pickedRoom = "room3";
                total = 90 * int.Parse(totalHours);
            }

            Form3 form3 = new Form3(name, noPeople, pickedRoom, total);
            form3.Show();
            this.Hide();





        }


    }
}
