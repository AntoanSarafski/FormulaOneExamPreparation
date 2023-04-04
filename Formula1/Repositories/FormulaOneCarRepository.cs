using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Repositories
{
    public class FormulaOneCarRepository : IRepository<IFormulaOneCar>
    {
        private List<IFormulaOneCar> models;
        public IReadOnlyCollection<IFormulaOneCar> Models => models.AsReadOnly();

        public void Add(IFormulaOneCar model)
        {
            models.Add(model);
        }

        public bool Remove(IFormulaOneCar model)
        {
            if (models.Remove(model)) return true;
            else return false;
        }

        public IFormulaOneCar FindByName(string name)
        {
            throw new NotImplementedException();
        }

        
    }
}
