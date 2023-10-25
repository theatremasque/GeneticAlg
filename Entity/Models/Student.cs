namespace GeneticAlgorithms.Models;

public class Student : Entity
{
    public string FullName { get; set; }

    public string Email { get; set; }

    public List<StudentCourse> Courses { get; set; }

    public List<TimeSlot> TimeSlots { get; set; }
}