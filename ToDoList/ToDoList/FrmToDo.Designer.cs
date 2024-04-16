namespace ToDoList
{
    partial class FrmToDo
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
            components = new System.ComponentModel.Container();
            lbxTasks = new ListBox();
            btnAddTask = new Button();
            tbxAddTask = new TextBox();
            tmrToDo = new System.Windows.Forms.Timer(components);
            lblHeadline = new Label();
            btnDarkMode = new Button();
            btnExplain = new Button();
            SuspendLayout();
            // 
            // lbxTasks
            // 
            lbxTasks.FormattingEnabled = true;
            lbxTasks.Location = new Point(199, 54);
            lbxTasks.Name = "lbxTasks";
            lbxTasks.Size = new Size(427, 244);
            lbxTasks.TabIndex = 0;
            lbxTasks.DoubleClick += lbxTasks_DoubleClick;
            lbxTasks.KeyDown += lbxTasks_KeyDown;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(532, 317);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(94, 29);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Hinzufügen";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // tbxAddTask
            // 
            tbxAddTask.Location = new Point(199, 317);
            tbxAddTask.Name = "tbxAddTask";
            tbxAddTask.Size = new Size(286, 27);
            tbxAddTask.TabIndex = 2;
            tbxAddTask.KeyDown += tbxAddTask_KeyDown;
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.Location = new Point(196, 21);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(74, 20);
            lblHeadline.TabIndex = 3;
            lblHeadline.Text = "Aufgaben";
            // 
            // btnDarkMode
            // 
            btnDarkMode.Location = new Point(12, 12);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(107, 29);
            btnDarkMode.TabIndex = 4;
            btnDarkMode.Text = "Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = true;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // btnExplain
            // 
            btnExplain.Location = new Point(666, 12);
            btnExplain.Name = "btnExplain";
            btnExplain.Size = new Size(94, 49);
            btnExplain.TabIndex = 5;
            btnExplain.Text = "Erklärung Steuerung";
            btnExplain.UseVisualStyleBackColor = true;
            btnExplain.Click += btnExplain_Click;
            // 
            // FrmToDo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExplain);
            Controls.Add(btnDarkMode);
            Controls.Add(lblHeadline);
            Controls.Add(tbxAddTask);
            Controls.Add(btnAddTask);
            Controls.Add(lbxTasks);
            Name = "FrmToDo";
            Text = "ToDos";
            Load += FrmToDo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxTasks;
        private Button btnAddTask;
        private TextBox tbxAddTask;
        private System.Windows.Forms.Timer tmrToDo;
        private Label lblHeadline;
        private Button btnDarkMode;
        private Button btnExplain;
    }
}
