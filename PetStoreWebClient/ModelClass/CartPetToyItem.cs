using PetStoreWebClient.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStoreWebClient.ModelClass
{
    [Serializable]
    public class CartPetToyItem
    {
        public PetToys petToy { set; get; }
        public int Quantity { set; get; }
    }
}