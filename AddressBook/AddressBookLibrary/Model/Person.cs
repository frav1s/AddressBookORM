namespace AddressBookLibrary.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        public string Organization { get; set; }
        public string Position { get; set; }
        public string FullNameFirst => $"{FirstName} {LastName}";
        public string FullNameLast => $"{LastName} {FirstName}";
    }
}