﻿namespace AzureContentSafety.Domain.Responses;

/// <summary>
/// Class representing a detection error response.
/// </summary>
public class DetectionErrorResponse
{
    /// <summary>
    /// The detection error.
    /// </summary>
    public DetectionError? error { get; set; }
}
