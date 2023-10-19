using Shop.domain.exceptions;

namespace Shop.domain.models
{
    public record Contact
    {
        public String? FirstName { get; init; }
        public String? LastName { get; init; }
        public String? TelephoneNumber { get; init; }
        public String? Address { get; init; }

        public Contact(String FirstName, String LastName, String TelephoneNumber, String Address)
        {
            if (!FirstName.Any(char.IsDigit))
            {
                this.FirstName = FirstName;
            }
            else
            {
                throw new InvalidContactException("FirstName cannot contain number");
            }

            if (!LastName.Any(char.IsDigit))
            {
                this.LastName = LastName;
            }
            else
            {
                throw new InvalidContactException("LastName cannot contain number");
            }

            if (TelephoneNumber.Length <= 10)
            {
                if (!TelephoneNumber.Any(char.IsLetter))
                {
                    this.TelephoneNumber = TelephoneNumber;
                }
                else
                {
                    throw new InvalidContactException("TelephoneNumber cannot contain letter");
                }
            }
            else
            {
                throw new InvalidContactException("TelephoneNumber cannot have more than 10 numbers");
            }

            this.Address = Address;
        }
        public override string ToString()
        {
            return $"[{this.FirstName} {this.LastName} {this.TelephoneNumber} {this.Address}] ";
        }
        public static bool TryParse(String FirstName, String LastName, String TelephoneNumber, String Address, out Contact? Contact)
        {
            bool IsValid = false;
            Contact = null;

            if (!FirstName.Any(char.IsDigit))
            {
                if (!LastName.Any(char.IsDigit))
                {
                    if (TelephoneNumber.Length <= 10)
                    {
                        if (!TelephoneNumber.Any(char.IsLetter))
                        {
                            IsValid = true;
                            Contact = new Contact(FirstName, LastName, TelephoneNumber, Address);
                        }
                        else
                        {
                            Console.WriteLine("tphone letter problem");
                        }
                    }
                    else
                    {
                        Console.WriteLine("tphone length problem");
                    }

                }
                else
                {
                    Console.WriteLine("lastname problem");
                }
            }
            else
            {
                Console.WriteLine("firstname problem");
            }

            // if (!FirstName.Any(char.IsDigit) && !LastName.Any(char.IsDigit) && TelephoneNumber.Length <= 10 && TelephoneNumber.Any(char.IsLetter))
            // {
            //     IsValid = true;
            //     Contact = new Contact(FirstName, LastName, TelephoneNumber, Address);
            // }

            return IsValid;
        }
        public void CheckAddress()
        {
            Console.WriteLine(this.Address);
        }
    }
}