namespace WindowsFormsApp1
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btn_stock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_add_sale = new FontAwesome.Sharp.IconButton();
            this.btn_add_buyin = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_stock.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_stock.Location = new System.Drawing.Point(59, 21);
            this.btn_stock.Margin = new System.Windows.Forms.Padding(1);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(340, 200);
            this.btn_stock.TabIndex = 0;
            this.btn_stock.Text = "Shop\r\nဆိုင်နှင့်ပတ်သတ်သော";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(59, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 200);
            this.button2.TabIndex = 1;
            this.button2.Text = "ATC Savings\r\nငွေစုစာရင်းများ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add_sale
            // 
            this.btn_add_sale.BackColor = System.Drawing.Color.Firebrick;
            this.btn_add_sale.FlatAppearance.BorderSize = 0;
            this.btn_add_sale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_sale.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_add_sale.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_sale.ForeColor = System.Drawing.Color.White;
            this.btn_add_sale.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_add_sale.IconColor = System.Drawing.Color.White;
            this.btn_add_sale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_sale.IconSize = 48;
            this.btn_add_sale.Location = new System.Drawing.Point(406, 21);
            this.btn_add_sale.Name = "btn_add_sale";
            this.btn_add_sale.Rotation = 0D;
            this.btn_add_sale.Size = new System.Drawing.Size(270, 95);
            this.btn_add_sale.TabIndex = 2;
            this.btn_add_sale.Text = "အရောင်းစာရင်းအသစ်ထည့်ရန်";
            this.btn_add_sale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_sale.UseVisualStyleBackColor = false;
            this.btn_add_sale.Click += new System.EventHandler(this.btn_add_sale_Click);
            // 
            // btn_add_buyin
            // 
            this.btn_add_buyin.BackColor = System.Drawing.Color.Firebrick;
            this.btn_add_buyin.FlatAppearance.BorderSize = 0;
            this.btn_add_buyin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_buyin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_add_buyin.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_buyin.ForeColor = System.Drawing.Color.White;
            this.btn_add_buyin.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btn_add_buyin.IconColor = System.Drawing.Color.White;
            this.btn_add_buyin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_buyin.IconSize = 48;
            this.btn_add_buyin.Location = new System.Drawing.Point(406, 126);
            this.btn_add_buyin.Name = "btn_add_buyin";
            this.btn_add_buyin.Rotation = 0D;
            this.btn_add_buyin.Size = new System.Drawing.Size(270, 95);
            this.btn_add_buyin.TabIndex = 3;
            this.btn_add_buyin.Text = "ဝယ်ယူစာရင်းအသစ်ထည့်ရန်";
            this.btn_add_buyin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_buyin.UseVisualStyleBackColor = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.btn_add_buyin);
            this.Controls.Add(this.btn_add_sale);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Menu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button button2;
        private FontAwesome.Sharp.IconButton btn_add_sale;
        private FontAwesome.Sharp.IconButton btn_add_buyin;
    }
}