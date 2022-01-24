
using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class MeetingRoom : Room
    {

        private bool hasProjector;
        private int chairCount;
        private int tableCount;
        public bool HasProjector { get => hasProjector; set => hasProjector = value; }
        public int ChairCount { get => chairCount; set => chairCount = value; }
        public int TableCount { get => tableCount; set => tableCount = value; }

        public MeetingRoom(double area, int capacity, string roomName, bool hasProjector, int chairCount, int tableCount) : base(area, capacity, roomName)
        {
            HasProjector = hasProjector;
            ChairCount = chairCount;
            TableCount = tableCount;
        }

        public override void PrintRoom()
        {
            base.PrintRoom();
            Console.WriteLine("    Has Projector {0}, Chair count {1}, Table count {2}", hasProjector, chairCount, tableCount);
        }

    }
}
