namespace Lab_1
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
    }

    
}