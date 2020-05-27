namespace OrderAppForm
{
    partial class EditItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemName_txt = new System.Windows.Forms.TextBox();
            this.itemPrice_txt = new System.Windows.Forms.TextBox();
            this.itemNum_txt = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.save_btn = new System.Windows.Forms.Button();
            this.index_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "单价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "数量";
            // 
            // itemName_txt
            // 
            this.itemName_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemName_txt.Location = new System.Drawing.Point(127, 85);
            this.itemName_txt.Name = "itemName_txt";
            this.itemName_txt.Size = new System.Drawing.Size(284, 25);
            this.itemName_txt.TabIndex = 3;
            // 
            // itemPrice_txt
            // 
            this.itemPrice_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPrice_txt.Location = new System.Drawing.Point(127, 143);
            this.itemPrice_txt.Name = "itemPrice_txt";
            this.itemPrice_txt.Size = new System.Drawing.Size(284, 25);
            this.itemPrice_txt.TabIndex = 4;
            // 
            // itemNum_txt
            // 
            this.itemNum_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNum_txt.Location = new System.Drawing.Point(127, 200);
            this.itemNum_txt.Name = "itemNum_txt";
            this.itemNum_txt.Size = new System.Drawing.Size(284, 25);
            this.itemNum_txt.TabIndex = 5;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(OrderApp.OrderItem);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_btn.Location = new System.Drawing.Point(218, 269);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "保存";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // index_txt
            // 
            this.index_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.index_txt.Location = new System.Drawing.Point(127, 31);
            this.index_txt.Name = "index_txt";
            this.index_txt.Size = new System.Drawing.Size(284, 25);
            this.index_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "索引";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 321);
            this.Controls.Add(this.index_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.itemNum_txt);
            this.Controls.Add(this.itemPrice_txt);
            this.Controls.Add(this.itemName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditItemForm";
            this.Text = "addItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemName_txt;
        private System.Windows.Forms.TextBox itemPrice_txt;
        private System.Windows.Forms.TextBox itemNum_txt;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox index_txt;
        private System.Windows.Forms.Label label4;
    }
}