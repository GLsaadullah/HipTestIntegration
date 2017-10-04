namespace Example {

    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ProjectTest {

        public Actionwords Actionwords;

        [SetUp]
        protected void SetUp() {
            Actionwords = new Actionwords();
        }

        [Test]
        public void SimpleUseUid945bdc4c7076425db092e03ff1ffc6ff() {
            Actionwords.IStartTheCoffeeMachine();
            Actionwords.ITakeACoffee();
            Actionwords.CoffeeShouldBeServed();
        }
    }
}