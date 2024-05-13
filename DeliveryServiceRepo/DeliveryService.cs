namespace DeliveryServiceRepo.repository;



//This is the repository for the past deliveries with the POCOs...
 public class DeliveryService
{
    public DateTime OrderDate { get; set;}

    public DateTime DeliveryDate { get; set; }

    public string? OrderStatus { get; set;}

    public double ItemNumber { get; set; }
    public double ItemQuantity { get; set;}

    public double CustomerId { get; set;}


}