using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müsteri eklendi:" + " " + customer.Isim + " " + customer.Soyisim + " " + customer.Yas + " " + customer.Id);

        }
        
        public void CustomerList(Customer customer)
        {                  
            Console.WriteLine(customer.Isim + " " + customer.Soyisim + " " + customer.Yas + " " + customer.Id);            
        }

        public void CustomerDelet(Customer customer)
        {
            Console.WriteLine("Müsteri silindi:"+ " " + customer.Isim + " " + customer.Soyisim + " " + customer.Yas + " " + customer.Id);
        }
    }
}
