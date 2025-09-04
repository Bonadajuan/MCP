namespace MyMonkeyApp.Models;

/// <summary>
/// Represents a monkey species with relevant data.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Gets or sets the name of the monkey species.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets the location where the monkey species is found.
    /// </summary>
    public required string Location { get; set; }

    /// <summary>
    /// Gets or sets the population estimate for the monkey species.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Gets or sets a description of the monkey species.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the image URL for the monkey species.
    /// </summary>
    public string? ImageUrl { get; set; }
}