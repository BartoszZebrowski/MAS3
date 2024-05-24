using MAS3;

var petrolEngine1 = new PetrolEngine(200321, 1, "124552345234", 2000, 4);
var petrolEngine2 = new PetrolEngine(45512, 3, "565416122134", 4000, 6);

var electricEngine1 = new ElectricEngine(18519, 0.5, "53458728112312",10, 100);
var electricEngine2 = new ElectricEngine(5414, 0.8, "5678562345", 20, 300);

var casualCar = new GroundVehicle(GroundVehicleType.CasualCar, electricEngine1, DateOnly.Parse("01-01-2001"), "Ford");
var sportCar = new GroundVehicle(GroundVehicleType.SportCar, petrolEngine1, DateOnly.Parse("25-07-2020"), "Lamborgini");

var amphibian = new Amphibian(10, electricEngine2, DateOnly.Parse("18-06-2018"), "Amphicar");

casualCar.ChangeGroundVehicleTypeToSportcar(130);

var tractor = new Tractor(petrolEngine2, DateOnly.Parse("13-02-1989"), "Ursus");

CountryTractor.CreateAsPartOfTractor(tractor, 10000);
ForestTractor.CreateAsPartOfTractor(tractor, 30);


List<IVehicle> vehicles = new List<IVehicle>();

vehicles.Add(casualCar);
vehicles.Add(sportCar);
vehicles.Add(amphibian);
vehicles.Add(tractor);