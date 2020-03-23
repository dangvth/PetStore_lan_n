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
    /// Represents the single Pet object view model.
    /// </summary>
    public partial class PetViewModel : SingleObjectViewModel<Pet, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Pets, x => x.p_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of BillDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<BillDetail> LookUpBillDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetViewModel x) => x.LookUpBillDetails,
                    getRepositoryFunc: x => x.BillDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Comments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Comment> LookUpComments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetViewModel x) => x.LookUpComments,
                    getRepositoryFunc: x => x.Comments);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Types for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Type> LookUpTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PetViewModel x) => x.LookUpTypes,
                    getRepositoryFunc: x => x.Types);
            }
        }


        /// <summary>
        /// The view model for the PetBillDetails detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<BillDetail, BillDetail, IPetStoreEntitiesUnitOfWork> PetBillDetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetViewModel x) => x.PetBillDetailsDetails, x => x.BillDetails, x => x.p_id); }
        }

        /// <summary>
        /// The view model for the PetComments detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModelBase<Comment, Comment, IPetStoreEntitiesUnitOfWork> PetCommentsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((PetViewModel x) => x.PetCommentsDetails, x => x.Comments, x => x.p_id); }
        }
    }
}
