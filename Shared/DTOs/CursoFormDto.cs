using System.ComponentModel.DataAnnotations;
using LP3.BlazorServer.Domain.Constants;
/// <summary>DTO para crear o editar un curso.</summary>

public class CursoFormDto
{
    public int Id  { get; set; } = 0; // 0 = crear nuevo

    [Required(ErrorMessage = ReglasDominio.ErrorNombreRequerido)]
    [MaxLength(ReglasDominio.NombreMaxLongitud)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [MaxLength]
    public string Codigo { get; set; } = string.Empty;

    [Required]
    [MaxLength(ReglasDominio.CreditosMaxLongitud)]
    public int Creditos { get; set; } 

    [Required]
    [MaxLength(10)]
    public bool Activo { get; set; } = true;


}