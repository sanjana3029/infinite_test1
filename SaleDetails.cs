using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class SaleDetails
    {
        private int salesno;
        private int Productno;
        private double Price;
        private DateTime dateofsale;
        private int Qty;
        private double TotalAmount;
    
     public SaleDetails(int salesno ,int Productno, double Price, string dateofsale, int Qty)
        {
            this.salesno = salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = DateTime.ParseExact(dateofsale, "d/M/yyyy", null);
            this.Qty = Qty;
            this.TotalAmount = TotalAmount;
           
        }
        public void Sales()
        {
            this.TotalAmount = Qty * Price;
        }

        public void Showdata()
        {
            Console.WriteLine($"Sales Number: {salesno}");
            Console.WriteLine($"Product Number: {Productno}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Date of Sale: {dateofsale.ToString("d/M/yyyy")}"); // Format for display

            Console.WriteLine($"Total Amount: ${TotalAmount}");
            /*Console.WriteLine($"{salesno},{Productno},{Price},{Qty},{TotalAmount},{dateofsale:ToShortDateString()}")*/
            
        }


    }
}
