using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderAppForm
{
    public partial class EditItemForm : Form
    {
        public EditItemForm()
        {
            InitializeComponent();
        }

        public OrderItem CurrentOrderItem { get; set; }


        public EditItemForm(OrderItem orderItem) : this()
        {
            CurrentOrderItem = orderItem;
            itemBindingSource.DataSource = CurrentOrderItem;
            index_txt.Text = orderItem.Index.ToString();
            itemName_txt.Text = orderItem.GoodsName.ToString();
            itemPrice_txt.Text = orderItem.Price.ToString();
            itemNum_txt.Text = orderItem.Quantity.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(index_txt.Text, out int index);
            double.TryParse(itemPrice_txt.Text, out double itemPrice);
            int.TryParse(itemNum_txt.Text, out int itemNum);
            CurrentOrderItem = new OrderItem((uint)index, itemName_txt.Text, itemPrice, (uint)itemNum);
            itemBindingSource.DataSource = CurrentOrderItem;
            itemBindingSource.ResetBindings(true);
            this.Close();
        }
    }
}
