using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class DepositRoom : Room
    {

        private List<string> depositBox;
        public List<string> DepositBox { get => depositBox; set => depositBox = value; }

        public DepositRoom(double area, int capacity, string roomName, List<string> depositBox) : base(area, capacity, roomName)
        {
            DepositBox = depositBox;
        }

        public override void PrintRoom()
        {
            base.PrintRoom();
            Console.WriteLine("    There are the following {0} deposit boxes: ", DepositBox.Count);
            foreach (string box in DepositBox)
            {
                Console.WriteLine("    Box with {0}",box);
            }
        }
    }
}
