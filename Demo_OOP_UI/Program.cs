// --------------------------- indexeurs -------------------------------------

using DEMO_POO_Constructeur.Models;
using DEMO_POO_Props_Indexeurs.Models;

Console.WriteLine("Avec Indexeurs :");
Console.WriteLine();
Console.WriteLine("Hello, World! ca part en allemand");


Charakter c = new Charakter();

c.Name = "della"; // set (c.set_Name("Della")) --> il va le mettre en majuscules grâce au set

Console.WriteLine("set Name : " + c.Name); // get (c.get_Name()


// --> test[] => indexeur
// Liste.get(42); ==> Liste[42] (indexeur)
// Liste.set(42, valeur); ==> Liste[42] = valeur (indexeur)
// Liste[42] = valeur; // set (indexeur)
// Liste[42]; // get (indexeur)
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
// ----------------------------- Constructeurs --------------------------------
Console.WriteLine("Avec Constructeur :");
Console.WriteLine();
Person p1 = new Person("Della", "Duck", new DateTime(1987, 7, 1));
Person p2 = new("Donald", "Duck", new DateTime(1987, 7, 1));
Person p3 = new Person("Picsou", new DateTime(1967, 12, 1));

//p1.FirstName = "Della";
//p1.LastName = "Duck";

Console.WriteLine($"Bonjour {p1.FirstName} {p1.LastName}");