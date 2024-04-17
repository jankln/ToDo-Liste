using System.ComponentModel;
using System.Xml.Linq;

namespace ToDoList
{
    public partial class FrmToDo : Form
    {
        public static BindingList<string> TasksList = new BindingList<string>();
        private bool isDarkMode = false;
        public FrmToDo()
        {
            InitializeComponent();
        }
        private void FrmToDo_Load(object sender, EventArgs e)
        {

            lbxTasks.DataSource = TasksList;

            ToolTip toolTipbtnAddTask = new ToolTip();
            toolTipbtnAddTask.SetToolTip(btnAddTask, "Geben Sie links in die TextBox die Aufgabe ein, die Sie hinzufügen möchten.");
            ToolTip toolTipbtnDarkMode = new ToolTip();
            toolTipbtnDarkMode.SetToolTip(btnDarkMode, "Durch drücken wechseln Sie den Ansichtsmodus.");
            ToolTip toolTipbtnExplain = new ToolTip();
            toolTipbtnExplain.SetToolTip(btnExplain, "Durch drücken öffnen Sie die Funktionen und Steuerung Erklärung der Software.");

        }
        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(tbxAddTask.Text))
            {
                bool taskAlreadyExists = false;
                foreach (var task in TasksList)
                {
                    if (task == tbxAddTask.Text)
                    {
                        taskAlreadyExists = true;
                        break;
                    }
                }
                if (!taskAlreadyExists)
                {
                    TasksList.Add(tbxAddTask.Text);
                    tbxAddTask.Text = "";
                }
                else
                {
                    MessageBox.Show("Die Aufgabe existiert bereits!");
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask();

        }
        


        private void lbxTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lbxTasks.SelectedItem != null)
            {
                string newTaskDescription = Microsoft.VisualBasic.Interaction.InputBox("Bitte geben Sie die korrigierte Aufgabe ein:", "Aufgabe bearbeiten", "");

                if (!string.IsNullOrWhiteSpace(newTaskDescription))
                {
                    TasksList[lbxTasks.SelectedIndex] = newTaskDescription;
                }
            }
        }

        private void lbxTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lbxTasks.SelectedItem != null)
                {
                    TasksList.RemoveAt(lbxTasks.SelectedIndex);
                }
            }
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            if (isDarkMode)
            {
                BackColor = Color.FromArgb(31, 31, 31);
                ForeColor = Color.White;
                lbxTasks.BackColor = Color.FromArgb(45, 45, 45);
                lbxTasks.ForeColor = Color.White;

                tbxAddTask.BackColor = Color.FromArgb(45, 45, 45);
                tbxAddTask.ForeColor = Color.White;
                btnAddTask.BackColor = Color.FromArgb(45, 45, 45);
                btnAddTask.ForeColor = Color.White;
                btnDarkMode.BackColor = Color.FromArgb(45, 45, 45);
                btnDarkMode.ForeColor = Color.White;
                btnExplain.BackColor = Color.FromArgb(45, 45, 45);
                btnExplain.ForeColor = Color.White;
                btnDarkMode.Text = "Light Mode";

            }
            else
            {
                BackColor = SystemColors.Control;
                ForeColor = SystemColors.ControlText;
                lbxTasks.BackColor = SystemColors.Window;
                lbxTasks.ForeColor = SystemColors.WindowText;

                tbxAddTask.BackColor = SystemColors.Window;
                tbxAddTask.ForeColor = SystemColors.ControlText;
                btnAddTask.BackColor = SystemColors.Control;
                btnAddTask.ForeColor = SystemColors.ControlText;
                btnDarkMode.BackColor = SystemColors.Control;
                btnDarkMode.ForeColor = SystemColors.ControlText;
                btnExplain.BackColor = SystemColors.Control;
                btnExplain.ForeColor = SystemColors.ControlText;
                btnDarkMode.Text = "Dark Mode";
            }
        }

        private void btnExplain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Willkommen bei der ToDo-Liste!\n\n" +
                    "Hier sind die Funktionen der Software:\n\n" +
                    "- Aufgaben hinzufügen: Geben Sie eine Aufgabe in das Textfeld ein und klicken Sie auf 'Aufgabe hinzufügen'.\n\n" +
                    "- Aufgaben bearbeiten: Doppelklicken Sie auf eine Aufgabe in der Liste, um sie zu bearbeiten. Geben Sie dann die korrigierte Aufgabe ein und bestätigen Sie.\n\n" +
                    "- Aufgaben löschen: Wählen Sie eine Aufgabe aus der Liste aus und drücken Sie die 'Entf'-Taste auf Ihrer Tastatur.\n\n" +
                    "- Ansichtsmodus ändern: Klicken Sie auf 'Dark Mode', um zwischen dem dunklen und hellen Modus zu wechseln.\n\n" +
                    "Vielen Dank, dass Sie die ToDo-Liste verwenden!");
        }

        private void tbxAddTask_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddTask();
            }
        }
    }
}
