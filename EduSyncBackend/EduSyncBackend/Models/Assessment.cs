using EduSyncBackend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Assessment
{
    [Key]
    public Guid AssessmentId { get; set; }

    [Required]
    public Guid CourseId { get; set; }

    [ForeignKey("CourseId")]
    public Course Course { get; set; }

    public string Title { get; set; }

    public string? Questions { get; set; } // JSON stored as string

    public int MaxScore { get; set; }

    public ICollection<Result> Results { get; set; } = new List<Result>();
}
