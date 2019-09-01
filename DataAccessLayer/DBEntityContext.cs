namespace DataAccessLayer
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBEntityContext : DbContext
    {

        public DBEntityContext()
            : base("name=DBEntityContext")
        {
            Database.SetInitializer<DBEntityContext>(new DbInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

       
        public virtual DbSet<Model.Action> Actions { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAction> RoleActions { get; set; }
        public virtual DbSet<Sliders> Categorys { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sliders> Sliders { get; set; }
        public virtual DbSet<Orders> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
     

        //public class MyEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
    }
}
