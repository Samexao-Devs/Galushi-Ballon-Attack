using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ActionShip
    {
        [Test]
        public void DirectionUp()
        {
            Assert.AreEqual(Input.GetAxis("Vertical"), PlayerController.input.y);
        }
        [Test]
        public void DirectionDown()
        {
            Assert.AreEqual(Input.GetAxis("Vertical"), PlayerController.input.y);
        }
        [Test]
        public void Shooting()
        {
            Assert.AreEqual(Input.GetAxis("Vertical"), PlayerController.input.y);
        }
        [Test]
        public void GameOverShip()
        {
            Assert.AreEqual(Input.GetAxis("Vertical"), PlayerController.input.y);
        }
    }
}
