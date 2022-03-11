using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CRMBL.Molel
{
    class ModelShop
    {
        Generator Generator = new Generator();
        public List<Cart> CartInModel { get; set; }
        public List<CashDesk> CashDesksInModel { get; set; }
        public List<Check> ChecksInModel { get; set; }
        public List <Sell> SellsInModel { get; set; }

        //Очередь из продовцов
        public Queue<Seller> SellersQueue { get; set; }
       
        public int EmtySeller { get; set; }

        public ModelShop()
        {
            SellersQueue = new Queue<Seller>();
            var freeSellers = Generator.GetNewSeller(10);
            AddSelerInQueue(freeSellers, SellersQueue);                     
             Generator.GetNewProduct(10000);          

        }

        public void Start()
        {
            var customer = Generator.GetNewCustomers(34);
            GetCarts(customer, CartInModel);
            AddProduct(Generator.ProductsinGenerator, CartInModel, 1, 20);
            GetCashDesks(CashDesksInModel, SellersQueue, 5);
            AddCartInCashDesks(CashDesksInModel, CartInModel);

        }
        Random random = new Random();
        public Queue<Seller> AddSelerInQueue(List<Seller> sellers, Queue<Seller> SellersQueue)
        {
            foreach(var seller in sellers)
            {
                SellersQueue.Enqueue(seller);
            }
            return SellersQueue;
        }
        public List<Cart> GetCarts(List<Customer> customers, List<Cart> CartInModel)
        {
            foreach (var customer in customers)
            {
                var cart = new Cart(customer)
                {
                    ID = customer.Id,
                    catalogProducts = new Dictionary<Product, int>(),

                };
                CartInModel.Add(cart);
            };
            return CartInModel;
        }
        public List<Cart> AddProduct(List<Product> product, List<Cart> CartInModel,int min, int max)
        {            
            var countProduct = random.Next(min, max);
            foreach (var cart in CartInModel)
            {
                for (int i = 0; i < countProduct; i++)
                {
                    cart.AddProductInCart(product[random.Next(product.Count-1)]);
                }
            }
            return CartInModel;
        }
        public List<CashDesk> GetCashDesks(List<CashDesk> CashDesksInModel, Queue<Seller> SellersQueue, int CountCashDesk)
        {
            if (SellersQueue.Count >= CountCashDesk)
            {
                for (int i = 0; i < CountCashDesk; i++)
                {
                    var seller = SellersQueue.Dequeue();
                    var cashdesk = new CashDesk(seller, i)
                    {
                        IsModel = true,
                        CountOurCustomerQueue = 0,
                        ExitWhithoutSellCustomer = 5,
                        MaxLengthQueue = 10,
                        NumberCashDesk = i,
                        Queues = new Queue<Cart>(),
                        Seller = seller,
                    };
                    CashDesksInModel.Add(cashdesk);
                }
            }
            else
                for (int a = 0; a < SellersQueue.Count; a++)
                {
                    var seller = SellersQueue.Dequeue();
                    var cashdesk = new CashDesk(seller, a)
                    {
                        IsModel = true,
                        CountOurCustomerQueue = 0,
                        ExitWhithoutSellCustomer = 5,
                        MaxLengthQueue = 10,
                        NumberCashDesk = a,
                        Queues = new Queue<Cart>(),
                        Seller = seller,

                    };
                    CashDesksInModel.Add(cashdesk);
                }

            return CashDesksInModel;
        }
        public List<CashDesk> AddCartInCashDesks(List<CashDesk> CashDesksInModel, List<Cart> CartInModel)
        {
            //var cash = CashDesksInModel.Min(c => c.Queues.Count);//ТОDO
            foreach (var cashDesk in CashDesksInModel)
            {
               
                for (int i = 0; i < cashDesk.MaxLengthQueue; i++)
                {
                    var cart = CartInModel[i];
                    cashDesk.AddQueuesCustomer(cart);
                    //if (CartInModel.Count >= 1)
                    //{
                    //    CartInModel.RemoveAt(0);
                    //}
                    //else if (CartInModel.Count == 0)
                    //{
                    //    break;

                    //}
                }

            }
            return CashDesksInModel;
        }

    }
}
