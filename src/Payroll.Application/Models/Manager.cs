namespace PayrollApp.Application.Models
{
    public class Manager : Staff
    {
        private const float MANAGER_HOURLY_RATE = 50;

        public Manager(string name) : base(name, MANAGER_HOURLY_RATE)
        {
        }

        public int Allowance { get; private set; }

        public override void CalculatePay()
        {
            base.CalculatePay();

            Allowance = 1000;

            if (HoursWorked > 160)
            {
                TotalPay += 1000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", {nameof(Allowance)} = {Allowance} ";
        }
    }
}
