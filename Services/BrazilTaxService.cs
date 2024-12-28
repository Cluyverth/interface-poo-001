namespace ProjectD.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double ammout)
        {
            if (ammout != 0)
            {
                if (ammout < 100.00)
                {
                    return ammout * 0.2;
                }
                else { return ammout * 0.15; }
            }
            return 0;
        }
    }
}
