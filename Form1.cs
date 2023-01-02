using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exercise_task_A
{
    public partial class Form1 : Form
    {
        private QueueTasks tasks;
        public Form1()
        {
            tasks = new QueueTasks();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(inputTaskTextBox.Text); //create new task with info from the inputTaskTextBox
            tasks.Enqueue(task); // add task to the queue
            countLabel.Text = "" + tasks.Count();
            currentTaskTextBox.Text = "" + tasks.Peek().ToString(); // display first task
            inputTaskTextBox.Text = ""; // clear inputTaskTextBox          
        }

        private void removeTaskButton_Click(object sender, EventArgs e)
        {
            tasks.Dequeue();
            countLabel.Text = "" + tasks.Count(); //displays number of tasks to do
            if (tasks.Count() > 0) // if the number of tasks is greater than 0 then display the first task
            {
                currentTaskTextBox.Text = "" + tasks.Peek().ToString();                
            }
            else { currentTaskTextBox.Text = ""; }
        }

        private void currentTaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void countLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskRemovedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
