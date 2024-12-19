namespace Assignment_7._4
{
    public class ParkingSystem
    {
        private int big;
        private int medium;
        private int small;

        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1)  
            {
                if (big > 0)
                {
                    big--;
                    return true;
                }
            }
            else if (carType == 2)  
            {
                if (medium > 0)
                {
                    medium--;
                    return true;
                }
            }
            else if (carType == 3)  
            {
                if (small > 0)
                {
                    small--;
                    return true;
                }
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

            Console.WriteLine(parkingSystem.AddCar(1));  
            Console.WriteLine(parkingSystem.AddCar(2));  
            Console.WriteLine(parkingSystem.AddCar(3));  
            Console.WriteLine(parkingSystem.AddCar(1));  
        }
    }
}
