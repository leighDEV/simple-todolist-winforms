using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_toDoList_winforms
{
    public partial class ToDoListForm : Form
    {
        public ToDoListForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbToDo.Text == "")
                return;
            else
                chklbToDoList.Items.Add(tbToDo.Text);
        }

        private void btnClear_Click(object sender, EventArgs e) => tbToDo.ResetText();

        private void btnClearChecked_Click(object sender, EventArgs e)
        {
            for (int i = chklbToDoList.Items.Count - 1; i >= 0; i--)
            {
                if (chklbToDoList.GetItemChecked(i))
                    chklbToDoList.Items.RemoveAt(i);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            chklbToDoList.Items.Clear();
            tbToDo.ResetText();
        }
    }
}
