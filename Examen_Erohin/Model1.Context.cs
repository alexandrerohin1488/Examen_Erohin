﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_Erohin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ErohinEntities : DbContext
    {
        public ErohinEntities()
            : base("name=ErohinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EdIzm> EdIzm { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Postmat> Postmat { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SostavOrder> SostavOrder { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
