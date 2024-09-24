using System.ComponentModel.DataAnnotations.Schema;

namespace template_net_9.Entities.Updates;

[Table("structureupdates")]
public class StructureUpdate : UpdatesBase
{
    public float Amount { get; set; }
}