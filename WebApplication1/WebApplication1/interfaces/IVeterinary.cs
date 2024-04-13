using WebApplication1;

namespace WebApplication1.interfaces;

public interface IVeterinary
{
    List<Animal> GetAnimals();
    Animal GetAnimalById(int id);
    void AddAnimal(Animal animal);
    void UpdateAnimal(Animal animal);
    void DeleteAnimal(int id);

    List<Visit> GetVisitsForAnimal(int animalId);
    void AddVisit(Visit visit);
}