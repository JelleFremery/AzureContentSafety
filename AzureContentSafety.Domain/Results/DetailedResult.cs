using AzureContentSafety.Domain.Enums;
using AzureContentSafety.Domain.Services;

namespace AzureContentSafety.Domain.Results;

/// <summary>
/// Class representing a detailed detection result for a specific category.
/// </summary>
public class DetailedResult
{
    /// <summary>
    /// The category of the detection result.
    /// </summary>
    public Category? Category { get; set; }
    /// <summary>
    /// The severity of the detection result.
    /// </summary>
    public int? Severity { get; set; }
}
