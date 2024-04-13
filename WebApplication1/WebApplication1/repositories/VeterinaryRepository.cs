using WebApplication1.interfaces;

namespace WebApplication1.repositories;

public class VeterinaryRepository : IVeterinary
{
    public List<Animal> GetAnimals()
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimalById(int id)
    {
        throw new NotImplementedException();
    }

    public void AddAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void UpdateAnimal(Animal animal)
    {
        throw new NotImplementedException();
    }

    public void DeleteAnimal(int id)
    {
        throw new NotImplementedException();
    }

    public List<Visit> GetVisitsForAnimal(int animalId)
    {
        throw new NotImplementedException();
    }

    public void AddVisit(Visit visit)
    {
        throw new NotImplementedException();
    }
}