using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DifficultyChangesTestScript
    {
        GameObject mole;
        GameObject score;
        public float speed = 11.7f;
        // A Test behaves as an ordinary method
        [SetUp]
        public void TestSetup()
        {
            
        }

        [Test]
        public void ScoreChangesTestScriptSimplePasses()
        {
            mole = new GameObject();
            MoleBehaviour Mole = mole.AddComponent<MoleBehaviour>();

            score = new GameObject();
            ScoreUpdate Score = score.AddComponent<ScoreUpdate>();
            Score.increase(20000);
            Mole.UpdateDifficulty();
            Assert.AreEqual(speed, Mole.speed);

        }


        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ScoreChangesTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
