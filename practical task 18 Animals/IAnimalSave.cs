using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_18_Animals
{
    internal interface IAnimalSave
    {
        void SaveFile(List<Birds> birds, List<Amphibians> amphibians, List<Mammals> mammals, string name);
    }
}
