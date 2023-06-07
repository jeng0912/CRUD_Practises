using CRUD_Practises.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace CRUD_Practises.Models
{

    public class ProductContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        private readonly IConfiguration _configuration;

        public ProductContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ProductContext"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = "P001", ProductName = "Iphone 14", Quantity = 23, Price = 45000, Category = "3C" },
                new Product { ProductId = "P002", ProductName = "SamSung A52", Quantity = 10, Price = 23000, Category = "3C" },
                new Product { ProductId = "P003", ProductName = "SamSung S20", Quantity = 15, Price = 35200, Category = "3C" },
                new Product { ProductId = "P004", ProductName = "青森頻果原汁", Quantity = 100, Price = 370, Category = "飲料" },
                new Product { ProductId = "P005", ProductName = "綠茶(瓶裝)", Quantity = 1000, Price = 25, Category = "飲料" },
                new Product { ProductId = "P006", ProductName = "辛拉麵(袋裝)", Quantity = 1000, Price = 50, Category = "食品" },
                new Product { ProductId = "P007", ProductName = "台酒麻油雞泡麵(碗裝)", Quantity = 5000, Price = 53, Category = "食品" },
                new Product { ProductId = "P008", ProductName = "台酒花雕雞泡麵(碗裝)", Quantity = 10000, Price = 53, Category = "食品" },
                new Product { ProductId = "P009", ProductName = "台酒酸菜牛肉泡麵(碗裝)", Quantity = 12000, Price = 53, Category = "食品" },
                new Product { ProductId = "P010", ProductName = "滿漢大餐珍味牛肉麵(碗裝)", Quantity = 25080, Price = 53, Category = "食品" },
                new Product { ProductId = "P011", ProductName = "烏龍茶(瓶裝)", Quantity = 10000, Price = 35, Category = "飲料" },
                new Product { ProductId = "P012", ProductName = "錫蘭奶茶(瓶裝)", Quantity = 5000, Price = 20, Category = "飲料" },
                new Product { ProductId = "P013", ProductName = "紅茶(瓶裝)", Quantity = 1230, Price = 25, Category = "飲料" },
                new Product { ProductId = "P014", ProductName = "台酒花雕雞泡麵(碗裝)", Quantity = 10000, Price = 53, Category = "食品" },
                new Product { ProductId = "P015", ProductName = "台酒花雕雞泡麵(袋裝)", Quantity = 250000, Price = 45, Category = "食品" },
                new Product { ProductId = "P016", ProductName = "Ipad Pro", Quantity = 1000, Price = 53420, Category = "3C" },
                new Product { ProductId = "P017", ProductName = "筆記型電腦", Quantity = 1235, Price = 33023, Category = "3C" }
            );
        }
    }
}