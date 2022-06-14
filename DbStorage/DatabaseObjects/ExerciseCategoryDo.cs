using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbStorage.DatabaseObjects;

public class ExerciseCategoryDo
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;

    public List<ExerciseDo> Exercises { get; set; } = null!;
}