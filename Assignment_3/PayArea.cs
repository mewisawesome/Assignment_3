using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class PayArea : Form
    {
        public PayArea()
        {
            InitializeComponent();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pay f2 = new Pay();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }
    }
}
