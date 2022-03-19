namespace Domain;

public class DbSeedData
{
    public const int Count = 10;

    public static readonly string[] NamesFemale = new[]
    {
              "Ava",
              "Anna",
              "Amelia",
              "Ella",
              "Sapphire",
              "Emily",
              "Aquamarine",
              "Montana",
              "Grace",
              "Erinite",
              "Emerald",
              "Jonquil",
              "Olivine",
              "Lucy",
              "Citrine",
              "Sophie",
              "Opal",
              "Rose",
              "Olivia",
              "Siam",
              "Ruby",
              "Violet"
        };

    public static readonly string[] NamesMale = new[]
    {
              "Daniel",
              "Charlie",
              "Harry",
              "Jack",
              "Jake",
              "James",
              "Noah",
              "Matthew",
              "Oliver",
              "Erinite",
              "Winston",
              "Jonquil",
              "Justin",
              "Thomas",
              "Citrine",
              "Tony",
              "Jayden",
              "Jaden",
              "Daniel",
              "Tom",
              "Joshua",
              "Paul"
        };
    public static readonly string[] NamesLastName = new[]
    {
              "Doe",
              "Smith",
              "Thomas",
              "Jones",
              "Williams",
              "Kelly",
              "Bush",
              "Angus",
              "Duncan",
              "Durrant",
              "Whyte",
              "Lee",
              "Giptson",
              "Bethel",
              "Thomas",
              "Byfield",
              "Johnson",
              "McKenzie",
              "Blaire",
              "Patton",
              "Wylde",
              "Willis",
              "Green",
              "Black",
              "Brown",
              "Crimson",
              "Gray",
              "Cyan",
              "White",
              "Gold",
              "Pink"
        };

    public static readonly string[] Gems = new[]
    {
              "Diamond",
              "Crystal",
              "Morion",
              "Azore",
              "Sapphire",
              "Cobalt",
              "Aquamarine",
              "Montana",
              "Turquoise",
              "Lime",
              "Erinite",
              "Emerald",
              "Turmaline",
              "Jonquil",
              "Olivine",
              "Topaz",
              "Citrine",
              "Sun",
              "Quartz",
              "Opal",
              "Alabaster",
              "Rose",
              "Burgundy",
              "Siam",
              "Ruby",
              "Amethyst",
              "Violet",
              "Lilac"
        };
    public static readonly string[] Colors = new[]
    {
              "Blue",
              "Aqua",
              "Red",
              "Green",
              "Orange",
              "Yellow",
              "Black",
              "Violet",
              "Brown",
              "Crimson",
              "Gray",
              "Cyan",
              "Magenta",
              "White",
              "Gold",
              "Pink",
              "Lavender"
        };
    public static readonly string[] Things = new[]
    {
              "beard",
              "finger",
              "hand",
              "toe",
              "stalk",
              "hair",
              "vine",
              "street",
              "son",
              "brook",
              "river",
              "lake",
              "stone",
              "ship"
        };

    public static readonly string[] Discipline = new[]
    {
              "Science",
              "Engineering",
              "Arts"
        };
    public static readonly string[] Level = new[]
    {
              "100",
              "200",
              "300"
        };

    public static readonly string[] ItemCategories = new[]
    {
              "Art",
              "Film",
              "Music",
              "Food",
              "Tech",
              "Nature",
              "Geography",
              "History"
        };

    public static readonly string[] Gender = new[]
    {
              "Male",
              "Female"
        };

    public static readonly string[] AcademicInstitutes = new[]
    {
              "MIT",
              "Yale",
              "Harvard",
              "Oxford",
              "Middlesex",
              "OpenU",
              "Stanford",
              "Duke",
              "Cambridge",
              "Brunel",
              "Imperial College London",
              "UCL",
              "Berkeley",
              "Princeton",
              "Brown",
              "John Hopkins",
              "NYU",
              "Morehouse College",
              "Rutgers",
              "Cornell",
              "USC",
              "Purdue"
        };

    public static readonly string[] EnrollmentDates = new[]
    {
              "2016-09-01",
              "2018-09-01",
              "2019-09-01",
              "2018-09-01",
              "2018-09-01",
              "2017-09-01",
              "2020-09-01",
              "2019-09-01",
              "2011-09-01",
              "2020-09-01"
        };

    public static readonly Random Randomize = new Random();

    public static string GetRandomElement(string[] list)
    {
        var i = Randomize.Next(list.Length - 1);

        return list[i];
    }

    public static string GetElement(int index, string[] list) => list[index];

    public static string GetFirstName() => Randomize.Next(1, 3) % 2 == 0 ? GetRandomElement(NamesFemale) : GetRandomElement(NamesMale);

    public static int GetRandomNumber(string[] list) => Randomize.Next(list.Length - 1);

    public static int GetRandomNumber(List<string> list) => Randomize.Next(list.Count - 1);
}
