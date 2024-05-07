using DeliveryServiceRepo.repository;

namespace DeliveryServiceRepo.Repository;

public class DeliveryServiceRepo
{
    private List<DeliveryService> _listOfDeliveries = new List<DeliveryService>();

    // Create Delivery...
    public void AddDeliveryToList(DeliveryService deliveryService)
    {
        _deliveryservice.Add(deliveryService);
    }
    // Read a delivery...
    public List<DeliveryService> GetDeliveryList(DeliveryService);
    {
        return new List<DeliveryService>(_listOfDeliveries);
    }
    // Update deliveries...
    public bool UpdateDeliveryList(DeliveryService deliveryService);

        //Find that delivery content...
        DeliveryService oldContent = GetDeliveryList();

        // ...And then we'll update that delivery content...
        
    //Delete those deliveries...


    //Helper Methods...
}
