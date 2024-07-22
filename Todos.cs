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
        private Mode Status = Mode.Add;
        private XMLRepository xMLRepository = new XMLRepository();
        private int curId;


        public Todos(IRepository<TodoModel> repository)
        {
            InitializeComponent();
            todos = new List<TodoModel>();
            if (!File.Exists("todo.xml"))
            {
                xMLRepository.Add(new TodoModel("Bring the Messiah now", DateOnly.FromDateTime(DateTime.Now)));
            }
            dataGridView_tasks.DataSource = xMLRepository.GetAll();
            this.repository = repository;
        }

        private void populateViewWithTodo() { }

        // populate form from selected row

        private void SetMode(Mode mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case Mode.Add:
                    SetAddMode();
                    break;
                case Mode.Edit:
                    SetEditMode();
                    break;
            }
        }

        private void SetEditMode()
        {
            button_action.Text = "Edit";
            Status = Mode.Edit;
            ShowTheTask();
            ButtonDelete.Enabled = true;
        }

        private void SetAddMode()
        {
            button_action.Text = "Add";
            Status = Mode.Add;
            ResetTheTask();
            ButtonDelete.Enabled = false;
            curId = -1;
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            if (Status == Mode.Add)
            {
                AddEvent();
            }
            if (Status == Mode.Edit)
            {
                EditEvent();

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

        private void EditEvent()
        {
            SetMode(Mode.Edit);
            // add to xml
            //and then cgnge back to add mode
            dataGridView_tasks.DataSource = xMLRepository.GetAll();

            SetMode(Mode.Add);
        }
        private void AddEvent()
        {
            TodoModel myTask = CreateTodoModel();
            xMLRepository.Add(myTask);
            dataGridView_tasks.DataSource = xMLRepository.GetAll();
        }

        private TodoModel CreateTodoModel()
        {
            DateOnly date = DateOnly.FromDateTime(hopeDatePicker.Date);
            MessageBox.Show(date.ToString());
            string Task = textboxTask.Text;
            TodoModel todos = new TodoModel(Task, date);
            return todos;
        }

        private void checkbox_isDone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (Status == Mode.Edit)
            {
                int id = curId;
                XMLRepository xMLRepository = new XMLRepository();
                xMLRepository.DeleteById(id);
                dataGridView_tasks.DataSource = xMLRepository.GetAll();
                SetMode(Mode.Add);
            }
        }
        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("dataGridViewDisplay_CellClick");
        }
        private void dataGridView_tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            curId = (int)this.dataGridView_tasks.CurrentRow.Cells[0].Value;
            SetMode(Mode.Edit);
        }
    }
}
///=======
///>>>>>>> 3a59ed724c066067ec9d11af64c15a495a8660cc

//<<<<<<< HEAD