using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBL.Molel
{
    public class CashDesk
    {
        CRMContext db = new CRMContext();
        public Seller Seller { get; set; }
        public int NumberCashDesk { get; set; }
        public Queue<Cart> Queues { get; set; }
        public int Count => Queues.Count;
        public bool IsModel { get; set; }
        public int CountOurCustomerQueue { get; set; }
        public int MaxLengthQueue { get; set; }
        public int ExitWhithoutSellCustomer { get; set; }

        public event EventHandler<Check> CheckClose;
        public CashDesk(Seller seller, int number,int maxlenghtQueues)        
        {
            NumberCashDesk = number;
            Seller = seller;
            IsModel = true;
            Queues = new Queue<Cart>();
            MaxLengthQueue = maxlenghtQueues;
          
        }
        public void AddQueuesCustomer(Cart cart)
        {
            if (Queues.Count >= MaxLengthQueue)
            {
                ExitWhithoutSellCustomer ++;
            }
        else
            {
                Queues.Enqueue(cart);
            }
        }
        public decimal DellQueuesCustomer()
        {
            if(Queues.Count==0)
            {
                return 0;
            }

                decimal sumPriseSellProguct = 0;
                var outCustomer=Queues.Dequeue();
                {
                    List<Product> allproduct = outCustomer.GetAll(outCustomer);

                    var check = new Check()
                    {
                        Date = DateTime.Now,
                        Seller = Seller,
                        SellerId = Seller.Id,
                        Customer = outCustomer.CustomerInCart,
                        CustomerId = outCustomer.CustomerInCart.Id,
                        Sells= new List<Sell>()
                };
                    if (!IsModel)
                    {                       
                        db.Checks.Add(check);
                        db.SaveChanges();
                    }
                    else
                    {
                        check.Id = Seller.Id + 1000;
                    }

                    
                    foreach (var product in allproduct)
                    {
                       
                        if (product.Count > 0)
                        {
                            var sell = new Sell()
                            {
                                Chek = check,
                                Product = product,
                                ProductId = product.Id
                            };
                           
                        check.Sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }
                        else
                        {
                            sell.Id = Seller.Id + 100;
                        }
                        sumPriseSellProguct += product.Price;
                        product.Count--;
                       }
                        else
                        {
                            throw new ArgumentException($"Товара{product.NameProduct} нет на складе");
                        }
                    }
                    check.SumChek= sumPriseSellProguct;
                   

                    if (!IsModel)
                    {
                        db.SaveChanges();
                    }
                    CheckClose?.Invoke(this,check);
                }
                return sumPriseSellProguct;
            
            

        }
    }
}
