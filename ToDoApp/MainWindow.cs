namespace ToDoApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ToDoText.Text != "")
            {
                ToDoObjectCRD toDoObjectCRD = new ToDoObjectCRD();
                ToDoObject toDoObject = new ToDoObject();
                toDoObject.task = ToDoText.Text;
                toDoObjectCRD.InsertToDoObject(toDoObject);
                UpdateList();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ToDoList.SelectedItems[0].Text != null)
            {
                ToDoObjectCRD toDoObjectCRD = new ToDoObjectCRD();
                ToDoObject toDoObject = new ToDoObject();
                toDoObject.task = ToDoList.SelectedItems[0].Text.ToString();
                toDoObjectCRD.DeleteToDoObject(toDoObject.task);
                UpdateList();
            }
        }

        void UpdateList()
        {
            List<ToDoObject> ToDos = new ToDoObjectCRD().SelectAllToDoObjects();
            ToDoList.Items.Clear();
            foreach (var item in ToDos)
            {
                ToDoList.Items.Add(item.task);
            }
        }
    }
}
