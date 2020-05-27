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
    public partial class EditForm : Form
    {
        public Order CurrentOrder { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Order order):this()
        {
            CurrentOrder = order;
            orderBindingSource.DataSource = CurrentOrder;
            orderId_txt.Text = order.OrderId.ToString();
            orderId_txt.ReadOnly = true;
            customer_txt.Text = order.Customer.ToString();
        }

        private void addOrder_btn_Click(object sender, EventArgs e)
        {
            int.TryParse(orderId_txt.Text, out int OrderID);
            CurrentOrder = new Order((uint)OrderID, customer_txt.Text,new List<OrderItem>());
            orderBindingSource.DataSource = CurrentOrder;
            orderBindingSource.ResetBindings(true);
            this.Close();
        }

    }
}
