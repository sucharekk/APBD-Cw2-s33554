using APBD_Cw2_s33554.Enums;

namespace APBD_Cw2_s33554.Devices;

public class Device
{
    protected int _id;
    protected DeviceType _type;
    protected bool _isAvailable;
    protected int _quanity;
    protected string _model;
    protected double _marketPrice;
    public Device(string model,double marketPrice, int quanity)
    {
        _id = Random.Shared.Next(1, 10000);;
       _quanity = quanity;
       _model = model;
       _marketPrice = marketPrice;
       
        if (quanity > 0)
            _isAvailable = true;
        _isAvailable = false;
    }
    public int Id { get => _id; set => _id = value; }
   
    public int Quanity { get => _quanity; set => _quanity = value; }
    public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }

}