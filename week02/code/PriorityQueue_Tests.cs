using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: A queue with 4 items with different priorities: Fruit(1), Glass(2), Device(3), Box(4),
    // Expected Result: Box, Device, Glass, Fruit
    // Defect(s) Found: It was necessary to add methods to enqueue the items correctly, to add and
    // organize the classes better in order to have a better performance and more understandable code
    public void TestPriorityQueue_1()
    {
           
        var fruit = new PriorityItem("Fruit", 1);
        var glass = new PriorityItem("Glass", 2);
        var device = new PriorityItem("Device", 3);
        var box = new PriorityItem("Box", 4);
        
        PriorityItem[] expected = [ box, device, glass, fruit ];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(fruit.Value, fruit.Priority);
        priorityQueue.Enqueue(glass.Value, glass.Priority);
        priorityQueue.Enqueue(device.Value, device.Priority);
        priorityQueue.Enqueue(box.Value, box.Priority);

        int i = 0;
        while (priorityQueue.Length > 0) {
            if (i >= expected.Length) {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expected[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario:  A queue with 4 items with different priorities: Fruit(1), Glass(3), Device(3), Box(4),
    // Expected Result: Box, Glass, Device, Fruit
    // Defect(s) Found: It was necessary to add methods to enqueue the items correctly, to add and
    // organize the classes better in order to have a better performance and more understandable code
    // ------
    // It was necessary to adjust the method in charge of arrange the priority of the item, if two items
    // had the same value the method would return the the last repeated item, and we were looking for to
    // receive the first item with the same priority first
    public void TestPriorityQueue_2()
    {
        var fruit = new PriorityItem("Fruit", 1);
        var glass = new PriorityItem("Glass", 3);
        var device = new PriorityItem("Device", 3);
        var box = new PriorityItem("Box", 4);
        
        PriorityItem[] expected = [ box, glass, device, fruit ];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(fruit.Value, fruit.Priority);
        priorityQueue.Enqueue(glass.Value, glass.Priority);
        priorityQueue.Enqueue(device.Value, device.Priority);
        priorityQueue.Enqueue(box.Value, box.Priority);

        int i = 0;
        while (priorityQueue.Length > 0) {
            if (i >= expected.Length) {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expected[i].Value, item);
            i++;
        }
    }
}