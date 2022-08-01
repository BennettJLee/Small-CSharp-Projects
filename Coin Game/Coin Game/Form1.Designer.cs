namespace Coin_Game
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
            this.pictureBoxHeads = new System.Windows.Forms.PictureBox();
            this.pictureBoxTails = new System.Windows.Forms.PictureBox();
            this.radioButtonHeads = new System.Windows.Forms.RadioButton();
            this.radioButtonTails = new System.Windows.Forms.RadioButton();
            this.buttonTossCoins = new System.Windows.Forms.Button();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxBetting = new System.Windows.Forms.TextBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHeads
            // 
            this.pictureBoxHeads.Image = global::Coin_Game.Properties.Resources.Bit_Coin_H;
            this.pictureBoxHeads.InitialImage = null;
            this.pictureBoxHeads.Location = new System.Drawing.Point(225, 53);
            this.pictureBoxHeads.Name = "pictureBoxHeads";
            this.pictureBoxHeads.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeads.TabIndex = 0;
            this.pictureBoxHeads.TabStop = false;
            // 
            // pictureBoxTails
            // 
            this.pictureBoxTails.Image = global::Coin_Game.Properties.Resources.Bit_Coin_T;
            this.pictureBoxTails.InitialImage = null;
            this.pictureBoxTails.Location = new System.Drawing.Point(431, 53);
            this.pictureBoxTails.Name = "pictureBoxTails";
            this.pictureBoxTails.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTails.TabIndex = 1;
            this.pictureBoxTails.TabStop = false;
            // 
            // radioButtonHeads
            // 
            this.radioButtonHeads.AutoSize = true;
            this.radioButtonHeads.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeads.Location = new System.Drawing.Point(34, 171);
            this.radioButtonHeads.Name = "radioButtonHeads";
            this.radioButtonHeads.Size = new System.Drawing.Size(82, 29);
            this.radioButtonHeads.TabIndex = 2;
            this.radioButtonHeads.TabStop = true;
            this.radioButtonHeads.Text = "Heads";
            this.radioButtonHeads.UseVisualStyleBackColor = true;
            // 
            // radioButtonTails
            // 
            this.radioButtonTails.AutoSize = true;
            this.radioButtonTails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTails.Location = new System.Drawing.Point(125, 171);
            this.radioButtonTails.Name = "radioButtonTails";
            this.radioButtonTails.Size = new System.Drawing.Size(66, 29);
            this.radioButtonTails.TabIndex = 3;
            this.radioButtonTails.TabStop = true;
            this.radioButtonTails.Text = "Tails";
            this.radioButtonTails.UseVisualStyleBackColor = true;
            // 
            // buttonTossCoins
            // 
            this.buttonTossCoins.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTossCoins.Location = new System.Drawing.Point(53, 206);
            this.buttonTossCoins.Name = "buttonTossCoins";
            this.buttonTossCoins.Size = new System.Drawing.Size(138, 47);
            this.buttonTossCoins.TabIndex = 4;
            this.buttonTossCoins.Text = "Toss Coins";
            this.buttonTossCoins.UseVisualStyleBackColor = true;
            this.buttonTossCoins.Click += new System.EventHandler(this.buttonTossCoins_Click);
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(34, 53);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(157, 39);
            this.textBoxBalance.TabIndex = 5;
            this.textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBetting
            // 
            this.textBoxBetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBetting.Location = new System.Drawing.Point(34, 126);
            this.textBoxBetting.Name = "textBoxBetting";
            this.textBoxBetting.Size = new System.Drawing.Size(157, 39);
            this.textBoxBetting.TabIndex = 6;
            this.textBoxBetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResults
            // 
            this.textBoxResults.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResults.Location = new System.Drawing.Point(352, 293);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(157, 39);
            this.textBoxResults.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(105, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "betting amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.textBoxBetting);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.buttonTossCoins);
            this.Controls.Add(this.radioButtonTails);
            this.Controls.Add(this.radioButtonHeads);
            this.Controls.Add(this.pictureBoxTails);
            this.Controls.Add(this.pictureBoxHeads);
            this.Name = "Form1";
            this.Text = "Coin Flip";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHeads;
        private System.Windows.Forms.PictureBox pictureBoxTails;
        private System.Windows.Forms.RadioButton radioButtonHeads;
        private System.Windows.Forms.RadioButton radioButtonTails;
        private System.Windows.Forms.Button buttonTossCoins;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxBetting;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

