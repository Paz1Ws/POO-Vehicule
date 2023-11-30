namespace POO
{
    public class Moto : Vehiculo, IStart

    {

        public void registerMoto()
        {
            Random gearCar = new Random();
            gear = gearCar.Next(0, 100);
            Console.Write("Name of the Moto: ");
            name = Console.ReadLine();
            Console.Write("Antique of the Moto: ");
            antique = int.Parse(Console.ReadLine());
            Console.Write("Model of the Moto: ");
            model = Console.ReadLine();
            Console.Write("State of the Moto (1/ In march - 0/ Stop): ");
            int state = int.Parse(Console.ReadLine());
            if (state == 1) { go = true; Console.WriteLine("Moto register!"); }
            else if (state == 0) { go = false; Console.WriteLine("Moto register!"); }
            else { Console.WriteLine("Error%$&$%."); Console.WriteLine("Moto not register!"); }

        }
        public void informationMoto()
        {
            Console.WriteLine(information(name, antique, model));
            Console.WriteLine(state(go));
            start(go, name);
        }
        

    }
}
