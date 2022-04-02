using SustainableForaging.Core.Models;
using SustainableForaging.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SustainableForaging.BLL
{
    public class ForagerService
    {
        private readonly IForagerRepository repository;

        public ForagerService(IForagerRepository repository)
        {
            this.repository = repository;
        }

        public List<Forager> FindByState(string stateAbbr)
        {
            return repository.FindByState(stateAbbr);
        }

        public List<Forager> FindByLastName(string prefix)
        {
            return repository.FindAll()
                    .Where(i => i.LastName.StartsWith(prefix))
                    .ToList();
        }
        public Result<Forager> Add(Forager forager)
        {
            var result = new Result<Forager>();
            if(forager == null)
            {
                result.AddMessage("Forager must not be null.");
                return result;
            }

            if (string.IsNullOrWhiteSpace(forager.FirstName))
            {
                result.AddMessage("First name is required.");
            }

            if (string.IsNullOrEmpty(forager.LastName))
            {
                result.AddMessage("Last name is required");
            }
            if (string.IsNullOrEmpty(forager.State))
            {
                result.AddMessage("State is required");
            }

            if (repository.FindAll()
                .Any(i => i.FirstName.Equals(forager.FirstName)
                && i.LastName.Equals(forager.LastName)
                && i.State.Equals(forager.State)))
            {
                result.AddMessage($"Forager {forager.FirstName} {forager.LastName}, {forager.State} is a duplicate.");
            }

            if (!result.Success)
            {
                return result;
            }
            
            result.Value = repository.Add(forager);
            return result;
        }
    }
}
