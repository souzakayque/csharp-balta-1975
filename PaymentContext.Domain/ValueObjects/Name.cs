using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<string>()
                .Requires()
                .IsGreaterOrEqualsThan(FirstName, 3, "Name.FirstName", "Name must be at least 3 carachters.")
                .IsGreaterOrEqualsThan(LastName, 3, "Name.LastName", "Lastname must be at least 3 carachters.")
                .IsLowerOrEqualsThan(FirstName, 40, "Name.FirstName", "Name must be in max 40 carachters.")
            );
        }

        protected Name() { }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{ FirstName} {LastName}";
        }
    }

}