namespace GeneticAlgorithms.Models;

public class Teacher : Entity   
{
    public List<Course> Courses { get; set; }
    
    public string FullName { get; set; }
}