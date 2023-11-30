using POO;

Console.WriteLine("You'll register a car, motorbike or bicycle? (1 - 3)");
int opc = int.Parse(Console.ReadLine());
if (opc == 1)
{
    Coche C = new Coche();
    C.registerCar();
    C.informationCar();
}
if (opc == 2)
{
    Moto M = new();
    M.registerMoto();
    M.informationMoto();
}
if (opc == 3)
{
    Bicycle B = new();
    B.registerBicycle();
    B.informationBicycle();
}