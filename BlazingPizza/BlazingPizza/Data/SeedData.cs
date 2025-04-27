using BlazingPizza.Model;

namespace BlazingPizza.Data;

public class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var pizzas = new PizzaSpecial[]
        {
            new()
            {
                Nome = "Pizza de Queijo Básica",
                Descricao = "É queijosa e deliciosa. Por que você não iria querer uma?",
                PrecoBase = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new()
            {
                Id = 2,
                Nome = "Super Bacon",
                Descricao = "Tem TODOS os tipos de bacon",
                PrecoBase = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new()
            {
                Id = 3,
                Nome = "Calabresa clássica",
                Descricao = "É a pizza que voce cresceu comendo, mas extremamente picante!",
                PrecoBase = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new()
            {
                Id = 4,
                Nome = "Frango Buffalo",
                Descricao = "Frango apimentado, molho picante e queijo azul, garantido para aquecê-lo",
                PrecoBase = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new()
            {
                Id = 5,
                Nome = "Amantes de cogumelos",
                Descricao = "Tem cogumelos. Não é óbvio?",
                PrecoBase = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new()
            {
                Id = 7,
                Nome = "Delícia Vegetariana",
                Descricao = "É como salada, mas em uma pizza",
                PrecoBase = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new()
            {
                Id = 8,
                Nome = "Marguerita",
                Descricao = "Pizza tradicional italiana com tomate e manjericão",
                PrecoBase = 9.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
            },
        };
        db.Tb_Pizzas.AddRange(pizzas);
        db.SaveChanges();
    }
}
