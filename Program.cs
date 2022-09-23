using System.IO;
using System.Linq.Expressions;

// open stream on file
StreamReader AddressesFile = File.OpenText("C:/Users/81N800KVIX/Desktop/addresses.csv");

// skip first line
AddressesFile.ReadLine();

// while there are more lines
while (!AddressesFile.EndOfStream)
{
    string name, surname, street, city, province, zip;

    // get current line
    string line = AddressesFile.ReadLine();

    // split string every ','
    string[] split = line.Split(',');

    try
    {
        name = split[0];
        surname = split[1];
        street = split[2];
        city = split[3];
        province = split[4];
        zip = split[5];

        // if street doesn't begin with a number
        if (!Char.IsDigit(street[0]))
        {
            throw new FormatException();
        }

        if(name == "" | surname == "" | street == "" | city == "" | province == "" | zip == "")
        {
            throw new FormatException();
        }

        // create instance of address object
        Address address = new Address(name, surname, street, city, province, zip);

        // print address info
        address.Print();
        
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Invalid Address: " + line);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Format: " + line);
    }
}
