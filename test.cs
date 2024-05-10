using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    class Test
    {
        [Test]
        public void Ein_Test()
        {
            Program program = new Program();
            Assert.That(program.HelloWorld() == "Hello world!");
        }
    }
}
