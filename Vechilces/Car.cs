using System.Drawing;

namespace HW_GIT_TEAM.Vechilces;

public abstract class Car : IVechilces
{
    public VechilcesBrands Brand {  get; set; }
    public string Model { get; set; }
    public Color Color { get; set; }
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
