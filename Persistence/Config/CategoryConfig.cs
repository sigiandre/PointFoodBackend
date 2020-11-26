using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class CategoryConfig
    {
        public CategoryConfig(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(20);

            entityBuilder.HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Alitas"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Árabe"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Asiática"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Café"
                },
                new Category
                {
                    CategoryId = 5,
                    Name = "Carnes"
                },
                new Category
                {
                    CategoryId = 6,
                    Name = "Chifa"
                },
                new Category
                {
                    CategoryId = 7,
                    Name = "Criolla"
                },
                new Category
                {
                    CategoryId = 8,
                    Name = "Desayunos"
                },
                new Category
                {
                    CategoryId = 9,
                    Name = "Hamburguesas"
                },
                new Category
                {
                    CategoryId = 10,
                    Name = "Helados"
                },
                new Category
                {
                    CategoryId = 11,
                    Name = "Internacional"
                },
                new Category
                {
                    CategoryId = 12,
                    Name = "Jugos y Batidos"
                },
                new Category
                {
                    CategoryId = 13,
                    Name = "Mexicana"
                },
                new Category
                {
                    CategoryId = 14,
                    Name = "Panadería"
                },
                new Category
                {
                    CategoryId = 15,
                    Name = "Pastas"
                },
                new Category
                {
                    CategoryId = 16,
                    Name = "Pescados y Mariscos"
                },
                new Category
                {
                    CategoryId = 17,
                    Name = "Pizzas"
                },
                new Category
                {
                    CategoryId = 18,
                    Name = "Poke"
                },
                new Category
                {
                    CategoryId = 19,
                    Name = "Pollería"
                },
                new Category
                {
                    CategoryId = 20,
                    Name = "Postres"
                },
                new Category
                {
                    CategoryId = 21,
                    Name = "Salchipapas"
                },
                new Category
                {
                    CategoryId = 22,
                    Name = "Saludable"
                },
                new Category
                {
                    CategoryId = 23,
                    Name = "Sándwiches"
                },
                new Category
                {
                    CategoryId = 24,
                    Name = "Sopas y Cremas"
                },
                new Category
                {
                    CategoryId = 25,
                    Name = "Sushi"
                },
                new Category
                {
                    CategoryId = 26,
                    Name = "Vegetariana"
                }
            );
        }
    }
}
