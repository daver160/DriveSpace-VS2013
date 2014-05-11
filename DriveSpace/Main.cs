using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveSpace
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnDirectoryAdd_Click(object sender, EventArgs e)
        {
            if (popupDirectoryAdd.ShowDialog() == DialogResult.OK)
            {
                txtDrivePath.Text = popupDirectoryAdd.SelectedPath;
                txtDriveLetter.Text = popupDirectoryAdd.SelectedPath;
                listDirectories.Items.Add(popupDirectoryAdd.SelectedPath);
            }
        }

        private void popupDirectoryAdd_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
