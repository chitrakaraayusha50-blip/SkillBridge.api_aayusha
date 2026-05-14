using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

public class UserProfile
{
    public int Id {get; set;}
    [Required]
    public User User {get; set;}
    [Required]
    public int FullName {get; set;}
    [Required]
    public string SkillSet {get; set;}
    [Required]
    public string Education {get; set;}
    [Required]
    public string Experience {get; set;}
    [Required]
    public string ResumePath {get; set;}
    [Required]
    public string LinkedInProfile {get; set;}
    [Required]
    public string GitHubProfile {get; set;}
    [Required]
    public string Bio {get; set;}
    [Required]
    public string Location {get; set;}
    [Required]
    public string ContactNumber {get; set;}
   
}