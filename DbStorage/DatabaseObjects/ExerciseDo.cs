using static System.String;

namespace DbStorage.DatabaseObjects;

public class ExerciseDo
{
    public int Id { get; set; }
    
    public string Name { get; set; } = Empty;

    public ExerciseCategoryDo CategoryDo { get; set; } = null!;
}