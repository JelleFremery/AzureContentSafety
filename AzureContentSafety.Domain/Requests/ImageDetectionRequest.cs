using AzureContentSafety.Domain.Content;
using AzureContentSafety.Domain.Interfaces;
using AzureContentSafety.Domain.Services;

namespace AzureContentSafety.Domain.Requests;

/// <summary>
/// Class representing an image detection request.
/// </summary>
public class ImageDetectionRequest : IDetectionRequest
{
    public Image Image { get; set; }

    /// <summary>
    /// Constructor for the ImageDetectionRequest class.
    /// </summary>
    /// <param name="content">The base64-encoded content of the image.</param>
    public ImageDetectionRequest(string content)
    {
        Image = new Image(content);
    }
}
