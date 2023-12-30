namespace HW_GIT_TEAM.ParselCommon;

public class Parsel : IParsel, ICloneable
{
    public Parsel(Parsel parsel)
    {
        this.Sender = parsel.Sender;
        this.Client = parsel.Client;
        this.Weight = parsel.Weight;
        this.DeclaredPrice = parsel.DeclaredPrice;
    }

    public string Sender { get; set; }
    public string Client { get; set; }
    public double Weight { get; set; }
    public double DeclaredPrice { get; set; }

    Parsel SetSender(string sender)
    {
        Sender = sender;
        return this;
    }

    Parsel SetClient(string client)
    {
        Client = client;
        return this;
    }

    Parsel SetWeight(double weight) 
    {
        Weight = weight;
        return this;
    }

    Parsel SetDeclaredPrice(double declaredPrice)
    {
        DeclaredPrice = declaredPrice;
        return this;
    }

    public object Clone()
    {
        Parsel clone = new Parsel(this);
        return clone;
    }
}
