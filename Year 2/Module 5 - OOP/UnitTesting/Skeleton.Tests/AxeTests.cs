using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        //Test if axe loses durability affter attack
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            var expectedResult = 9;
            var actualresult = axe.DurabilityPoints;

            //Assert
            //Assert.That(actualresult, Is.EqualTo(expectedResult));
            Assert.AreEqual(expectedResult, actualresult);
        }

        //Test attacking with a broken weapon
        [Test]
        public void BrokenAxeAttack()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 0);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            //Assert.Throws(typeof(InvalidOperationException), () => axe.Attack(dummy));
            //Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}
