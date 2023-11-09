using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_18_Animals
{
    internal class Presenter
    {
        Model model;
        IAnimal animal;
        public Presenter(IAnimal animal)
        {
            this.animal = animal;
            model = new Model();
        }
        public void AddAnimal()
        {
            model.AddAnimal(animal);
            Load();
        }
        public void Load()
        {
            List<Birds> birds = model.LoadTableBirds();
            List<Amphibians> amphibians = model.LoadTableAmphibians();
            List<Mammals> mammals = model.LoadTableMammals();
            animal.LoadData(birds,amphibians,mammals);
        }
        public void Delete() 
        {
            model.Delete(animal);
            Load();
        }
        public void Update()
        {
            model.Update(animal);
        }
        public void SaveFile(int formatIndex)
        {
            if (formatIndex==1) model.SaveTxtFile(animal);
            if (formatIndex == 2) model.SaveCsvFile(animal);
        }
    }
}
