using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Template.FunctionCode;
using Template.Tests.Framework.Base;

namespace Template.Tests
{
    [TestClass]
    public class FunctionTests : TestBase
    {
        [TestMethod]
        public async Task HttpTriggerOne_ReturnsHelloToJohnDoe()
        {
            //arrange
            var someMeaninglessPayload = new { name = "John Doe" };

            var request = CreateHttpRequestWith(someMeaninglessPayload);
            var traceWriter = GetTestTraceWriter();

            //act
            var response = await Main.HttpTriggerOne(request, traceWriter);
            var returnMessage = await response.Content.ReadAsStringAsync();
            returnMessage = returnMessage.TrimStart('"').TrimEnd('"');

            //assert
            Assert.AreEqual("Hello John Doe", returnMessage);
        }

        [TestMethod()]
        public async Task HttpTriggerTwo_World_ReturnsHelloWorld()
        {
            //arrange
            var payload = new { name = "World" };
            var request = CreateHttpRequestWith(payload);
            var traceWriter = GetTestTraceWriter();

            //act
            var response = await Main.HttpTriggerTwo(request, traceWriter);
            var returnMessage = await response.Content.ReadAsStringAsync();
            returnMessage = returnMessage.TrimStart('"').TrimEnd('"');

            //assert
            Assert.AreEqual("Hello World", returnMessage);
        }
    }
}