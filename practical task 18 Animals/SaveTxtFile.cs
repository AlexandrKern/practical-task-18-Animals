using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;

namespace practical_task_18_Animals
{
    internal class SaveTxtFile:IAnimalSave
    {
        private string GetData(List<Birds> birds,List<Amphibians>amphibians,List<Mammals> mammals)
        {
            string data = null;
            if (birds!=null)
            {
                for (int i = 0; i < birds.Count; i++)
                {
                    data += $"{birds[i].Detachment} ";
                    data += $"{birds[i].Family} ";
                    data += $"{birds[i].ViweAnimal}\n";
                }
            }
            if (amphibians!= null)
            {
                for (int i = 0; i < amphibians.Count; i++)
                {
                    data += $"{amphibians[i].Detachment} ";
                    data += $"{amphibians[i].Family} ";
                    data += $"{amphibians[i].ViweAnimal}\n";
                }
            }
            if (mammals != null)
            {
                for (int i = 0; i < mammals.Count; i++)
                {
                    data += $"{mammals[i].Detachment} ";
                    data += $"{mammals[i].Family} ";
                    data += $"{mammals[i].ViweAnimal}\n";
                }
            }
            return data;
        }
        public  void SaveFile(List<Birds> birds, List<Amphibians> amphibians,List<Mammals> mammals,string name)
        {
            using(StreamWriter sw = new StreamWriter($"{name}.txt",true,Encoding.Unicode))
            {
                
                foreach (var item in GetData(birds,amphibians,mammals).Split('\n'))
                {
                    sw.WriteLine(item);
                }
              
            }
        }
    }
}
