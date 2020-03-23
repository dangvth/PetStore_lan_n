using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    [Serializable]
    public class CartItem
    {
        public String productID { set; get; }
        public int Quantity { set; get; }
    }
}