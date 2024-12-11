using NUnit.Framework;
using BreweryInventoryEFClasses.Models;
using Microsoft.EntityFrameworkCore;

namespace TestProject1
{
    [TestFixture]
    public class BreweryInventoryTests
    {
        private BreweryInventoryContext? dbContext;
        private Recipe? r;
        private List<Recipe>? recipes;
        [SetUp]
        public void Setup()
        {
            dbContext = new BreweryInventoryContext();
            //dbContext.Database.ExecuteSqlRaw("call usp_testingResetData()");
        }
        [Test]
        public void TestGetAllRecipes()
        {
            recipes = dbContext.Recipes.ToList();
            Assert.IsNotNull(recipes);
        }
    }
}