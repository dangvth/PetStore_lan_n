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
    /// Represents the single Gift object view model.
    /// </summary>
    public partial class GiftViewModel : SingleObjectViewModel<Gift, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of GiftViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static GiftViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new GiftViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the GiftViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the GiftViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected GiftViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Gifts, x => x.g_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bills for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bill> LookUpBills {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (GiftViewModel x) => x.LookUpBills,
                    getRepositoryFunc: x => x.Bills);
            }
        }


        /// <summary>
        /// The view model for the GiftBills detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<Bill, Bill, IPetStoreEntitiesUnitOfWork> GiftBillsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((GiftViewModel x) => x.GiftBillsDetails, x => x.Bills, x => x.g_id); }
        }
    }
}
