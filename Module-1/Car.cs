namespace Assignment
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Mileage { get; private set; }
        public Car(string brand, string model, int year, int mileage=0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        /** 
         * <summary>
         * Simulates driving the car a certain distance, updating the mileage.
         * </summary>
         */
        public void Drive(int kilometers)
        {
            Mileage += kilometers;
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km");
        }

        /** 
         * <summary>
         * Displays the car's information, including brand, model, year, and mileage.
         * </summary>
         */
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
        }
    }
}
