using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
    namespace Tests
    {
        public class InventoryTestSuite
        {
            private Inventory inv;
            private Key key;
            private Key testKey;

            [SetUp]
            public void Setup()
            {
                inv = new Inventory(5);
                for(int i=0; i <=6; i++)
                {
                    key = new Key("testKey", null, 1000);
                    inv.addItem(key);
                }
            }
        
            [Test]
            public void testAddMethod()
            {
                int result = inv.items.Length;
                Assert.That(result, Is.EqualTo(5));
            }

            [Test]
            public void testLookForItemMethod()
            {
                foreach (Item item in inv.items)
                {
                    inv.removeItem(item);
                }
            
                testKey = new Key("testK", null, 1500);
                inv.addItem(testKey);

                bool result = inv.checkForItem("testK");
                Assert.That(result, Is.True);

                bool result2 = inv.checkForItem("notKey");
                Assert.That(result2, Is.False);
            }
        }
    }

