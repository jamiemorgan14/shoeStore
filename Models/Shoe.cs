namespace shoeStore.Models
{
  public class Shoe
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Edition { get; set; }

    public Shoe(int id, string name, int edition)
    {
      Id = id;
      Name = name;
      Edition = edition;
    }
  }
}