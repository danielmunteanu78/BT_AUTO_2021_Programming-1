using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class Floor
    {
        private List<Room> rooms;
        private int elevatorCount;
        private int floorNumber;

        public List<Room> Rooms { get => rooms; set => rooms = value; }
        public int ElevatorCount { get => elevatorCount; set => elevatorCount = value; }
        public int FloorNumber { get => floorNumber; set => floorNumber = value; }

        public Floor(List<Room> rooms, int elevatorCount, int floorNumber)
        {
            Rooms = rooms;
            ElevatorCount = elevatorCount;
            FloorNumber = floorNumber;
        }

        public int TotalFloorCapacity()
        {
            int capacity = 0;
            foreach (Room r in Rooms)
            {
                capacity += r.Capacity;
            }
            return capacity;
        }

        public double TotalFloorArea()
        {
            double area = 0;
            foreach (Room r in Rooms)
            {
                area += r.Area;
            }
            return area;
        }

        internal void PrintFloor()
        {
            Console.WriteLine(" --- FLOOR {0} --- ", FloorNumber);
            foreach (Room r in Rooms)
            {
                r.PrintRoom();
            }
            Console.WriteLine();
        }
    }
}
