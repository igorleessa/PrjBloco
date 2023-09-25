using PrjBlocoIgorLessa.Controllers;

namespace PrjBlocoIgorLessa.Test
{
    public class ChuckNorrisControllerTest
    {
        [Fact]
        public void GetSuccess()
        {
            var controller = new ChuckNorrisController();

            var result = controller.GetChuckNorrisRandom();
            Assert.True(result.Any()); 
        }

        [Fact]
        public void PostSuccess()
        {
            var controller = new ChuckNorrisController();

            var result = controller.GetChuckNorrisPost("money");
            Assert.True(result.Any());
        }
    }
}