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
    /// Represents the single PetToy object view model.
    /// </summary>
    public partial class PetToyViewModel : SingleObjectViewModel<PetToy, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetToyViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetToyViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetToyViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetToyViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetToyViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetToyViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PetToys, x => x.pt_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillDetail> LookUpBillDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetToyViewModel x) => x.LookUpBillDetails,
                    getRepositoryFunc: x => x.BillDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Carts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Cart> LookUpCarts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetToyViewModel x) => x.LookUpCarts,
                    getRepositoryFunc: x => x.Carts);
            }
        }


        /// <summary>
        /// The view model for the PetToyBillDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<BillDetail, BillDetail, IPetStoreEntitiesUnitOfWork> PetToyBillDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetToyViewModel x) => x.PetToyBillDetailsDetails, x => x.BillDetails, x => x.pt_id); }
        }

        /// <summary>
        /// The view model for the PetToyCarts detail collection.
        /// </summary>
        public CollectionViewModelBase<Cart, Cart, int, IPetStoreEntitiesUnitOfWork> PetToyCartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PetToyViewModel x) => x.PetToyCartsDetails,
                    getRepositoryFunc: x => x.Carts,
                    foreignKeyExpression: x => x.pt_id,
                    navigationExpression: x => x.PetToy);
            }
        }
    }
}
