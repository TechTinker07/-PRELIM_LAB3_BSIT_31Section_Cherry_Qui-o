
namespace PRELIM_LAB3_BSIT_31Section_Cherry_Quiño.Models
{
    // Base class ng lahat. Ibig sabihin,
    // lahat ng customer manggagaling dito.
    public abstract class BaseEntity : IDescribeable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthday.Year; 

        }
        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
        public virtual string GetDescription() // pwede na agad gamitin, pero pwedeng i-override ng mga anak
        {
            return GetFullName() + " " + GetAge();
        }

    }
}
