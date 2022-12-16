namespace ConsoleAppEntityFramework.Models
{
    public enum EState
    {
        Unknown,
        ChoiceInProgress,
        Cancelled,
        WaitingForPayment,
        PaymentFailed,
        WaitingRestaurantConfirmation,
        CookingProgress,
        WaitingDeliverymanConfirmation,
        WaitingDeliverymanPickUp,
        DeliveryInProgress,
        Delivered
    }
}
