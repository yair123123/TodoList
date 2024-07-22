using ReaLTaiizor.Forms;
using TodoList.Repositories;

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
            AddEvent();
        }

        private TodoModel AddEvent()
        {          
            DateOnly date = DateOnly.FromDateTime(hopeDatePicker.Date);
            string Task = textboxTask.Text;
            TodoModel todos = new TodoModel(Task, date);

        }

        private void checkbox_isDone_CheckedChanged(object sender, EventArgs e)
        {
            XMLRepository xMLRepository = new XMLRepository();
            xMLRepository.DeleteById(1);
        }
    }
}
