﻿namespace EduSyncBackend.DTOs
{
    public class CourseResponseDto
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string InstructorName { get; set; }
        public string MediaUrl { get; set; }
    }
}