using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;

//namespace Infrastructure.Data
//{
    // public class ApplicationContextSeed
    // {
    //     public static async Task SeedAsync(ApplicationContext context)
    //     {
    //         var brandsJson = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
    //         var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsJson);
    //         foreach (var item in brands)
    //         {
    //             context.ProductBrands.Add(item);
    //         }

    //         await context.SaveChangesAsync();

    //         var typesJson = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
    //         var types = JsonSerializer.Deserialize<List<ProductType>>(typesJson);
    //         foreach (var item in types)
    //         {
    //             context.ProductTypes.Add(item);
    //         }

    //         await context.SaveChangesAsync();

    //         var productsJson = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
    //         var products = JsonSerializer.Deserialize<List<Product>>(productsJson);
    //         foreach (var item in products)
    //         {
    //             context.Products.Add(item);
    //         }

    //         await context.SaveChangesAsync();
    //     }
    // }
//}