using System.ComponentModel.DataAnnotations;


namespace SkillBridge.Api.Entities
    {
        public class User
{
    [Required,Key]
public int Id {get; set;}
[Required]
public string name {get; set;}
[Required]
public string email{get; set;}
[Required]
public string PasswordHash{get; set;}
[Required]
public string Type{get; set;}
[Required]
public DateTime CreatedAt{get;set;}
public bool IsActive {get; set;}
}
    
    
    }