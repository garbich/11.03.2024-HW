using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Task_2
{
    internal class NoteModel
    {
        public DateTime CreationDate { get; set; }
        public string AddToList(string text)
        {
          
           CreationDate = DateTime.Now;
           return($"Name: {text}                  Time: {CreationDate}");
        }

        public void deleteFromList(ListBox listBox, object itemToDelete)
        { 
             listBox.Items.Remove(itemToDelete);         
        }
    }
}
