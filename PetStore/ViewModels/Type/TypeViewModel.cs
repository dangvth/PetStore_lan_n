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
    /// Represents the single Type object view model.
    /// </summary>
    public partial class TypeViewModel : SingleObjectViewModel<Type, int, IPetStoreEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TypeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TypeViewModel Create(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TypeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TypeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TypeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TypeViewModel(IUnitOfWorkFactory<IPetStoreEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Types, x => x.t_name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Pets for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Pet> LookUpPets {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TypeViewModel x) => x.LookUpPets,
                    getRepositoryFunc: x => x.Pets);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of PetFoods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<PetFood> LookUpPetFoods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TypeViewModel x) => x.LookUpPetFoods,
                    getRepositoryFunc: x => x.PetFoods);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Origins for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Origin> LookUpOrigins {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TypeViewModel x) => x.LookUpOrigins,
                    getRepositoryFunc: x => x.Origins);
            }
        }


        /// <summary>
        /// The view model for the TypePets detail collection.
        /// </summary>
        public CollectionViewModelBase<Pet, Pet, string, IPetStoreEntitiesUnitOfWork> TypePetsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TypeViewModel x) => x.TypePetsDetails,
                    getRepositoryFunc: x => x.Pets,
                    foreignKeyExpression: x => x.t_id,
                    navigationExpression: x => x.Type);
            }
        }

        /// <summary>
        /// The view model for the TypePetFoods detail collection.
        /// </summary>
        public CollectionViewModelBase<PetFood, PetFood, string, IPetStoreEntitiesUnitOfWork> TypePetFoodsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TypeViewModel x) => x.TypePetFoodsDetails,
                    getRepositoryFunc: x => x.PetFoods,
                    foreignKeyExpression: x => x.t_id,
                    navigationExpression: x => x.Type);
            }
        }
    }
}
