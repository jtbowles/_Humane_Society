using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        static HumaneSocietyDataContext db;

        static Query()
        {
            db = new HumaneSocietyDataContext();
        }

        internal static List<USState> GetStates()
        {
            List<USState> allStates = db.USStates.ToList();
            return allStates;
        }

        internal static Client GetClient(string userName, string password)
        {
            Client client = db.Clients.Where(c => c.UserName == userName && c.Password == password).Single();
            return client;
        }

        internal static List<Client> GetClients()
        {
            List<Client> allClients = db.Clients.ToList();
            return allClients;
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int stateId)
        {
            Client newClient = new Client();

            newClient.FirstName = firstName;
            newClient.LastName = lastName;
            newClient.UserName = username;
            newClient.Password = password;
            newClient.Email = email;

            Address addressFromDb = db.Addresses.Where(a => a.AddressLine1 == streetAddress && a.Zipcode == zipCode && a.USStateId == stateId).FirstOrDefault();

            if (addressFromDb == null)
            {
                Address newAddress = new Address();
                newAddress.AddressLine1 = streetAddress;
                newAddress.City = null;
                newAddress.USStateId = stateId;
                newAddress.Zipcode = zipCode;

                db.Addresses.InsertOnSubmit(newAddress);
                db.SubmitChanges();

                addressFromDb = newAddress;
            }
            newClient.AddressId = addressFromDb.AddressId;
            db.Clients.InsertOnSubmit(newClient);
            db.SubmitChanges();
        }

        internal static void UpdateClient(Client clientWithUpdates)
        {
            Client clientFromDb = null;

            try
            {
                clientFromDb = db.Clients.Where(c => c.ClientId == clientWithUpdates.ClientId).Single();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No clients have a ClientId that matches the Client passed in.");
                Console.WriteLine("No update have been made.");
                return;
            }

            clientFromDb.FirstName = clientWithUpdates.FirstName;
            clientFromDb.LastName = clientWithUpdates.LastName;
            clientFromDb.UserName = clientWithUpdates.UserName;
            clientFromDb.Password = clientWithUpdates.Password;
            clientFromDb.Email = clientWithUpdates.Email;

            Address clientAddress = clientWithUpdates.Address;

            Address updatedAddress = db.Addresses.Where(a => a.AddressLine1 == clientAddress.AddressLine1 && a.USStateId == clientAddress.USStateId && a.Zipcode == clientAddress.Zipcode).FirstOrDefault();

            if (updatedAddress == null)
            {
                Address newAddress = new Address();
                newAddress.AddressLine1 = clientAddress.AddressLine1;
                newAddress.City = null;
                newAddress.USStateId = clientAddress.USStateId;
                newAddress.Zipcode = clientAddress.Zipcode;

                db.Addresses.InsertOnSubmit(newAddress);
                db.SubmitChanges();

                updatedAddress = newAddress;
            }
            clientFromDb.AddressId = updatedAddress.AddressId;
            db.SubmitChanges();
        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            Employee employeeFromDb = db.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();

            employeeFromDb.UserName = employee.UserName;
            employeeFromDb.Password = employee.Password;

            db.SubmitChanges();
        }

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            Employee employeeFromDb = db.Employees.Where(e => e.Email == email && e.EmployeeNumber == employeeNumber).FirstOrDefault();

            if (employeeFromDb == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return employeeFromDb;
            }
        }

        internal static Employee EmployeeLogin(string userName, string password)
        {
            Employee employeeFromDb = db.Employees.Where(e => e.UserName == userName && e.Password == password).FirstOrDefault();
            return employeeFromDb;
        }

        internal static bool CheckEmployeeUserNameExist(string userName)
        {
            Employee employeeWithUserName = db.Employees.Where(e => e.UserName == userName).FirstOrDefault();
            return employeeWithUserName == null;
        }

        internal static void RunEmployeeQueries(Employee employee, string crudOperation)
        {
            switch (crudOperation)
            {
                case "create":
                    // check for registration number
                    AddEmployee(employee);
                    break;

                case "read":
                    ReadEmployee(employee);
                    break;

                case "update":
                    UpdateEmployee(employee);
                    break;

                case "delete":
                    DeleteEmployee(employee);
                    break;

                default:
                    break;
            }

        }

        internal static void AddEmployee(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);
            db.SubmitChanges();
        }

        internal static void ReadEmployee(Employee employee)
        {
            Employee employeeFound = db.Employees.Where(e => e.EmployeeNumber == employee.EmployeeNumber).Single();
            UserInterface.DisplayEmployeeInfo(employeeFound);
        }

        internal static void UpdateEmployee(Employee employee)
        {
            Employee employeeToUpdate = db.Employees.Where(e => e.EmployeeNumber == employee.EmployeeNumber && e.LastName == employee.LastName).Single();
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Email = employee.Email;
            db.SubmitChanges();
        }

        internal static void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = db.Employees.Where(e => e.EmployeeNumber == employee.EmployeeNumber && e.LastName == employee.LastName).Single();
            db.Employees.DeleteOnSubmit(employeeToDelete);
            db.SubmitChanges();
        }

        internal static void AddAnimal(Animal animal)
        {
            CreateRoom();
            AssignAnimalToRoom(animal);
            db.Animals.InsertOnSubmit(animal);
            db.SubmitChanges();
        }

        internal static Animal GetAnimalByID(int id)
        {
            return db.Animals.Where(a => a.AnimalId == id).Single();
        }

        internal static void UpdateAnimal(int animalId, Dictionary<int, string> updates)
        {
            Animal animalFromDb = GetAnimalByID(animalId);
            foreach (var update in updates)
            {
                switch (update.Key)
                {
                    case 1:
                        Category category = db.Categories.Where(c => c.Name == update.Value).Single();
                        animalFromDb.Category = category;
                        break;
                    case 2:
                        animalFromDb.Name = update.Value;
                        break;
                    case 3:
                        animalFromDb.Age = int.Parse(update.Value);
                        break;
                    case 4:
                        animalFromDb.Demeanor = update.Value;
                        break;
                    case 5:
                        animalFromDb.KidFriendly = bool.Parse(update.Value);
                        break;
                    case 6:
                        animalFromDb.PetFriendly = bool.Parse(update.Value);
                        break;
                    case 7:
                        animalFromDb.Weight = int.Parse(update.Value);
                        break;
                    case 8:
                        animalFromDb.AnimalId = int.Parse(update.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        internal static void RemoveAnimal(Animal animal)
        {
            Animal animalDelete = db.Animals.Where(a => a.AnimalId == animal.AnimalId).Select(a => a).FirstOrDefault();
            db.Animals.DeleteOnSubmit(animalDelete);
            db.SubmitChanges();
        }

        internal static IQueryable<Animal> SearchForAnimalsByMultipleTraits(Dictionary<int, string> updates)
        {
            var animalsFromDbToQueryable = db.Animals.AsQueryable();

            foreach (var criterion in updates)
            {
                switch (criterion.Key)
                {
                    case 1:
                        int categoryID = db.Categories.Where(c => c.Name == criterion.Value).Select(c => c.CategoryId).Single();
                        var refinedCategorySearch = animalsFromDbToQueryable.Where(a => a.CategoryId == categoryID);
                        animalsFromDbToQueryable = refinedCategorySearch;
                        break;

                    case 2:
                        var refinedNameSearch = animalsFromDbToQueryable.Where(a => a.Name == criterion.Value);
                        animalsFromDbToQueryable = refinedNameSearch;
                        break;

                    case 3:
                        var refinedAgeSearch = animalsFromDbToQueryable.Where(a => a.Gender == criterion.Value);
                        animalsFromDbToQueryable = refinedAgeSearch;
                        break;

                    case 4:
                        var refinedDemeanorSearch = animalsFromDbToQueryable.Where(a => a.Demeanor == criterion.Value);
                        animalsFromDbToQueryable = refinedDemeanorSearch;
                        break;

                    case 5:
                        var refinedKidFriendlySearch = animalsFromDbToQueryable.Where(a => a.KidFriendly == bool.Parse(criterion.Value));
                        animalsFromDbToQueryable = refinedKidFriendlySearch;
                        break;

                    case 6:
                        var refinedPetFriendlySearch = animalsFromDbToQueryable.Where(a => a.PetFriendly == bool.Parse(criterion.Value));
                        animalsFromDbToQueryable = refinedPetFriendlySearch;
                        break;

                    case 7:
                        var refinedWeightSearch = animalsFromDbToQueryable.Where(a => a.Weight == Int32.Parse(criterion.Value));
                        animalsFromDbToQueryable = refinedWeightSearch;
                        break;

                    case 8:
                        var refinedIdSearch = animalsFromDbToQueryable.Where(a => a.AnimalId == Int32.Parse(criterion.Value));
                        animalsFromDbToQueryable = refinedIdSearch;
                        break;

                    default:
                        break;
                }
            }
            return animalsFromDbToQueryable;
        }

        internal static int GetCategoryId(string categoryName)
        {
            return db.Categories.Where(c => c.Name == categoryName).Select(c => c.CategoryId).Single();
        }

        internal static Room GetRoom(int animalId)
        {
            return db.Rooms.Where(r => r.AnimalId == animalId).Single();
        }

        internal static void CreateRoom()
        {
            Room newRoom = new Room();
            newRoom.RoomNumber = newRoom.RoomId;
            db.Rooms.InsertOnSubmit(newRoom);
            db.SubmitChanges();
        }

        internal static void AssignAnimalToRoom(Animal animal)
        {
            var openRoom = db.Rooms.Where(r => r.AnimalId == null).First();
            openRoom.AnimalId = animal.AnimalId;
            db.SubmitChanges();
        }

        internal static int GetDietPlanId(string dietPlanName)
        {
            return db.DietPlans.Where(d => d.Name == dietPlanName).Select(d => d.DietPlanId).Single();
        }

        internal static void Adopt(Animal animal, Client client)
        {
            Adoption newAdoption = new Adoption();
            newAdoption.ClientId = client.ClientId;
            newAdoption.AnimalId = animal.AnimalId;
            newAdoption.ApprovalStatus = "pending";
            newAdoption.AdoptionFee = 75;
            db.Adoptions.InsertOnSubmit(newAdoption);
            db.SubmitChanges();
        }

        internal static IQueryable<Adoption> GetPendingAdoptions()
        {
            return db.Adoptions.Where(a => a.ApprovalStatus.ToUpper() == "PENDING").AsQueryable();
        }

        internal static void UpdateAdoption(bool isAdopted, Adoption adoption)
        {
            if (isAdopted)
            {
                Adoption updatedAdoption = db.Adoptions.Where(a => a.ClientId == adoption.ClientId && a.AnimalId == adoption.AnimalId).Single();
                updatedAdoption.ApprovalStatus = "APPROVED";
                db.SubmitChanges();
            }
            else
            {
                RemoveAdoption(adoption.AnimalId, adoption.ClientId);
            }
        }

        internal static void RemoveAdoption(int animalId, int clientId)
        {
            var adoptionToRemove = db.Adoptions.Where(a => a.AnimalId == animalId && a.ClientId == clientId).Single();
            adoptionToRemove.ApprovalStatus = "DENIED";          
            db.Adoptions.DeleteOnSubmit(adoptionToRemove);      // removes the adoption from the db => instead, should just update the approval status to keep a record of denied adoptions
            db.SubmitChanges();
        }

        internal static IQueryable<AnimalShot> GetShots(Animal animal)
        {
            return db.AnimalShots.Where(a => a.AnimalId == animal.AnimalId).AsQueryable();
        }

        internal static void UpdateShot(string shotName, Animal animal)
        {
            AnimalShot updateAnimalShot = db.AnimalShots.Where(a => a.AnimalId == animal.AnimalId).Single();
            Shot shot = db.Shots.Where(s => s.Name == shotName).Single();
            updateAnimalShot.DateReceived = DateTime.Now;
            updateAnimalShot.ShotId = shot.ShotId;

            db.SubmitChanges();
        }
    }
}