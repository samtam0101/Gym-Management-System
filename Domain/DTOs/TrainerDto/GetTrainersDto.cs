namespace Domain.DTOs.TrainerDto;

public class GetTrainersDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public required string Specialization { get; set; }
    public string? Photo { get; set; }
}
