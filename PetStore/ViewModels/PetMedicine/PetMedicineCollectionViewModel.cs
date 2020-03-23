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
    /// Represents the PetMedicines collection view model.
    /// </summary>
    public partial class PetMedicineCollectionViewModel : CollectionViewModel<PetMedicine, string, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PetMedicineCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PetMedicineCollectionViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PetMedicineCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PetMedicineCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetMedicineCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PetMedicineCollectionViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PetMedicines) {
        }
    }
}