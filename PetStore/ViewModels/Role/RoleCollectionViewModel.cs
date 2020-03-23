using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using PetStore.PetStoreEntitiesDataModel;
using PetStore.Common;
using PetStore;

namespace PetStore.ViewModels {

    /// <summary>
    /// Represents the Roles collection view model.
    /// </summary>
    public partial class RoleCollectionViewModel : CollectionViewModel<Role, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RoleCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RoleCollectionViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RoleCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RoleCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RoleCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RoleCollectionViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Roles) {
        }
    }
}