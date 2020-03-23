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
    /// Represents the single Role object view model.
    /// </summary>
    public partial class RoleViewModel : SingleObjectViewModel<Role, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RoleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RoleViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RoleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RoleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RoleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RoleViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Roles, x => x.r_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Accounts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Account> LookUpAccounts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (RoleViewModel x) => x.LookUpAccounts,
                    getRepositoryFunc: x => x.Accounts);
            }
        }


        /// <summary>
        /// The view model for the RoleAccounts detail collection.
        /// </summary>
        public CollectionViewModelBase<Account, Account, int, IPetStoreEntitiesUnitOfWork> RoleAccountsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (RoleViewModel x) => x.RoleAccountsDetails,
                    getRepositoryFunc: x => x.Accounts,
                    foreignKeyExpression: x => x.r_id,
                    navigationExpression: x => x.Role);
            }
        }
    }
}
