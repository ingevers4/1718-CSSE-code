public class Wagen : Voertuig
{
    string kleur;
    int aantalZitplaatsen;

    public string Kleur { get => kleur; set => kleur = value; }
    public int AantalZitplaatsen { get => aantalZitplaatsen; set => aantalZitplaatsen = value; }

    public int getAantalZitplaatsen()
    {
        return this.aantalZitplaatsen;
    }

    public Wagen()
    {
    }

    public Wagen(string merk, string model, int zitplaatsen)
    {
        this.AantalZitplaatsen = zitplaatsen;
        this.Model = model;
        this.Merk = merk;
    }
}