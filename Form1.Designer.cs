
namespace Baloon_Game
{
    partial class Form_Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_Soh = new System.Windows.Forms.Button();
            this.btn_sa = new System.Windows.Forms.Button();
            this.btn_pg = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.Image_showBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image_showBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_load.Location = new System.Drawing.Point(111, 335);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(184, 66);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_spin.Location = new System.Drawing.Point(551, 335);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(208, 66);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_Soh
            // 
            this.btn_Soh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Soh.Location = new System.Drawing.Point(50, 453);
            this.btn_Soh.Name = "btn_Soh";
            this.btn_Soh.Size = new System.Drawing.Size(347, 80);
            this.btn_Soh.TabIndex = 2;
            this.btn_Soh.Text = "Shoot On Head";
            this.btn_Soh.UseVisualStyleBackColor = false;
            // 
            // btn_sa
            // 
            this.btn_sa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sa.Location = new System.Drawing.Point(508, 453);
            this.btn_sa.Name = "btn_sa";
            this.btn_sa.Size = new System.Drawing.Size(316, 80);
            this.btn_sa.TabIndex = 3;
            this.btn_sa.Text = "Shoot Away";
            this.btn_sa.UseVisualStyleBackColor = false;
            // 
            // btn_pg
            // 
            this.btn_pg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pg.Location = new System.Drawing.Point(12, 96);
            this.btn_pg.Name = "btn_pg";
            this.btn_pg.Size = new System.Drawing.Size(61, 64);
            this.btn_pg.TabIndex = 6;
            this.btn_pg.Text = "Play Game";
            this.btn_pg.UseVisualStyleBackColor = false;
            // 
            // btn_ex
            // 
            this.btn_ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ex.Location = new System.Drawing.Point(802, 96);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(65, 64);
            this.btn_ex.TabIndex = 7;
            this.btn_ex.Text = "Exit\r\n";
            this.btn_ex.UseVisualStyleBackColor = false;
            // 
            // Image_showBox
            // 
            this.Image_showBox.Location = new System.Drawing.Point(312, 116);
            this.Image_showBox.Name = "Image_showBox";
            this.Image_showBox.Size = new System.Drawing.Size(220, 243);
            this.Image_showBox.TabIndex = 8;
            this.Image_showBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Balloon\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(891, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image_showBox);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.btn_pg);
            this.Controls.Add(this.btn_sa);
            this.Controls.Add(this.btn_Soh);
            this.Controls.Add(this.btn_load);
            this.Name = "Form_Game";
            this.Text = "Game_Project";
            ((System.ComponentModel.ISupportInitialize)(this.Image_showBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_Soh;
        private System.Windows.Forms.Button btn_sa;
        private System.Windows.Forms.Button btn_pg;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.PictureBox Image_showBox;
        private System.Windows.Forms.Label label1;
    }
}

