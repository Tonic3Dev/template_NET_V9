using System.ComponentModel.DataAnnotations.Schema;
using template_net_9.Entities.Users;

namespace template_net_9.Entities
{
    [Table("trainings")]
    public class Training
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public StatusTrainigEnum Status { get; set; }
        public SatisfactionLevelEnum? SatisfactionLevel { get; set; }
        public LegacyUser LegacyUser { get; set; }
        public int LegacyUserId { get; set; }
        public string TypeOfTraining { get; set; }
        public int Points { get; set; }
        public string SEPYME { get; set; }
        public float CourseCost { get; set; }
        public string Attendance { get; set; }
        public string TypeOfRequest { get; set; }
        public EffectivenessLevelEnum? EffectivenessLevel { get; set; }
    }

    public enum StatusTrainigEnum
    {
        NotStartedYet,
        InProgress,
        Abandoned,
        Finished
    }

    public enum SatisfactionLevelEnum
    {
        NotAtAllSatisfied,
        PartlySatified,
        Satisfied,
        MoreThanSatisfied,
        VerySatisfied
    }

    public enum EffectivenessLevelEnum
    {
        Low,
        Medium,
        High
    }
}
