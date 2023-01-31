using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void NewTestScriptSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator NewTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame

            var spwnedEnemy = GameObject.FindWithTag("name");
            var prefabSomething = PrefabUtility.GetPrefabParent(spwnedEnemy);
            yield return null;
        }
        
        [TearDown]
        public void AfterEveryTest()
        {
            //loop through all the spwned GameObjects and destroy with either 
            //GameObject.FindObjectsOfType<>();
            //GameObject.FindGameObjectsWithTag();
        }
    }
}
