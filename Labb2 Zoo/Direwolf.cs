namespace Labb2_Zoo
{
    internal class Direwolf : Wolf
    {
        public int BirthYear { get; set; } = 1654;

        public Direwolf()
        {

        }

        public Direwolf(string name, int age, bool wild, string handler, bool isFemale, string furColor, int birthYear) : base(name, age, wild, handler, isFemale, furColor)
        {
            BirthYear = birthYear;
        }

        public override void PawPrint()
        {
            Console.WriteLine("  ^   ^\r\n^ XXXXX ^\r\nXXXXXXXXX\r\nXXXXXXXXX\r\nXXXXXXXXX\r\n  XXXXX");
        }
    }
}
