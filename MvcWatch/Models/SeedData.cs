using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcWatch.Data;
using System;
using System.Linq;

namespace MvcWatch.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcWatchContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcWatchContext>>()))
            {
                // Look for any movies.
                if (context.Watch.Any())
                {
                    return;   // DB has been seeded
                }

                context.Watch.AddRange(
                    new Watch
                    {
                        Name = "Rolex GMT Master-||",
                        Color = "Black",
                        Material = "Aluminium",
                        Type = "Quartz",
                        Price = 16000,
                        Rating = 4
                    },

                    new Watch
                    {
                        Name = "Apple Watch Series 7",
                        Color = "Green",
                        Material = "Titanium",
                        Type = "Smart Watch",
                        Price = 1000,
                        Rating = 5
                    },

                    new Watch
                    {
                        Name = "Fitbit Sense",
                        Color = "Blue",
                        Material = "Plastic",
                        Type = "Semi-Smart Watch",
                        Price = 300,
                        Rating = 3
                    },

                    new Watch
                    {
                        Name = "Samsung Galaxy Watch",
                        Color = "grey",
                        Material = "Stainless Steel",
                        Type = "Smart Watch",
                        Price = 700,
                        Rating = 3
                    },

                    new Watch
                    {
                        Name = "Fossil",
                        Color = "Black",
                        Material = "Titanium",
                        Type = "Analog",
                        Price = 488,
                        Rating = 3
                    },


                    new Watch
                    {
                        Name = "Fossil Gen-5 Smart Watch",
                        Color = "Grey",
                        Material = " Black-Stainless Steel",
                        Type = "Smart Watch",
                        Price = 699,
                        Rating = 3
                    },

                     new Watch
                     {
                         Name = "Fossil Gen-7 ",
                         Color = "white",
                         Material = "Titanium",
                         Type = "Digital Watch",
                         Price = 1000,
                         Rating = 3
                     },

                      new Watch
                      {
                          Name = "Rolex Cosmograph Daytona",
                          Color = "Black",
                          Material = " Stainless Steel ",
                          Type = "Chronograph Watch",
                          Price = 15000,
                          Rating = 5
                      },

                       new Watch
                       {
                           Name = "Omega Speedmaster Professional",
                           Color = "Black",
                           Material = " Stainless Steel ",
                           Type = "Chronograph Watch",
                           Price = 20000,
                           Rating = 5
                       },

                        new Watch
                        {
                            Name = " Yema Speedgraf",
                            Color = "Black",
                            Material = " Stainless Steel ",
                            Type = "Chronograph Watch",
                            Price = 14999,
                            Rating = 5
                        }
                );
                context.SaveChanges();
            }
        }
    }
}