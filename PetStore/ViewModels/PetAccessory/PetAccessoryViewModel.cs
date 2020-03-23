using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using PetStore.PetStoreEntitiesDataModel;
using PetStore.Common;
using PetStore;

namespace PetStore.ViewModels {

    /// <summary>
    /// Represents the single PetAccessory object view model.
    /// </summary>
    public partial class PetAccessoryViewModel : SingleObjectViewModel<PetAccessory, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetAccessoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetAccessoryViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetAccessoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetAccessoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetAccessoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetAccessoryViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PetAccessories, x => x.pa_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillDetail> LookUpBillDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetAccessoryViewModel x) => x.LookUpBillDetails,
                    getRepositoryFunc: x => x.BillDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Carts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Cart> LookUpCarts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetAccessoryViewModel x) => x.LookUpCarts,
                    getRepositoryFunc: x => x.Carts);
            }
        }


        /// <summary>
        /// The view model for the PetAccessoryBillDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<BillDetail, BillDetail, IPetStoreEntitiesUnitOfWork> PetAccessoryBillDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetAccessoryViewModel x) => x.PetAccessoryBillDetailsDetails, x => x.BillDetails, x => x.pa_id); }
        }

        /// <summary>
        /// The view model for the PetAccessoryCarts detail collection.
        /// </summary>
        public CollectionViewModelBase<Cart, Cart, int, IPetStoreEntitiesUnitOfWork> PetAccessoryCartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PetAccessoryViewModel x) => x.PetAccessoryCartsDetails,
                    getRepositoryFunc: x => x.Carts,
                    foreignKeyExpression: x => x.pa_id,
                    navigationExpression: x => x.PetAccessory);
            }
        }
    }
}
