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


        public Todos(IRepository<TodoModel> repository)
        {
            InitializeComponent();
            todos = new List<TodoModel>();
            if (!File.Exists("todo.xml"))
            {
                xMLRepository.Add(new TodoModel("Bring the Messiah now", DateOnly.FromDateTime(DateTime.Now)));
            }
            dataGridView_tasks.DataSource = xMLRepository.GetAll();
            dataGridView_tasks.Columns["Date"].Visible = false;
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
            dataGridView_tasks.Columns["Date"].Visible = false;

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
                int id = 1;
                XMLRepository xMLRepository = new XMLRepository();
                xMLRepository.DeleteById(id);
            }
        }
        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("dataGridViewDisplay_CellClick");
        }
        private void dataGridView_tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
            MessageBox.Show("");

            //this.dataGridView_tasks.CurrentRow.Cells[0].Value;

        }
    }
}
///=======
///>>>>>>> 3a59ed724c066067ec9d11af64c15a495a8660cc

//<<<<<<< HEAD