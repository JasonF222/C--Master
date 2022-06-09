namespace DojoSurvey.Models;
using System.ComponentModel.DataAnnotations;

public class Survey
{
    [Required]
    [MinLength(2)]
    public string Name { get; set; } = null!;
    [Required]
    public string Location { get; set; } = null!;
    [Required]
    public string Language { get; set; } = null!;
    [MinLength(20)]
    public string? Comment { get; set; }
}