using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CommerceAPI_NetCore.Models {

    public partial class EcommerceSimplifieContext : DbContext {

        public EcommerceSimplifieContext() {
        }

        public EcommerceSimplifieContext(DbContextOptions<EcommerceSimplifieContext> options)
            : base(options) {
        }

        public virtual DbSet<Address> Addresses {
            get; set;
        }

        public virtual DbSet<Category> Categories {
            get; set;
        }

        public virtual DbSet<Country> Countries {
            get; set;
        }

        public virtual DbSet<Currency> Currencies {
            get; set;
        }

        public virtual DbSet<Customer> Customers {
            get; set;
        }

        public virtual DbSet<CustomerAddress> CustomerAddresses {
            get; set;
        }

        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings {
            get; set;
        }

        public virtual DbSet<CustomerRole> CustomerRoles {
            get; set;
        }

        public virtual DbSet<EmailAccount> EmailAccounts {
            get; set;
        }

        public virtual DbSet<Order> Orders {
            get; set;
        }

        public virtual DbSet<OrderItem> OrderItems {
            get; set;
        }

        public virtual DbSet<Picture> Pictures {
            get; set;
        }

        public virtual DbSet<Product> Products {
            get; set;
        }

        public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings {
            get; set;
        }

        public virtual DbSet<ProductPictureMapping> ProductPictureMappings {
            get; set;
        }

        public virtual DbSet<StateProvince> StateProvinces {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=EcommerceSimplifie;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Address>(entity => {
                entity.ToTable("Address");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("Address_Country");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StateProvinceId)
                    .HasConstraintName("Address_StateProvince");
            });

            modelBuilder.Entity<Category>(entity => {
                entity.ToTable("Category");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Country>(entity => {
                entity.ToTable("Country");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Currency>(entity => {
                entity.ToTable("Currency");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity => {
                entity.ToTable("Customer");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.LastActivityDateUtc).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateUtc).HasColumnType("datetime");

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username).HasMaxLength(1000);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.CustomerBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("Customer_BillingAddress");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.CustomerShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("Customer_ShippingAddress");
            });

            modelBuilder.Entity<CustomerAddress>(entity => {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("PK__Customer__3C895822B47306BB");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("Customer_Addresses_Target");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Customer_Addresses_Source");
            });

            modelBuilder.Entity<CustomerCustomerRoleMapping>(entity => {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId })
                    .HasName("PK__Customer__ABACF0F745755CA7");

                entity.ToTable("Customer_CustomerRole_Mapping");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Customer_CustomerRoles_Source");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("Customer_CustomerRoles_Target");
            });

            modelBuilder.Entity<CustomerRole>(entity => {
                entity.ToTable("CustomerRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<EmailAccount>(entity => {
                entity.ToTable("EmailAccount");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity => {
                entity.ToTable("Order");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.OrderTotal).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Order_BillingAddress");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Order_Customer");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("Order_ShippingAddress");
            });

            modelBuilder.Entity<OrderItem>(entity => {
                entity.ToTable("OrderItem");

                entity.Property(e => e.UnitPriceInclTax).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("OrderItem_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("OrderItem_Product");
            });

            modelBuilder.Entity<Picture>(entity => {
                entity.ToTable("Picture");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<Product>(entity => {
                entity.ToTable("Product");

                entity.Property(e => e.AvailableEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.AvailableStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.CreatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SpecialPriceEndDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.SpecialPriceStartDateTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOnUtc).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity => {
                entity.ToTable("Product_Category_Mapping");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("ProductCategory_Category");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCategoryMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductCategory_Product");
            });

            modelBuilder.Entity<ProductPictureMapping>(entity => {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasOne(d => d.Picture)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.PictureId)
                    .HasConstraintName("ProductPicture_Picture");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictureMappings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("ProductPicture_Product");
            });

            modelBuilder.Entity<StateProvince>(entity => {
                entity.ToTable("StateProvince");

                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("StateProvince_Country");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}