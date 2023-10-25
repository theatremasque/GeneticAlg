namespace GeneticAlgorithms.Models;

public class Course : Entity
{
    public string Title { get; set; } = null!;

    public List<TimeSlot> Slots { get; set; }

    public Teacher Teacher { get; set; }
    public List<StudentCourse> StudentCourses { get; set; }
    
}