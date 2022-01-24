using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    public class Building : AbstractBuilding
    {
        private List<Floor> floors;
        private string buildingName;

        public List<Floor> Floors { get => floors; set => floors = value; }
        public string BuildingName { get => buildingName; set => buildingName = value; }

        public Building(List<Floor> floors, string buildingName)
        {
            Floors = floors;
            BuildingName = buildingName;
        }

        public override double ComputingArea()
        {
            double area = 0;
            foreach (Floor f in Floors)
            {
                area += f.TotalFloorArea();
            }
            return area;
        }

        public override int GetNumberOfFloors()
        {
            return Floors.Count;
        }

        public override int GetTotalNumberOfRooms()
        {
            int roomCount = 0;
            foreach (Floor f in Floors)
            {
                roomCount += f.Rooms.Count;
            }
            return roomCount;
        }

        public override double TotalCapacity()
        {
            int capacity = 0;
            foreach (Floor f in Floors)
            {
                capacity += f.TotalFloorCapacity();
            }
            if (capacity > MAX_CAPACITY)
            {
                throw new CapacityExceededException(String.Format("Exceeded capacity {0} with current capacity {1}", MAX_CAPACITY, capacity));
            }
            return capacity;
        }

        public static void PrintBuilding(Building b)
        {
            Console.WriteLine("--- BUILDING {0} ---", b.BuildingName);
            Console.WriteLine(" -> Floor count {0}, Total Room Count {1}, Total Capacity {2}, Total area {3}", b.Floors.Count, b.GetTotalNumberOfRooms(), b.TotalCapacity(), b.ComputingArea());
            Console.WriteLine();
            Console.WriteLine("Now printing all {0} floors:", b.Floors.Count);
            foreach (Floor f in b.Floors)
            {
                f.PrintFloor();
            }

        }
    }
}
