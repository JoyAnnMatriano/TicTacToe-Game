﻿
namespace TicTacToe_Game
{
    partial class Form1
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
            this.bx1 = new System.Windows.Forms.Button();
            this.bx2 = new System.Windows.Forms.Button();
            this.bx3 = new System.Windows.Forms.Button();
            this.bx4 = new System.Windows.Forms.Button();
            this.bx5 = new System.Windows.Forms.Button();
            this.bx6 = new System.Windows.Forms.Button();
            this.bx7 = new System.Windows.Forms.Button();
            this.bx8 = new System.Windows.Forms.Button();
            this.bx9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(108, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(385, 86);
            label1.TabIndex = 1;
            label1.Text = "TIC TAC TOE";
            // 
            // bx1
            // 
            this.bx1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx1.Location = new System.Drawing.Point(130, 140);
            this.bx1.Name = "bx1";
            this.bx1.Size = new System.Drawing.Size(106, 95);
            this.bx1.TabIndex = 0;
            this.bx1.UseVisualStyleBackColor = true;
            this.bx1.Click += new System.EventHandler(this.bx_click);
            // 
            // bx2
            // 
            this.bx2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx2.Location = new System.Drawing.Point(242, 140);
            this.bx2.Name = "bx2";
            this.bx2.Size = new System.Drawing.Size(106, 95);
            this.bx2.TabIndex = 0;
            this.bx2.UseVisualStyleBackColor = true;
            this.bx2.Click += new System.EventHandler(this.bx_click);
            // 
            // bx3
            // 
            this.bx3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx3.Location = new System.Drawing.Point(354, 140);
            this.bx3.Name = "bx3";
            this.bx3.Size = new System.Drawing.Size(106, 95);
            this.bx3.TabIndex = 0;
            this.bx3.UseVisualStyleBackColor = true;
            this.bx3.Click += new System.EventHandler(this.bx_click);
            // 
            // bx4
            // 
            this.bx4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx4.Location = new System.Drawing.Point(129, 241);
            this.bx4.Name = "bx4";
            this.bx4.Size = new System.Drawing.Size(106, 95);
            this.bx4.TabIndex = 0;
            this.bx4.UseVisualStyleBackColor = true;
            this.bx4.Click += new System.EventHandler(this.bx_click);
            // 
            // bx5
            // 
            this.bx5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx5.Location = new System.Drawing.Point(241, 241);
            this.bx5.Name = "bx5";
            this.bx5.Size = new System.Drawing.Size(106, 95);
            this.bx5.TabIndex = 0;
            this.bx5.UseVisualStyleBackColor = true;
            this.bx5.Click += new System.EventHandler(this.bx_click);
            // 
            // bx6
            // 
            this.bx6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx6.Location = new System.Drawing.Point(353, 241);
            this.bx6.Name = "bx6";
            this.bx6.Size = new System.Drawing.Size(106, 95);
            this.bx6.TabIndex = 0;
            this.bx6.UseVisualStyleBackColor = true;
            this.bx6.Click += new System.EventHandler(this.bx_click);
            // 
            // bx7
            // 
            this.bx7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx7.Location = new System.Drawing.Point(129, 342);
            this.bx7.Name = "bx7";
            this.bx7.Size = new System.Drawing.Size(106, 95);
            this.bx7.TabIndex = 0;
            this.bx7.UseVisualStyleBackColor = true;
            this.bx7.Click += new System.EventHandler(this.bx_click);
            // 
            // bx8
            // 
            this.bx8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx8.Location = new System.Drawing.Point(241, 342);
            this.bx8.Name = "bx8";
            this.bx8.Size = new System.Drawing.Size(106, 95);
            this.bx8.TabIndex = 0;
            this.bx8.UseVisualStyleBackColor = true;
            this.bx8.Click += new System.EventHandler(this.bx_click);
            // 
            // bx9
            // 
            this.bx9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bx9.Location = new System.Drawing.Point(354, 342);
            this.bx9.Name = "bx9";
            this.bx9.Size = new System.Drawing.Size(106, 95);
            this.bx9.TabIndex = 0;
            this.bx9.UseVisualStyleBackColor = true;
            this.bx9.Click += new System.EventHandler(this.bx_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(213, 481);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(162, 52);
            this.button10.TabIndex = 0;
            this.button10.Text = "Play Again";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 579);
            this.Controls.Add(label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bx9);
            this.Controls.Add(this.bx8);
            this.Controls.Add(this.bx6);
            this.Controls.Add(this.bx5);
            this.Controls.Add(this.bx7);
            this.Controls.Add(this.bx3);
            this.Controls.Add(this.bx4);
            this.Controls.Add(this.bx2);
            this.Controls.Add(this.bx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button10;
    }
}
