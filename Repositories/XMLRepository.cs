using System.Xml.Linq;
using System.Xml.Serialization;


namespace TodoList.Repositories
{
    internal class XMLRepository : IRepository<TodoModel>
    {
        int _id = 0;
        public void Add(TodoModel todo)
        {
            Console.WriteLine(todo.Id);

            todo.Id = _id++;
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
            throw new NotImplementedException();
        }

        public TodoModel Update(TodoModel todo)
        {
            throw new NotImplementedException();
        }
    }
}
