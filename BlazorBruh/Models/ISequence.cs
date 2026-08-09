namespace BlazorBruh.Models;

public interface ISequence
{
    public int SequenceNumber { get; set; }
}

public class FlowModel : ISequence
{
    public int SequenceNumber { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }
}

public class Event : ISequence
{
    public int SequenceNumber { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public decimal Price { get; set; }
}

