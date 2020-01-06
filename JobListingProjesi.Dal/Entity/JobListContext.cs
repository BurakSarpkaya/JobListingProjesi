namespace JobListingProjesi.Dal.Entity
{
    using JobListingProjesi.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class JobListContext : DbContext
    {
        // Your context has been configured to use a 'JobListContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'JobListingProjesi.Dal.Entity.JobListContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JobListContext' 
        // connection string in the application configuration file.
        public JobListContext()
            : base("name=JobListContext")
        {
            Database.SetInitializer<JobListContext>(new CreateDatabaseIfNotExists<JobListContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Basvuru> Basvuru { get; set; }
        public virtual DbSet<Begeni> Begeni { get; set; }
        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Cv> Cv { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Ilan> Ilan { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Mesaj> Mesaj { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Sikayet> Sikayet { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}