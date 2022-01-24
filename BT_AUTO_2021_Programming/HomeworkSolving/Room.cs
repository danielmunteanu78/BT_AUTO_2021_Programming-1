using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class Room
    {
        private double area;
        private int capacity;
        private string roomName;
        public double Area { get => area; set => area = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string RoomName { get => roomName; set => roomName = value; }

        public Room(double area, int capacity, string roomName)
        {
            Area = area;
            Capacity = capacity;
            RoomName = roomName;
        }

        public virtual void PrintRoom()
        {
            Console.WriteLine("    ---{0}---", RoomName);
            Console.WriteLine("    Area: {0}, Capacity {1}", Area, Capacity);
        }
    }
}
