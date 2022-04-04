using NUnit.Framework;
using SustainableForaging.Core.Models;
using System.Collections.Generic;

namespace SustainableForaging.DAL.Tests
{
    public class ForagerFileRepositoryTest
    {
        [Test]
        public void ShouldFindAll()
        {
            ForagerFileRepository repo = new ForagerFileRepository(@"data\foragers.csv");
            List<Forager> all = repo.FindAll();
            Assert.AreEqual(1000, all.Count);
        }

        [Test]
        public void ShouldAddForager()
        {
            /*ForagerFileRepository repo = new ForagerFileRepository(@"data\foragers.csv");
            Forager forager = new Forager();
            forager.FirstName = "John";
            forager.LastName = "Doe";
            forager.State = "NM";
            repo.Add(forager);
            List<Forager> all = repo.FindAll();
            int expected = 1001;
            int actual = all.Count;
            Assert.AreEqual(expected, actual);*/
           
        }
    }
}
