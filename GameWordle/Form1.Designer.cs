namespace GameWordle
{
    partial class Form1
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
            this.lblTebak = new System.Windows.Forms.Label();
            this.textBoxTebakBerapa = new System.Windows.Forms.TextBox();
            this.labelKesempatan = new System.Windows.Forms.Label();
            this.buttonMulai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTebak
            // 
            this.lblTebak.AutoSize = true;
            this.lblTebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTebak.Location = new System.Drawing.Point(209, 116);
            this.lblTebak.Name = "lblTebak";
            this.lblTebak.Size = new System.Drawing.Size(357, 26);
            this.lblTebak.TabIndex = 0;
            this.lblTebak.Text = "WELCOME TO WORDLE GAME";
            // 
            // textBoxTebakBerapa
            // 
            this.textBoxTebakBerapa.Location = new System.Drawing.Point(259, 186);
            this.textBoxTebakBerapa.Name = "textBoxTebakBerapa";
            this.textBoxTebakBerapa.Size = new System.Drawing.Size(214, 20);
            this.textBoxTebakBerapa.TabIndex = 1;
            this.textBoxTebakBerapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTebakBerapa_KeyPress);
            // 
            // labelKesempatan
            // 
            this.labelKesempatan.AutoSize = true;
            this.labelKesempatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKesempatan.ForeColor = System.Drawing.Color.IndianRed;
            this.labelKesempatan.Location = new System.Drawing.Point(232, 159);
            this.labelKesempatan.Name = "labelKesempatan";
            this.labelKesempatan.Size = new System.Drawing.Size(299, 15);
            this.labelKesempatan.TabIndex = 2;
            this.labelKesempatan.Text = "Masukkan Angka untuk kesempatan menebak";
            // 
            // buttonMulai
            // 
            this.buttonMulai.Location = new System.Drawing.Point(307, 236);
            this.buttonMulai.Name = "buttonMulai";
            this.buttonMulai.Size = new System.Drawing.Size(123, 23);
            this.buttonMulai.TabIndex = 3;
            this.buttonMulai.Text = "Let\'s Go!";
            this.buttonMulai.UseVisualStyleBackColor = true;
            this.buttonMulai.Click += new System.EventHandler(this.buttonMulai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMulai);
            this.Controls.Add(this.labelKesempatan);
            this.Controls.Add(this.textBoxTebakBerapa);
            this.Controls.Add(this.lblTebak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTebak;
        private System.Windows.Forms.TextBox textBoxTebakBerapa;
        private System.Windows.Forms.Label labelKesempatan;
        private System.Windows.Forms.Button buttonMulai;
    }
}

