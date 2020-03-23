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
    /// Represents the single PetFood object view model.
    /// </summary>
    public partial class PetFoodViewModel : SingleObjectViewModel<PetFood, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetFoodViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetFoodViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetFoodViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetFoodViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetFoodViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetFoodViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PetFoods, x => x.pf_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillDetail> LookUpBillDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetFoodViewModel x) => x.LookUpBillDetails,
                    getRepositoryFunc: x => x.BillDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Carts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Cart> LookUpCarts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetFoodViewModel x) => x.LookUpCarts,
                    getRepositoryFunc: x => x.Carts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Types for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Type> LookUpTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetFoodViewModel x) => x.LookUpTypes,
                    getRepositoryFunc: x => x.Types);
            }
        }


        /// <summary>
        /// The view model for the PetFoodBillDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<BillDetail, BillDetail, IPetStoreEntitiesUnitOfWork> PetFoodBillDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetFoodViewModel x) => x.PetFoodBillDetailsDetails, x => x.BillDetails, x => x.pf_id); }
        }

        /// <summary>
        /// The view model for the PetFoodCarts detail collection.
        /// </summary>
        public CollectionViewModelBase<Cart, Cart, int, IPetStoreEntitiesUnitOfWork> PetFoodCartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PetFoodViewModel x) => x.PetFoodCartsDetails,
                    getRepositoryFunc: x => x.Carts,
                    foreignKeyExpression: x => x.pf_id,
                    navigationExpression: x => x.PetFood);
            }
        }
    }
}
