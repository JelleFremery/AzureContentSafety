namespace AzureContentSafety.Domain.Results;

/// <summary>
/// Class representing a detailed detection result for a blocklist match.
/// </summary>
public class BlocklistDetailedResult
{
    /// <summary>
    /// The name of the blocklist.
    /// </summary>
    public string? BlocklistName { get; set; }
    /// <summary>
    /// The ID of the block item that matched.
    /// </summary>
    public string? BlockItemId { get; set; }
    /// <summary>
    /// The text of the block item that matched.
    /// </summary>
    public string? BlockItemText { get; set; }
    /// <summary>
    /// The offset of the matching block item in the input text.
    /// </summary>
    public int? Offset { get; set; }
    /// <summary>
    /// The length of the matching block item in the input text.
    /// </summary>
    public int? Length { get; set; }
}
