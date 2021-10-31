using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Movement
    {
        [Test]
        public void Directions()
        {
            Assert.AreEqual(Input.GetAxis("Vertical"), PlayerController.input.y);
        }

    }
}
