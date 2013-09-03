using System;
using System.Linq;

public class Creature
{
    enum Sex { Male, Female }

    public class Human
    {
        public Sex HumanSex { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }

    public void ProduceHuman(int humanAge)
    {
        Human human = new Human();

        human.Age = humanAge;
        if (humanAge % 2 == 0)
        {
            human.FullName = "Ivan";
            human.HumanSex = Sex.Male;
        }
        else
        {
            human.FullName = "Nadia";
            human.HumanSex = Sex.Female;
        }
    }
}
