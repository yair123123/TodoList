using System.Xml.Linq;
using System.Xml.Serialization;


namespace TodoList.Repositories
{
    internal class XMLRepository : IRepository<TodoModel>
    {

        public void Add(TodoModel todo)
        {
            //todo.Id = _id++;
            XmlSerializer listSerializer = new XmlSerializer(typeof(TodoListModel));
            XmlSerializer itemSerializer = new XmlSerializer(typeof(TodoModel));

            TodoListModel todoList;

            if (File.Exists("todo.xml"))
            {
                try
                {
                    using (StreamReader reader = new StreamReader("todo.xml"))
                    {
                        try
                        {
                            todoList = (TodoListModel)listSerializer.Deserialize(reader);
                        }
                        catch (InvalidCastException)
                        { 
                            TodoModel existingTodo = (TodoModel)itemSerializer.Deserialize(reader);
                            todoList = new TodoListModel();
                            todoList.Todos.Add(existingTodo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading XML: {ex.Message}");
                    todoList = new TodoListModel();
                }

            }
            else
            {
                todoList = new TodoListModel();
            }


            int _id = todoList.Todos.LastOrDefault().Id;
            if (todo.Id == null)
            {
                todo.Id = _id++;
            }
            todoList.Todos.Add(todo);

            using (StreamWriter writer = new StreamWriter("todo.xml"))
            {
                listSerializer.Serialize(writer, todoList);
            }
        }
        
        public void DeleteById(int id)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TodoListModel));
            TodoListModel todoList;
            using (StreamReader reader = new StreamReader("todo.xml"))
            {
                todoList = (TodoListModel)serializer.Deserialize(reader);
                todoList.Todos = todoList.Todos.Where(todo => todo.Id != id).ToList();
            }
            using (StreamWriter writer = new StreamWriter("todo.xml"))
            {
                serializer.Serialize(writer, todoList);
            }
        }

        public List<TodoModel> GetAll()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TodoListModel));
            TodoListModel todoList;
            using (StreamReader reader = new StreamReader("todo.xml"))
            {
                todoList = (TodoListModel)serializer.Deserialize(reader);
                //todoList.Todos = todoList.Todos.ToList();
            }
            return todoList.Todos;
        }

        public List<TodoModel> GetAll(Func<TodoModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TodoModel GetById(int id)
        {
            TodoModel get;
            XmlSerializer serializer = new XmlSerializer(typeof(TodoListModel));
            TodoListModel todoList;
            using (StreamReader reader = new StreamReader("todo.xml"))
            {
                todoList = (TodoListModel)serializer.Deserialize(reader);
                get = todoList.Todos.SingleOrDefault(todo => todo.Id == id);
            }
            return get;
        }

        public void Update(TodoModel todo)
        {
           TodoModel Get =  GetById(todo.Id);
           DeleteById(todo.Id);
           Add(Get);
        }
    }
}
