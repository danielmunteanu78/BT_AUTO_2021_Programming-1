using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class Kitchen : Room
    {
        private List<string> appliances;
        private int chairCount;
        public List<string> Appliances { get => appliances; set => appliances = value; }
        public int ChairCount { get => chairCount; set => chairCount = value; }

        public Kitchen(double area, int capacity, string roomName, List<String> appliances, int chairCount) : base(area, capacity, roomName)
        {
            Appliances = appliances;
            ChairCount = chairCount;
        }

        public override void PrintRoom()
        {
            base.PrintRoom();
            Console.WriteLine("    Chair count {0} and the following {1} appliances:", ChairCount, Appliances.Count);
            foreach (string appliance in Appliances)
            {
                Console.WriteLine("    Appliance of type {0}", appliance);
            }
        }

    }
}
