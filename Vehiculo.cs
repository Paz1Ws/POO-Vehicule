namespace POO
{
    public class Vehiculo 
    {
        public string name { get; set; }
        public int antique { get; set; }
        public string model { get; set; }
        public int gear { get; set; }
        public bool go { get; set; }
        public string information(string name, int antique, string model)
        {
            return $"I'm {name} of the year {2023 - antique}, my model is {model}\n";
        }
        public string state(bool go)
        {
            if (go)
                return $"I'm in running, and my gear is {gear}k/m";
            else
                return "I'm not in running";
        }
        public void start(bool go, string name)
        {
            if (!go)
                Console.WriteLine($"Starting + {name}...");
            else
                Console.WriteLine($"{name} already is in march...");
        }
    }
}
