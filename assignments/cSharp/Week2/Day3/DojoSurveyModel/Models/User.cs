#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models;
public class User
{
    [Required]
    [MinLength(2,ErrorMessage ="Name must be at least 2 characters long")]
    public string Name{ get; set; }
    [Required]
    public string Location{ get; set; }
    [Required]
    public string Language{ get; set; }
    [MinLength(20, ErrorMessage ="Comment must be at least 20 characters")]
    public string? Comment{ get; set; }

    
}
