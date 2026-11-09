using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ProductResponseDto
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("content")]
    public List<ProductDto> Content { get; set; } = new();
}

public class ProductDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("alias")]
    public string Alias { get; set; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("size")]
    public string Size { get; set; } = "[]";

    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = string.Empty;

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }

    [JsonPropertyName("categories")]
    public string Categories { get; set; } = "[]";

    [JsonPropertyName("relatedProducts")]
    public string RelatedProducts { get; set; } = "[]";

    [JsonPropertyName("feature")]
    public bool Feature { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
}