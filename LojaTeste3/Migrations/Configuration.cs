namespace LojaTeste3.Migrations
{
    using LojaTeste3.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LojaTeste3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LojaTeste3.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(
                p => p.Id,
                new Product
                {
                    Id = 5,
                    nome = "produto	5",
                    codigo = "COD1",	descricao	=	"descrição  produto 5",	preco	=	10	},

                new Product
                {
                    Id = 6,
                    nome = "produto	6",
                    codigo = "COD2",	descricao	=	"descrição  produto 6",	preco	=	20	},

                new Product
                {
                    Id = 7,
                    nome = "produto	7",
                    codigo = "COD3",	descricao	=	"descrição  produto 7",	preco	=	30	},
                 new Product
                 {
                     Id = 8,
                     nome = "produto	8",
                     codigo = "COD4",
                     descricao = "descrição  produto 8",
                     preco = 50
                 }

);
        }
    }
}
