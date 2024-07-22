using ReaLTaiizor.Forms;
using System.Threading.Tasks;
using TodoList.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoList
{
    enum Mode
    {
        Add,
        Edit
    }
    internal partial class Todos : MaterialForm
    {
        private List<TodoModel> todos;
        private Mode mode;
        private IRepository<TodoModel> repository;
        private string Status = "add";
        private XMLRepository xMLRepository = new XMLRepository();


        public Todos(IRepository<TodoModel> repository)
        {
            InitializeComponent();
            todos = new List<TodoModel>();
            dataGridView_tasks.DataSource = todos;
            this.repository = repository;
        }

        private void populateViewWithTodo() { }

        // populate form from selected row
        private void dataGridView_tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetMode(Mode mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case Mode.Add:
                    button_action.Text = "Add";
                    break;
                case Mode.Edit:
                    button_action.Text = "Edit";
                    break;
            }
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            if (Status == "add")
            {
                AddEvent();
            }
            if (Status == "edit")
            {
                EditEvent();

            }
        }

        private void EditEvent()
        {
            ShowTheTask();

        }
        private void StatusChange(string status)
        {
            switch(status)
            {
                case "edit":
                    Status = "edit";
                    ShowTheTask();
                    break;

                case "add":
                    Status = "add";
                    ResetTheTask();
                    break;
                }
        }
        private void ShowTheTask()
        {
            textboxTask.Text = string.Empty;
        }
        private void ResetTheTask()
        {
            textboxTask.Text = string.Empty;
        }


        private void AddEvent()
        {
            TodoModel myTask = CreateTodoModel();
            xMLRepository.Add(myTask);
        }

        private TodoModel CreateTodoModel()
        {
            DateOnly date = DateOnly.FromDateTime(hopeDatePicker.Date);
            string Task = textboxTask.Text;
            TodoModel todos = new TodoModel(Task, date);
            return todos;
        }

        private void checkbox_isDone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (true)
            {
                int id = 1;
                XMLRepository xMLRepository = new XMLRepository();
                xMLRepository.DeleteById(id);
            }
        }
    }
}
///=======
///>>>>>>> 3a59ed724c066067ec9d11af64c15a495a8660cc

//<<<<<<< HEAD