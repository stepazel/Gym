using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.String;

namespace DbStorage.DatabaseObjects;

public class ExerciseDo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; } = Empty;

    public ExerciseCategoryDo CategoryDo { get; set; } = null!;
}