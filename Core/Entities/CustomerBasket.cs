using System.Collections.Generic;
namespace Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket()
        {
        }

        public CustomerBasket(string id)
        {
            this.id = id;
             
        }

        public string id { get; set; }
        public List<BaseketItem> Items { get; set; }=new List<BaseketItem>();
    }
}