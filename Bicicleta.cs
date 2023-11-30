namespace POO
{
    public class Bicycle : Vehiculo, IStart
    {
        public void registerBicycle()
        {
            Random gearCar = new Random();
            gear = gearCar.Next(0, 100);
            Console.Write("Name of the Bici: ");
            name = Console.ReadLine();
            Console.Write("Antique of the Bici: ");
            antique = int.Parse(Console.ReadLine());
            Console.Write("Model of the Bici: ");
            model = Console.ReadLine();
            Console.Write("State of the Bici (1/ In march - 0/ Stop): ");
            int state = int.Parse(Console.ReadLine());
            if (state == 1) { go = true; Console.WriteLine("Bici register!"); }
            else if (state == 0) { go = false; Console.WriteLine("Bici register!"); }
            else { Console.WriteLine("Error%$&$%."); Console.WriteLine("Bici not register!"); }

        }
        public void informationBicycle()
        {
            Console.WriteLine(information(name, antique, model));
            Console.WriteLine(state(go));
            start(go, name);
        }
       
    }
}
