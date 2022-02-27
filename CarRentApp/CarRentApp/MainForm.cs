using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class MainForm : Form
    {
        private string car;
        public MainForm()
        {
            InitializeComponent();
            car = "Dacia";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lCar.Text = lCar.Text + " " + car;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("I'm here");
        }
    }
}
