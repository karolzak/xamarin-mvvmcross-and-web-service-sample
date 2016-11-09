namespace XamFormsMvvmAndRestServices.API.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class XamarinLOBDbContext : DbContext
    {
        // Your context has been configured to use a 'XamarinLOBDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'XamFormsMvvmAndRestServices.API.Data.XamarinLOBDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'XamarinLOBDb' 
        // connection string in the application configuration file.
        public XamarinLOBDbContext()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Course> Courses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                       .HasRequired<Employee>(s => s.Employee) // Student entity requires Standard 
                       .WithMany(s => s.Customers); // Standard entity includes many Students entities
            modelBuilder.Entity<Order>()
                      .HasRequired<Customer>(s => s.Customer) // Student entity requires Standard 
                      .WithMany(s => s.Orders);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}