using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    [Serializable]
    public class CartPetItem
    {
        public Pet pet { set; get; }
        public int Quantity { set; get; }
    }
}