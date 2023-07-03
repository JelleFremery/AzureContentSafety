namespace AzureContentSafety.Domain.Results;

/// <summary>
/// Class representing a text detection result.
/// </summary>
public class TextDetectionResult : DetectionResult
{
    /// <summary>
    /// The list of detailed results for blocklist matches.
    /// </summary>
    public List<BlocklistDetailedResult>? BlocklistsMatchResults { get; set; }
}
