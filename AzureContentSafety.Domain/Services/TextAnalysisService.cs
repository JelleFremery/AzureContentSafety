using AzureContentSafety.Domain.Enums;
using AzureContentSafety.Domain.Results;
using Microsoft.Extensions.Options;
using Action = AzureContentSafety.Domain.Enums.Action;

namespace AzureContentSafety.Domain.Services;

public class TextAnalysisService
{
    private readonly IOptions<ContentSafetyApiOptions> _options;

    public TextAnalysisService(IOptions<ContentSafetyApiOptions> options)
    {
        _options = options;
    }
    public async Task<Decision> AnalyzeText(string content)
    {
        // Initialize the ContentSafety object
        ContentSafetyService contentSafety = new ContentSafetyService(_options);

        // Set the media type and blocklists
        MediaType mediaType = MediaType.Text;
        string[] blocklists = { };

        // Detect content safety
        DetectionResult detectionResult = await contentSafety.Detect(mediaType, content, blocklists);

        // Set the reject thresholds for each category
        Dictionary<Category, int> rejectThresholds = new Dictionary<Category, int> {
            { Category.Hate, 4 }, { Category.SelfHarm, 2 }, { Category.Sexual, 2 }, { Category.Violence, 4 }
        };

        // Make a decision based on the detection result and reject thresholds
        Decision decisionResult = contentSafety.MakeDecision(detectionResult, rejectThresholds);
        return decisionResult;
    }
}