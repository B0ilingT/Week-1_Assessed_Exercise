using System;
using System.Collections.Generic;
using System.Text;

namespace Assessed_Exercise_task_A
{
    class QueueTasks
    {
        private readonly int maxsize = 20; // max size of queue is 21 meaning it can store up to 20 tasks 
        private Task[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;

        public QueueTasks()
        {
            store = new Task[maxsize];
        }

        public QueueTasks(int size)
        {
            maxsize = size;
            store = new Task[maxsize];
        }

        public void Enqueue(Task value)
        {
            if (IsFull() == false)
            {
                store[tail] = value;
                numItems++;
                if (++tail == maxsize)
                {
                    tail = 0;
                }
            }
            else
            {
                return;
            }

        }
        public Task Dequeue()
        {
            if (IsEmpty() == false)
            {
                Task headItem = store[head];
                numItems--;
                if (++head == maxsize)
                {
                    head = 0;
                }
                return headItem;
            }
            else
            {
                return null;
            }

        }

        public Task Peek() // check first task in the queue
        {
            Task emptyQueue = new Task("Queue Is Empty");
            if (IsEmpty() == false)
            {
                Task headItem;
                headItem = store[head];
                return headItem;
            }  
            else
            {
                return emptyQueue;
            }
        }

        public bool IsEmpty() // check if queue is empty
        {
            return /*head == tail ||*/ numItems == 0;
        }

        public bool IsFull() // check if task is full
        {
            return tail == maxsize;
        }
        public int Count() //count how many elements are in the queue
        {
           int count = numItems;
           return count;
        }
    } 
}
