using BreweryInventoryEFClasses.Models;

namespace BreweryInventoryNUnit
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
            Assert.AreEqual(4, recipes.Count);
        }
        [Test]
        public void TestGetRecipeById()
        {
            r = dbContext.Find("")
            Assert.IsNotNull(recipes);
            Assert.AreEqual(4, recipes.Count);
        }
    }
}