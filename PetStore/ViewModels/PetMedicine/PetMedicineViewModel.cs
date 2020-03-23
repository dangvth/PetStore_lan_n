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
    /// Represents the single PetMedicine object view model.
    /// </summary>
    public partial class PetMedicineViewModel : SingleObjectViewModel<PetMedicine, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetMedicineViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetMedicineViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetMedicineViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetMedicineViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetMedicineViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetMedicineViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PetMedicines, x => x.pm_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillDetail> LookUpBillDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetMedicineViewModel x) => x.LookUpBillDetails,
                    getRepositoryFunc: x => x.BillDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Carts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Cart> LookUpCarts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetMedicineViewModel x) => x.LookUpCarts,
                    getRepositoryFunc: x => x.Carts);
            }
        }


        /// <summary>
        /// The view model for the PetMedicineBillDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<BillDetail, BillDetail, IPetStoreEntitiesUnitOfWork> PetMedicineBillDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetMedicineViewModel x) => x.PetMedicineBillDetailsDetails, x => x.BillDetails, x => x.pm_id); }
        }

        /// <summary>
        /// The view model for the PetMedicineCarts detail collection.
        /// </summary>
        public CollectionViewModelBase<Cart, Cart, int, IPetStoreEntitiesUnitOfWork> PetMedicineCartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PetMedicineViewModel x) => x.PetMedicineCartsDetails,
                    getRepositoryFunc: x => x.Carts,
                    foreignKeyExpression: x => x.pm_id,
                    navigationExpression: x => x.PetMedicine);
            }
        }
    }
}
