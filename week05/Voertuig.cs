public class Voertuig{
    
    private string merk;
    private string model;
    private int aantalBanden;

    public Voertuig()
    {
        aantalBanden = 1;
    }

    public Voertuig(string merk, int aantalBanden)
    {
        this.aantalBanden = aantalBanden;
        this.merk = merk;
    }

    public string Merk { get => merk; set => merk = value; }
    public string Model { get => model; set => model = value; }

}