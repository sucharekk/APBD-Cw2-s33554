using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Devices;

public class Device
{
    private static int _counter = 0;
    protected int _id;
    protected DeviceType _type;
    protected bool _isAvailable => _quantity > 0;
    protected int _quantity;
    protected string _model;
    protected double _marketPrice;
    public Device(string model,double marketPrice, int quantity)
    {
        _counter++;
        _id = _counter;
       _quantity = quantity;
       _model = model;
       _marketPrice = marketPrice;
       
       
        
    }
    public int Id { get => _id; set => _id = value; }

    public int Quanity
    {
        get => _quantity;
        set
        {
            _quantity = value;
        }

    }
    public bool IsAvailable { get => _isAvailable;  }
    public override string ToString()
    {
        return $"id: {_id} | model: {_model} | type: {_type.ToString().ToLower()} | quantity: {_quantity} | available: {_isAvailable}";
    }
}