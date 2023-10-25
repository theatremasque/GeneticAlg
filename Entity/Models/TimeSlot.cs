namespace GeneticAlgorithms.Models;

public class TimeSlot : Entity
{
    public DayOfWeek Day { get; set; }

    public TimeSpan Start { get; set; }

    public TimeSpan End { get; set; }

    public int PlaceId { get; set; }

    public Place Place { get; set; }

    public int CourseId { get; set; }

    public Course Course { get; set; }

    public List<Student> Students { get; set; }
}