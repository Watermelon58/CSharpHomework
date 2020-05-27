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
    public partial class OrderAppForm : Form
    {
        OrderService orderService;
        public String Keyword { get; set; }

        public OrderAppForm()
        {
            orderService = new OrderService();
            OrderItem apple = new OrderItem(1, "apple", 10.0, 80);
            OrderItem egg = new OrderItem(2, "eggs", 1.2, 200);
            OrderItem milk = new OrderItem(3, "milk", 50, 10);

            Order order1 = new Order(1, "Summer", new List<OrderItem> { apple, egg, milk });
            Order order2 = new Order(2, "Lisa", new List<OrderItem> { egg, milk });
            Order order3 = new Order(3, "Lily", new List<OrderItem> { apple, milk });
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            InitializeComponent();

            orderBindingSource.DataSource = orderService.Orders;
            queryWay_cb.SelectedIndex = 0;
            keyword_tb.DataBindings.Add("Text", this, "Keyword");
        }

        private void BindingsReset()
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void addOrder_btn_Click(object sender, EventArgs e)
        {
            EditForm form1 = new EditForm();
            if (form1.ShowDialog() != DialogResult.OK)
            {
                orderService.AddOrder(form1.CurrentOrder);
                BindingsReset();
            }
        }

        private void changeOrder_btn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择需要修改的订单");
                return;
            }
            EditForm form2 = new EditForm(order);
            if (form2.ShowDialog() != DialogResult.OK)
            {
                orderService.UpdateOrder(form2.CurrentOrder);
                BindingsReset();
            }
        }

        private void deleteOrder_btn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if(order == null)
            {
                MessageBox.Show("请选择需要删除的订单");
                return;
            }
            orderService.RemoveOrder(order.OrderId);
            BindingsReset();
        }

        private void exportOrder_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog.FileName;
                orderService.Export(fileName);
            }
        }

        private void importOrder_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog.FileName;
                orderService.Export(fileName);
                BindingsReset();
            }
        }

        private void queryOrder_btn_Click(object sender, EventArgs e)
        {
            switch (queryWay_cb.SelectedIndex)
            {
                case 0://orders
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
                case 1://OrderID
                    int.TryParse(Keyword, out int id);
                    Order order = orderService.GetOrder((uint)id);
                    List<Order> res = new List<Order>();
                    if (order != null) res.Add(order);
                    orderBindingSource.DataSource = res;
                    break;
                case 2://Customer
                    orderBindingSource.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3://Goods
                    orderBindingSource.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                    break;
            }
            orderBindingSource.ResetBindings(true);
        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {
            EditItemForm form3 = new EditItemForm();
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择需要编辑的订单");
                return;
            }
            if (form3.ShowDialog() != DialogResult.OK)
            {
                order.AddItem(form3.CurrentOrderItem);
                BindingsReset();
            }
        }

        private void changeItem_btn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            OrderItem orderItem = itemsBindingSource.Current as OrderItem;
            EditItemForm form4 = new EditItemForm(orderItem);
            if (order == null)
            {
                MessageBox.Show("请选择需要编辑的订单");
                return;
            }
            if (orderItem == null)
            {
                MessageBox.Show("请选择需要编辑的商品");
                return;
            }
            if (form4.ShowDialog() != DialogResult.OK)
            {
                order.Items.Remove(orderItem);
                order.Items.Add(form4.CurrentOrderItem);
                BindingsReset();
            }
        }

        private void deleteItem_btn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            OrderItem orderItem = itemsBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择需要删除的商品");
                return;
            }
            order.RemoveItem(orderItem);
            BindingsReset();
        }
    }
}
