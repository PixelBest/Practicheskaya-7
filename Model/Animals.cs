using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskaya_7
{
    public abstract class Animals //Абстрактный класс животные
    {
        public abstract string KindOfAnimals { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Animals(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }

    public class Mammals : Animals //Млекопитающие
    {
        public override string KindOfAnimals { get; set; }
        public Mammals(string name, int age, string gender) : base(name, age, gender) { KindOfAnimals = "Млекопитающее"; }
        public Mammals() : base("", 0, "") { }
    }

    public class Birds : Animals //Птицы
    {
        public override string KindOfAnimals { get; set; }
        public Birds(string name, int age, string gender) : base(name, age, gender) { KindOfAnimals = "Птица"; }
        public Birds() : base("", 0, "") { }
    }

    public class Amphibians : Animals  //Земноводные
    {
        public override string KindOfAnimals { get; set; }
        public Amphibians(string name, int age, string gender) : base(name, age, gender) { KindOfAnimals = "Земноводное"; }
        public Amphibians() : base("", 0, "") { }
    }

    public class UnknownAnimals : Animals  //Неизвестные животные
    {
        public override string KindOfAnimals { get; set; }
        public UnknownAnimals(string name, int age, string gender) : base(name, age, gender) { KindOfAnimals = "Неизвестное"; }
        public UnknownAnimals() : base("", 0, "") { }
    }
}
