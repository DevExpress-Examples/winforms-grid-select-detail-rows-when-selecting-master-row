using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestMasterDetailSelection
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = GetData(10, 10);
            new MasterDetailSelectionHelper(gridView1);
        }

        BindingList<Customer> GetData(int custCount, int orderCount)
        {
            BindingList<Customer> custList = new BindingList<Customer>();
            Random r = new Random();
            for (int i = 0; i < custCount; i++)
            {
                Customer cust = custList.AddNew();
                cust.ID = i;
                cust.Name = "Name" + i;
                for (int j = 0; j < orderCount; j++)
                {
                    cust.Orders.Add(new Order() { ID = j });
                    int productCount = r.Next(10);
                    for (int k = 0; k < productCount; k++)
                    {
                        cust.Orders[j].Products.Add(new Product() { ID = k, Name = "Product" + k, Price = r.Next(100) });
                    }
                }
            }
            return custList;
        }

        private void gridControl1_ViewRegistered(object sender, DevExpress.XtraGrid.ViewOperationEventArgs e)
        {
            new MasterDetailSelectionHelper(e.View as GridView);
        }
    }

    public class Customer 
    {
        public Customer() 
        {
            _Orders = new BindingList<Order>();
        }
        int _ID = 0;
        string _Name = "";
        BindingList<Order> _Orders;
        
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public BindingList<Order> Orders
        {
            get { return _Orders; }
            set { _Orders = value; }
        }
    }

    public class Order 
    {
        public Order() 
        {
            _Products = new BindingList<Product>();
        }

        int _ID = 0;
        BindingList<Product> _Products;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int Sum
        {
            get 
            {
                int sum = 0;
                foreach(Product product in _Products)
                {
                    sum += product.Price;
                }
                return sum; 
            }
        }
        public BindingList<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
    }

    public class Product 
    {
        public Product() { }
        int _ID = 0;
        string _Name = "";
        int _Price = 0;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }


    }
}
