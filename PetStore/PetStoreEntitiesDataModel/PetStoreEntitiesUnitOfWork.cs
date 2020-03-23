using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using PetStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore.PetStoreEntitiesDataModel {

    /// <summary>
    /// A PetStoreEntitiesUnitOfWork instance that represents the run-time implementation of the IPetStoreEntitiesUnitOfWork interface.
    /// </summary>
    public class PetStoreEntitiesUnitOfWork : DbUnitOfWork<PetStoreEntities>, IPetStoreEntitiesUnitOfWork {

        public PetStoreEntitiesUnitOfWork(Func<PetStoreEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Account, int> IPetStoreEntitiesUnitOfWork.Accounts {
            get { return GetRepository(x => x.Set<Account>(), (Account x) => x.ac_id); }
        }

        IRepository<Bill, int> IPetStoreEntitiesUnitOfWork.Bills {
            get { return GetRepository(x => x.Set<Bill>(), (Bill x) => x.b_id); }
        }

        IRepository<BillDetail, int> IPetStoreEntitiesUnitOfWork.BillDetails {
            get { return GetRepository(x => x.Set<BillDetail>(), (BillDetail x) => x.bd_id); }
        }

        IRepository<Cart, int> IPetStoreEntitiesUnitOfWork.Carts {
            get { return GetRepository(x => x.Set<Cart>(), (Cart x) => x.c_id); }
        }

        IRepository<Comment, int> IPetStoreEntitiesUnitOfWork.Comments {
            get { return GetRepository(x => x.Set<Comment>(), (Comment x) => x.cmt_id); }
        }

        IRepository<CommentDetail, int> IPetStoreEntitiesUnitOfWork.CommentDetails {
            get { return GetRepository(x => x.Set<CommentDetail>(), (CommentDetail x) => x.cmtd_id); }
        }

        IRepository<Gift, string> IPetStoreEntitiesUnitOfWork.Gifts {
            get { return GetRepository(x => x.Set<Gift>(), (Gift x) => x.g_id); }
        }

        IRepository<Origin, int> IPetStoreEntitiesUnitOfWork.Origins {
            get { return GetRepository(x => x.Set<Origin>(), (Origin x) => x.org_id); }
        }

        IRepository<Pet, string> IPetStoreEntitiesUnitOfWork.Pets {
            get { return GetRepository(x => x.Set<Pet>(), (Pet x) => x.p_id); }
        }

        IRepository<PetAccessory, string> IPetStoreEntitiesUnitOfWork.PetAccessories {
            get { return GetRepository(x => x.Set<PetAccessory>(), (PetAccessory x) => x.pa_id); }
        }

        IRepository<PetFood, string> IPetStoreEntitiesUnitOfWork.PetFoods {
            get { return GetRepository(x => x.Set<PetFood>(), (PetFood x) => x.pf_id); }
        }

        IRepository<PetMedicine, string> IPetStoreEntitiesUnitOfWork.PetMedicines {
            get { return GetRepository(x => x.Set<PetMedicine>(), (PetMedicine x) => x.pm_id); }
        }

        IRepository<PetToy, string> IPetStoreEntitiesUnitOfWork.PetToys {
            get { return GetRepository(x => x.Set<PetToy>(), (PetToy x) => x.pt_id); }
        }

        IRepository<Role, int> IPetStoreEntitiesUnitOfWork.Roles {
            get { return GetRepository(x => x.Set<Role>(), (Role x) => x.r_id); }
        }

        IRepository<Type, int> IPetStoreEntitiesUnitOfWork.Types {
            get { return GetRepository(x => x.Set<Type>(), (Type x) => x.t_id); }
        }

        IRepository<User, int> IPetStoreEntitiesUnitOfWork.Users {
            get { return GetRepository(x => x.Set<User>(), (User x) => x.u_id); }
        }
    }
}
