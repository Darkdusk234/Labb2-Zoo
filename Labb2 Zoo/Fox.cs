using System.Xml.Linq;

namespace Labb2_Zoo
{
    internal class Fox : Animal
    {
        public bool LikesToPlay { get; set; }

        public Fox()
        {
            Name = "Otilldelad";
            Alive = true;
            Age = 0;
            Wild = true;
            Sick = false;
            Handler = "Otilldelad";
            Hungry = false;
            IsFemale = false;
            LikesToPlay = false;
        }

        public Fox(string name, int age, bool wild, string handler, bool isFemale, bool likesToPlay)
        {
            Name = name;
            Alive = true;
            Age = age;
            Wild = wild;
            Sick = false;
            Handler = handler;
            Hungry = false;
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
