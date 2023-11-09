using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_18_Animals
{
    internal class DataRecording
    {
        public IAnimalSave Save { get; set; }
        public DataRecording(IAnimalSave Save)
        {
            this.Save = Save;
        }
        public void AnimalSave(List<Birds> birds, List<Amphibians> amphibians, List<Mammals> mammals, string name)
        {
            Save.SaveFile(birds, amphibians, mammals,name);
        }
    }
}
