using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;
namespace SkillBridge.Api.Entities{public class Job
{
    [Required,Key]
    public int Id {get;set;}
    [Required]
    public string Title {get;set;}
    [Required]
    public string Description {get;set;}
    [Required]

    public string Company {get;set;}
    [Required]
    public string Location {get;set;}
    [Required]
    public decimal MinimumSalary {get;set;}
    [Required]
    public decimal MaximumSalary {get;set;}
    //float MinSalary = 15.04
    [Required]
    
    public DateTime DeadlineDate {get;set;}
    [Required]
    public bool isActive {get;set;}
    [Required]
    public User PostedBy  {get;set;}
     public int PostedById  {get;set;}
}
    
}
