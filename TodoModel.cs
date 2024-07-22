using System.Xml.Serialization;

namespace TodoList
{
    [XmlRoot("Todo")] 
    public class TodoModel
    {
        [XmlElement("ID")] 
        public int Id { get; set; }

        [XmlElement("Title")] 
        public string Title { get; set; }

        [XmlElement("Done")]
        public bool Done;
        
        
        public DateOnly Date { get; set; }

        public TodoModel(string title, DateOnly date, bool done = false)
        {
            Title = title;
            Date = date;
            Done = done;
        }
    }
}
