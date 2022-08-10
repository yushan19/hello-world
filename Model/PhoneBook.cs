
class PhoneBook 
{
    private string name;
    private string phone;
    private struct address 
    {
        public string city;
        public string street;
        public uint no;
    }
    public string Phone 
    {
        get { return phone; }
        set { phone = value; }
    }

    public PhoneBook(string n)
    {
        name = n;
    }
    public Edit() 
    {
        System.Console.WriteLine("start edit");
    }
}