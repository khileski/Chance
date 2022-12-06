using Microsoft.EntityFrameworkCore;

namespace Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new ShelterDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShelterDbContext>>()
            ))
            {
                if(context.Shelters.Any())
                {
                    return;
                }
                context.Shelters.AddRange(
                    new Shelter{Name = "Fritch Animal Control", Address = "103 E Monroe St.", Town = "Fritch",
                    Animals = new List<Animal>
                    {
                        new Animal {AnimalName ="Max", Weight = 51.2, Description ="White with one black dot on leg", Type = "Dog"},
                        new Animal {AnimalName = "Bella", Weight = 10.5, Description = "Tan", Type = "Dog" },
                        new Animal {AnimalName = "Charlie", Weight = 150.7, Description = "Black and Brown", Type = "Dog" },
                        new Animal {AnimalName = "Buddy", Weight = 60, Description = "Black", Type = "Dog" },
                        new Animal {AnimalName = "Rocky", Weight = 45.6, Description = "White", Type = "Dog" },
                        new Animal {AnimalName = "Tigger", Weight = 8.7, Description = "Orange", Type = "Cat" },
                        new Animal {AnimalName = "Shadow", Weight = 10.2, Description = "Slate gray", Type = "Cat" },
                        new Animal {AnimalName = "Hallo", Weight = 9.8, Description = "Black with a few orage stripes", Type = "Cat" },
                        new Animal {AnimalName = "Chloe", Weight = 9.5, Description = "White", Type = "Cat" }

                    }
                    },
                    new Shelter{Name = "Borger Animal Control Shelter", Address = "1300 W 3rd St.", Town = "Borger",
                    Animals = new List<Animal>
                    {
                        new Animal {AnimalName ="Jake", Weight = 80.2, Description ="Yellow", Type = "Dog"},
                        new Animal {AnimalName = "Jack", Weight = 25.4, Description = "Black and White", Type = "Dog" },
                        new Animal {AnimalName = "Lucy", Weight = 72.8, Description = "Red and White", Type = "Dog" },
                        new Animal {AnimalName = "Molly", Weight = 120.6, Description = "Black", Type = "Dog" },
                        new Animal {AnimalName = "Daisy", Weight = 46.3, Description = "Black", Type = "Dog" },
                        new Animal {AnimalName = "Luna", Weight = 8.2, Description = "Yellow", Type = "Cat" },
                        new Animal {AnimalName = "Baby", Weight = 10.8, Description = "White and black", Type = "Cat" },
                        new Animal {AnimalName = "Oreo", Weight = 10.3, Description = "Black", Type = "Cat" },
                        new Animal {AnimalName = "Harley", Weight = 9.0, Description = "Calico", Type = "Cat" }
                        
                    }},
                    new Shelter{Name = "City of Stinnett", Address = "609 MacKenzie Ave.", Town = "Stinnett",
                    Animals = new List<Animal>
                    {
                        new Animal {AnimalName ="Maggie", Weight = 37.2, Description ="Brindle", Type = "Dog"},
                        new Animal {AnimalName = "Sophie", Weight = 108.5, Description = "Chocolate Brown", Type = "Dog" },
                        new Animal {AnimalName = "Zoe", Weight = 79.0, Description = "Golden", Type = "Dog" },
                        new Animal {AnimalName = "Abby", Weight = 29.3, Description = "Brindle with white chest", Type = "Dog" },
                        new Animal {AnimalName = "Buster", Weight = 48.1, Description = "Yellow", Type = "Dog" },
                        new Animal {AnimalName = "Princess", Weight = 135.4, Description = "White with black ears", Type = "Dog" },
                        new Animal {AnimalName = "Jasper", Weight = 11.0, Description = "Yello", Type = "Cat" },
                        new Animal {AnimalName = "Gizmo", Weight = 10.4, Description = "Calico", Type = "Cat" },
                        new Animal {AnimalName = "Nala", Weight = 8.9, Description = "Yello", Type = "Cat" },
                        new Animal {AnimalName = "Sasha", Weight = 10.7, Description = "Slate Gray", Type = "Cat" }
                        
                    }}
                );
                context.SaveChanges();
            }
        }
    }
}