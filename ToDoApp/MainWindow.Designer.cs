namespace ToDoApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ToDoText = new TextBox();
            RemoveButton = new Button();
            AddButton = new Button();
            ToDoList = new ListView();
            SuspendLayout();
            // 
            // ToDoText
            // 
            ToDoText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToDoText.Location = new Point(12, 12);
            ToDoText.Name = "ToDoText";
            ToDoText.Size = new Size(644, 23);
            ToDoText.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.Location = new Point(728, 12);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(60, 23);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(662, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(60, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ToDoList
            // 
            ToDoList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ToDoList.Location = new Point(12, 41);
            ToDoList.Name = "ToDoList";
            ToDoList.Size = new Size(776, 397);
            ToDoList.TabIndex = 3;
            ToDoList.UseCompatibleStateImageBehavior = false;
            ToDoList.View = View.List;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToDoList);
            Controls.Add(AddButton);
            Controls.Add(RemoveButton);
            Controls.Add(ToDoText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "Kilicsizoglu ToDo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ToDoText;
        private Button RemoveButton;
        private Button AddButton;
        private ListView ToDoList;
    }
}
