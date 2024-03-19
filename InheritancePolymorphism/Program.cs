
using PolymorphismAndInheritance;
using static PolymorphismAndInheritance.Vehicles;
using static PolymorphismAndInheritance.Animals;


Cars car = new Cars();
car.type = "Jeep";
car.color = "white";
car.Travel();
car.Engine();

Bicycle bicycle = new Bicycle();
bicycle.type = "race bicycle ";
bicycle.color = "red";
bicycle.Travel();
bicycle.Engine();

Motocycles motocycles = new Motocycles();
motocycles.type = "Yamaha";
motocycles.color = "yellow";
motocycles.Travel();
motocycles.Engine();

Console.WriteLine("-----------------");

Dog dog = new Dog();
dog.Name = "Scooby";
dog.Age = 10;
dog.Race = "Labrador Retriever";
dog.Pet();
dog.Sounds();

Bird bird = new Bird();
bird.Name = "Pepper";
bird.Age = 2;
bird.Race = "parrot";
bird.Pet();
bird.Sounds();

Fish fish = new Fish();
fish.Race = "Jellyfish";
fish.Pet();
fish.Sounds();

Cat cat = new Cat();
cat.Name = "Sylvester";
cat.Age = 8;
cat.Race = "Turkish Van";
cat.Pet();
cat.Sounds();