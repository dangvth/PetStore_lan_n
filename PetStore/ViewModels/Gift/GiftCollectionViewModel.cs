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
    /// Represents the Gifts collection view model.
    /// </summary>
    public partial class GiftCollectionViewModel : CollectionViewModel<Gift, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GiftCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GiftCollectionViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GiftCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GiftCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GiftCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GiftCollectionViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Gifts) {
        }
    }
}