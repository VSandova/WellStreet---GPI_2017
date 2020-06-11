namespace WellStreet
{
    partial class Market
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbSellFor = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.listBoxSell = new System.Windows.Forms.ListBox();
            this.listBoxBuy = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxActionsM = new System.Windows.Forms.PictureBox();
            this.pictureBoxCash = new System.Windows.Forms.PictureBox();
            this.pictureBoxActions = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbwarehouse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRestart.Location = new System.Drawing.Point(651, 376);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(81, 36);
            this.btnRestart.TabIndex = 94;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(18, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 36);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxCash
            // 
            this.textBoxCash.Location = new System.Drawing.Point(198, 34);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(100, 20);
            this.textBoxCash.TabIndex = 92;

            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.BackColor = System.Drawing.Color.White;
            this.lbQuantity.Location = new System.Drawing.Point(131, 284);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 88;
            this.lbQuantity.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbQuantity.Location = new System.Drawing.Point(189, 279);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(79, 22);
            this.tbQuantity.TabIndex = 87;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 86;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotal.ForeColor = System.Drawing.Color.Lime;
            this.tbTotal.Location = new System.Drawing.Point(189, 303);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(79, 22);
            this.tbTotal.TabIndex = 85;
            // 
            // lbSellFor
            // 
            this.lbSellFor.AutoSize = true;
            this.lbSellFor.BackColor = System.Drawing.Color.White;
            this.lbSellFor.Location = new System.Drawing.Point(488, 268);
            this.lbSellFor.Name = "lbSellFor";
            this.lbSellFor.Size = new System.Drawing.Size(42, 13);
            this.lbSellFor.TabIndex = 84;
            this.lbSellFor.Text = "Sell for:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(149, 308);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 83;
            this.lbTotal.Text = "Total:";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSell.Location = new System.Drawing.Point(485, 339);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 81;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Lime;
            this.btnBuy.Location = new System.Drawing.Point(129, 331);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 80;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // listBoxSell
            // 
            this.listBoxSell.FormattingEnabled = true;
            this.listBoxSell.Location = new System.Drawing.Point(485, 151);
            this.listBoxSell.Name = "listBoxSell";
            this.listBoxSell.Size = new System.Drawing.Size(120, 95);
            this.listBoxSell.TabIndex = 79;
            // 
            // listBoxBuy
            // 
            this.listBoxBuy.FormattingEnabled = true;
            this.listBoxBuy.Items.AddRange(new object[] {
            "Actions of Adidas",
            "Actions of Puma",
            "Actions of Nike",
            "Actions of Audi",
            "Actions of BMW",
            "Actions of Mercedes",
            "Actions of Skoda",
            "Actions of Volvo",
            "Actions of Volkswagen",
            "Actions of SUBWAY",
            "Actions of KFC",
            "Actions of McDonald\'s",
            "Actions of Barselona",
            "Actions of Bayern Munchen",
            "Actions of BVB",
            "Actions of Chelsea",
            "Actions of Liverpool",
            "Actions of Manchestar City",
            "Actions of Manchestar United ",
            "Actions of Real Madrid "});
            this.listBoxBuy.Location = new System.Drawing.Point(134, 151);
            this.listBoxBuy.Name = "listBoxBuy";
            this.listBoxBuy.Size = new System.Drawing.Size(120, 95);
            this.listBoxBuy.TabIndex = 77;
            this.listBoxBuy.SelectedIndexChanged += new System.EventHandler(this.listBoxBuy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(484, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 41);
            this.label2.TabIndex = 76;
            this.label2.Text = "WareHouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(130, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 78;
            this.label1.Text = "The Market";
            // 
            // pictureBoxActionsM
            // 
            this.pictureBoxActionsM.Image = global::WellStreet.Properties.Resources.home_with_emphasized_roof_318_403371;
            this.pictureBoxActionsM.Location = new System.Drawing.Point(485, 12);
            this.pictureBoxActionsM.Name = "pictureBoxActionsM";
            this.pictureBoxActionsM.Size = new System.Drawing.Size(63, 42);
            this.pictureBoxActionsM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxActionsM.TabIndex = 90;
            this.pictureBoxActionsM.TabStop = false;
            // 
            // pictureBoxCash
            // 
            this.pictureBoxCash.Image = global::WellStreet.Properties.Resources.images;
            this.pictureBoxCash.InitialImage = null;
            this.pictureBoxCash.Location = new System.Drawing.Point(129, 12);
            this.pictureBoxCash.Name = "pictureBoxCash";
            this.pictureBoxCash.Size = new System.Drawing.Size(63, 42);
            this.pictureBoxCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCash.TabIndex = 89;
            this.pictureBoxCash.TabStop = false;
            // 
            // pictureBoxActions
            // 
            this.pictureBoxActions.BackColor = System.Drawing.Color.White;
            this.pictureBoxActions.Location = new System.Drawing.Point(277, 151);
            this.pictureBoxActions.Name = "pictureBoxActions";
            this.pictureBoxActions.Size = new System.Drawing.Size(95, 95);
            this.pictureBoxActions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxActions.TabIndex = 82;
            this.pictureBoxActions.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(149, 260);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 95;
            this.lbPrice.Text = "Price:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Location = new System.Drawing.Point(274, 279);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 97;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.Location = new System.Drawing.Point(189, 255);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(79, 22);
            this.tbPrice.TabIndex = 98;
            // 
            // tbwarehouse
            // 
            this.tbwarehouse.Location = new System.Drawing.Point(554, 34);
            this.tbwarehouse.Name = "tbwarehouse";
            this.tbwarehouse.Size = new System.Drawing.Size(100, 20);
            this.tbwarehouse.TabIndex = 99;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WellStreet.Properties.Resources.pari4;
            this.ClientSize = new System.Drawing.Size(768, 432);
            this.Controls.Add(this.tbwarehouse);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxCash);
            this.Controls.Add(this.pictureBoxActionsM);
            this.Controls.Add(this.pictureBoxCash);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbSellFor);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.pictureBoxActions);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.listBoxSell);
            this.Controls.Add(this.listBoxBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Market";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Market_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActionsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.PictureBox pictureBoxActionsM;
        internal System.Windows.Forms.PictureBox pictureBoxCash;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbSellFor;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.PictureBox pictureBoxActions;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox listBoxSell;
        private System.Windows.Forms.ListBox listBoxBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbwarehouse;
    }
}