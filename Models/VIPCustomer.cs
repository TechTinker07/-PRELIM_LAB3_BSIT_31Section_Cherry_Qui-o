namespace PRELIM_LAB3_BSIT_31Section_Cherry_Quiño.Models
{
    public class VIPCustomer : Customer
    {
        public bool IsVip { get; set; }
        public override string GetDescription()
        {
            return "VIP Customer," + GetFullName() + " " + GetAge() + " " + CustomerId;
        }

    }
}
