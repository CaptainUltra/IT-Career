using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 10;
        private const int DeadDummyHealth = 0;
        private const int DummyExperience = 10;
        private Dummy dummy;
        private Dummy deadDummy;

        [SetUp]
        public void SetUp()
        {
            this.dummy = new Dummy(DummyHealth, DummyExperience);
            this.deadDummy = new Dummy(DeadDummyHealth, DummyExperience);
        }

        //Test if dummy loses health after attack
        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            dummy.TakeAttack(5);
            var expectedResult = 5;
            var actualresult = dummy.Health;

            Assert.AreEqual(expectedResult, actualresult);
        }

        //Test if dead dummy throws exception when attacked
        [Test]
        public void DeadDummyThrowsException()
        {
            Assert.That(() => deadDummy.TakeAttack(5), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        //Test if dead dummy gives xp
        [Test]
        public void DeadDummyCanGiveXP()
        {
            var expectedResult = 10;
            var actualResult = deadDummy.GiveExperience();

            Assert.AreEqual(expectedResult, actualResult);
        }

        //Test if alive dummy gives xp
        [Test]
        public void AliveDummyCanGiveXP()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}