using System;
namespace APPMAUI44.Core.Model
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTrainer { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

