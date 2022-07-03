using NUnit.Framework;
using Singleton; //Added a project to our current one

namespace Creational.Integration.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Btw, we had to Singleton.Singleton here because if we just use
            //Singleton (the class) it will think we are referring to the namespace
            Singleton.Singleton createdFirst = Singleton.Singleton.getInstance();
        }
        [Test]
        public void GivenInstanceConfirmType()
        {
            var instance = Singleton.Singleton.getInstance();
            Assert.IsInstanceOf<Singleton.Singleton>(instance);
        }
        [Test]
        public void GivenAnotherInstanceConfirmItIsSameInstance()
        {
            var singleton = Singleton.Singleton.getInstance();
            var instance = Singleton.Singleton.getInstance();
            Assert.IsNotNull(instance);
            Assert.That(singleton, Is.SameAs(instance));
        }
        
    }
}