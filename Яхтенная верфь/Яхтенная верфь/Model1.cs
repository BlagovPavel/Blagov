namespace Яхтенная_верфь
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Аксессуары> Аксессуары { get; set; }
        public virtual DbSet<Аксессуары_лодочные> Аксессуары_лодочные { get; set; }
        public virtual DbSet<Доставка> Доставка { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<КритерииДоставки> КритерииДоставки { get; set; }
        public virtual DbSet<Лодки> Лодки { get; set; }
        public virtual DbSet<Менеджерыxlsx> Менеджерыxlsx { get; set; }
        public virtual DbSet<Партнёры> Партнёры { get; set; }
        public virtual DbSet<Счет> Счет { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Аксессуары>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Заказы>()
                .Property(e => e.DepositePayed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Заказы>()
                .Property(e => e.ContractTotalPrice__ContractTotalPrice___)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Заказы>()
                .Property(e => e.ContractTotalPrice_inclVAT)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Счет>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);
        }
    }
}
