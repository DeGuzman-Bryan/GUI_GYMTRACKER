using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_GYMTRACKER.Models;

namespace GUI_GYMTRACKER.Repositories
{
    public interface iTraineeRep
    {
        List<Trainee> GetTrainee();
        Trainee? GetTrainee(int id);
        void CreateTrainee(Trainee trainee);
        void UpdateTrainee(Trainee trainee);
        void DeleteTrainee(int id);
    }
}
