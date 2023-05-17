using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_15_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutTheProgramMenuItem_Click(object sender, EventArgs e)
        {
            InfoProgram infoProgram = new InfoProgram();
            infoProgram.ShowDialog();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InfoGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateLabel2_Click(object sender, EventArgs e)
        {

        }

        private void SearchLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
