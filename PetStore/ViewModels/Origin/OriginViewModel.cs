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
    /// Represents the single Origin object view model.
    /// </summary>
    public partial class OriginViewModel : SingleObjectViewModel<Origin, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OriginViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OriginViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OriginViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OriginViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OriginViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OriginViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Origins, x => x.org_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Types for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Type> LookUpTypes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OriginViewModel x) => x.LookUpTypes,
                    getRepositoryFunc: x => x.Types);
            }
        }


        /// <summary>
        /// The view model for the OriginTypes detail collection.
        /// </summary>
        public CollectionViewModelBase<Type, Type, int, IPetStoreEntitiesUnitOfWork> OriginTypesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OriginViewModel x) => x.OriginTypesDetails,
                    getRepositoryFunc: x => x.Types,
                    foreignKeyExpression: x => x.org_id,
                    navigationExpression: x => x.Origin);
            }
        }
    }
}
