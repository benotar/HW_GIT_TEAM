namespace HW_GIT_TEAM.Vechilces;

public class Truck : IVechilces
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public DateTime DateOfCreating { get; set; } = DateTime.Now;
    public void BreackDown()
    {
        throw new NotImplementedException();
    }

    public void Fix()
    {
        throw new NotImplementedException();
    }

    public void Maintenance()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        throw new NotImplementedException();
    }
}
