﻿using Automobile.Data;
using Automobile.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace automobile.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                // Look for any automobile_brands.
                if (context.automobile_brands.Any()
                    && context.automobile_brands.Any())
                {
                    return;   // DB has already been seeded
                }


                var automobile_brands = DummyData.automobile_brands().ToArray();
                context.automobile_brands.AddRange(automobile_brands);
                context.SaveChanges();

                var products = DummyData.Getproducts(context).ToArray();
                context.products.AddRange(products);
                context.SaveChanges();
            }
        }

        public static List<automobile_brand> automobile_brands()
        {
            List<automobile_brand> continents = new List<automobile_brand>() {
            new automobile_brand() {

                Name="Benz",
            },
            new automobile_brand() {
                Name="BMW",
            },
            new automobile_brand() {
                Name="Volkswagen",
            }
        };

            return continents;
        }

        public static List<product> Getproducts(ApplicationDbContext context)
        {
            List<product> automobile_brands = new List<product>() {
            new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
            },
         new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
        },
              new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
               new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
                new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
                 new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
                 new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
                  new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
               new product() {
                productName = "China",
                country_of_origin = "BeiJing",
                automobile_brandId = context.automobile_brands.FirstOrDefault(t => t.Name == "Asia").automobile_brandId,
              },
            };


            return automobile_brands;
        }
    }
}