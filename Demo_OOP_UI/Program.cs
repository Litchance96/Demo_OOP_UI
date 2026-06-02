using DEMO_POO_Props_Indexeurs.Models;

Console.WriteLine("Hello, World! ca part en allemand");


Charakter c = new Charakter();

c.Name = "della"; // set (c.set_Name("Della")) --> il va le mettre en majuscules grâce au set

Console.WriteLine("set Name : " + c.Name); // get (c.get_Name()


// --> test[] => indexeur
// Liste.get(42); ==> Liste[42] (indexeur)
// Liste.set(42, valeur); ==> Liste[42] = valeur (indexeur)
// Liste[42] = valeur; // set (indexeur)
// Liste[42]; // get (indexeur)