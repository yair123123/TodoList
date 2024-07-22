using System.Xml.Linq;
using System.Xml.Serialization;


namespace TodoList.Repositories
{
    internal class XMLRepository : IRepository<TodoModel>
    {
        public TodoModel Add(TodoModel todo)
        {
            todo.Id = 1;
            XmlSerializer serializer = new XmlSerializer(typeof(TodoModel));
            using (StreamWriter writer = new StreamWriter("todo.xml"))
            {
                serializer.Serialize(writer, todo);
            }
            XmlSerializer newserializer = new XmlSerializer(typeof(TodoModel));
            using (StreamReader reader = new StreamReader("todo.xml"))
            {
                todo = (TodoModel)serializer.Deserialize(reader);
            }
            return todo;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetAll(Func<TodoModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TodoModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TodoModel Update(TodoModel todo)
        {
            throw new NotImplementedException();
        }
    }
}
