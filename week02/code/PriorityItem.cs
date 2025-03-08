public class PriorityItem
{
    public string Value { get; set; }
    public int Priority { get; set; }
    
    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }
    
    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
}
