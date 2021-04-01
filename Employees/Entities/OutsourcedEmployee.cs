namespace Employees.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharg { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharg)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharg = additionalCharg;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionalCharg * 1.1;
        }
    }
}
