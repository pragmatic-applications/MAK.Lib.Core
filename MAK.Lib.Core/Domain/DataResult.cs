namespace Domain;

public class DataResult<TData>
{
    public TData? Data { get; set; }
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
}
