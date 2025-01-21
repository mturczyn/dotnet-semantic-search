using Microsoft.Extensions.VectorData;

public class MovieVector<T> : Movie<T>
{
    [VectorStoreRecordVector(384, DistanceFunction.CosineSimilarity)]
    public ReadOnlyMemory<float> Vector { get; set; }
}
