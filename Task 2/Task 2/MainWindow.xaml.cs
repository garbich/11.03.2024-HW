using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Task_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            NoteModel noteModel = new NoteModel();

            listBox.Items.Add(noteModel.AddToList(textBox.Text));

               
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            NoteModel noteModel = new NoteModel();
            
            object selectedItem = listBox.SelectedItem;
          
            noteModel.deleteFromList(listBox, selectedItem);
            
        }

 
    }
}
