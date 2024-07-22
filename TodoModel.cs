using System.Xml.Serialization;

namespace TodoList
{
    [XmlRoot("TodoList")] 
    public class TodoListModel
    {
        [XmlElement("Todo")]
        public List<TodoModel> Todos { get; set; } = new List<TodoModel>();
    }
    public class TodoModel
    {
        [XmlElement("ID")] 
        public int Id { get; set; }

        [XmlElement("Title")] 
        public string Title { get; set; }

        [XmlElement("Done")]
        public bool Done;


        [XmlIgnore]
        public DateOnly Date { get; set; }


        public string DateString
        {
            get => Date.ToString("yyyy-MM-dd");
            set => Date = DateOnly.Parse(value);
        }


        public TodoModel(string title, DateOnly date, bool done = false)
        {
            Title = title;
            Date = date;
            Done = done;
        }
        public TodoModel() { }
    }
}
