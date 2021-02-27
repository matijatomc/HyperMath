namespace HyperMath
{
    partial class FormaPermutacijeSPonavljanjem
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
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnUnesiK = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtRjesenje = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtR.Location = new System.Drawing.Point(57, 88);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(197, 23);
            this.txtR.TabIndex = 3;
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtK.Location = new System.Drawing.Point(57, 134);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(197, 23);
            this.txtK.TabIndex = 12;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.FlatAppearance.BorderSize = 0;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.ForeColor = System.Drawing.Color.White;
            this.btnIzracunaj.Location = new System.Drawing.Point(57, 267);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(118, 20);
            this.btnIzracunaj.TabIndex = 14;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Visible = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnUnesiK
            // 
            this.btnUnesiK.FlatAppearance.BorderSize = 0;
            this.btnUnesiK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiK.ForeColor = System.Drawing.Color.White;
            this.btnUnesiK.Location = new System.Drawing.Point(57, 163);
            this.btnUnesiK.Name = "btnUnesiK";
            this.btnUnesiK.Size = new System.Drawing.Size(90, 27);
            this.btnUnesiK.TabIndex = 13;
            this.btnUnesiK.Text = "Unesi";
            this.btnUnesiK.UseVisualStyleBackColor = true;
            this.btnUnesiK.Click += new System.EventHandler(this.btnUnesiK_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtN.Location = new System.Drawing.Point(57, 238);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(197, 23);
            this.txtN.TabIndex = 15;
            this.txtN.Visible = false;
            // 
            // txtRjesenje
            // 
            this.txtRjesenje.Location = new System.Drawing.Point(57, 334);
            this.txtRjesenje.Name = "txtRjesenje";
            this.txtRjesenje.ReadOnly = true;
            this.txtRjesenje.Size = new System.Drawing.Size(197, 20);
            this.txtRjesenje.TabIndex = 16;
            this.txtRjesenje.Visible = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(12, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(434, 39);
            this.lblNaslov.TabIndex = 18;
            this.lblNaslov.Text = "Permutacije s ponavljanjem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Upišite koliko K-ova želite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "K:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "N:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rješenje:";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HyperMath.Properties.Resources.formulaPSP;
            this.pictureBox1.Location = new System.Drawing.Point(483, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 215);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Image = global::HyperMath.Properties.Resources.btnNazad;
            this.btnNazad.Location = new System.Drawing.Point(673, 405);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(115, 33);
            this.btnNazad.TabIndex = 17;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // FormaPermutacijeSPonavljanjem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtRjesenje);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.btnUnesiK);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaPermutacijeSPonavljanjem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperMath";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnUnesiK;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtRjesenje;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}