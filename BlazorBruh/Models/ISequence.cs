namespace BlazorBruh.Models;

public class ISequence
{
    public int SequenceNumber { get; set; }
}

public class FlowModel : ISequence
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }
}