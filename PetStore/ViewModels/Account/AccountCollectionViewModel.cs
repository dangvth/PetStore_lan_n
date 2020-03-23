using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using PetStore.PetStoreEntitiesDataModel;
using PetStore.Common;
using PetStore;

namespace PetStore.ViewModels {

    /// <summary>
    /// Represents the Accounts collection view model.
    /// </summary>
    public partial class AccountCollectionViewModel : CollectionViewModel<Account, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AccountCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountCollectionViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AccountCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountCollectionViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts) {
        }
    }
}