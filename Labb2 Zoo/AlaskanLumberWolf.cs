namespace Labb2_Zoo
{
    internal class AlaskanLumberWolf : Wolf
    {
        public string BirthPlace { get; set; } = "Otilldelad";
        public AlaskanLumberWolf()
        {

        }

        public AlaskanLumberWolf(string name, int age, bool wild, string handler, bool isFemale, string furColor, string birthPlace) : base(name, age, wild, handler, isFemale, furColor)
        {
            BirthPlace = birthPlace;
        }

        public void Present()
        {
            Console.WriteLine($"{Name} är {Age} år gammal, och föddes i {BirthPlace}.");
        }
    }
}
