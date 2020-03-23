namespace PetStoreWebClient.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PetStoreOnlineDbContext : DbContext
    {
        public PetStoreOnlineDbContext()
            : base("name=PetStoreOnlineDbContext")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentDetail> CommentDetail { get; set; }
        public virtual DbSet<Gift> Gift { get; set; }
        public virtual DbSet<Origin> Origin { get; set; }
        public virtual DbSet<Pet> Pet { get; set; }
        public virtual DbSet<PetAccessories> PetAccessories { get; set; }
        public virtual DbSet<PetFood> PetFood { get; set; }
        public virtual DbSet<PetMedicine> PetMedicine { get; set; }
        public virtual DbSet<PetToys> PetToys { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.u_gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.u_phone)
                .IsUnicode(false);
        }
    }
}
