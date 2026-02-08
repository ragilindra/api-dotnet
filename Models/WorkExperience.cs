namespace api_pertama.Models;

public class WorkExperience
{
    public int Id { get; set; }
    public string Company { get; set; } = "";
    public string Position { get; set; } = "";
    public int Years { get; set; }

    public int UserId { get; set; }
}
