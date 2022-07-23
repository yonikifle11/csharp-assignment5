using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateform
{
    internal class Class1
    {
        static private List<Class1> items = new List<Class1>();
        public string objectName { get; set; }
        public string InventoryNumber { get; set; }
        public string date { get; set; }
        public string number { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        
        public void save()
        {
            MessageBox.Show("saved");
        }
        public static List<Class1> GetAllProducts()
        {
            return Class1.GetAllProducts();
        }


    }
}
