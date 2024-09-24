using template_net_9.Entities;

namespace template_net_9.DTOs.Trainings
{
    public class TrainingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public StatusTrainigEnum Status { get; set; }
        public SatisfactionLevelEnum? SatisfactionLevel { get; set; }
        public LegacyUserPublicDTO LegacyUser { get; set; }
        public int LegacyUserId { get; set; }
        public string TypeOfTraining { get; set; }
        public int Points { get; set; }
        public string SEPYME { get; set; }
        public float CourseCost { get; set; }
        public string Attendance { get; set; }
        public string TypeOfRequest { get; set; }
        public EffectivenessLevelEnum? EffectivenessLevel { get; set; }
    }
}
