
using System;
using System.Linq;

namespace Library
{
    public class Member
    {
        // Private backing fields
        private int memberId;
        private string name;
        private string address;
        private string phone;

        // Member ID property with validation
        public int MemberId
        {
            get { return memberId; }
            private set
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine(
                        "Error: Member ID must be greater than zero.");
                }
            }
        }

        // Name property with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) &&
                    !value.Any(char.IsDigit))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine(
                        "Error: Member name cannot be blank or contain numbers.");
                }
            }
        }

        // Address property
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Phone property
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor
        public Member(int memberId, string name,
                      string address, string phone)
        {
            this.MemberId = memberId;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Display member information
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }
    }
}
