public class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string Zip { get; set; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public void Print()
    {
        Console.WriteLine("Name: "+ Name +", Surname: "+ Surname +", Street: "+ Street +", City: "+ City + ", Province: "+ Province +", Zip: "+ Zip);
    }


}
