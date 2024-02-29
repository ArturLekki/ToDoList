namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_AllTasks = new System.Windows.Forms.ListBox();
            this.TextBox_NewTask = new System.Windows.Forms.TextBox();
            this.Button_AddNewTask = new System.Windows.Forms.Button();
            this.Button_DeleteTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBox_AllTasks
            // 
            this.ListBox_AllTasks.FormattingEnabled = true;
            this.ListBox_AllTasks.ItemHeight = 16;
            this.ListBox_AllTasks.Location = new System.Drawing.Point(32, 259);
            this.ListBox_AllTasks.Name = "ListBox_AllTasks";
            this.ListBox_AllTasks.Size = new System.Drawing.Size(516, 308);
            this.ListBox_AllTasks.TabIndex = 0;
            // 
            // TextBox_NewTask
            // 
            this.TextBox_NewTask.Location = new System.Drawing.Point(32, 81);
            this.TextBox_NewTask.Multiline = true;
            this.TextBox_NewTask.Name = "TextBox_NewTask";
            this.TextBox_NewTask.Size = new System.Drawing.Size(516, 136);
            this.TextBox_NewTask.TabIndex = 1;
            // 
            // Button_AddNewTask
            // 
            this.Button_AddNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_AddNewTask.Location = new System.Drawing.Point(577, 81);
            this.Button_AddNewTask.Name = "Button_AddNewTask";
            this.Button_AddNewTask.Size = new System.Drawing.Size(195, 75);
            this.Button_AddNewTask.TabIndex = 2;
            this.Button_AddNewTask.Text = "Dodaj zadanie";
            this.Button_AddNewTask.UseVisualStyleBackColor = true;
            this.Button_AddNewTask.Click += new System.EventHandler(this.Button_AddNewTask_Click);
            // 
            // Button_DeleteTask
            // 
            this.Button_DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_DeleteTask.Location = new System.Drawing.Point(577, 492);
            this.Button_DeleteTask.Name = "Button_DeleteTask";
            this.Button_DeleteTask.Size = new System.Drawing.Size(195, 75);
            this.Button_DeleteTask.TabIndex = 3;
            this.Button_DeleteTask.Text = "Usuń zaznaczony";
            this.Button_DeleteTask.UseVisualStyleBackColor = true;
            this.Button_DeleteTask.Click += new System.EventHandler(this.Button_DeleteTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nowe zadanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(30, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista zadań:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_DeleteTask);
            this.Controls.Add(this.Button_AddNewTask);
            this.Controls.Add(this.TextBox_NewTask);
            this.Controls.Add(this.ListBox_AllTasks);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_AllTasks;
        private System.Windows.Forms.TextBox TextBox_NewTask;
        private System.Windows.Forms.Button Button_AddNewTask;
        private System.Windows.Forms.Button Button_DeleteTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

