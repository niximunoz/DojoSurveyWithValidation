#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;
public class Usuario
{
    [Required(ErrorMessage ="Campo obligatorio")]
    [MinLength(2, ErrorMessage = "Tu nombre debe tener al menos 2 caracteres.")]
    public string FirstName {get;set;}

    [Required(ErrorMessage ="Campo obligatorio")]
    public string Location {get;set;}

    [Required(ErrorMessage ="Campo obligatorio")]
    public string Language {get;set;}

    [MinLength(20, ErrorMessage = "Tu comentario debe tener mas de 20 caracteres")]
    public string? Comments {get;set;}
}