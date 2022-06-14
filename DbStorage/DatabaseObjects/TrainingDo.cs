using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbStorage.DatabaseObjects;

public class TrainingDo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public DateTime Start { get; set; }
    
    public DateTime End { get; set; }

    public List<ExerciseDo> Exercises { get; set; } = new();
}