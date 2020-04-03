﻿using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int DummyHealth = 10;
        private const int DummyXP = 10;
        private const int AxeAttack = 10;
        private const int AxeDurability = 10;
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
            Assert.AreEqual(expectedResult, actualresult, "Axe doesn't lose durability after attack");
        }

        //Test attacking with a broken weapon
        [TestCase(12, 0)]
        [TestCase(5, 0)]
        [TestCase(10, -1)]
        public void BrokenAxeAttack(int attackPoints, int durability)
        {
            this.brokenAxe = new Axe(attackPoints, durability);

            Assert.Throws<InvalidOperationException>(() => brokenAxe.Attack(dummy));
        }
    }
}