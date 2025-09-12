using SfDataGrid_Demo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGrid_Demo
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }
        
        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1002, "Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1003, "Antonio", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1004, "Thomas", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1005, "Christina", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1006, "Hanna", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1007, "Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1008, "Martin", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1009, "Laurence", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1010, "Elizabeth", "Canada", "BOTTM", "Tsawassen"));
        }
    }
}
