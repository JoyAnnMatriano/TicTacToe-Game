
namespace TicTacToe_Game
{
    partial class TicTacToe_bx_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label score_label;
            this.bx1 = new System.Windows.Forms.Button();
            this.bx2 = new System.Windows.Forms.Button();
            this.bx3 = new System.Windows.Forms.Button();
            this.bx4 = new System.Windows.Forms.Button();
            this.bx5 = new System.Windows.Forms.Button();
            this.bx6 = new System.Windows.Forms.Button();
            this.bx7 = new System.Windows.Forms.Button();
            this.bx8 = new System.Windows.Forms.Button();
            this.bx9 = new System.Windows.Forms.Button();
            this.bg_pic = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.label_Draw = new System.Windows.Forms.Label();
            this.count_x_wins = new System.Windows.Forms.Label();
            this.count_o_wins = new System.Windows.Forms.Label();
            this.count_draw_wins = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            score_label = new System.Windows.Forms.Label();
            this.bg_pic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Minecraft Evenings", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(0, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(542, 91);
            label1.TabIndex = 1;
            label1.Text = "TIC TAC TOE";
            // 
            // score_label
            // 
            score_label.AutoSize = true;
            score_label.BackColor = System.Drawing.Color.Transparent;
            score_label.Font = new System.Drawing.Font("Blox (BRK)", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            score_label.Location = new System.Drawing.Point(16, 0);
            score_label.Name = "score_label";
            score_label.Size = new System.Drawing.Size(191, 63);
            score_label.TabIndex = 1;
            score_label.Text = "sCoRe";
            // 
            // bx1
            // 
            this.bx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx1.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx1.Location = new System.Drawing.Point(16, 130);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(106, 95);
            this.bx1.TabIndex = 0;
            this.bx1.UseVisualStyleBackColor = true;
            this.bx1.Click += new System.EventHandler(this.bx_click);
            this.bx1.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx1.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx2
            // 
            this.bx2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx2.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx2.Location = new System.Drawing.Point(128, 130);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(106, 95);
            this.bx2.TabIndex = 0;
            this.bx2.UseVisualStyleBackColor = true;
            this.bx2.Click += new System.EventHandler(this.bx_click);
            this.bx2.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx2.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx3
            // 
            this.bx3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx3.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx3.Location = new System.Drawing.Point(240, 130);
            this.bx3.Name = "bx3";
            this.bx3.Size = new System.Drawing.Size(106, 95);
            this.bx3.TabIndex = 0;
            this.bx3.UseVisualStyleBackColor = true;
            this.bx3.Click += new System.EventHandler(this.bx_click);
            this.bx3.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx3.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx4
            // 
            this.bx4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx4.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx4.Location = new System.Drawing.Point(16, 231);
            this.bx4.Name = "bx4";
            this.bx4.Size = new System.Drawing.Size(106, 95);
            this.bx4.TabIndex = 0;
            this.bx4.UseVisualStyleBackColor = true;
            this.bx4.Click += new System.EventHandler(this.bx_click);
            this.bx4.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx4.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx5
            // 
            this.bx5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx5.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx5.Location = new System.Drawing.Point(128, 231);
            this.bx5.Name = "bx5";
            this.bx5.Size = new System.Drawing.Size(106, 95);
            this.bx5.TabIndex = 0;
            this.bx5.UseVisualStyleBackColor = true;
            this.bx5.Click += new System.EventHandler(this.bx_click);
            this.bx5.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx5.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx6
            // 
            this.bx6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx6.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx6.Location = new System.Drawing.Point(240, 231);
            this.bx6.Name = "bx6";
            this.bx6.Size = new System.Drawing.Size(106, 95);
            this.bx6.TabIndex = 0;
            this.bx6.UseVisualStyleBackColor = true;
            this.bx6.Click += new System.EventHandler(this.bx_click);
            this.bx6.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx6.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx7
            // 
            this.bx7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx7.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx7.Location = new System.Drawing.Point(16, 332);
            this.bx7.Name = "bx7";
            this.bx7.Size = new System.Drawing.Size(106, 95);
            this.bx7.TabIndex = 0;
            this.bx7.UseVisualStyleBackColor = true;
            this.bx7.Click += new System.EventHandler(this.bx_click);
            this.bx7.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx7.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx8
            // 
            this.bx8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx8.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx8.Location = new System.Drawing.Point(128, 332);
            this.bx8.Name = "bx8";
            this.bx8.Size = new System.Drawing.Size(106, 95);
            this.bx8.TabIndex = 0;
            this.bx8.UseVisualStyleBackColor = true;
            this.bx8.Click += new System.EventHandler(this.bx_click);
            this.bx8.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx8.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bx9
            // 
            this.bx9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx9.Font = new System.Drawing.Font("Minecraft Evenings", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bx9.Location = new System.Drawing.Point(240, 332);
            this.bx9.Name = "bx9";
            this.bx9.Size = new System.Drawing.Size(106, 95);
            this.bx9.TabIndex = 0;
            this.bx9.UseVisualStyleBackColor = true;
            this.bx9.Click += new System.EventHandler(this.bx_click);
            this.bx9.MouseEnter += new System.EventHandler(this.btn_enter);
            this.bx9.MouseLeave += new System.EventHandler(this.btn_leave);
            // 
            // bg_pic
            // 
            this.bg_pic.BackgroundImage = global::TicTacToe_Game.Properties.Resources.bg1;
            this.bg_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bg_pic.Controls.Add(this.panel1);
            this.bg_pic.Controls.Add(this.quit_btn);
            this.bg_pic.Controls.Add(this.reset_btn);
            this.bg_pic.Controls.Add(this.bx9);
            this.bg_pic.Controls.Add(this.bx8);
            this.bg_pic.Controls.Add(label1);
            this.bg_pic.Controls.Add(this.bx7);
            this.bg_pic.Controls.Add(this.bx6);
            this.bg_pic.Controls.Add(this.bx1);
            this.bg_pic.Controls.Add(this.bx5);
            this.bg_pic.Controls.Add(this.bx2);
            this.bg_pic.Controls.Add(this.bx3);
            this.bg_pic.Controls.Add(this.bx4);
            this.bg_pic.Location = new System.Drawing.Point(-1, 0);
            this.bg_pic.Name = "bg_pic";
            this.bg_pic.Size = new System.Drawing.Size(605, 628);
            this.bg_pic.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.count_draw_wins);
            this.panel1.Controls.Add(this.count_o_wins);
            this.panel1.Controls.Add(this.count_x_wins);
            this.panel1.Controls.Add(this.label_Draw);
            this.panel1.Controls.Add(this.label_y);
            this.panel1.Controls.Add(this.label_x);
            this.panel1.Controls.Add(score_label);
            this.panel1.Location = new System.Drawing.Point(362, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 332);
            this.panel1.TabIndex = 3;
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(362, 488);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(162, 54);
            this.quit_btn.TabIndex = 2;
            this.quit_btn.Text = "QUIT";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(84, 488);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(162, 54);
            this.reset_btn.TabIndex = 2;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Hobo Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_x.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_x.Location = new System.Drawing.Point(0, 75);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(81, 91);
            this.label_x.TabIndex = 2;
            this.label_x.Text = "X";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Hobo Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_y.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_y.Location = new System.Drawing.Point(0, 166);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(82, 91);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Y";
            // 
            // label_Draw
            // 
            this.label_Draw.AutoSize = true;
            this.label_Draw.Font = new System.Drawing.Font("Hobo Std", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Draw.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Draw.Location = new System.Drawing.Point(-10, 274);
            this.label_Draw.Name = "label_Draw";
            this.label_Draw.Size = new System.Drawing.Size(134, 52);
            this.label_Draw.TabIndex = 2;
            this.label_Draw.Text = "DRAW";
            // 
            // count_x_wins
            // 
            this.count_x_wins.AutoSize = true;
            this.count_x_wins.Font = new System.Drawing.Font("Futura Hv BT", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.count_x_wins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.count_x_wins.Location = new System.Drawing.Point(135, 75);
            this.count_x_wins.Name = "count_x_wins";
            this.count_x_wins.Size = new System.Drawing.Size(72, 77);
            this.count_x_wins.TabIndex = 3;
            this.count_x_wins.Text = "0";
            // 
            // count_o_wins
            // 
            this.count_o_wins.AutoSize = true;
            this.count_o_wins.Font = new System.Drawing.Font("Futura Hv BT", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.count_o_wins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.count_o_wins.Location = new System.Drawing.Point(135, 166);
            this.count_o_wins.Name = "count_o_wins";
            this.count_o_wins.Size = new System.Drawing.Size(72, 77);
            this.count_o_wins.TabIndex = 3;
            this.count_o_wins.Text = "0";
            // 
            // count_draw_wins
            // 
            this.count_draw_wins.AutoSize = true;
            this.count_draw_wins.Font = new System.Drawing.Font("Futura Hv BT", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.count_draw_wins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.count_draw_wins.Location = new System.Drawing.Point(135, 252);
            this.count_draw_wins.Name = "count_draw_wins";
            this.count_draw_wins.Size = new System.Drawing.Size(72, 77);
            this.count_draw_wins.TabIndex = 3;
            this.count_draw_wins.Text = "0";
            // 
            // TicTacToe_bx_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 625);
            this.Controls.Add(this.bg_pic);
            this.Name = "TicTacToe_bx_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bg_pic.ResumeLayout(false);
            this.bg_pic.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bx1;
        private System.Windows.Forms.Button bx2;
        private System.Windows.Forms.Button bx3;
        private System.Windows.Forms.Button bx4;
        private System.Windows.Forms.Button bx5;
        private System.Windows.Forms.Button bx6;
        private System.Windows.Forms.Button bx7;
        private System.Windows.Forms.Button bx8;
        private System.Windows.Forms.Button bx9;
        private System.Windows.Forms.Panel bg_pic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Label count_draw_wins;
        private System.Windows.Forms.Label count_o_wins;
        private System.Windows.Forms.Label count_x_wins;
        private System.Windows.Forms.Label label_Draw;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Label label_x;
    }
}

