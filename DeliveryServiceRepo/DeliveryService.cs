namespace DeliveryServiceRepo.repository;



//This is the repository for the past deliveries with the POCOs...
 public class DeliveryService
{
    public DateTime OrderDate { get; set;}

    public DateTime DeliveryDate { get; set; }

    public string OrderStatus { get; set;}

    public double ItemNumber { get; set; }
    public double ItemQuantity { get; set;}

    public double CustomerId { get; set;}
    
    
    public DeliveryService(DateTime OrderDate, DateTime DeliveryDate, string OrderSatus, double ItemNumber, double ItemQuantity, double CustomerId)
    {
        this.OrderDate = OrderDate;
        this.DeliveryDate = DeliveryDate;
        this.OrderStatus = OrderStatus;
        this.ItemNumber = ItemNumber;
        this.ItemQuantity = ItemQuantity;
        this.CustomerId = CustomerId;
    }

    internal void Add(DeliveryService deliveryService)
    {
        throw new NotImplementedException();
    }
}