namespace Domain.Entities
{
    public class Tasks
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public List<string> Tags { get; private set; }

        public Tasks(string title, string description, DateTime dueDate, int priority, List<string> tags)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            DueDate = dueDate;
            Priority = priority;
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }
}