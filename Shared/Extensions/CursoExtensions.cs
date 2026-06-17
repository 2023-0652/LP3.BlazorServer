using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

namespace LP3.BlazorServer.Shared.Extensions;
/// <summary>
/// Métodos de conversión entre Entidad y DTO.
/// </summary>
public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso e)
        => new()
        {
            Id        = e.Id,
            Nombre    = e.Nombre,
            Codigo    = e.Codigo,
            Creditos  = e.Creditos,
            Activo    = e.Activo
        };

    public static Curso ToEntity(this CursoFormDto dto)
        => new()
        {
            Id        = dto.Id,
            Nombre    = dto.Nombre,
            Codigo    = dto.Codigo,
            Creditos  = dto.Creditos,
            Activo    = dto.Activo
        };
}