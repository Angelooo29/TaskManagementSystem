namespace TaskManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            numPriority = new NumericUpDown();
            btnAddTask = new Button();
            btnAddSubTask = new Button();
            listTasks = new ListBox();
            lblResult = new Label();
            btnSearch = new Button();
            txtTaskId = new TextBox();
            txtProject = new TextBox();
            txtSubTask = new TextBox();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnCountSubs = new Button();
            btnSetPriority = new Button();
            listQueue = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtSearchId = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            label5 = new Label();
            label8 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            numTestPriority = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPriority).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTestPriority).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.AcceptsTab = true;
            txtTitle.Location = new Point(111, 67);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(217, 27);
            txtTitle.TabIndex = 0;
            // 
            // numPriority
            // 
            numPriority.Location = new Point(111, 141);
            numPriority.Name = "numPriority";
            numPriority.Size = new Size(80, 27);
            numPriority.TabIndex = 2;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(6, 195);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnAddSubTask
            // 
            btnAddSubTask.Location = new Point(6, 325);
            btnAddSubTask.Name = "btnAddSubTask";
            btnAddSubTask.Size = new Size(125, 29);
            btnAddSubTask.TabIndex = 4;
            btnAddSubTask.Text = "Add Sub Task";
            btnAddSubTask.UseVisualStyleBackColor = true;
            btnAddSubTask.Click += btnAddSubTask_Click;
            // 
            // listTasks
            // 
            listTasks.FormattingEnabled = true;
            listTasks.Location = new Point(6, 23);
            listTasks.Name = "listTasks";
            listTasks.Size = new Size(552, 144);
            listTasks.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Location = new Point(12, 605);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(51, 22);
            lblResult.TabIndex = 9;
            lblResult.Text = "Result";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(6, 417);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTaskId
            // 
            txtTaskId.Location = new Point(111, 32);
            txtTaskId.Name = "txtTaskId";
            txtTaskId.ReadOnly = true;
            txtTaskId.Size = new Size(80, 27);
            txtTaskId.TabIndex = 12;
            // 
            // txtProject
            // 
            txtProject.AcceptsTab = true;
            txtProject.Location = new Point(111, 100);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(217, 27);
            txtProject.TabIndex = 1;
            // 
            // txtSubTask
            // 
            txtSubTask.Location = new Point(109, 275);
            txtSubTask.Name = "txtSubTask";
            txtSubTask.Size = new Size(219, 27);
            txtSubTask.TabIndex = 3;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(99, 481);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(152, 29);
            btnEnqueue.TabIndex = 6;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(99, 516);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(152, 29);
            btnDequeue.TabIndex = 7;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnCountSubs
            // 
            btnCountSubs.Location = new Point(110, 35);
            btnCountSubs.Name = "btnCountSubs";
            btnCountSubs.Size = new Size(150, 40);
            btnCountSubs.TabIndex = 17;
            btnCountSubs.Text = "Count Subs";
            btnCountSubs.UseVisualStyleBackColor = true;
            btnCountSubs.Click += btnCountSubs_Click;
            // 
            // btnSetPriority
            // 
            btnSetPriority.Location = new Point(253, 36);
            btnSetPriority.Name = "btnSetPriority";
            btnSetPriority.Size = new Size(94, 29);
            btnSetPriority.TabIndex = 18;
            btnSetPriority.Text = "Set Priority";
            btnSetPriority.UseVisualStyleBackColor = true;
            btnSetPriority.Click += btnSetPriority_Click;
            // 
            // listQueue
            // 
            listQueue.FormattingEnabled = true;
            listQueue.Location = new Point(6, 26);
            listQueue.Name = "listQueue";
            listQueue.Size = new Size(552, 124);
            listQueue.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 20;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 21;
            label2.Text = "Task ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 103);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 22;
            label3.Text = "Project Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 278);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 23;
            label4.Text = "SubTask Title:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearchId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAddTask);
            groupBox1.Controls.Add(txtSubTask);
            groupBox1.Controls.Add(btnEnqueue);
            groupBox1.Controls.Add(btnDequeue);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numPriority);
            groupBox1.Controls.Add(btnAddSubTask);
            groupBox1.Controls.Add(txtProject);
            groupBox1.Controls.Add(txtTaskId);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 547);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Task";
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(111, 384);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(80, 27);
            txtSearchId.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 387);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 25;
            label6.Text = "Search by ID:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(148, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 23;
            label5.Text = "Priority (1-5):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 563);
            label8.Name = "label8";
            label8.Size = new Size(156, 20);
            label8.TabIndex = 27;
            label8.Text = "Result / Status Output:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listTasks);
            groupBox2.Location = new Point(360, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(564, 176);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Tasks";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listQueue);
            groupBox3.Location = new Point(360, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(564, 159);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Next Task Queue";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnCountSubs);
            groupBox4.Location = new Point(360, 349);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(522, 106);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(numTestPriority);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(btnSetPriority);
            groupBox5.Location = new Point(360, 461);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(522, 86);
            groupBox5.TabIndex = 28;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // numTestPriority
            // 
            numTestPriority.Location = new Point(145, 36);
            numTestPriority.Name = "numTestPriority";
            numTestPriority.Size = new Size(92, 27);
            numTestPriority.TabIndex = 28;
            numTestPriority.ValueChanged += btnSetPriority_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 40);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 27;
            label7.Text = "New Priority:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 653);
            Controls.Add(lblResult);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label8);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management System";
            ((System.ComponentModel.ISupportInitialize)numPriority).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTestPriority).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private NumericUpDown numPriority;
        private Button btnAddTask;
        private Button btnAddSubTask;
        private ListBox listTasks;
        private Label lblResult;
        private Button btnSearch;
        private TextBox txtTaskId;
        private TextBox txtProject;
        private TextBox txtSubTask;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnCountSubs;
        private Button btnSetPriority;
        private ListBox listQueue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private Button btnClear;
        private TextBox txtSearchId;
        private Label label6;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label8;
        private Label label7;
        private NumericUpDown numTestPriority;
    }
}
