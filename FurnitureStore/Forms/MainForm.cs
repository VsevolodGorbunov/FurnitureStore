using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureStoreDLL;

namespace FurnitureStore
{
    public partial class MainForm : FParent
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToProfile_Click(object sender, EventArgs e)
        {
            Forms.Profile fadd = new Forms.Profile();
            fadd.ShowDialog();
        }
    }
}
