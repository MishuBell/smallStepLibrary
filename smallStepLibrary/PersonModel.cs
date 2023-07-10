namespace smallStepLibrary
{

    public class PersonModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? UniqueIdentityNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        // Credit Model
        // GroupModel

        public PersonModel (string firstName, string lastName, string dateOfBirth, string address, string uniqueIdentityNumber, string phoneNumber, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Address = address;
            UniqueIdentityNumber = uniqueIdentityNumber;
            PhoneNumber = phoneNumber;
            Email = eMail;
        }
    }
}
