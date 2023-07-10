//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//namespace smallStepLibrary
//{
//    public static class GenerateMockdata
//    {
//        public static void InsertIntoDatabase()
//        {
//            var connectionString = "Your_Connection_String"; // Replace with your actual connection string
//            var insertQuery = "INSERT INTO YourTableName (FirstName, LastName, DateOfBirth, Address, UniqueIdentityNumber, PhoneNumber, Email) " +
//                "VALUES (@FirstName, @LastName, @DateOfBirth, @Address, @UniqueIdentityNumber, @PhoneNumber, @Email)";

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                connection.Open();

//                for (var i = 0; i < 100; i++) // Change the number 10 to the desired number of mock data entries
//                {
//                    PersonModel person = GenerateMockPerson();

//                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
//                    {
//                        command.Parameters.AddWithValue("@FirstName", person.FirstName);
//                        command.Parameters.AddWithValue("@LastName", person.LastName);
//                        command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
//                        command.Parameters.AddWithValue("@Address", person.Address);
//                        command.Parameters.AddWithValue("@UniqueIdentityNumber", person.UniqueIdentityNumber);
//                        command.Parameters.AddWithValue("@PhoneNumber", person.PhoneNumber);
//                        command.Parameters.AddWithValue("@Email", person.Email);

//                        command.ExecuteNonQuery();
//                    }
//                }
//            }
//        }

//        private static PersonModel GenerateMockPerson()
//        {
//            Random random = new Random();
//            var firstNames = new string[]
//            {
//                "Emma",
//                "Ben",
//                "Hannah",
//                "Leon",
//                "Mia",
//                "Paul",
//                "Emilia",
//                "Finn",
//                "Lena",
//                "Max",
//                "Sophia",
//                "Noah",
//                "Mila",
//                "Elias",
//                "Anna",
//                "Julian",
//                "Ella",
//                "Lukas",
//                "Lina",
//                "Felix",
//                "Sarah",
//                "Luca",
//                "Laura",
//                "Henry",
//                "Lea",
//                "Tim",
//                "Amelia",
//                "Oskar",
//                "Lara",
//                "Anton",
//                "Maja",
//                "Moritz",
//                "Sophie",
//                "Jakob",
//                "Emilia",
//                "David",
//                "Johanna",
//                "Matteo",
//                "Clara",
//                "Jonas",
//                "Charlotte",
//                "Philipp",
//                "Greta",
//                "Tom",
//                "Paula",
//                "Niklas",
//                "Marie",
//                "Jan",
//                "Isabella",
//                "Leonard",
//                "Leni",
//                "Simon",
//                "Mara"
//            };

//            var lastNames = new string[]
//            {
//                "Müller",
//                "Schmidt",
//                "Schneider",
//                "Fischer",
//                "Weber",
//                "Meyer",
//                "Wagner",
//                "Becker",
//                "Schulz",
//                "Hoffmann",
//                "Schäfer",
//                "Koch",
//                "Bauer",
//                "Richter",
//                "Klein",
//                "Wolf",
//                "Schröder",
//                "Neumann",
//                "Schwarz",
//                "Zimmermann",
//                "Braun",
//                "Krüger",
//                "Hofmann",
//                "Hartmann",
//                "Lange",
//                "Schmitt",
//                "Werner",
//                "Schmitz",
//                "Krause",
//                "Meier",
//                "Lehmann",
//                "Schmid",
//                "Schulze",
//                "Maier",
//                "Köhler",
//                "Herrmann",
//                "König",
//                "Walter",
//                "Mayer",
//                "Huber",
//                "Kaiser",
//                "Fuchs",
//                "Peters",
//                "Lang",
//                "Vogel",
//                "Jung",
//                "Keller",
//                "Günther",
//                "Frank",
//                "Berger",
//                "Roth"
//            };

//            var firstName = firstNames[random.Next(firstNames.Length)];
//            var lastName = lastNames[random.Next(lastNames.Length)];
//            var dateOfBirth = GenerateRandomDateOfBirth();
//            var address = GenerateRandomAddress();
//            var uniqueIdentityNumber = GenerateRandomUniqueIdentityNumber();
//            var phoneNumber = GenerateRandomPhoneNumber();
//            var email = $"{firstName.ToLower()}.{lastName.ToLower()}@example.com";

//            return new PersonModel
//            {
//                FirstName = firstName,
//                LastName = lastName,
//                DateOfBirth = dateOfBirth,
//                Address = address,
//                UniqueIdentityNumber = uniqueIdentityNumber,
//                PhoneNumber = phoneNumber,
//                Email = email
//            };

//        }

//        private static string GenerateRandomDateOfBirth()
//        {
//            Random random = new Random();
//            DateTime start = new DateTime(1960, 1, 1);
//            var range = (DateTime.Today - start).Days;

//            DateTime randomDate = start.AddDays(random.Next(range));
//            return randomDate.ToString("dd.MM.yyyy");
//        }

//        private static string GenerateRandomAddress()
//        {
//            var streets = new string[]
//            {
//                "Goethestraße",
//                "Schillerstraße",
//                "Mozartstraße",
//                "Hauptstraße",
//                "Berliner Straße",
//                "Bahnhofstraße",
//                "Schlossallee",
//                "Rosenweg",
//                "Lindenstraße",
//                "Kirchplatz",
//                "Mühlenweg",
//                "Am Markt",
//                "Parkstraße",
//                "Sonnenallee",
//                "Gartenstraße",
//                "Friedrichstraße",
//                "Bergstraße",
//                "Adlerstraße",
//                "Buchenweg",
//                "Eichenweg",
//                "Kaiserstraße",
//                "Schulstraße",
//                "Rathausplatz",
//                "Poststraße",
//                "Neue Straße",
//                "Schützenstraße",
//                "Feldstraße",
//                "Weinbergstraße",
//                "Hermannstraße",
//                "Wilhelmstraße",
//                "Dorfstraße",
//                "Bahnhofsweg",
//                "Bismarckstraße",
//                "Kirchstraße",
//                "Hochstraße",
//                "Mühlenstraße",
//                "Schillerplatz",
//                "Am Sonnenhang",
//                "Birkenstraße",
//                "Heinrichstraße",
//                "Schulweg",
//                "Lerchenweg",
//                "Am Hang",
//                "Friedhofstraße",
//                "Ringstraße",
//                "Kirchberg",
//                "Bergweg",
//                "Am Wiesenrand",
//                "Waldstraße",
//                "Goetheplatz"
//            };

//            var cities = new string[]
//            {
//                "Berlin",
//                "Hamburg",
//                "München",
//                "Köln",
//                "Frankfurt",
//                "Stuttgart",
//                "Düsseldorf",
//                "Dortmund",
//                "Essen",
//                "Leipzig",
//                "Bremen",
//                "Dresden",
//                "Hannover",
//                "Nürnberg",
//                "Duisburg",
//                "Bochum",
//                "Wuppertal",
//                "Bielefeld",
//                "Bonn",
//                "Münster",
//                "Karlsruhe",
//                "Mannheim",
//                "Augsburg",
//                "Wiesbaden",
//                "Gelsenkirchen",
//                "Mönchengladbach",
//                "Braunschweig",
//                "Chemnitz",
//                "Kiel",
//                "Aachen",
//                "Halle",
//                "Magdeburg",
//                "Freiburg",
//                "Krefeld",
//                "Lübeck",
//                "Oberhausen",
//                "Erfurt",
//                "Mainz",
//                "Rostock",
//                "Kassel",
//                "Hagen",
//                "Hamm",
//                "Saarbrücken",
//                "Mülheim",
//                "Potsdam",
//                "Ludwigshafen",
//                "Oldenburg",
//                "Leverkusen",
//                "Osnabrück",
//                "Solingen",
//                "Heidelberg"
//            };


//            Random random = new Random();
//            var street = streets[random.Next(streets.Length)];
//            var streetNumber = random.Next(1, 100);
//            var city = cities[random.Next(cities.Length)];

//            return $"{street} {streetNumber}, {city}";
//        }

//        private static string GenerateRandomUniqueIdentityNumber()
//        {
//            Guid guid = Guid.NewGuid();
//            return guid.ToString("N");
//        }

//        private static string GenerateRandomPhoneNumber()
//        {
//            Random random = new Random();
//            var phoneNumber = "+49 ";
//            phoneNumber += random.Next(111, 999).ToString();
//            phoneNumber += " ";
//            phoneNumber += random.Next(100000, 999999).ToString();

//            return phoneNumber;
//        }
//    }
//}
