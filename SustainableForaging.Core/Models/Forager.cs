namespace SustainableForaging.Core.Models
{
    public class Forager
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }

        public Forager() { }

        public Forager(int id, string firstname, string lastName, string state)
        {
            Id = Id;
            FirstName = firstname;
            LastName = lastName;
            State = state;
        }

        public override bool Equals(object obj)
        {
            return obj is Forager forager &&
                Id == forager.Id &&
                FirstName == forager.FirstName &&
                LastName == forager.LastName &&
                State == forager.State;
        }


    }
}
