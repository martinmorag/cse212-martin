public class PriorityQueue
{
    private readonly PriorityItemQueue _queue = new();

    public int Length => _queue.Length;

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var item = new PriorityItem(value, priority);
        _queue.Enqueue(item);
    }

    public string Dequeue()
    {
        if (_queue.IsEmpty()) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        } else { 
            //PriorityItem item = _queue.Dequeue();
            var highest = _queue.HighestIndex();
            PriorityItem item = _queue.GetItem(highest);

            _queue.Dequeue(item);

            return item.Value;
        }
    }
    public string currentItem() {
        //_queue.Dequeue();
        return _queue.ToString();
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
