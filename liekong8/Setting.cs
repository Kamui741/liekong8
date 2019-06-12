using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liekong8
{
    public partial class Setting : Form
    {
        
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        public void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chusudu_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
