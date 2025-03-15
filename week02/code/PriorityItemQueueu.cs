public class PriorityItemQueue
{
    private readonly List<PriorityItem> _queue = new();

    public int Length => _queue.Count;
    

    public void Enqueue(PriorityItem priorityItem)
    {
        _queue.Add(priorityItem);
    }

    public int Dequeue(PriorityItem itemm) {
        var item = _queue.FirstOrDefault(i => i == itemm);
        int index = 0;
        for (var i = 0; i < _queue.Count; i++) {
            if (_queue[i] == itemm)
            index = i;
        }
        _queue.RemoveAt(index);
        return index;
    }

    public PriorityItem GetItem(string value) {
        PriorityItem item = _queue.FirstOrDefault(i => i.Value == value);
        return item;
    }

    public string HighestIndex() {
        // Find the index of the item with the highest priority to remove
        List<int> highests = new();
        var highPriorityIndex = 0;
        
        for (int index = 1; index < _queue.Count; index++)
        {
            if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
            {
                highPriorityIndex  = index;
            }
            
        }
        
        for (var k = 0; k < _queue.Count; k++) {
            if (_queue[k].Priority == _queue[highPriorityIndex].Priority)
            {
                highests.Add(k);
            } 
        }
        
        if (highests.Count > 1) {
            highPriorityIndex = highests[0];             
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        return value;
    }

    public override string ToString()
    {
        return $"{_queue[0].Value} (Pri:{_queue[0].Priority})";
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }   
}
