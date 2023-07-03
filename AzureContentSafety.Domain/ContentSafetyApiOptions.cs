namespace AzureContentSafety.Domain
{
    public class ContentSafetyApiOptions
    {
        public const string ConfigSectionName = "ContentSafetyApi";

        public string Endpoint { get; set; } = string.Empty;
        public string Key { get; set; } = string.Empty;
    }
}