using System.Threading.Channels;

namespace POO
{
    public class Coche : Vehiculo, IStart
    {
        
        public void registerCar()
        {
            
            Random gearCar = new Random();
            gear = gearCar.Next(0, 100);
            Console.Write("Name of the Car: ");
            name = Console.ReadLine();
            Console.Write("Antique of the Car: ");
            antique = int.Parse(Console.ReadLine());
            Console.Write("Model of the Car: ");
            model = Console.ReadLine();
            Console.Write("State of the Car (1/ In march - 0/ Stop: ");
            int state = int.Parse(Console.ReadLine());
            if (state == 1) { go = true; Console.WriteLine("Car register!"); }
            else if (state == 0) { go = false; Console.WriteLine("Car register!"); }
            else { Console.WriteLine("Error%$&$%."); Console.WriteLine("Car not register!"); }

        }
        public void informationCar()
        {
            Console.WriteLine(information(name, antique, model));
            Console.WriteLine(state(go));
            start(go, name);

        }
    }
}
