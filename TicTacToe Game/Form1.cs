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

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void lookPanalo()
        {
            bool may_nanalo_na = false;


            //bx 1 possible answers,,,, panalo
            if ((bx1.Text == bx2.Text) && (bx2.Text == bx3.Text) && (!bx1.Enabled))
                may_nanalo_na = true;
            if ((bx1.Text == bx4.Text) && (bx4.Text == bx7.Text) && (!bx1.Enabled))
                may_nanalo_na = true;
            if ((bx1.Text == bx5.Text) && (bx5.Text == bx9.Text) && (!bx1.Enabled))
                may_nanalo_na = true;



            if(may_nanalo_na)
            {
                String nanalo = " ";
                if (pasa)
                    nanalo = "O";
                else
                    nanalo = "X";


                MessageBox.Show(nanalo + "Wins!");
            }
        }
    }
}
