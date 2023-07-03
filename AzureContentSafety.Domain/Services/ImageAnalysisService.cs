using AzureContentSafety.Domain.Enums;
using AzureContentSafety.Domain.Results;
using Microsoft.Extensions.Options;

namespace AzureContentSafety.Domain.Services;

public class ImageAnalysisService
{
    private readonly IOptions<ContentSafetyApiOptions> _options;

    public ImageAnalysisService(IOptions<ContentSafetyApiOptions> options)
    {
        _options = options;
    }

    public async Task<Decision> AnalyzeImage(string content)
    {
        // Initialize the ContentSafety object
        ContentSafetyService contentSafety = new ContentSafetyService(_options);

        // Set the media type and blocklists
        MediaType mediaType = MediaType.Image;
        string[] blocklists = { };

        // Detect content safety
        DetectionResult detectionResult = await contentSafety.Detect(mediaType, content, blocklists);

        // Set the reject thresholds for each category
        Dictionary<Category, int> rejectThresholds = new Dictionary<Category, int> {
            { Category.Hate, 4 }, { Category.SelfHarm, 4 }, { Category.Sexual, 4 }, { Category.Violence, 0 }
        };

        // Make a decision based on the detection result and reject thresholds
        Decision decisionResult = contentSafety.MakeDecision(detectionResult, rejectThresholds);
        return decisionResult;
    }
}