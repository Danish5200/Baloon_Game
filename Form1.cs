using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baloon_Game
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
            btn_spin.Enabled = false;
            btn_Soh.Enabled = false;
            btn_sa.Enabled = false;
            
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_load.Enabled = false;

            
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {

        }
    }
}
