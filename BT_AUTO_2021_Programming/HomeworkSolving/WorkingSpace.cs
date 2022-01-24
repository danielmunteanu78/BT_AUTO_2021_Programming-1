using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class WorkingSpace : Room
    {

        private int chairCount;
        private int deskCount;
        private int monitorCount;
        public int ChairCount { get => chairCount; set => chairCount = value; }
        public int DeskCount { get => deskCount; set => deskCount = value; }
        public int MonitorCount { get => monitorCount; set => monitorCount = value; }

        public WorkingSpace(double area, int capacity, string roomName, int chairCount, int deskCount, int monitorCount) : base(area, capacity, roomName)
        {
            ChairCount = chairCount;
            DeskCount = deskCount;
            MonitorCount = monitorCount;
        }

        public override void PrintRoom()
        {
            base.PrintRoom();
            Console.WriteLine("    Chair count {0}, desk count {1}, monitor count {2}", ChairCount, DeskCount, MonitorCount);
        }
    }
}
