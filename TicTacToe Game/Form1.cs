﻿using System;
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
            pasa_count++;

            lookPanalo();
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


            //bx2
            if ((bx2.Text == bx5.Text) && (bx5.Text == bx8.Text) && (!bx2.Enabled))
                may_nanalo_na = true;


            //bx3
            if ((bx3.Text == bx6.Text) && (bx6.Text == bx9.Text) && (!bx3.Enabled))
                may_nanalo_na = true;

            if ((bx3.Text == bx5.Text) && (bx5.Text == bx7.Text) && (!bx3.Enabled))
                may_nanalo_na = true;


            //bx4
            if ((bx4.Text == bx5.Text) && (bx5.Text == bx6.Text) && (!bx3.Enabled))
                may_nanalo_na = true;

            //bx 7
            if ((bx7.Text == bx4.Text) && (bx4.Text == bx1.Text) && (!bx7.Enabled))
                may_nanalo_na = true;
            if ((bx7.Text == bx5.Text) && (bx5.Text == bx3.Text) && (!bx7.Enabled))
                may_nanalo_na = true;
            if ((bx7.Text == bx8.Text) && (bx8.Text == bx9.Text) && (!bx7.Enabled))
                may_nanalo_na = true;


            //bx 8
            if ((bx8.Text == bx5.Text) && (bx5.Text == bx2.Text) && (!bx8.Enabled))
                may_nanalo_na = true;


            //bx9
            if ((bx9.Text == bx8.Text) && (bx8.Text == bx7.Text) && (!bx9.Enabled))
                may_nanalo_na = true;
            if ((bx9.Text == bx5.Text) && (bx5.Text == bx1.Text) && (!bx9.Enabled))
                may_nanalo_na = true;
            if ((bx9.Text == bx6.Text) && (bx6.Text == bx3.Text) && (!bx9.Enabled))
                may_nanalo_na = true;





            if (may_nanalo_na)
            {
                disablebuttons();

                String nanalo = " ";
                if (pasa)
                    nanalo = "O";
                else
                    nanalo = "X";


                MessageBox.Show(nanalo + "Wins!");
            }//end ng if

            else
            {

                if (pasa_count == 9)
                    MessageBox.Show("Draw!");


            }



        }//end ng look panalo

        private void disablebuttons()

        {

            foreach (Component c in Controls)
            {
                Button btn = (Button)c;
                btn.Enabled = false;

            }//foreach end


        }
    }
}
