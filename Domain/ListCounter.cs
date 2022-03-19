namespace Domain;

public class ListCounter
{
    public int ListNumber { get; set; }

    public int GetListNumber() => ++this.ListNumber;
}
