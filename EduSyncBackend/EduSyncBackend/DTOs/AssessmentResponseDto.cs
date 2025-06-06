namespace EduSyncBackend.DTOs
{
    public class AssessmentResponseDto
    {
        public Guid AssessmentId { get; set; }
        public string Title { get; set; }
        public int MaxScore { get; set; }
        public Guid CourseId { get; set; }
    }
}