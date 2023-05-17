using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_15_20
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OkButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void NameTaskTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (NameTaskTextBox1.Text.Length > 0)
            {
                OkButton1.Enabled = true;
            }
            else { OkButton1.Enabled = false; }
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
