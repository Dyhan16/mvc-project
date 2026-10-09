namespace MVC_Project.Models;

public class ProfileViewModel
{
    public string FullName { get; set; } = "";
    public string Course   { get; set; } = "";
    public string School   { get; set; } = "";
    public string Bio      { get; set; } = "";
    public List<string> Skills { get; set; } = new();
    public string? ImagePath { get; set; }
    
}