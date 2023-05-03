using Stripe;
using Stripe.Checkout;

namespace BlazorApp1.Client.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;
        private readonly IOrderService _orderService;

        public PaymentService(ICartService cartService,
            IAuthService authService,
            IOrderService orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51N3d3TGzAHdztDT42UngCz8XDzUQ9vGejywGRyiuydLejF5mXBny1cmJXyALWaVBHjg2Mhnt0SCfDCoOGhxgKfoy003vB6Qo1M";

            _cartService = cartService;
            _authService = authService;
            _orderService = orderService;
        }
        
    }
}
