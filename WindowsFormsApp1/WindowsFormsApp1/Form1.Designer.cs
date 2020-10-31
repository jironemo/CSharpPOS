namespace WindowsFormsApp1
{
    partial class Tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tables));
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_stock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_stock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.btn_stock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_stock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_stock.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.White;
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.btn_stock.IconColor = System.Drawing.Color.White;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.IconSize = 32;
            this.btn_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stock.Location = new System.Drawing.Point(9, 9);
            this.btn_stock.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Rotation = 0D;
            this.btn_stock.Size = new System.Drawing.Size(100, 38);
            this.btn_stock.TabIndex = 5;
            this.btn_stock.Text = "Stocks";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_stock.UseCompatibleTextRendering = true;
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // main_panel
            // 
            this.main_panel.AutoSize = true;
            this.main_panel.Location = new System.Drawing.Point(5, 57);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1000, 600);
            this.main_panel.TabIndex = 0;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(122, 9);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(100, 38);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "Orders";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseCompatibleTextRendering = true;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(92)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1204, 721);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tables";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_stock;
        private System.Windows.Forms.Panel main_panel;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

