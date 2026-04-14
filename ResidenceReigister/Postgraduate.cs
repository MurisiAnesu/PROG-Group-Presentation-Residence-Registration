namespace ResidenceReigister
{
    internal class Postgraduate : StudentResident
    {
        public double ResearchFee { get; set; }

        public bool HasPrivateRoom { get; set; }

        public override double CalculateMonthlyFee()
        {
            double GrandFee = BaseFee + ResearchFee;
            if (HasPrivateRoom)
            {
                GrandFee += 2000; // Additional fee for private room
            }
            return GrandFee;
        }
    }
}
