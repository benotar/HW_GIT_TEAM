namespace HW_GIT_TEAM.ParselCommon;

public interface IParsel
{
    public string Sender { get; set; }
    public string Client { get; set; }
    public double Weight { get; set; }
    public double DeclaredPrice { get; set; }
}
