using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbStorage.DatabaseObjects;

public class ExerciseTrainingDo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public TrainingDo TrainingDo { get; set; } = null!;

    public ExerciseDo ExerciseDo { get; set; } = null!;
    
    public float Weight { get; set; }
    
    public int Sets { get; set; }

    public int Reps { get; set; }
}