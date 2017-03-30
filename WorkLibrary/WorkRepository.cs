using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLibrary
{
    public class WorkRepository
    {
        public static List<WorkDay> _workList = new List<WorkDay>();
        public static int idCounter = 0;

        public WorkRepository()
        {
            if (_workList.Count == 0)
            {
                AddSampleDays();
            }
        }

        public void AddDay(WorkDay newDay)
        {
            newDay.WorkDayId = idCounter++;
            _workList.Add(newDay);
        }

        public List<WorkDay> GetWorkHistory()
        {
            return _workList;
        }

        public WorkDay GetWorkDay(int id)
        {
            return _workList.Find(day => day.WorkDayId == id);
        }


        public void EditWordDay(WorkDay dayEdit)
        {
            _workList[_workList.IndexOf(GetWorkDay(dayEdit.WorkDayId))] = dayEdit;
        }

        public void AddSampleDays()
        {
            WorkDay day1 = new WorkDay
            {
                Start = "9:30 PM",
                End = "10:45 PM",
                Day = "Friday",
                Active = false,
                WorkLoad = new List<Task>
                {
                    new Task {TaskId = 1, Title = "Clean Up", Comment = "Took out the trash" },
                    new StockTask {TaskId = 2, Title = "Stocked", Comment = "Made EO", Quantity = 2, Size = "1/2 oz" }
                }
            };
            AddDay(day1);

            WorkDay day2 = new WorkDay
            {
                Start = "9:30 PM",
                End = "10:45 PM",
                Day = "Saturday",
                Active = false,
                WorkLoad = new List<Task>
                {
                    new Task {TaskId = 3, Title = "Computer Work", Comment = "Made all the new labels" },
                    new StockTask {TaskId = 4, Title = "Stocked", Comment = "Made butters", Quantity = 10, Size = "1/2 lb" }
                }
            };
            AddDay(day2);
        }


    }
}
