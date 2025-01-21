using Microsoft.Extensions.VectorData;

public class MovieSQLite<T> : Movie<T>
{
    [VectorStoreRecordVector(Dimensions: 4, DistanceFunction.CosineDistance)]
    public ReadOnlyMemory<float>? DescriptionEmbedding { get; set; }

}