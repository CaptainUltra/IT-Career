using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int DummyHealth = 20;
        private const int DummyXP = 20;
        private const int AxeAttack = 2;
        private const int AxeDurability = 2;
        private Dummy dummy;
        private Axe axe;
        private Axe brokenAxe;

        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(DummyHealth, DummyXP);
            this.axe = new Axe(AxeAttack, AxeDurability);
        }
        //Test if axe loses durability affter attack
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Act
            axe.Attack(dummy);

            var expectedResult = 9;
            var actualresult = axe.DurabilityPoints;

            //Assert
            //Assert.That(actualresult, Is.EqualTo(expectedResult));
            Assert.AreEqual(expectedResult, actualresult, "Axe doesn't lose durability after attack");
        }

        //Test attacking with a broken weapon
        [TestCase(12, 0)]
        [TestCase(5, 0)]
        [TestCase(10, -1)]
        public void BrokenAxeAttack(int attackPoints, int durability)
        {
            this.brokenAxe = new Axe(attackPoints, durability);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            //Assert.Throws(typeof(InvalidOperationException), () => axe.Attack(dummy));
            //Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}
