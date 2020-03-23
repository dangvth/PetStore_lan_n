using DevExpress.Mvvm.DataModel;
using PetStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore.PetStoreEntitiesDataModel {

    /// <summary>
    /// IPetStoreEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IPetStoreEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Account entities repository.
        /// </summary>
		IRepository<Account, int> Accounts { get; }
        
        /// <summary>
        /// The Bill entities repository.
        /// </summary>
		IRepository<Bill, int> Bills { get; }
        
        /// <summary>
        /// The BillDetail entities repository.
        /// </summary>
		IRepository<BillDetail, int> BillDetails { get; }
        
        /// <summary>
        /// The Cart entities repository.
        /// </summary>
		IRepository<Cart, int> Carts { get; }
        
        /// <summary>
        /// The Comment entities repository.
        /// </summary>
		IRepository<Comment, int> Comments { get; }
        
        /// <summary>
        /// The CommentDetail entities repository.
        /// </summary>
		IRepository<CommentDetail, int> CommentDetails { get; }
        
        /// <summary>
        /// The Gift entities repository.
        /// </summary>
		IRepository<Gift, string> Gifts { get; }
        
        /// <summary>
        /// The Origin entities repository.
        /// </summary>
		IRepository<Origin, int> Origins { get; }
        
        /// <summary>
        /// The Pet entities repository.
        /// </summary>
		IRepository<Pet, string> Pets { get; }
        
        /// <summary>
        /// The PetAccessory entities repository.
        /// </summary>
		IRepository<PetAccessory, string> PetAccessories { get; }
        
        /// <summary>
        /// The PetFood entities repository.
        /// </summary>
		IRepository<PetFood, string> PetFoods { get; }
        
        /// <summary>
        /// The PetMedicine entities repository.
        /// </summary>
		IRepository<PetMedicine, string> PetMedicines { get; }
        
        /// <summary>
        /// The PetToy entities repository.
        /// </summary>
		IRepository<PetToy, string> PetToys { get; }
        
        /// <summary>
        /// The Role entities repository.
        /// </summary>
		IRepository<Role, int> Roles { get; }
        
        /// <summary>
        /// The Type entities repository.
        /// </summary>
		IRepository<Type, int> Types { get; }
        
        /// <summary>
        /// The User entities repository.
        /// </summary>
		IRepository<User, int> Users { get; }
    }
}
