using app.components;
using static app.components.Quantity;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            // int option;
            // bool isFinish = false;

            // Contact contact = new Contact { Nume = "asd", Prenume = "asd", Adresa = "asd", NumarTelefon = "asd" };
            // Produs produs1 = new Produs { Cod = "asd", Cantitate = new Units(123) };
            Produs produs2 = new Produs { Cod = "asd", Cantitate = new Undefined("asd") };

            // Console.WriteLine(contact.ToString());
            // Console.WriteLine(produs1.Cantitate.GetType());
            // Console.WriteLine(produs2.Cantitate.GetType());

            Comanda comanda = new Comanda { Contact = new Contact { Nume = "asd", Prenume = "asd", Adresa = "asd", NumarTelefon = "asd" }, Produs = { } };

            Console.WriteLine(comanda);

            comanda.AdaugaComanda(new Produs { Cod = "asd", Cantitate = new Undefined("asd") });


            // Console.WriteLine("1. Creaza comanda\n");
            // Console.WriteLine("2. Adauga produs in comanda\n");
            // Console.WriteLine("3. Specifica greutatea produselor\n");
            // Console.WriteLine("Alege optiunea: \n");

            // do
            // {
            //     string consoleInput = Console.ReadLine()!;
            //     //check if csole input is !null
            //     if (!string.IsNullOrEmpty(consoleInput))
            //     {
            //         if (int.TryParse(consoleInput, out option))
            //         {
            //             switch (option)
            //             {
            //                 case 1:
            //                     comanda.AdaugaComanda(new Produs { Cod = "asd", Cantitate = new Undefined("asd") });
            //                     break;
            //             }
            //         }
            //         else
            //         {
            //             Console.WriteLine("Invalid int format");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Input is null or empty");
            //     }
            // } while (!isFinish);
        }
    }
}