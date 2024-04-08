namespace WebApplication1;

public class AnimalList
{
    private List<Animal> List
    {
        get
        {
            return this.List;
        } 
        set{}
    }

    public AnimalList()
    {
        List = new List<Animal>();
    }

    public Animal GetAnimalById(int id)
    {
        Animal resultAnimal = List.Find(animal => animal.Id == id);
        return resultAnimal;
    }

    public void AddAnimal(int id, string imie, string category, double mass, string colour)
    {
        Animal animal = new Animal(id, imie, category, mass, colour);
        List.Add(animal);
    }
    
    public void EditAnimal(int id, string imie, string category, double mass, string colour)
    {
        List.Remove(List.Find(animal => animal.Id == id));
        Animal animal = new Animal(id, imie, category, mass, colour);
        List.Add(animal);
    }

    public void DeleteAnimal(int id)
    {
        List.Remove(List.Find(animal => animal.Id == id));
    }
    
    
}