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
 
    public partial class TicTacToe_bx_main : Form
    {
        bool pasa = true;
        int pasa_count = 0;
        public TicTacToe_bx_main()
        {
            InitializeComponent();
            btn_again.MouseEnter += MouseEnter1;
            btn_again.MouseLeave += MouseLeave1;

        }
        private void MouseEnter1(object sender, EventArgs e)
        {
            btn_again.BackColor = Color.MediumSeaGreen;
        }
        private void MouseLeave1(object sender, EventArgs e)
        {
            btn_again.BackColor = SystemColors.ButtonFace;
        }

        private void btn_again_Click(object sender, EventArgs e)
        {
            Button btn_again = (Button)sender;
            btn_again.Enabled = true;
            Application.Restart();
        }
        private void bx_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (pasa)
                btn.Text = "x";
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
            //horizontal
            if ((bx1.Text == bx2.Text) && (bx2.Text == bx3.Text) && (!bx1.Enabled))
            {
                may_nanalo_na = true;
                bx1.BackColor = Color.MediumSeaGreen;
                bx2.BackColor = Color.MediumSeaGreen;
                bx3.BackColor = Color.MediumSeaGreen;
            }
            else if ((bx4.Text == bx5.Text) && (bx5.Text == bx6.Text) && (!bx4.Enabled))
            {
                may_nanalo_na = true;
                bx4.BackColor = Color.MediumSeaGreen;
                bx5.BackColor = Color.MediumSeaGreen;
                bx6.BackColor = Color.MediumSeaGreen;
            }
            else if ((bx7.Text == bx8.Text) && (bx8.Text == bx9.Text) && (!bx7.Enabled))
            {
                may_nanalo_na = true;
                bx7.BackColor = Color.MediumSeaGreen;
                bx8.BackColor = Color.MediumSeaGreen;
                bx9.BackColor = Color.MediumSeaGreen;
            }
            //vertical
            if ((bx1.Text == bx4.Text) && (bx4.Text == bx7.Text) && (!bx1.Enabled))
            {
                may_nanalo_na = true;
                bx1.BackColor = Color.MediumSeaGreen;
                bx4.BackColor = Color.MediumSeaGreen;
                bx7.BackColor = Color.MediumSeaGreen;
            }
            else if ((bx2.Text == bx5.Text) && (bx5.Text == bx8.Text) && (!bx2.Enabled))
            {
                may_nanalo_na = true;
                bx2.BackColor = Color.MediumSeaGreen;
                bx5.BackColor = Color.MediumSeaGreen;
                bx8.BackColor = Color.MediumSeaGreen;
            }
            else if ((bx3.Text == bx6.Text) && (bx6.Text == bx9.Text) && (!bx3.Enabled))
            {
                may_nanalo_na = true;
                bx3.BackColor = Color.MediumSeaGreen;
                bx6.BackColor = Color.MediumSeaGreen;
                bx9.BackColor = Color.MediumSeaGreen;
            }

            //diagonal
            else if ((bx1.Text == bx5.Text) && (bx5.Text == bx9.Text) && (!bx1.Enabled))
            {
                may_nanalo_na = true;
                bx1.BackColor = Color.MediumSeaGreen;
                bx5.BackColor = Color.MediumSeaGreen;
                bx9.BackColor = Color.MediumSeaGreen;
            }
            else if ((bx3.Text == bx5.Text) && (bx5.Text == bx7.Text) && (!bx3.Enabled))
            {
                may_nanalo_na = true;
                bx3.BackColor = Color.MediumSeaGreen;
                bx5.BackColor = Color.MediumSeaGreen;
                bx7.BackColor = Color.MediumSeaGreen;
            }

            if (may_nanalo_na)
            {
                disableButtons();
                String nanalo = " ";
                if (pasa)
                    nanalo = "O";
                else
                    nanalo = "X";
                MessageBox.Show(nanalo + " Wins!");
            }//end ng if
            else
            {
                if (pasa_count == 9)
                    MessageBox.Show(" Draw!");
            }
        }//end ng look panalo

        private void disableButtons()

        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button btn = (Button)c;
                    btn.Enabled = false;
                    btn_again.Enabled = true;
                }//foreach end
            }//end ng try
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            pasa = true;
            pasa_count = 0;

            try
            {
                foreach (Component c in Controls)
                {
                    Button btn = (Button)c;
                    btn.Enabled = true;
                    btn.Text = " ";

                }//foreach end

            }//end ng try
            catch { }
        }

        private void btn_enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (pasa)
                btn.Text = "X";
            else
                btn.Text = "O";
        }//end ng btn_enter

        private void btn_leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                btn.Text = "";
            }//end ng if

        }//end ng btn_leave
    }
}
