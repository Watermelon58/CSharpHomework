namespace OrderAppForm
{
    partial class OrderAppForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.quaryLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.queryWay_cb = new System.Windows.Forms.ComboBox();
            this.keyword_tb = new System.Windows.Forms.TextBox();
            this.queryOrder_btn = new System.Windows.Forms.Button();
            this.btnLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.changeOrder_btn = new System.Windows.Forms.Button();
            this.deleteOrder_btn = new System.Windows.Forms.Button();
            this.exportOrder_btn = new System.Windows.Forms.Button();
            this.importOrder_btn = new System.Windows.Forms.Button();
            this.addItem_btn = new System.Windows.Forms.Button();
            this.changeItem_btn = new System.Windows.Forms.Button();
            this.deleteItem_btn = new System.Windows.Forms.Button();
            this.OrderShowingContainer = new System.Windows.Forms.SplitContainer();
            this.OrderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.quaryLayoutPanel.SuspendLayout();
            this.btnLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderShowingContainer)).BeginInit();
            this.OrderShowingContainer.Panel1.SuspendLayout();
            this.OrderShowingContainer.Panel2.SuspendLayout();
            this.OrderShowingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quaryLayoutPanel
            // 
            this.quaryLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quaryLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.quaryLayoutPanel.Controls.Add(this.queryWay_cb);
            this.quaryLayoutPanel.Controls.Add(this.keyword_tb);
            this.quaryLayoutPanel.Controls.Add(this.queryOrder_btn);
            this.quaryLayoutPanel.Location = new System.Drawing.Point(4, 3);
            this.quaryLayoutPanel.Name = "quaryLayoutPanel";
            this.quaryLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.quaryLayoutPanel.Size = new System.Drawing.Size(1343, 43);
            this.quaryLayoutPanel.TabIndex = 0;
            // 
            // queryWay_cb
            // 
            this.queryWay_cb.FormattingEnabled = true;
            this.queryWay_cb.Items.AddRange(new object[] {
            "orders",
            "ID",
            "cutomer",
            "goods"});
            this.queryWay_cb.Location = new System.Drawing.Point(8, 8);
            this.queryWay_cb.Name = "queryWay_cb";
            this.queryWay_cb.Size = new System.Drawing.Size(121, 23);
            this.queryWay_cb.TabIndex = 3;
            // 
            // keyword_tb
            // 
            this.keyword_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyword_tb.Location = new System.Drawing.Point(135, 8);
            this.keyword_tb.Name = "keyword_tb";
            this.keyword_tb.Size = new System.Drawing.Size(395, 25);
            this.keyword_tb.TabIndex = 1;
            // 
            // queryOrder_btn
            // 
            this.queryOrder_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.queryOrder_btn.Location = new System.Drawing.Point(536, 8);
            this.queryOrder_btn.Name = "queryOrder_btn";
            this.queryOrder_btn.Size = new System.Drawing.Size(104, 25);
            this.queryOrder_btn.TabIndex = 2;
            this.queryOrder_btn.Text = "查询";
            this.queryOrder_btn.UseVisualStyleBackColor = false;
            this.queryOrder_btn.Click += new System.EventHandler(this.queryOrder_btn_Click);
            // 
            // btnLayoutPanel
            // 
            this.btnLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLayoutPanel.Controls.Add(this.addOrder_btn);
            this.btnLayoutPanel.Controls.Add(this.changeOrder_btn);
            this.btnLayoutPanel.Controls.Add(this.deleteOrder_btn);
            this.btnLayoutPanel.Controls.Add(this.exportOrder_btn);
            this.btnLayoutPanel.Controls.Add(this.importOrder_btn);
            this.btnLayoutPanel.Controls.Add(this.addItem_btn);
            this.btnLayoutPanel.Controls.Add(this.changeItem_btn);
            this.btnLayoutPanel.Controls.Add(this.deleteItem_btn);
            this.btnLayoutPanel.Location = new System.Drawing.Point(4, 52);
            this.btnLayoutPanel.Name = "btnLayoutPanel";
            this.btnLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.btnLayoutPanel.Size = new System.Drawing.Size(1343, 51);
            this.btnLayoutPanel.TabIndex = 1;
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addOrder_btn.Location = new System.Drawing.Point(8, 8);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(122, 34);
            this.addOrder_btn.TabIndex = 0;
            this.addOrder_btn.Text = "添加订单";
            this.addOrder_btn.UseVisualStyleBackColor = false;
            this.addOrder_btn.Click += new System.EventHandler(this.addOrder_btn_Click);
            // 
            // changeOrder_btn
            // 
            this.changeOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeOrder_btn.Location = new System.Drawing.Point(136, 8);
            this.changeOrder_btn.Name = "changeOrder_btn";
            this.changeOrder_btn.Size = new System.Drawing.Size(122, 34);
            this.changeOrder_btn.TabIndex = 1;
            this.changeOrder_btn.Text = "修改订单";
            this.changeOrder_btn.UseVisualStyleBackColor = false;
            this.changeOrder_btn.Click += new System.EventHandler(this.changeOrder_btn_Click);
            // 
            // deleteOrder_btn
            // 
            this.deleteOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteOrder_btn.Location = new System.Drawing.Point(264, 8);
            this.deleteOrder_btn.Name = "deleteOrder_btn";
            this.deleteOrder_btn.Size = new System.Drawing.Size(122, 34);
            this.deleteOrder_btn.TabIndex = 2;
            this.deleteOrder_btn.Text = "删除订单";
            this.deleteOrder_btn.UseVisualStyleBackColor = false;
            this.deleteOrder_btn.Click += new System.EventHandler(this.deleteOrder_btn_Click);
            // 
            // exportOrder_btn
            // 
            this.exportOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exportOrder_btn.Location = new System.Drawing.Point(392, 8);
            this.exportOrder_btn.Name = "exportOrder_btn";
            this.exportOrder_btn.Size = new System.Drawing.Size(122, 34);
            this.exportOrder_btn.TabIndex = 3;
            this.exportOrder_btn.Text = "导出订单";
            this.exportOrder_btn.UseVisualStyleBackColor = false;
            this.exportOrder_btn.Click += new System.EventHandler(this.exportOrder_btn_Click);
            // 
            // importOrder_btn
            // 
            this.importOrder_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.importOrder_btn.Location = new System.Drawing.Point(520, 8);
            this.importOrder_btn.Name = "importOrder_btn";
            this.importOrder_btn.Size = new System.Drawing.Size(122, 34);
            this.importOrder_btn.TabIndex = 4;
            this.importOrder_btn.Text = "导入订单";
            this.importOrder_btn.UseVisualStyleBackColor = false;
            this.importOrder_btn.Click += new System.EventHandler(this.importOrder_btn_Click);
            // 
            // addItem_btn
            // 
            this.addItem_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addItem_btn.Location = new System.Drawing.Point(648, 8);
            this.addItem_btn.Name = "addItem_btn";
            this.addItem_btn.Size = new System.Drawing.Size(122, 34);
            this.addItem_btn.TabIndex = 5;
            this.addItem_btn.Text = "添加商品";
            this.addItem_btn.UseVisualStyleBackColor = false;
            this.addItem_btn.Click += new System.EventHandler(this.addItem_btn_Click);
            // 
            // changeItem_btn
            // 
            this.changeItem_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeItem_btn.Location = new System.Drawing.Point(776, 8);
            this.changeItem_btn.Name = "changeItem_btn";
            this.changeItem_btn.Size = new System.Drawing.Size(122, 34);
            this.changeItem_btn.TabIndex = 6;
            this.changeItem_btn.Text = "修改详情";
            this.changeItem_btn.UseVisualStyleBackColor = false;
            this.changeItem_btn.Click += new System.EventHandler(this.changeItem_btn_Click);
            // 
            // deleteItem_btn
            // 
            this.deleteItem_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteItem_btn.Location = new System.Drawing.Point(904, 8);
            this.deleteItem_btn.Name = "deleteItem_btn";
            this.deleteItem_btn.Size = new System.Drawing.Size(122, 34);
            this.deleteItem_btn.TabIndex = 7;
            this.deleteItem_btn.Text = "删除商品";
            this.deleteItem_btn.UseVisualStyleBackColor = false;
            this.deleteItem_btn.Click += new System.EventHandler(this.deleteItem_btn_Click);
            // 
            // OrderShowingContainer
            // 
            this.OrderShowingContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderShowingContainer.Location = new System.Drawing.Point(0, 109);
            this.OrderShowingContainer.Name = "OrderShowingContainer";
            // 
            // OrderShowingContainer.Panel1
            // 
            this.OrderShowingContainer.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OrderShowingContainer.Panel1.Controls.Add(this.OrderDataGridView);
            // 
            // OrderShowingContainer.Panel2
            // 
            this.OrderShowingContainer.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.OrderShowingContainer.Panel2.Controls.Add(this.ItemDataGridView);
            this.OrderShowingContainer.Size = new System.Drawing.Size(1347, 344);
            this.OrderShowingContainer.SplitterDistance = 614;
            this.OrderShowingContainer.TabIndex = 3;
            // 
            // OrderDataGridView
            // 
            this.OrderDataGridView.AutoGenerateColumns = false;
            this.OrderDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.OrderDataGridView.DataSource = this.orderBindingSource;
            this.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowTemplate.Height = 27;
            this.OrderDataGridView.Size = new System.Drawing.Size(614, 344);
            this.OrderDataGridView.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderApp.Order);
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.AutoGenerateColumns = false;
            this.ItemDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.ItemDataGridView.DataSource = this.itemsBindingSource;
            this.ItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.RowTemplate.Height = 27;
            this.ItemDataGridView.Size = new System.Drawing.Size(729, 344);
            this.ItemDataGridView.TabIndex = 0;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.orderBindingSource;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // OrderAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 453);
            this.Controls.Add(this.OrderShowingContainer);
            this.Controls.Add(this.btnLayoutPanel);
            this.Controls.Add(this.quaryLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(1370, 500);
            this.Name = "OrderAppForm";
            this.Text = "订单管理";
            this.quaryLayoutPanel.ResumeLayout(false);
            this.quaryLayoutPanel.PerformLayout();
            this.btnLayoutPanel.ResumeLayout(false);
            this.OrderShowingContainer.Panel1.ResumeLayout(false);
            this.OrderShowingContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderShowingContainer)).EndInit();
            this.OrderShowingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel quaryLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel btnLayoutPanel;
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.Button changeOrder_btn;
        private System.Windows.Forms.SplitContainer OrderShowingContainer;
        private System.Windows.Forms.TextBox keyword_tb;
        private System.Windows.Forms.Button queryOrder_btn;
        private System.Windows.Forms.Button deleteOrder_btn;
        private System.Windows.Forms.Button exportOrder_btn;
        private System.Windows.Forms.Button importOrder_btn;
        private System.Windows.Forms.DataGridView OrderDataGridView;
        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox queryWay_cb;
        private System.Windows.Forms.Button addItem_btn;
        private System.Windows.Forms.Button changeItem_btn;
        private System.Windows.Forms.Button deleteItem_btn;
    }
}

