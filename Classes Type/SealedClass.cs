public class Program
{
    public static void Main()
    {
        PaymentService payment = new PaymentService();

        payment.Pay();
    }

    public sealed class PaymentService // prevent inheritance
    {
        public void Pay()
        {
            Console.WriteLine("Payment completed");
        }
    }
}
