using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace CRMBL.Molel
{
    public class ModelShop
    {

        Generator Generator = new Generator();
        public List<Cart> CartInModel { get; set; }
        public List<CashDesk> CashDesksInModel { get; set; }
        
        public bool isWoking { get; set; }

        //Очередь из продовцов
        public Queue<Seller> SellersQueue { get; set; }
        public int CustomerSpeed { get; set; }
        public int CashDeskSpeed { get; set; }
        public int EmtySeller { get; set; }
        List<Task> task = new List<Task>();

        public ModelShop(int countseller, int countproduct, int countcart, int MaxLengthQueue)
        {
            CartInModel = new List<Cart>();
            CashDesksInModel = new List<CashDesk>();
           

            SellersQueue = new Queue<Seller>();
            var freeSellers = Generator.GetNewSeller(countseller);
            AddSelerInQueue(freeSellers, SellersQueue);
            Generator.GetNewProduct(countproduct);
            GetCashDesks(CashDesksInModel, SellersQueue, countcart, MaxLengthQueue);
        }

        public void Start(int countcustomer, int minproductincart, int maxproductincart)
        {
            isWoking = true;
            Task.Run(() => CreateCart(countcustomer, minproductincart, maxproductincart));
            //Task.Run(() => AddCartInCashDesks(CashDesksInModel,CartInModel));
            task.AddRange(CashDesksInModel.Select(c => new Task(() => CashDeskWork(c))));
            
            foreach (var onetask in task)
            {               
                onetask.Start();
                
            }

        }
        private List<Cart> CreateCart(int countcustomer, int minproductincart, int maxproductincart)
        {
            var customer = Generator.GetNewCustomers(countcustomer);
            var cart = GetCarts(Generator.ProductsinGenerator, customer, minproductincart, maxproductincart);
            AddCartInCashDesks(CashDesksInModel, CartInModel);
           //Thread.Sleep(CustomerSpeed); ;
            
            return cart;
        }

        private void CashDeskWork(CashDesk cashDesk)
        {
            while (isWoking)
            {
                if (cashDesk.Queues.Count > 0)
                {
                    cashDesk.DellQueuesCustomer();
                    Thread.Sleep(CashDeskSpeed);
                }

            }
        }
        public void Stop()
        {
            isWoking = false;
        }

        Random random = new Random();
        private Queue<Seller> AddSelerInQueue(List<Seller> sellers, Queue<Seller> SellersQueue)
        {
            foreach (var seller in sellers)
            {
                SellersQueue.Enqueue(seller);
            }
            return SellersQueue;

        }
        private List<CashDesk> GetCashDesks(List<CashDesk> CashDesksInModel, Queue<Seller> SellersQueue, int CountCashDesk, int MaxLengthQueue)
        {
            if (SellersQueue.Count >= CountCashDesk)
            {
                for (int i = 0; i < CountCashDesk; i++)
                {
                    var seller = SellersQueue.Dequeue();
                    var cashdesk = new CashDesk(seller, i, MaxLengthQueue);

                    CashDesksInModel.Add(cashdesk);
                }
            }
            else
                for (int a = 0; a < SellersQueue.Count; a++)
                {
                    var seller = SellersQueue.Dequeue();
                    var cashdesk = new CashDesk(seller, a, MaxLengthQueue);

                    CashDesksInModel.Add(cashdesk);
                }
            return CashDesksInModel;
        }

        private List<Cart> GetCarts(List<Product> product, List<Customer> customers, int min, int max)
        {
            foreach (var customer in customers)
            {
                var cart = new Cart(customer)
                {
                    ID = customer.Id,

                };

                var countProduct = random.Next(min, max);

                for (int i = 0; i < countProduct; i++)
                {
                    cart.AddProductInCart(product[random.Next(product.Count - 1)]);
                }
                CartInModel.Add(cart);
            };
            return CartInModel;
        }

        private List<CashDesk> AddCartInCashDesks(List<CashDesk> CashDesksInModel, List<Cart> CartInModel)
        {
            //var cash = CashDesksInModel.Min(c => c.Queues.Count);//ТОDO
            for (int i = 0; i < CartInModel.Count; i++)
            {
                var cachDesk = CashDesksInModel[random.Next(CashDesksInModel.Count)];
                cachDesk.AddQueuesCustomer(CartInModel[0]);
                CartInModel.RemoveAt(0);
                Thread.Sleep(CustomerSpeed);

            }
            //Thread.Sleep(CustomerSpeed);
            return CashDesksInModel;
        }

    }
}
