using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskaya_7
{
    public class CreateAnim
    {
        public static ObservableCollection<Animals> anim = new ObservableCollection<Animals>();
        public static void Create()
        {
            Creator creator = new CreateMammals();
            Animals anim1 = creator.Create("Тигр", 10, "М");
            anim.Add(anim1);

            creator = new CreateBirds();
            Animals anim2 = creator.Create("Голубь", 3, "Ж");
            anim.Add(anim2);

            creator = new CreateAmphibians();
            Animals anim3 = creator.Create("Лягушка", 1, "М");
            anim.Add(anim3);
            
            creator = new CreateMammals();
            Animals anim4 = creator.Create("Панда", 6, "Ж");
            anim.Add(anim4);

            creator = new CreateBirds();
            Animals anim5 = creator.Create("Колибри", 8, "М");
            anim.Add(anim5);

            creator = new CreateAmphibians();
            Animals anim6 = creator.Create("Жаба", 2, "Ж");
            anim.Add(anim6);
        }

        public static void Add(string kindOfAnimals, string name, int age, string gender)
        {
            Creator creator = new CreateUnknown();
            Animals newAnim = creator.Create(name, age, gender);
            newAnim.KindOfAnimals = kindOfAnimals;
            anim.Add(newAnim);
        }
    }
}
