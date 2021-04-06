using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenchmarkLINQ
{
    public class Samples
    {
        private readonly Faker<User> _faker = new();
        private readonly List<User> _users;

        public Samples()
        {
            _users = _faker
                .RuleFor(user => user.Emri, faker => faker.Name.FullName())
                .RuleFor(user => user.Aktiv, faker => faker.Random.Bool())
                .Generate(500);
        }

        public int AlcoholicDrinksCountLinqWhere()
        {
            return _users.Where(x => x.Aktiv).Count();
        }


        public int AlcoholidDrinksCountLinqCount()
        {
            return _users.Count(x => x.Aktiv);
        }
    }
}
