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
    /// Represents the single Account object view model.
    /// </summary>
    public partial class AccountViewModel : SingleObjectViewModel<Account, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of AccountViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static AccountViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new AccountViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the AccountViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the AccountViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected AccountViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Accounts, x => x.ac_userName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Roles for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Role> LookUpRoles {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AccountViewModel x) => x.LookUpRoles,
                    getRepositoryFunc: x => x.Roles);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (AccountViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the AccountUsers detail collection.
        /// </summary>
        public CollectionViewModelBase<User, User, int, IPetStoreEntitiesUnitOfWork> AccountUsersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (AccountViewModel x) => x.AccountUsersDetails,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.ac_id,
                    navigationExpression: x => x.Account);
            }
        }
    }
}
