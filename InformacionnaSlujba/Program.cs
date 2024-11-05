namespace InformacionnaSlujba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Obekt s ime i godini");
                Slujba slujba = new Slujba("Gosho", 23);
                slujba.PrintNameAndAge();
                Console.WriteLine(new string('-', 20));
                Console.Write("Kolko choveka shte vuvejdash: ");
                int count = int.Parse(Console.ReadLine());
                string[] data;
                Console.WriteLine("Vuvedi grad, ime, godini, pol, adres na 1 red");
                List<Slujba> list = new List<Slujba>();
                for (int i = 0; i < count; i++)
                {
                    data = Console.ReadLine().Split();
                    Slujba slujba1 = new Slujba(data[0], data[1], int.Parse(data[2]), data[3], data[4]);
                    list.Add(slujba1);
                }
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Vsichki vuvedeni hora");
                list.ForEach(x => x.Print());
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Vuvedi ime na koeto iskash da vidish dannite");
                string name = Console.ReadLine();
                list.Where(x => x.Name == name).ToList().ForEach(x => x.Print());
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Nai-Mladiqt");
                list.OrderBy(x => x.Age).Take(1).ToList().ForEach(x => x.Print());
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("Vsichki hora podredeni po ime");
                list.OrderBy(x => x.Name).ToList().ForEach(x => x.Print());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
