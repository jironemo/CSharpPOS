namespace WindowsFormsApp1
{
    partial class NewSale
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
            this.components = new System.ComponentModel.Container();
            this.txt_item_num = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_cus_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cus_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_item_num
            // 
            this.txt_item_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item_num.Location = new System.Drawing.Point(29, 42);
            this.txt_item_num.Name = "txt_item_num";
            this.txt_item_num.Size = new System.Drawing.Size(249, 26);
            this.txt_item_num.TabIndex = 21;
            this.txt_item_num.TextChanged += new System.EventHandler(this.txt_item_num_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "ပစ္စည်းအမှတ်";
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cus_name.Location = new System.Drawing.Point(28, 332);
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.Size = new System.Drawing.Size(250, 26);
            this.txt_cus_name.TabIndex = 22;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(24, 303);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(88, 25);
            this.lbl_name.TabIndex = 23;
            this.lbl_name.Text = "ဝယ်သူအမည်";
            // 
            // txt_cus_ad
            // 
            this.txt_cus_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cus_ad.Location = new System.Drawing.Point(32, 397);
            this.txt_cus_ad.Name = "txt_cus_ad";
            this.txt_cus_ad.Size = new System.Drawing.Size(250, 26);
            this.txt_cus_ad.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "ဝယ်သူလိပ်စာ";
            // 
            // txt_cus_phone
            // 
            this.txt_cus_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cus_phone.Location = new System.Drawing.Point(30, 463);
            this.txt_cus_phone.Name = "txt_cus_phone";
            this.txt_cus_phone.Size = new System.Drawing.Size(250, 26);
            this.txt_cus_phone.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "ဖုန်းနံပါတ်";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 212);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(308, 572);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt_cus_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cus_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_item_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cus_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "NewSale";
            this.Text = "NewSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_item_num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_cus_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cus_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}