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
            reset_btn.MouseEnter += MouseEnter1;
            reset_btn.MouseLeave += MouseLeave1;
        }
        private void MouseEnter1(object sender, EventArgs e)
        {
            reset_btn.BackColor = Color.DarkMagenta ;
        }
        private void MouseLeave1(object sender, EventArgs e)
        {
            reset_btn.BackColor = Color.Indigo;
        }

        private void bx_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (pasa)
            {
                btn.Text = "X";
                o_turn();
            }
            else
            {
                btn.Text = "O";
                x_turn();
            }
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
                bx1.BackColor = Color.DarkOrchid;
                bx2.BackColor = Color.DarkOrchid;
                bx3.BackColor = Color.DarkOrchid;
            }
            else if ((bx4.Text == bx5.Text) && (bx5.Text == bx6.Text) && (!bx4.Enabled))
            {
                may_nanalo_na = true;
                bx4.BackColor = Color.DarkOrchid;
                bx5.BackColor = Color.DarkOrchid;
                bx6.BackColor = Color.DarkOrchid;
            }
            else if ((bx7.Text == bx8.Text) && (bx8.Text == bx9.Text) && (!bx7.Enabled))
            {
                may_nanalo_na = true;
                bx7.BackColor = Color.DarkOrchid;
                bx8.BackColor = Color.DarkOrchid;
                bx9.BackColor = Color.DarkOrchid;
            }
            //vertical
            if ((bx1.Text == bx4.Text) && (bx4.Text == bx7.Text) && (!bx1.Enabled))
            {
                may_nanalo_na = true;
                bx1.BackColor = Color.DarkOrchid;
                bx4.BackColor = Color.DarkOrchid;
                bx7.BackColor = Color.DarkOrchid;
            }
            else if ((bx2.Text == bx5.Text) && (bx5.Text == bx8.Text) && (!bx2.Enabled))
            {
                may_nanalo_na = true;
                bx2.BackColor = Color.DarkOrchid;
                bx5.BackColor = Color.DarkOrchid;
                bx8.BackColor = Color.DarkOrchid;
            }
            else if ((bx3.Text == bx6.Text) && (bx6.Text == bx9.Text) && (!bx3.Enabled))
            {
                may_nanalo_na = true;
                bx3.BackColor = Color.DarkOrchid;
                bx6.BackColor = Color.DarkOrchid;
                bx9.BackColor = Color.DarkOrchid;
            }

            //diagonal
            else if ((bx1.Text == bx5.Text) && (bx5.Text == bx9.Text) && (!bx1.Enabled))
            {
                may_nanalo_na = true;
                bx1.BackColor = Color.DarkOrchid;
                bx5.BackColor = Color.DarkOrchid;
                bx9.BackColor = Color.DarkOrchid;
            }
            else if ((bx3.Text == bx5.Text) && (bx5.Text == bx7.Text) && (!bx3.Enabled))
            {
                may_nanalo_na = true;
                bx3.BackColor = Color.DarkOrchid;
                bx5.BackColor = Color.DarkOrchid;
                bx7.BackColor = Color.DarkOrchid;
            }
            if (may_nanalo_na)
            {
                disableButtons();
                String nanalo = " ";
                if (pasa)
                {
                    nanalo = "O";
                    o_turn();
                    count_o_wins.Text = (Int32.Parse(count_o_wins.Text) + 1).ToString();
                    pasa_count = 0;
                    disableButtons();
                }
                else
                {
                    nanalo = "X";
                    x_turn();
                    count_x_wins.Text = (Int32.Parse(count_x_wins.Text) + 1).ToString();
                    pasa_count = 0;
                    disableButtons();
                }
                MessageBox.Show(nanalo + " Wins!");
            }//end ng if
            else
            {
                if (pasa_count == 9)
                {
                    MessageBox.Show(" Draw!");
                    count_draw_wins.Text = (Int32.Parse(count_draw_wins.Text) + 1).ToString();
                    pasa_count = 0;
                    disableButtons();
                }
            }
        }//end ng look panalo

        private void disableButtons()
        {
            bx1.Enabled = false;
            bx2.Enabled = false;
            bx3.Enabled = false;
            bx4.Enabled = false;
            bx5.Enabled = false;
            bx6.Enabled = false;
            bx7.Enabled = false;
            bx8.Enabled = false;
            bx9.Enabled = false;
            reset_btn.Enabled = true;
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
            {
                btn.Text = "X";
                x_turn();
            }
            else
            {
                btn.Text = "O";
                o_turn();
            }
        }//end ng btn_enter

        private void btn_leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Enabled)
            {
                btn.Text = "";
            }//end ng if
        }//end ng btn_leave

        private void reset_btn_Click(object sender, EventArgs e)
        {
            //enable buttons
            bx1.Enabled = true;
            bx2.Enabled = true;
            bx3.Enabled = true;
            bx4.Enabled = true;
            bx5.Enabled = true;
            bx6.Enabled = true;
            bx7.Enabled = true;
            bx8.Enabled = true;
            bx9.Enabled = true;

            //clear texts on boxes
            bx1.Text = "";
            bx2.Text = "";
            bx3.Text = "";
            bx4.Text = "";
            bx5.Text = "";
            bx6.Text = "";
            bx7.Text = "";
            bx8.Text = "";
            bx9.Text = "";

            //reset the back colors
            bx1.BackColor = SystemColors.Window;
            bx2.BackColor = SystemColors.Window;
            bx3.BackColor = SystemColors.Window;
            bx4.BackColor = SystemColors.Window;
            bx5.BackColor = SystemColors.Window;
            bx6.BackColor = SystemColors.Window;
            bx7.BackColor = SystemColors.Window;
            bx8.BackColor = SystemColors.Window;
            bx9.BackColor = SystemColors.Window;

            x_wins_btn.BackColor = Color.White;
            label_x.BackColor = Color.White;
            count_x_wins.BackColor = Color.White;

            o_wins_btn.BackColor = Color.White;
            label_o.BackColor = Color.White;
            count_o_wins.BackColor = Color.White;

            pasa_count = 0;
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void x_turn() //Changing of back colors X
        {
            x_wins_btn.BackColor = Color.Gold;
            label_x.BackColor = Color.Gold;
            count_x_wins.BackColor = Color.Gold;

            o_wins_btn.BackColor = Color.White;
            label_o.BackColor = Color.White;
            count_o_wins.BackColor = Color.White;
        }
        private void o_turn() //Changing of back colors O
        {
            o_wins_btn.BackColor = Color.Gold;
            label_o.BackColor = Color.Gold;
            count_o_wins.BackColor = Color.Gold;

            x_wins_btn.BackColor = Color.White;
            label_x.BackColor = Color.White;
            count_x_wins.BackColor = Color.White;
        }
    }
}
