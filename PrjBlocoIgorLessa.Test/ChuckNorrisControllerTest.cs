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
            Assert.True(result.Count() > 0); 
        }
    }
}