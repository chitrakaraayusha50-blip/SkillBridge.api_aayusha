
using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

public class JobApplication
{ [Required, Key]
   public int Id {get;set; }
   [Required]
   public Job AppliedJob {get;set; }
   [Required]

    public int AppliedJobId {get;set; }
   [Required]

     public User AppliedBy {get;set; }
   [Required]

      public int AppliedById {get;set; }
   [Required]

      public DateTime ApplicationDate {get;set; }
      public string Status {get;set;}
      public bool IsActive {get;set;}
      public string CoverLetter {get;set;}
      public string ResumePath {get;set;}
      public int User{get; set; }
}