namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Corolla", 2020);
            Car car2 = new Car("Tesla", "Model 3", 2021);

            car1.Drive(100);
            car2.Drive(200);

            Console.WriteLine("------------------------------------------------");
            car1.Drive(50);
            car2.Drive(10);

            Console.WriteLine("------------------------------------------------");
            car1.Drive(150);
            car2.Drive(300);

            Console.WriteLine("------------------------------------------------");
            car1.ShowCarInfo();
            car2.ShowCarInfo();
        }
    }
}
