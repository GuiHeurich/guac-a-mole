using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DifficultyChangesTestScript
    {
        private GameObject mole;
        private GameObject score;
        private float speed;
        // A Test behaves as an ordinary method
        [SetUp]
        public void TestSetup()
        {
            mole = new GameObject();
            score = new GameObject();
            speed = 11.7f;
        }

        [TearDown]
        public void TestTearDown()
        {
            mole = null;
            speed = 2;
        }

        [Test]
        public void DifficultyChangesTestScriptSimplePasses()
        {
            MoleBehaviour Mole = mole.AddComponent<MoleBehaviour>();
            ScoreUpdate Score = score.AddComponent<ScoreUpdate>();
            Score.increase(20000);
            Mole.UpdateDifficulty();
            Assert.AreEqual(speed, Mole.speed);
            Score.setScoreValue(0);

        }


        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator DifficultyChangesTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
