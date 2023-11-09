using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_18_Animals
{
    internal interface IAnimal
    {
        Birds Birds { get;  }
        Mammals Mammals { get; }
        Amphibians Amphibians { get; }
        int Id { get; }
        string Detachment { get; }
        string Family { get;  }
        string ViweAnimal { get;  }
        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="birds"></param>
        /// <param name="amphibians"></param>
        /// <param name="mammals"></param>
        void LoadData(List<Birds> birds,List<Amphibians> amphibians,List<Mammals> mammals);
    }
}
