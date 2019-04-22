namespace Selection_6.InterfaceAndTestbilityExam
{
    public class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1;

            return 0;
        }
    }
    }
}
