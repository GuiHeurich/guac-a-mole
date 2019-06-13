using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ScoreChangesTestScript
    {
        GameObject obj;
        // A Test behaves as an ordinary method
        [Test]
        public void ScoreChangesTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
            // SETUP
            obj = new GameObject();
            ScoreUpdate Score = obj.AddComponent<ScoreUpdate>();

            //ACT
            Score.increase(100);

            //ASSERT 
            Assert.AreEqual(Score.getScoreValue(), 100);

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
