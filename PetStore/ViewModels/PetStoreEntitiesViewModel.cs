using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using PetStore.PetStoreEntitiesDataModel;

namespace PetStore.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the PetStoreEntities data model.
    /// </summary>
    public partial class PetStoreEntitiesViewModel : DocumentsViewModel<PetStoreEntitiesModuleDescription, IPetStoreEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of PetStoreEntitiesViewModel as a POCO view model.
        /// </summary>
        public static PetStoreEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new PetStoreEntitiesViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the PetStoreEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PetStoreEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected PetStoreEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override PetStoreEntitiesModuleDescription[] CreateModules() {
			return new PetStoreEntitiesModuleDescription[] {
                new PetStoreEntitiesModuleDescription( "Accounts", "AccountCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Accounts)),
                new PetStoreEntitiesModuleDescription( "Bills", "BillCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Bills)),
                new PetStoreEntitiesModuleDescription( "Bill Details", "BillDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.BillDetails)),
                new PetStoreEntitiesModuleDescription( "Comments", "CommentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Comments)),
                new PetStoreEntitiesModuleDescription( "Comment Details", "CommentDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CommentDetails)),
                new PetStoreEntitiesModuleDescription( "Gifts", "GiftCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Gifts)),
                new PetStoreEntitiesModuleDescription( "Origins", "OriginCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Origins)),
                new PetStoreEntitiesModuleDescription( "Pets", "PetCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Pets)),
                new PetStoreEntitiesModuleDescription( "Pet Accessories", "PetAccessoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PetAccessories)),
                new PetStoreEntitiesModuleDescription( "Pet Foods", "PetFoodCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PetFoods)),
                new PetStoreEntitiesModuleDescription( "Pet Medicines", "PetMedicineCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PetMedicines)),
                new PetStoreEntitiesModuleDescription( "Pet Toys", "PetToyCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.PetToys)),
                new PetStoreEntitiesModuleDescription( "Roles", "RoleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Roles)),
                new PetStoreEntitiesModuleDescription( "Types", "TypeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Types)),
                new PetStoreEntitiesModuleDescription( "Users", "UserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
			};
        }
                		protected override void OnActiveModuleChanged(PetStoreEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class PetStoreEntitiesModuleDescription : ModuleDescription<PetStoreEntitiesModuleDescription> {
        public PetStoreEntitiesModuleDescription(string title, string documentType, string group, Func<PetStoreEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}