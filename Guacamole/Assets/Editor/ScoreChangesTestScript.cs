using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ScoreChangesTestScript
    {
        private ScoreUpdate score;
      
        [SetUp]
        public void TestSetup()
        {
            score = new ScoreUpdate();
            //ScoreUpdate Score = score.AddComponent<ScoreUpdate>();
        }

        [TearDown]
        public void TestTearDown()
        {
            score = null;

        }
        [Test]
        public void ScoreChangesTestScriptSimplePasses()
        {
            //Debug.Log(Score);
            ////ACT
            score.increase(100);

            //ASSERT 
            Assert.AreEqual(100, score.getScoreValue());

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
