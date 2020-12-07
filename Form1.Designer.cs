
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_pg = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.Image_showBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_showBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_load.Location = new System.Drawing.Point(96, 337);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(188, 73);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_spin.Location = new System.Drawing.Point(573, 335);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(186, 66);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_Soh
            // 
            this.btn_Soh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Soh.Location = new System.Drawing.Point(175, 453);
            this.btn_Soh.Name = "btn_Soh";
            this.btn_Soh.Size = new System.Drawing.Size(190, 80);
            this.btn_Soh.TabIndex = 2;
            this.btn_Soh.Text = "Shoot On Head";
            this.btn_Soh.UseVisualStyleBackColor = false;
            // 
            // btn_sa
            // 
            this.btn_sa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_sa.Location = new System.Drawing.Point(551, 453);
            this.btn_sa.Name = "btn_sa";
            this.btn_sa.Size = new System.Drawing.Size(191, 80);
            this.btn_sa.TabIndex = 3;
            this.btn_sa.Text = "Shoot Away";
            this.btn_sa.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(324, 113);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(195, 36);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Baloon Game";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Yellow;
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
            this.Image_showBox.Location = new System.Drawing.Point(317, 152);
            this.Image_showBox.Name = "Image_showBox";
            this.Image_showBox.Size = new System.Drawing.Size(220, 234);
            this.Image_showBox.TabIndex = 8;
            this.Image_showBox.TabStop = false;
            // 
            // Form_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(891, 562);
            this.Controls.Add(this.Image_showBox);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.btn_pg);
            this.Controls.Add(this.linkLabel1);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_pg;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.PictureBox Image_showBox;
    }
}

