using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private static readonly List<Animal> _animals = new List<Animal>
    {
        new Animal { Id = 1, Name = "Lion", Category = "Mammal", Mass = 190, Colour = "Golden" },
        new Animal { Id = 2, Name = "Tiger", Category = "Mammal", Mass = 200, Colour = "Orange" },
        new Animal { Id = 3, Name = "Elephant", Category = "Mammal", Mass = 5000, Colour = "Grey" },
        new Animal { Id = 4, Name = "Eagle", Category = "Bird", Mass = 6, Colour = "Brown" },
        new Animal { Id = 5, Name = "Crocodile", Category = "Reptile", Mass = 1000, Colour = "Green" },
        new Animal { Id = 6, Name = "Dolphin", Category = "Mammal", Mass = 300, Colour = "Grey" },
        new Animal { Id = 7, Name = "Python", Category = "Reptile", Mass = 50, Colour = "Brown" },
        new Animal { Id = 8, Name = "Shark", Category = "Fish", Mass = 2000, Colour = "Grey" },
        new Animal { Id = 9, Name = "Peacock", Category = "Bird", Mass = 5, Colour = "Multicolored" },
        new Animal { Id = 10, Name = "Spider", Category = "Arachnid", Mass = 0.1, Colour = "Black" }
    };

    private readonly List<Visit> _visits = new()
    {
        new Visit { VisitDate = DateTime.Parse("2024-04-10"), Animal = _animals.FirstOrDefault(a => a.Id == 4),Description = "Regular checkup", Price = 50 },
        new Visit { VisitDate = DateTime.Parse("2024-03-20"), Animal = _animals.FirstOrDefault(a => a.Id == 3), Description = "Vaccination", Price = 30 },
        new Visit { VisitDate = DateTime.Parse("2024-04-05"), Animal = _animals.FirstOrDefault(a => a.Id == 4), Description = "Injury treatment", Price = 80 },
        new Visit { VisitDate = DateTime.Parse("2024-04-12"), Animal = _animals.FirstOrDefault(a => a.Id == 1), Description = "Teeth cleaning", Price = 70 }
    };
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animals);
    }
    [HttpGet("visits")]
    public IActionResult GetVisits()
    {
        return Ok(_visits);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = _animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null)
        {
            return NotFound();
        }

        _animals.Remove(existingAnimal);
        _animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToRemove = _animals.FirstOrDefault(a => a.Id == id);
        if (animalToRemove == null)
        {
            return NotFound();
        }
        _animals.Remove(animalToRemove);
        return NoContent();
    }
    [HttpGet("{animalId:int}/visits")]
    public IActionResult GetAnimalVisits(int animalId)
    {
        var animalVisits = _visits.Where(v => v.Animal.Id == animalId).ToList();
        if (animalVisits.Count == 0)
        {
            return NotFound("No visits.");
        }
        return Ok(animalVisits);
    }

    [HttpPost("{animalId:int}/visits")]
    public IActionResult AddAnimalVisit(int animalId, Visit visit)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == animalId);
        if (animal == null)
        {
            return NotFound($"Animal with ID {animalId} not found.");
        }

        visit.Animal = animal;
        _visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
    
}