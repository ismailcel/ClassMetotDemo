using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Isim="Oğuzhan";
            customer1.Soyisim = "Baş";
            customer1.Id = 1;
            customer1.Yas = 24;

            Customer customer2 = new Customer();
            customer2.Isim = "Hasan";
            customer2.Soyisim = "Güler";
            customer2.Id = 2;
            customer2.Yas = 28;

            Customer customer3 = new Customer();
            customer3.Isim = "Ahmet";
            customer3.Soyisim = "Odacı";
            customer3.Id = 3;
            customer3.Yas = 24;

            Customer customer4 = new Customer();
            customer4.Isim = "İsmail";
            customer4.Soyisim = "Çelebi";
            customer4.Id = 4;
            customer4.Yas = 24;

            Customer[] customers = new Customer[] {customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("------Eklenen Müşteriler-----");
            foreach (var Customer in customers)
            {                
                customerManager.CustomerAdd(Customer);                
            }
            
            Console.WriteLine("------Müşteriler------");
            foreach (var Customer in customers)
            {
                customerManager.CustomerList(Customer);                
            }
            
            Console.WriteLine("-----Silinen Müşteriler----");
            foreach (var Customer in customers)
            {
                customerManager.CustomerDelet(customer1);                
            }
           
        }
    }
}
