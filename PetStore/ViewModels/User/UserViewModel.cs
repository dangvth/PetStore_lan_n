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
    /// Represents the single User object view model.
    /// </summary>
    public partial class UserViewModel : SingleObjectViewModel<User, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UserViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UserViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UserViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UserViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UserViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UserViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Users, x => x.u_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Bills for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Bill> LookUpBills {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpBills,
                    getRepositoryFunc: x => x.Bills);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Carts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Cart> LookUpCarts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpCarts,
                    getRepositoryFunc: x => x.Carts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Comments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Comment> LookUpComments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpComments,
                    getRepositoryFunc: x => x.Comments);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of CommentDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<CommentDetail> LookUpCommentDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpCommentDetails,
                    getRepositoryFunc: x => x.CommentDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Accounts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Account> LookUpAccounts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpAccounts,
                    getRepositoryFunc: x => x.Accounts);
            }
        }


        /// <summary>
        /// The view model for the UserBills detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<Bill, Bill, IPetStoreEntitiesUnitOfWork> UserBillsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((UserViewModel x) => x.UserBillsDetails, x => x.Bills, x => x.u_id); }
        }

        /// <summary>
        /// The view model for the UserCarts detail collection.
        /// </summary>
        public CollectionViewModelBase<Cart, Cart, int, IPetStoreEntitiesUnitOfWork> UserCartsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserCartsDetails,
                    getRepositoryFunc: x => x.Carts,
                    foreignKeyExpression: x => x.u_id,
                    navigationExpression: x => x.User);
            }
        }

        /// <summary>
        /// The view model for the UserComments detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<Comment, Comment, IPetStoreEntitiesUnitOfWork> UserCommentsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((UserViewModel x) => x.UserCommentsDetails, x => x.Comments, x => x.u_id); }
        }

        /// <summary>
        /// The view model for the UserCommentDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<CommentDetail, CommentDetail, IPetStoreEntitiesUnitOfWork> UserCommentDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((UserViewModel x) => x.UserCommentDetailsDetails, x => x.CommentDetails, x => x.u_id); }
        }
    }
}
