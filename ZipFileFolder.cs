using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktuchna02
{
    public partial class ZipFileFolder : Form
    {
        public ZipFileFolder()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.Description = "Select your path.";
            if (fdb.ShowDialog() == DialogResult.OK)
                textFolder.Text = fdb.SelectedPath;
        }
    }
}
