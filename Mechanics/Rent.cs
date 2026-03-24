using APBD_Cw2_s33554.Devices;
using APBD_Cw2_s33554.Users;

namespace APBD_Cw2_s33554.Mechanics;

public class Rent
{
    private User _user;
    private Device _device;
    private DateOnly _dateFrom;
    private DateOnly _dateTo;
    private double _fee;
    private bool _closed;

    public Rent(User user, Device device)
    {
        _user = user;
        _device = device;
        _dateFrom = DateOnly.FromDateTime(DateTime.Now);
        _dateTo = _dateFrom.AddDays(7);
        _closed = false;
    }


    public User User
    {
        get => _user;
        set => _user = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Device Device
    {
        get => _device;
        set => _device = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateOnly DateFrom
    {
        get => _dateFrom;
        set => _dateFrom = value;
    }

    public DateOnly DateTo
    {
        get => _dateTo;
        set => _dateTo = value;
    }

    public double Fee
    {
        get => _fee;
        set => _fee = value;
    }

    public bool Closed
    {
        get => _closed;
        set => _closed = value;
    }

    public int CalculateFee()
    {
        DateOnly currentDay = DateOnly.FromDateTime(DateTime.Now);
        if (currentDay > _dateTo)
        {
            int fee = 3;
            int days = currentDay.DayNumber - _dateTo.DayNumber;
            return fee * days;
        }
        return 0;
    }
}