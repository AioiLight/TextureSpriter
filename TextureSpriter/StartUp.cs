using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureSpriter
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void Button_Cutter_Click(object sender, EventArgs e)
        {
            var dialog = new Cutter();
            dialog.ShowDialog(this);
            dialog.Dispose();
        }

        private void Button_Marger_Click(object sender, EventArgs e)
        {
            var dialog = new Marger();
            dialog.ShowDialog(this);
            dialog.Dispose();
        }
    }
}
