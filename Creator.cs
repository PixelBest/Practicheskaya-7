using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskaya_7
{
    abstract class Creator     //Абстрактный класс создания
    {
        public abstract Animals Create(string name, int age, string gender);
    }

    class CreateMammals : Creator   //Создаёт млекопитающее
    {
        public override Animals Create(string name, int age, string gender)
        {
            return new Mammals(name, age, gender);
        }
    }
    
    class CreateBirds : Creator    //Создаёт птиц
    {
        public override Animals Create(string name, int age, string gender)
        {
            return new Birds(name, age, gender);
        }
    }
    
    class CreateAmphibians : Creator    //Создаёт земноводных
    {
        public override Animals Create(string name, int age, string gender)
        {
            return new Amphibians(name, age, gender);
        }
    }
    
    class CreateUnknown : Creator    //Создаёт неизвестных животных
    {
        public override Animals Create(string name, int age, string gender)
        {
            return new UnknownAnimals(name, age, gender);
        }
    }
}
