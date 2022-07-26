namespace PayrollApp.Application.Models
{
    public class Staff
    {
        private float _hourlyRate;
        private int _hWorked;

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            _hourlyRate = rate;
        }

        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string? NameOfStaff { get; private set; }
        public int HoursWorked { 
            get 
            { 
                return _hWorked; 
            } 
            set 
            {
                _hWorked = value > 0 ? value : 0;
            } 
        }

        public virtual void CalculatePay()
        {
            BasicPay = _hWorked * _hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return $"{nameof(NameOfStaff)} = {NameOfStaff}, {nameof(TotalPay)} = {TotalPay}, {nameof(BasicPay)} = {BasicPay}";
        }
    }
}
