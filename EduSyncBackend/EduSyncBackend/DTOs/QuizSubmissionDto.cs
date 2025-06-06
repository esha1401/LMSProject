namespace EduSyncBackend.DTOs
{
    public class QuizSubmissionDto
    {
        public Guid AssessmentId { get; set; }
        public Guid CourseId { get; set; }
        public int Score { get; set; }
        public DateTime AttemptDate { get; set; }
    }
}