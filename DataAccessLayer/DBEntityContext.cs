﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    public class DBEntityContext:DbContext
    {
        public DBEntityContext() : base("name=defaultConnection")
        {
            //Configuration.ProxyCreationEnabled = false;
            ////Configuration.ProxyCreationEnabled = false;
            //this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<DBEntityContext>(new DbInitializer());
        }
        public virtual DbSet<Model.Action> Actions { get; set; }
      
        public virtual DbSet<Group> Groups { get; set; }
       
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAction> RoleActions { get; set; }
     
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
    }
}
