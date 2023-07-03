using AzureContentSafety.Domain.Enums;
using System.Text;
using Action = AzureContentSafety.Domain.Enums.Action;

namespace AzureContentSafety.Domain.Results;

/// <summary>
/// Class representing the decision made by the content moderation system.
/// </summary>
public class Decision
{
    public Action SuggestedAction { get; set; }
    public Dictionary<Category, Action> ActionByCategory { get; set; }

    /// <summary>
    /// Constructor for the Decision class.
    /// </summary>
    /// <param name="suggestedAction">The overall action suggested by the system.</param>
    /// <param name="actionByCategory">The actions suggested by the system for each category.</param>
    public Decision(Action suggestedAction, Dictionary<Category, Action> actionByCategory)
    {
        SuggestedAction = suggestedAction;
        ActionByCategory = actionByCategory;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"Suggested action: {SuggestedAction}. ");
        foreach (var action in ActionByCategory)
        {
            sb.Append($"{action.Key}: {action.Value}. ");
        }
        return sb.ToString();
    }
}

