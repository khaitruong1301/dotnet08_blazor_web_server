using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ProductDetailResponseDto
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("content")]
    public ProductDetailDto Content { get; set; } = new();

    [JsonPropertyName("dateTime")]
    public DateTimeOffset DateTime { get; set; }
}

public class ProductDetailDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("alias")]
    public string Alias { get; set; } = string.Empty;

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("feature")]
    public bool Feature { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("size")]
    public List<string> Size { get; set; } = new();

    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = string.Empty;

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("categories")]
    public List<CategoryDto> Categories { get; set; } = new();

    [JsonPropertyName("relatedProducts")]
    public List<RelatedProductDto> RelatedProducts { get; set; } = new();
}

public class CategoryDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;
}

public class RelatedProductDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("alias")]
    public string Alias { get; set; } = string.Empty;

    [JsonPropertyName("feature")]
    public bool Feature { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = string.Empty;

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;
}