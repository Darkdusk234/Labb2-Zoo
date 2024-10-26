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
    }
}
