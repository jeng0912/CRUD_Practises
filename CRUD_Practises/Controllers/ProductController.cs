using CRUD_Practises.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {

        // 1. 計算所有商品的總價格
        decimal totalProductPrice = _context.Products.Sum(p => p.Price);

        // 2. 計算所有商品的平均價格
        decimal averageProductPrice = _context.Products.Average(p => p.Price);

        // 3. 計算商品的總數量
        int totalProductQuantity = _context.Products.Sum(p => p.Quantity);

        // 4. 計算商品的平均數量
        double averageProductQuantity = _context.Products.Average(p => p.Quantity);

        // 5. 找出哪一項商品最貴
        Product mostExpensiveProduct = _context.Products.OrderByDescending(p => p.Price).FirstOrDefault();

        // 6. 找出哪一項商品最便宜
        Product cheapestProduct = _context.Products.OrderBy(p => p.Price).FirstOrDefault();

        // 7. 計算產品類別為 "3C" 的商品總價格
        decimal total3CProductPrice = _context.Products.Where(p => p.Category == "3C").Sum(p => p.Price);

        // 8. 計算產品類別為 "飲料" 及 "食品" 的商品總價格
        decimal totalBeverageAndFoodProductPrice = _context.Products
            .Where(p => p.Category == "飲料" || p.Category == "食品").Sum(p => p.Price);

        // 9. 找出所有商品類別為 "食品"，且商品數量大於 100 的商品
        var foodProducts = _context.Products.Where(p => p.Category == "食品" && p.Quantity > 100).ToList();

        // 10. 找出各個商品類別下價格大於 1000 的商品
        var expensiveProductsByCategory = _context.Products
        .Where(p => p.Price > 1000)
        .AsEnumerable() // 在此處添加 AsEnumerable
        .GroupBy(p => p.Category)
        .ToDictionary(g => g.Key, g => g.ToList());

        // 11. 呈上題，計算該類別下所有商品的平均價格
        var averagePriceByCategory = _context.Products
        .AsEnumerable()
        .GroupBy(p => p.Category)
        .ToDictionary(g => g.Key, g => g.Average(p => p.Price));


        // 12. 按商品價格由高到低排序
        var productsByPriceDescending = _context.Products.OrderByDescending(p => p.Price).ToList();

        // 13. 按商品數量由低到高排序
        var productsByQuantityAscending = _context.Products.OrderBy(p => p.Quantity).ToList();

        // 14. 找出各商品類別下，最貴的商品
        var mostExpensiveProductsByCategory = _context.Products
        .AsEnumerable() // 在此處添加 AsEnumerable
        .GroupBy(p => p.Category)
        .ToDictionary(g => g.Key, g => g.OrderByDescending(p => p.Price).FirstOrDefault());

        var products = _context.Products.ToList();
        // 15. 找出各商品類別下，最便宜的商品
        var cheapestProductsByCategory = products
        .GroupBy(p => p.Category)
        .ToDictionary(g => g.Key, g => g.OrderBy(p => p.Price).FirstOrDefault());


        // 16. 找出價格小於等於 10000 的商品
        var inexpensiveProducts = _context.Products.Where(p => p.Price <= 10000).ToList();

        
        ViewData["TotalProductPrice"] = totalProductPrice;
        ViewData["AverageProductPrice"] = averageProductPrice;
        ViewData["TotalProductQuantity"] = totalProductQuantity;
        ViewData["AverageProductQuantity"] = averageProductQuantity;
        ViewData["MostExpensiveProduct"] = mostExpensiveProduct;
        ViewData["CheapestProduct"] = cheapestProduct;
        ViewData["Total3CProductPrice"] = total3CProductPrice;
        ViewData["TotalBeverageAndFoodProductPrice"] = totalBeverageAndFoodProductPrice;
        ViewData["FoodProducts"] = foodProducts;
        ViewData["ExpensiveProductsByCategory"] = expensiveProductsByCategory;
        ViewData["AveragePriceByCategory"] = averagePriceByCategory;
        ViewData["ProductsByPriceDescending"] = productsByPriceDescending;
        ViewData["ProductsByQuantityAscending"] = productsByQuantityAscending;
        ViewData["MostExpensiveProductsByCategory"] = mostExpensiveProductsByCategory;
        ViewData["CheapestProductsByCategory"] = cheapestProductsByCategory;
        ViewData["InexpensiveProducts"] = inexpensiveProducts;

        return View();

    }


}