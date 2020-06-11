namespace WellStreet
{
    partial class Profil
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
            this.btnMarket = new System.Windows.Forms.Button();
            this.lbstock = new System.Windows.Forms.Label();
            this.lbCash = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbPicProfil = new System.Windows.Forms.PictureBox();
            this.lbProfil = new System.Windows.Forms.Label();
            this.lbStockFull = new System.Windows.Forms.Label();
            this.lbCashFull = new System.Windows.Forms.Label();
            this.lbUserFull = new System.Windows.Forms.Label();
            this.btnChangePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMarket
            // 
            this.btnMarket.BackColor = System.Drawing.Color.White;
            this.btnMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMarket.ForeColor = System.Drawing.Color.Red;
            this.btnMarket.Location = new System.Drawing.Point(448, 324);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(97, 34);
            this.btnMarket.TabIndex = 12;
            this.btnMarket.Text = "Market";
            this.btnMarket.UseVisualStyleBackColor = false;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // lbstock
            // 
            this.lbstock.AutoSize = true;
            this.lbstock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbstock.Location = new System.Drawing.Point(290, 222);
            this.lbstock.Name = "lbstock";
            this.lbstock.Size = new System.Drawing.Size(38, 13);
            this.lbstock.TabIndex = 11;
            this.lbstock.Text = "Stock:";
            // 
            // lbCash
            // 
            this.lbCash.AutoSize = true;
            this.lbCash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCash.Location = new System.Drawing.Point(293, 173);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(34, 13);
            this.lbCash.TabIndex = 10;
            this.lbCash.Text = "Cash:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUser.Location = new System.Drawing.Point(293, 125);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(32, 13);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "User:";
            // 
            // pbPicProfil
            // 
            this.pbPicProfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbPicProfil.Image = global::WellStreet.Properties.Resources.forum_icon;
            this.pbPicProfil.Location = new System.Drawing.Point(31, 108);
            this.pbPicProfil.Name = "pbPicProfil";
            this.pbPicProfil.Size = new System.Drawing.Size(223, 208);
            this.pbPicProfil.TabIndex = 8;
            this.pbPicProfil.TabStop = false;
            // 
            // lbProfil
            // 
            this.lbProfil.AutoSize = true;
            this.lbProfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProfil.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfil.ForeColor = System.Drawing.Color.Red;
            this.lbProfil.Location = new System.Drawing.Point(221, 27);
            this.lbProfil.Name = "lbProfil";
            this.lbProfil.Size = new System.Drawing.Size(150, 45);
            this.lbProfil.TabIndex = 16;
            this.lbProfil.Text = "Profil";
            // 
            // lbStockFull
            // 
            this.lbStockFull.AutoSize = true;
            this.lbStockFull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbStockFull.Location = new System.Drawing.Point(353, 222);
            this.lbStockFull.Name = "lbStockFull";
            this.lbStockFull.Size = new System.Drawing.Size(32, 13);
            this.lbStockFull.TabIndex = 17;
            this.lbStockFull.Text = "User:";
            this.lbStockFull.Click += new System.EventHandler(this.lbStockFull_Click);
            // 
            // lbCashFull
            // 
            this.lbCashFull.AutoSize = true;
            this.lbCashFull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCashFull.Location = new System.Drawing.Point(353, 173);
            this.lbCashFull.Name = "lbCashFull";
            this.lbCashFull.Size = new System.Drawing.Size(32, 13);
            this.lbCashFull.TabIndex = 18;
            this.lbCashFull.Text = "User:";
            this.lbCashFull.Click += new System.EventHandler(this.lbCashFull_Click);
            // 
            // lbUserFull
            // 
            this.lbUserFull.AutoSize = true;
            this.lbUserFull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbUserFull.Location = new System.Drawing.Point(353, 125);
            this.lbUserFull.Name = "lbUserFull";
            this.lbUserFull.Size = new System.Drawing.Size(32, 13);
            this.lbUserFull.TabIndex = 19;
            this.lbUserFull.Text = "User:";
            this.lbUserFull.Click += new System.EventHandler(this.lbUserFull_Click);
            // 
            // btnChangePic
            // 
            this.btnChangePic.BackColor = System.Drawing.Color.White;
            this.btnChangePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePic.ForeColor = System.Drawing.Color.Black;
            this.btnChangePic.Location = new System.Drawing.Point(38, 340);
            this.btnChangePic.Name = "btnChangePic";
            this.btnChangePic.Size = new System.Drawing.Size(216, 34);
            this.btnChangePic.TabIndex = 20;
            this.btnChangePic.Text = "Change profile photo";
            this.btnChangePic.UseVisualStyleBackColor = false;
            this.btnChangePic.Click += new System.EventHandler(this.btnChangePic_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::WellStreet.Properties.Resources.pari2;
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.btnChangePic);
            this.Controls.Add(this.lbUserFull);
            this.Controls.Add(this.lbCashFull);
            this.Controls.Add(this.lbStockFull);
            this.Controls.Add(this.lbProfil);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.lbstock);
            this.Controls.Add(this.lbCash);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbPicProfil);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Profil";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Label lbstock;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pbPicProfil;
        private System.Windows.Forms.Label lbProfil;
        private System.Windows.Forms.Label lbStockFull;
        private System.Windows.Forms.Label lbCashFull;
        private System.Windows.Forms.Label lbUserFull;
        private System.Windows.Forms.Button btnChangePic;
    }
}