﻿namespace HyperMath
{
    partial class FormaKombinacijeBezPonavljanja
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.txtRjesenje = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblRjesenj = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtN.Location = new System.Drawing.Point(62, 70);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 23);
            this.txtN.TabIndex = 0;
            // 
            // txtK
            // 
            this.txtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtK.Location = new System.Drawing.Point(62, 106);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(161, 23);
            this.txtK.TabIndex = 1;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(58, 155);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 2;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // txtRjesenje
            // 
            this.txtRjesenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRjesenje.Location = new System.Drawing.Point(20, 245);
            this.txtRjesenje.Name = "txtRjesenje";
            this.txtRjesenje.Size = new System.Drawing.Size(203, 23);
            this.txtRjesenje.TabIndex = 3;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNaslov.ForeColor = System.Drawing.Color.White;
            this.lblNaslov.Location = new System.Drawing.Point(13, 12);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(432, 39);
            this.lblNaslov.TabIndex = 5;
            this.lblNaslov.Text = "Kominacije bez ponavljanja";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblN.ForeColor = System.Drawing.Color.White;
            this.lblN.Location = new System.Drawing.Point(14, 62);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(42, 31);
            this.lblN.TabIndex = 6;
            this.lblN.Text = "N:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblK.ForeColor = System.Drawing.Color.White;
            this.lblK.Location = new System.Drawing.Point(14, 98);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(40, 31);
            this.lblK.TabIndex = 7;
            this.lblK.Text = "K:";
            // 
            // lblRjesenj
            // 
            this.lblRjesenj.AutoSize = true;
            this.lblRjesenj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblRjesenj.ForeColor = System.Drawing.Color.White;
            this.lblRjesenj.Location = new System.Drawing.Point(14, 211);
            this.lblRjesenj.Name = "lblRjesenj";
            this.lblRjesenj.Size = new System.Drawing.Size(113, 31);
            this.lblRjesenj.TabIndex = 8;
            this.lblRjesenj.Text = "Rjesenj:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HyperMath.Properties.Resources.formulaKBP;
            this.pictureBox1.Location = new System.Drawing.Point(485, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 279);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.FlatAppearance.BorderSize = 0;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Image = global::HyperMath.Properties.Resources.btnNazad;
            this.btnNazad.Location = new System.Drawing.Point(682, 406);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(106, 32);
            this.btnNazad.TabIndex = 4;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // FormaKombinacijeBezPonavljanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRjesenj);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.txtRjesenje);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaKombinacijeBezPonavljanja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HyperMath";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.TextBox txtRjesenje;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblRjesenj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}