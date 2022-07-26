namespace PayrollApp.Application.Models
{
    public class Admin : Staff
    {
        private const float OVERTIME_RATE = 15.5f;
        private const float ADMIN_HOURLY_RATE = 30;

        public Admin(string name) : base(name, ADMIN_HOURLY_RATE)
        {
        }

        public float Overtime { get; private set; }

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 160)
            {
                Overtime = OVERTIME_RATE * (HoursWorked - 160);
                TotalPay += Overtime;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", {nameof(Overtime)} = {Overtime}";
        }
    }
}
