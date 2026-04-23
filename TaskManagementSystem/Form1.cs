namespace TaskManagementSystem
{
    public partial class Form1 : Form
    {
        // Single instance of TaskManager — used by all buttons
        private TaskManager _manager = new TaskManager();

        // Constructor
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        // Set default properties that are easier in code than designer
        private void InitializeControls()
        {
            // numPriority: for adding tasks (valid range 1–5)
            numPriority.Minimum = 1;
            numPriority.Maximum = 5;
            numPriority.Value = 1;

            // numTestPriority: for Section 3 testing — allow out-of-range values
            numTestPriority.Minimum = -10;
            numTestPriority.Maximum = 10;
            numTestPriority.Value = 3;

            // Result label styling
            lblResult.BackColor = Color.LightYellow;
            //lblResult.BorderStyle = BorderStyle.None;
            lblResult.AutoSize = true;
            //lblResult.Font = new Font("Consolas", 9f);
            lblResult.Text = "Ready. Add a task to get started.";

            // ListBox fonts for readability
            listTasks.Font = new Font("Consolas", 9f);
            listQueue.Font = new Font("Consolas", 9f);

            // Refresh display
            RefreshTaskList();
            RefreshQueueList();
            UpdateNextId();
        }

        // SECTION 1 — BUTTON: btnAddTask
        // Creates a new ProjectTask and adds it to List<AbstractTask>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string project = txtProject.Text.Trim();
            int priority = (int)numPriority.Value;

            // Validate inputs
            if (string.IsNullOrEmpty(title))
            {
                ShowResult("Please enter a Task Title.", Color.MistyRose);
                txtTitle.Focus();
                return;
            }
            if (string.IsNullOrEmpty(project))
            {
                ShowResult("Please enter a Project Name.", Color.MistyRose);
                txtProject.Focus();
                return;
            }

            // Add the task via TaskManager
            _manager.AddTask(title, priority, project);

            // Refresh UI
            RefreshTaskList();
            UpdateNextId();
            ShowResult($"Task '{title}' added successfully! [Priority: {priority}] [Project: {project}]", Color.Honeydew);

            // Clear input fields ready for next entry
            txtTitle.Clear();
            txtProject.Clear();
            numPriority.Value = 1;
            txtTitle.Focus();
        }

        // SECTION 1 — BUTTON: btnClear
        // Clears all input fields in the Add New Task group
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtProject.Clear();
            txtSubTask.Clear();
            txtSearchId.Clear();
            numPriority.Value = 1;
            listTasks.ClearSelected();
            ShowResult("Input fields cleared.", Color.LightYellow);
            txtTitle.Focus();
        }

        // SECTION 1 — BUTTON: btnAddSubTask
        // Adds a SubTask to the currently selected task in listTasks
        private void btnAddSubTask_Click(object sender, EventArgs e)
        {
            // Must have a task selected
            if (listTasks.SelectedIndex < 0)
            {
                ShowResult("Please select a task from the Task List first.", Color.MistyRose);
                return;
            }

            string subTitle = txtSubTask.Text.Trim();
            if (string.IsNullOrEmpty(subTitle))
            {
                ShowResult("Please enter a SubTask title.", Color.MistyRose);
                txtSubTask.Focus();
                return;
            }

            int selectedIndex = listTasks.SelectedIndex;
            bool success = _manager.AddSubTask(selectedIndex, subTitle);

            if (success)
            {
                RefreshTaskList();
                // Re-select the same task after refresh
                listTasks.SelectedIndex = selectedIndex;
                ShowResult($"SubTask '{subTitle}' added to '{_manager.TaskList[selectedIndex].Title}'.", Color.Honeydew);
                txtSubTask.Clear();
                txtSubTask.Focus();
            }
            else
            {
                ShowResult("Failed to add SubTask. Invalid selection.", Color.MistyRose);
            }
        }

        // SECTION 1 #3 — BUTTON: btnSearch
        // Runs calculateTotalWorkload() — LINEAR SEARCH by Task ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string input = txtSearchId.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                ShowResult("Please enter a Task ID to search.", Color.MistyRose);
                txtSearchId.Focus();
                return;
            }

            if (!int.TryParse(input, out int searchId))
            {
                ShowResult("Task ID must be a number.", Color.MistyRose);
                return;
            }

            // LINEAR SEARCH executed here
            AbstractTask found = _manager.CalculateTotalWorkload(searchId);

            if (found != null)
            {
                // Highlight found task in ListBox
                int listIndex = _manager.TaskList.IndexOf(found);
                if (listIndex >= 0)
                    listTasks.SelectedIndex = listIndex;

                ShowResult(
                    $"LINEAR SEARCH RESULT — FOUND: [ID:{found.Id}] '{found.Title}' " +
                    $"| Priority: {found.PriorityLevel} | {found.GetTaskCategory()} " +
                    $"| SubTasks: {found.SubTasks.Count}",
                    Color.LightCyan
                );
            }
            else
            {
                ShowResult($"LINEAR SEARCH RESULT — Task with ID '{searchId}' NOT FOUND. (Checked all {_manager.TaskList.Count} task(s))", Color.MistyRose);
            }
        }
        // SECTION 1 #2 — BUTTON: btnEnqueue
        // Adds selected task to the Next Tasks Queue (FIFO)
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex < 0)
            {
                ShowResult("Please select a task from the Task List to enqueue.", Color.MistyRose);
                return;
            }

            int selectedIndex = listTasks.SelectedIndex;
            AbstractTask task = _manager.TaskList[selectedIndex];
            bool success = _manager.EnqueueTask(selectedIndex);

            if (success)
            {
                RefreshQueueList();
                ShowResult(
                    $"ENQUEUE — '{task.Title}' added to Next Tasks Queue (FIFO). " +
                    $"Queue size: {_manager.NextTasksQueue.Count}",
                    Color.Honeydew
                );
            }
        }

        // SECTION 1 #2 — BUTTON: btnDequeue
        // Processes (removes) the first task from the Queue — FIFO orde
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (_manager.NextTasksQueue.Count == 0)
            {
                ShowResult("Queue is empty. No tasks to process.", Color.MistyRose);
                return;
            }

            AbstractTask processed = _manager.DequeueTask();
            RefreshQueueList();

            ShowResult(
                $"DEQUEUE — Processing: '{processed.Title}' [Priority: {processed.PriorityLevel}] " +
                $"removed from front of Queue (FIFO). Remaining: {_manager.NextTasksQueue.Count}",
                Color.LightCyan
            );
        }

        // SECTION 2 — BUTTON: btnCountSubs
        // Calls CountAllSubTasks() — RECURSIVE function
        private void btnCountSubs_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex < 0)
            {
                ShowResult("Please select a task from the Task List to count sub-tasks.", Color.MistyRose);
                return;
            }

            AbstractTask task = _manager.TaskList[listTasks.SelectedIndex];
            int count = _manager.CountAllSubTasks(task);

            // Show recursion explanation in result
            if (count == 0)
            {
                ShowResult(
                    $"RECURSION — BASE CASE REACHED: '{task.Title}' has 0 sub-tasks. " +
                    $"Recursion stopped immediately (base case: SubTasks.Count == 0).",
                    Color.LightYellow
                );
            }
            else
            {
                ShowResult(
                    $"RECURSION — Total SubTasks for '{task.Title}': {count}. " +
                    $"Recursive step counted all nesting levels. Base case: when SubTasks.Count == 0.",
                    Color.Honeydew
                );
            }
        }

        // SECTION 3 — BUTTON: btnSetPriority
        // Tests the setPriority(int level) method — Black-Box Testing
        // Boundary Values: 0 = below min, 1 = min, 5 = max, 6 = above max
        private void btnSetPriority_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedIndex < 0)
            {
                ShowResult("Please select a task from the Task List to test setPriority.", Color.MistyRose);
                return;
            }

            int selectedIndex = listTasks.SelectedIndex;
            int testValue = (int)numTestPriority.Value;

            // Determine test type for display
            string testType;
            if (testValue < 1)
                testType = "Boundary (Below Minimum) / Negative";
            else if (testValue > 5)
                testType = "Negative (Above Maximum)";
            else if (testValue == 1 || testValue == 5)
                testType = "Boundary (Edge of valid range)";
            else
                testType = "Positive (Within valid range)";

            // Call the testable method
            string result = _manager.SetPriority(selectedIndex, testValue);
            bool isValid = testValue >= 1 && testValue <= 5;

            // Refresh task list if priority changed successfully
            if (isValid) RefreshTaskList();

            ShowResult(
                $"TEST — Input: {testValue} | Output: \"{result}\" | Test Type: {testType}",
                isValid ? Color.Honeydew : Color.MistyRose
            );
        }

        // HELPER: Refresh listTasks — shows all tasks in the List<AbstractTask>
        private void RefreshTaskList()
        {
            // Remember selected index so we can restore it after refresh
            int previousIndex = listTasks.SelectedIndex;

            listTasks.Items.Clear();

            foreach (AbstractTask task in _manager.TaskList)
            {
                listTasks.Items.Add(task.ToString());
            }

            // Restore selection if it's still valid
            if (previousIndex >= 0 && previousIndex < listTasks.Items.Count)
                listTasks.SelectedIndex = previousIndex;
        }

        // HELPER: Refresh listQueue — shows all tasks in the Queue
        private void RefreshQueueList()
        {
            listQueue.Items.Clear();
            int position = 1;

            foreach (AbstractTask task in _manager.GetQueueAsList())
            {
                listQueue.Items.Add($"#{position++} | {task.Title} | [Priority: {task.PriorityLevel}] | {task.GetTaskCategory()}");
            }
        }

        // HELPER: Update the auto-ID display in txtSearchId placeholder
        //         (shows user what the next task ID will be)
        private void UpdateNextId()
        {
            // Optionally show next ID hint in the form title
            this.Text = $"Task Management System — {_manager.TaskList.Count} Task(s) | Next ID: {_manager.NextId}";
        }

        // HELPER: Show result message in lblResult with background color
        private void ShowResult(string message, Color bgColor)
        {
            lblResult.Text = message;
            lblResult.BackColor = bgColor;
        }
    }
}
