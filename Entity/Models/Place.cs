namespace GeneticAlgorithms.Models;

public class Place : Entity
{
    public string Title { get; set; }
    
    public List<TimeSlot> TimeSlots { get; set; }
}