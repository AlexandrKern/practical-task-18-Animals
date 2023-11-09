using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace practical_task_18_Animals
{
    internal class Model
    {
        AnimalsDBContainer db;
        DataRecording dr;
        public Model()
        {
            db = new AnimalsDBContainer();
        }
        /// <summary>
        /// Добавляет животного
        /// </summary>
        public void AddAnimal(IAnimal animal)
        {
            if (CheckingAnEmptyString(animal)) 
            {
                MessageBox.Show("Заполните все поля");
                return;
            } 
                switch (animal.Id)
                {
                    case 3:
                        Birds birds = new Birds
                        {
                            Detachment = animal.Detachment,
                            ViweAnimal = animal.ViweAnimal,
                            Family = animal.Family
                        };
                        db.BirdsSet.Add(birds);
                        db.SaveChanges();
                        break;
                    case 2:
                        Amphibians amphibians = new Amphibians
                        {
                            Detachment = animal.Detachment,
                            ViweAnimal = animal.ViweAnimal,
                            Family = animal.Family
                        };
                        db.AmphibiansSet.Add(amphibians);
                        db.SaveChanges();
                        break;
                    case 1:
                        Mammals mammals = new Mammals
                        {
                            Detachment = animal.Detachment,
                            ViweAnimal = animal.ViweAnimal,
                            Family = animal.Family
                        };
                        db.MammalsSet.Add(mammals);
                        db.SaveChanges();
                        break;
                        default : MessageBox.Show("Выбирете класс");
                        break;
                }
        }
        /// <summary>
        /// Проверка строк на пустоту
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        private bool CheckingAnEmptyString(IAnimal animal)
        {
            if ((String.IsNullOrEmpty(animal.Detachment)|| String.IsNullOrEmpty(animal.Family))|| String.IsNullOrEmpty(animal.ViweAnimal))
                 return true;
            return false;
        }
        /// <summary>
        /// Загружает таблицу птиц
        /// </summary>
        /// <returns></returns>
        public List<Birds> LoadTableBirds()
        {
            db.BirdsSet.Load();
            return db.BirdsSet.Local.ToList();
        }
        /// <summary>
        /// Загружает таблицу земноводных
        /// </summary>
        /// <returns></returns>
        public List<Amphibians> LoadTableAmphibians()
        {
            db.AmphibiansSet.Load();
            return db.AmphibiansSet.Local.ToList();
        }
        /// <summary>
        /// Загружает таблицу млекопитающих
        /// </summary>
        /// <returns></returns>
        public List<Mammals> LoadTableMammals()
        {
            db.MammalsSet.Load();
            return db.MammalsSet.Local.ToList(); 
        }
        /// <summary>
        /// Выполняет удаление из базы данных
        /// </summary>
        /// <param name="animal"></param>
        public void Delete (IAnimal animal) 
        {
            if(animal.Amphibians!=null) db.AmphibiansSet.Remove(animal.Amphibians);
            if (animal.Mammals != null) db.MammalsSet.Remove(animal.Mammals);
            if (animal.Birds != null) db.BirdsSet.Remove(animal.Birds);
            db.SaveChanges();
        }
        /// <summary>
        /// Изменяет нанные в таблице
        /// </summary>
        /// <param name="animal"></param>
        public void Update(IAnimal animal)
        {
            if (animal.Amphibians != null) db.AmphibiansSet.AddOrUpdate(animal.Amphibians);
            if (animal.Mammals != null) db.MammalsSet.AddOrUpdate(animal.Mammals);
            if (animal.Birds != null) db.BirdsSet.AddOrUpdate(animal.Birds);
            db.SaveChanges();
        }
        /// <summary>
        /// Созраняет указанный Класс в файл txt
        /// </summary>
        public void SaveTxtFile(IAnimal animal)
        {
            switch (animal.Id)
            {
                case 1:
                    dr = new DataRecording(new SaveTxtFile());
                    dr.AnimalSave(null, null, LoadTableMammals(),"Mammals");
                    break;
                case 2:
                    dr = new DataRecording(new SaveTxtFile());
                    dr.AnimalSave(null, LoadTableAmphibians(), null, "Amphibians"); ;
                    break;
                case 3:
                    dr = new DataRecording(new SaveTxtFile());
                    dr.AnimalSave(LoadTableBirds(), null, null, "Birds"); ;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Созраняет указанный Класс в файл csv
        /// </summary>
        public void SaveCsvFile(IAnimal animal)
        {
            switch (animal.Id)
            {
                case 1:
                    dr = new DataRecording(new SaveCsvFile());
                    dr.AnimalSave(null, null, LoadTableMammals(), "Mammals");
                    break;
                case 2:
                    dr = new DataRecording(new SaveCsvFile());
                    dr.AnimalSave(null, LoadTableAmphibians(), null, "Amphibians"); ;
                    break;
                case 3:
                    dr = new DataRecording(new SaveCsvFile());
                    dr.AnimalSave(LoadTableBirds(), null, null, "Birds"); ;
                    break;
                default:
                    break;
            }
        }
    }
}
