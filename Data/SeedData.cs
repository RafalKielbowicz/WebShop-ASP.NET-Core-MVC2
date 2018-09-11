using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Models;

namespace WebShop.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .GetRequiredService<AppDbContext>();
            context.Database.Migrate();

            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Mountain Bike",
                        Description = "A bicycle designed for off-road cycling",
                        Category = "Mountain Sports",
                        Price = 1999
                    },
                    new Product
                    {
                        Name = "Volleyball ball",
                        Description = "Ball used to play indoor volleyball, beach volleyball, or other less common variations of the sport",
                        Category = "Volleyball",
                        Price = 50
                    },
                    new Product
                    {
                        Name = "Trekking boots",
                        Description = "Waterproof boots which are designed for long hiking",
                        Category = "Mountain Sports",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Deck",
                        Description = "Flat board that you stand on when skateboarding",
                        Category = "Skateboarding",
                        Price = 200
                    },
                    new Product
                    {
                        Name = "Trucks",
                        Description = "Essential part of the skateboard, because they are used to attach the wheels to the skateboard deck",
                        Category = "Skateboarding",
                        Price = 250
                    },
                    new Product
                    {
                        Name = "Wheels",
                        Description = "Bones wheels are the best with bones read bearing",
                        Category = "Skateboarding",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Tent",
                        Description = "A shelter consisting of sheets of fabric or other material draped over, attached to a frame of poles or attached to a supporting rope.",
                        Category = "Mountain Sports",
                        Price = 399
                    },
                    new Product
                    {
                        Name = "Volleyball shirt",
                        Description = "Cheer your team with this shirt",
                        Category = "Volleyball",
                        Price = 79
                    },
                    new Product
                    {
                        Name = "Football Ball",
                        Description = "UEFA original",
                        Category = "Football",
                        Price = 400
                    }

                );
                context.SaveChanges();
            }
        }
    }
}