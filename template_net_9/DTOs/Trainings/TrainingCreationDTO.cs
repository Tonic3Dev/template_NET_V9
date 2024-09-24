using template_net_9.Entities;
using System.ComponentModel.DataAnnotations;

namespace template_net_9.DTOs.Trainings
{
    public class TrainingCreationDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public StatusTrainigEnum Status { get; set; }
        public SatisfactionLevelEnum? SatisfactionLevel { get; set; }
        [Required]
        public int LegacyUserId { get; set; }
        public string TypeOfTraining { get; set; }
        public int Points { get; set; }
        public string SEPYME { get; set; }
        [Required]
        public float CourseCost { get; set; }
        public string Attendance { get; set; }
        public string TypeOfRequest { get; set; }
        public EffectivenessLevelEnum? EffectivenessLevel { get; set; }
    }
}
