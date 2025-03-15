using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: test
    public void TestPriorityQueue_1()
    {
           
        var fruit = new PriorityItem("Fruit", 1);
        var glass = new PriorityItem("Glass", 2);
        var device = new PriorityItem("Device", 3);
        var box = new PriorityItem("Box", 4);
        
        PriorityItem[] expected = [ box, device, glass, fruit ];

        var priorityQueue = new PriorityQueue();
        priorityQueue.AddItem(fruit.Value, fruit.Priority);
        priorityQueue.AddItem(glass.Value, glass.Priority);
        priorityQueue.AddItem(device.Value, device.Priority);
        priorityQueue.AddItem(box.Value, box.Priority);

        int i = 0;
        while (priorityQueue.Length > 0) {
            if (i >= expected.Length) {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Next();
            Assert.AreEqual(expected[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var fruit = new PriorityItem("Fruit", 1);
        var glass = new PriorityItem("Glass", 3);
        var device = new PriorityItem("Device", 3);
        var box = new PriorityItem("Box", 4);
        
        PriorityItem[] expected = [ box, glass, device, fruit ];

        var priorityQueue = new PriorityQueue();
        priorityQueue.AddItem(fruit.Value, fruit.Priority);
        priorityQueue.AddItem(glass.Value, glass.Priority);
        priorityQueue.AddItem(device.Value, device.Priority);
        priorityQueue.AddItem(box.Value, box.Priority);

        int i = 0;
        while (priorityQueue.Length > 0) {
            if (i >= expected.Length) {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Next();
            Assert.AreEqual(expected[i].Value, item);
            i++;
        }
    }

    // Add more test cases as needed below.
}
