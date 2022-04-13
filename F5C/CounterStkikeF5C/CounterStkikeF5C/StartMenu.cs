using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CounterStkikeF5C
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();                    
        }
                     
        private void StartMenu_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyData == Keys.Enter)
            {
                Oyun str = new Oyun();
                str.Show();
                this.Hide();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Oyun str = new Oyun();
            str.Show();
            this.Hide();
        }
    }
}
