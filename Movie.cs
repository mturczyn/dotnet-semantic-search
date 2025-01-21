using Microsoft.Extensions.VectorData;

public class Movie<T>
{
    [VectorStoreRecordKey]
    public T Key { get; set; }

    [VectorStoreRecordData]
    public string? Title { get; set; }

    [VectorStoreRecordData]
    public string? Description { get; set; }

}
