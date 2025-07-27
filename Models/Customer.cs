namespace PRELIM_LAB3_BSIT_31Section_Cherry_Quiño.Models
{
    // Eto yung class para sa regular customer lang
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }
        public override string GetDescription()
        {
            return "Regular Customer," + GetFullName() + " " + GetAge() + " " + CustomerId;
        }
    }
}
