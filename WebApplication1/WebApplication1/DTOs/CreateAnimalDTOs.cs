using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTOs;

public record CreateAnimalRequest(
    [Required] [MaxLength(200)] string Name,
    [Required] [MaxLength(200)] string Description,
    [Required] [MaxLength(200)] string Category,
    [Required] [MaxLength(200)] string Area
);

public record CreateAnimalResponse(int id, string Name, string Desription, string Category, string Area)
{
    public CreateAnimalResponse(int id, CreateAnimalRequest request) : this(id, request.Name, request.Description,
        request.Category, request.Area)
    {
    }
};


























