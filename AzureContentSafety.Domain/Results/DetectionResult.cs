namespace AzureContentSafety.Domain.Results;

/// <summary>
/// Base class for detection result.
/// </summary>
public class DetectionResult
{
    /// <summary>
    /// The detailed result for hate speech detection.
    /// </summary>
    public DetailedResult? HateResult { get; set; }
    /// <summary>
    /// The detailed result for self-harm detection.
    /// </summary>
    public DetailedResult? SelfHarmResult { get; set; }
    /// <summary>
    /// The detailed result for sexual content detection.
    /// </summary>
    public DetailedResult? SexualResult { get; set; }
    /// <summary>
    /// The detailed result for violence detection.
    /// </summary>
    public DetailedResult? ViolenceResult { get; set; }
}

