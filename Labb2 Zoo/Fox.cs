using System.Xml.Linq;

namespace Labb2_Zoo
{
    internal class Fox : Animal
    {
        public bool LikesToPlay { get; set; } = false;

        public Fox()
        {
            
        }

        public Fox(string name, int age, bool wild, string handler, bool isFemale, bool likesToPlay)
        {
            Name = name;
            Age = age;
            Wild = wild;
            Handler = handler;
            IsFemale = isFemale;
            LikesToPlay = likesToPlay;
        }

        public void MakeSound()
        {
            Console.WriteLine("Yip");
        }

        public void PlayTime()
        {
            Console.WriteLine($"{Name} vill leka.");
        }
    }
}
