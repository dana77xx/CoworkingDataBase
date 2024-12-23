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
    public partial class Form3 : Form
    {
        public Form3(string name, string noPeople, string pickedRoom, double total)
        {
            InitializeComponent();
            nameLabel.Text = name;
            nopplLabel.Text = noPeople;
            totalLabel.Text = total.ToString();
            roomNoLabel.Text = pickedRoom;


        }
    }
}
