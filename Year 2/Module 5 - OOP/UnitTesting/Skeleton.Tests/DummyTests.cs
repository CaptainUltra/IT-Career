using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        //Test if dummy loses health after attack
        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            Dummy dummy = new Dummy(10, 10);
            
            dummy.TakeAttack(5);
            var expectedResult = 5;
            var actualresult = dummy.Health;

            Assert.AreEqual(expectedResult, actualresult);
            //Assert.AreSame - comapares pointers - i.e. not working in this case
        }

        //Test if dead dummy throws exception when attacked
        [Test]
        public void DeadDummyThrowsException()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.That(() => dummy.TakeAttack(5), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
        }

        //Test if dead dummy gives xp
        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 10);

            var expectedResult = 10;
            var actualResult = dummy.GiveExperience();

            Assert.AreEqual(expectedResult, actualResult);
        }

        //Test if alive dummy gives xp
        [Test]
        public void AliveDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(10, 15);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}
