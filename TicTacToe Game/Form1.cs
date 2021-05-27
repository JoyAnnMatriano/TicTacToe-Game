using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        bool pasa = true;
        int pasa_count = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void bx_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (pasa)
                btn.Text = "X";
            else
                btn.Text = "O";
            pasa = !pasa;
            btn.Enabled = false;
        }
    }
}
