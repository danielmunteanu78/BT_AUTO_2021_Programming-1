using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public abstract class AbstractBuilding : IBuilding
    {
        protected const int MAX_CAPACITY = 300;
        public abstract double ComputingArea();
        public abstract int GetNumberOfFloors();
        public abstract int GetTotalNumberOfRooms();
        public abstract double TotalCapacity();


    }
}
