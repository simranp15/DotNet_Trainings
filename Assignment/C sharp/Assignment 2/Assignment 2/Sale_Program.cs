using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Sale_Program

    {
        
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateOfSale;
        private int Qty;
        private double TotalAmount;

        
        public Sale_Program(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;

            //  Sales method to update TotalAmount
            Sales();
        }

       
        private void Sales()
        {
            TotalAmount = Qty * Price;
        }

        
        public void ShowData()
        {
            Console.WriteLine($"SalesNo: {SalesNo}");
            Console.WriteLine($"ProductNo: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Qty: {Qty}");
            Console.WriteLine($"DateOfSale: {DateOfSale.ToShortDateString()}");
            Console.WriteLine($"TotalAmount: {TotalAmount}");
        }
    }



    //static void Main()
    //{
    //    // Example usage
    //    Sale_Program s1 = new Sale_Program(1, 500, 50.26, 4, DateTime.Now);
    //    s1.ShowData();

}  

