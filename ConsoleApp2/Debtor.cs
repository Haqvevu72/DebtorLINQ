namespace debtor
{
    public class Debtor
    {
        public string? Name { get; set; }
        public DateTime? bDate { get; set; }
        public string? PhNumber { get; set; }
        public string? Mail { get; set; }
        public string? Address { get; set; }
        public int Debt { get; set; }

        public Debtor(string? name, DateTime? bDate, string? phNumber, string? mail, string? address, int debt)
        {
            Name = name;
            this.bDate = bDate;
            PhNumber = phNumber;
            Mail = mail;
            Address = address;
            Debt = debt;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nBirth Date: {bDate.ToString()}\nPhone: {PhNumber}\nMail: {Mail}\nAddress: {Address}\nDebt: {Debt}";
        }
    }
}
