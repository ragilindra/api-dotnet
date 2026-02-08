namespace api_pertama.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<Hobby> Hobbies { get; set; } = new();
    public List<WorkExperience> WorkExperiences { get; set; } = new();
}