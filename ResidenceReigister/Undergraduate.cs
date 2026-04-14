namespace ResidenceReigister
{
    internal class Undergraduate : StudentResident

    {
        public int YearOfStudy { get; set; }
        public double MealPlanFee { get; set; }

        public override double CalculateMonthlyFee()
        {
            return BaseFee + MealPlanFee;
        }
    }
}
