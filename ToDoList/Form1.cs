using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private List<string> _tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // ustaw formualrz na środku ekranu
            this.StartPosition = FormStartPosition.CenterScreen;

            // Pobranie wersji zestawu Assembly
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            // Ustawienie wersji jako tytułu formularza
            this.Text = $"ToDoList v: {version.Major}.{version.Minor}.{version.Build}";
        }

        public void RefreshListBox()
        {
            // Wyczyść kontrolke listBox
            ListBox_AllTasks.Items.Clear();

            // Dodaj do kontrolki listBox zadania z głównej listy
            for(int i = 0; i < _tasks.Count; i++)
            {
                ListBox_AllTasks.Items.Add(_tasks[i]);
            }
        }

        private void Button_AddNewTask_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(TextBox_NewTask.Text))
            {
                _tasks.Add(TextBox_NewTask.Text);
                TextBox_NewTask.Text = "";
                RefreshListBox();
            }
        }

        private void Button_DeleteTask_Click(object sender, EventArgs e)
        {
            // Pobierz zaznaczony element
            object isSelected = ListBox_AllTasks.SelectedItem;

            // Sprawdź czy jakiekolwiek zadanie jest zaznaczone czy jest nie
            if(isSelected != null )
            {
                // Stwórz potwierdzenie usunięcia
                DialogResult confirmDelete = MessageBox.Show("Czy na pewno usunąć " + isSelected + "?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Sprawdź czy został kliknięty klawisz YES
                if(confirmDelete == DialogResult.Yes)
                {
                    // tymczasowa lista
                    List<string> tempList = new List<string>();
                    object selectedItem;

                    // skopiuj elementy z kontrolki listbox do tymczasowej listy
                    foreach (string task in ListBox_AllTasks.Items)
                    {
                        tempList.Add(task);
                    }

                    // z tymczasowej listy pobierz tylko ten zaznaczony element
                    selectedItem = ListBox_AllTasks.SelectedItem;

                    // z tymczasowej listy usuń tylko ten zaznaczony
                    tempList.Remove(selectedItem.ToString());

                    // z głównej listy usuń wszystko
                    _tasks.Clear();

                    // z tymczasowej listy dodaj do główej listy zaktualizowane elementy
                    foreach (string task in tempList)
                    {
                        _tasks.Add(task);
                    }

                    RefreshListBox();
                }
            }
        }
    }
}
