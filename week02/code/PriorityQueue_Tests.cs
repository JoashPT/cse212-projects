using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following items and priority: H(1), Li(3), He(2)
    // run until the queue is empty
    // Expected Result: Li, He, H
    // Defect(s) Found: 
    public void TestPriorityQueue_DifferentPriority()
    {
        var hydrogen = new PriorityItem("H", 1);
        var lithium = new PriorityItem("Li", 3);
        var helium = new PriorityItem("He", 2);

        PriorityItem[] expectedResult = [lithium, helium, hydrogen];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(hydrogen.Value, hydrogen.Priority);
        priorityQueue.Enqueue(lithium.Value, lithium.Priority);
        priorityQueue.Enqueue(helium.Value, helium.Priority);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should no longer have any items.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Create a queue with two items of the same priority the first input 
    // with the same priority should be the first one out: Be(4), C1(6), B(5), C2(6)
    // Expected Result: C1, C2, B, Be
    // Defect(s) Found: 
    public void TestPriorityQueue_SamePriority()
    {
        var beryllium = new PriorityItem("Be", 4);
        var carbon1 = new PriorityItem("C1", 6);
        var boron = new PriorityItem("B", 5);
        var carbon2 = new PriorityItem("C2", 6);

        PriorityItem[] expectedResult = [carbon1, carbon2, boron, beryllium];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(beryllium.Value, beryllium.Priority);
        priorityQueue.Enqueue(carbon1.Value, carbon1.Priority);
        priorityQueue.Enqueue(boron.Value, boron.Priority);
        priorityQueue.Enqueue(carbon2.Value, carbon2.Priority);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should no longer have any items.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Running an empty queue should return an error
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}