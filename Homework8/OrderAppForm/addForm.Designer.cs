namespace OrderAppForm
{
    partial class EditForm
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
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.orderId_txt = new System.Windows.Forms.TextBox();
            this.customer_txt = new System.Windows.Forms.TextBox();
            this.订单号 = new System.Windows.Forms.Label();
            this.客户名 = new System.Windows.Forms.Label();
            this.wrongInfo = new System.Windows.Forms.Label();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addOrder_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addOrder_btn.Location = new System.Drawing.Point(186, 166);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(75, 28);
            this.addOrder_btn.TabIndex = 1;
            this.addOrder_btn.Text = "保存";
            this.addOrder_btn.UseVisualStyleBackColor = false;
            this.addOrder_btn.Click += new System.EventHandler(this.addOrder_btn_Click);
            // 
            // orderId_txt
            // 
            this.orderId_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderId_txt.Location = new System.Drawing.Point(160, 37);
            this.orderId_txt.Name = "orderId_txt";
            this.orderId_txt.Size = new System.Drawing.Size(191, 25);
            this.orderId_txt.TabIndex = 2;
            // 
            // customer_txt
            // 
            this.customer_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_txt.Location = new System.Drawing.Point(160, 100);
            this.customer_txt.Name = "customer_txt";
            this.customer_txt.Size = new System.Drawing.Size(191, 25);
            this.customer_txt.TabIndex = 3;
            // 
            // 订单号
            // 
            this.订单号.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.订单号.AutoSize = true;
            this.订单号.Location = new System.Drawing.Point(75, 40);
            this.订单号.Name = "订单号";
            this.订单号.Size = new System.Drawing.Size(52, 15);
            this.订单号.TabIndex = 4;
            this.订单号.Text = "订单号";
            // 
            // 客户名
            // 
            this.客户名.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.客户名.AutoSize = true;
            this.客户名.Location = new System.Drawing.Point(78, 103);
            this.客户名.Name = "客户名";
            this.客户名.Size = new System.Drawing.Size(52, 15);
            this.客户名.TabIndex = 5;
            this.客户名.Text = "客户名";
            // 
            // wrongInfo
            // 
            this.wrongInfo.AutoSize = true;
            this.wrongInfo.Location = new System.Drawing.Point(160, 69);
            this.wrongInfo.Name = "wrongInfo";
            this.wrongInfo.Size = new System.Drawing.Size(0, 15);
            this.wrongInfo.TabIndex = 6;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 206);
            this.Controls.Add(this.wrongInfo);
            this.Controls.Add(this.客户名);
            this.Controls.Add(this.订单号);
            this.Controls.Add(this.customer_txt);
            this.Controls.Add(this.orderId_txt);
            this.Controls.Add(this.addOrder_btn);
            this.Name = "EditForm";
            this.Text = "addForm";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.TextBox orderId_txt;
        private System.Windows.Forms.TextBox customer_txt;
        private System.Windows.Forms.Label 订单号;
        private System.Windows.Forms.Label 客户名;
        private System.Windows.Forms.Label wrongInfo;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}