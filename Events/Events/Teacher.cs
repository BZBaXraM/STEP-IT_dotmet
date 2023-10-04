using System;


namespace Events
{
    internal class Teacher
    {
        public event ExamDelegate examEvent;

        public EventHandler<ExamEventArgs> examEventHandler;

        SortedList<int, ExamDelegate> sortedEvents = new SortedList<int, ExamDelegate>();
        Random random = new Random();

        public event ExamDelegate myExamEvent
        {
            add
            {
                for (int i = 0; ;)
                {
                    i = random.Next();
                    if (!sortedEvents.ContainsKey(i))
                    {
                        sortedEvents.Add(i, value);
                        break;
                    }
                }
            }
            remove
            {
                sortedEvents.RemoveAt(sortedEvents.IndexOfValue(value));
            }
        }

        public void Exam(string task)
        {
            if (examEvent != null)
            {
                examEvent(task);
            }
        }

        public void Exam(ExamEventArgs task)
        {
            examEventHandler(this, task);
        }

        public void ExamRand(string task)
        {
            foreach (int item in sortedEvents.Keys)
            {
                if (sortedEvents[item] != null)
                {
                    sortedEvents[item].Invoke(task);
                }
            }
        }
    }
}
