using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json; // <-- Correct namespace

namespace EduSyncBackend.Models
{
    public class QuizQuestion
    {
        public string Id { get; set; }              // e.g. "q2"
        public required string Question { get; set; }        // e.g. "Which Azure service is used for hosting virtual machines?"
        public List<string> Options { get; set; }   // List of options
        public string CorrectOption { get; set; }   // Correct answer text
        public int TimeLimit { get; set; }          // Time limit in minutes (or whatever unit)


    }
}