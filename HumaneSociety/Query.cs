﻿using System;
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

            // if the address isn't found in the Db, create and insert it
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

            // attach AddressId to clientFromDb.AddressId
            newClient.AddressId = addressFromDb.AddressId;

            db.Clients.InsertOnSubmit(newClient);

            db.SubmitChanges();
        }

        internal static void UpdateClient(Client clientWithUpdates)
        {
            // find corresponding Client from Db
            Client clientFromDb = null;

            try
            {
                clientFromDb = db.Clients.Where(c => c.ClientId == clientWithUpdates.ClientId).Single();
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("No clients have a ClientId that matches the Client passed in.");
                Console.WriteLine("No update have been made.");
                return;
            }
            
            // update clientFromDb information with the values on clientWithUpdates (aside from address)
            clientFromDb.FirstName = clientWithUpdates.FirstName;
            clientFromDb.LastName = clientWithUpdates.LastName;
            clientFromDb.UserName = clientWithUpdates.UserName;
            clientFromDb.Password = clientWithUpdates.Password;
            clientFromDb.Email = clientWithUpdates.Email;

            // get address object from clientWithUpdates
            Address clientAddress = clientWithUpdates.Address;

            // look for existing Address in Db (null will be returned if the address isn't already in the Db
            Address updatedAddress = db.Addresses.Where(a => a.AddressLine1 == clientAddress.AddressLine1 && a.USStateId == clientAddress.USStateId && a.Zipcode == clientAddress.Zipcode).FirstOrDefault();

            // if the address isn't found in the Db, create and insert it
            if(updatedAddress == null)
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

            // attach AddressId to clientFromDb.AddressId
            clientFromDb.AddressId = updatedAddress.AddressId;
            
            // submit changes
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


        //// TODO Items: ////
        
        // TODO: Allow any of the CRUD operations to occur here
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


        // TODO: Animal CRUD Operations
        internal static void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static Animal GetAnimalByID(int id)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAnimal(int animalId, Dictionary<int, string> updates)
        {            
            throw new NotImplementedException();
        }

        internal static void RemoveAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }
        
        // TODO: Animal Multi-Trait Search
        internal static IQueryable<Animal> SearchForAnimalsByMultipleTraits(Dictionary<int, string> updates) // parameter(s)?
        {
            var animalsFromDbToList = db.Animals.AsQueryable();

            foreach (var criterion in updates)
            {
                switch (criterion.Key)
                {
                    case 1:
                        // category
                        // convert value to foreign key value or Category data type and pass in
                        // var refinedCategorySearch = db.Animals.Where(a => a.Category == criterion.Value);
                        break;

                    case 2:
                        // animal.Name
                        //Console.WriteLine("Enter the name of the animal you wish to search for: ");
                        //var animalNameChoice = Console.ReadLine();
                        var refinedNameSearch = db.Animals.Where(a => a.Name == criterion.Value);
                        animalsFromDbToList = refinedNameSearch.AsQueryable();
                        break;

                    case 3:
                        // animal.Age
                        var refinedAgeSearch = db.Animals.Where(a => a.Gender == criterion.Value);
                        animalsFromDbToList = refinedAgeSearch.AsQueryable();
                        break;

                    case 4:
                        // animal.Demeanor
                        var refinedDemeanorSearch = db.Animals.Where(a => a.Demeanor == criterion.Value);
                        animalsFromDbToList = refinedDemeanorSearch.AsQueryable();
                        break;

                    case 5:
                        // animal.KidFriendly
                        // IS KID FRIENDLY
                        var refinedKidFriendlySearch = db.Animals.Where(a => a.KidFriendly == bool.Parse(criterion.Value));
                        animalsFromDbToList = refinedKidFriendlySearch.AsQueryable();
                        break;

                    case 6:
                        // animal.PetFriendly
                        // IS PET FRIENDLY
                        var refinedPetFriendlySearch = db.Animals.Where(a => a.PetFriendly == bool.Parse(criterion.Value));
                        animalsFromDbToList = refinedPetFriendlySearch.AsQueryable();
                        break;

                    case 7:
                        // animal.Weight
                        var refinedWeightSearch = db.Animals.Where(a => a.Weight == Int32.Parse(criterion.Value));
                        animalsFromDbToList = refinedWeightSearch.AsQueryable();
                        break;

                    case 8:
                        // animal.AnimalId
                        var refinedIdSearch = db.Animals.Where(a => a.AnimalId == Int32.Parse(criterion.Value));
                        animalsFromDbToList = refinedIdSearch.AsQueryable();
                        break;

                    default:
                        break;
                }
            }

            var animalsFromDb = animalsFromDbToList.AsQueryable();
            return animalsFromDb;
        }
         
        // TODO: Misc Animal Things
        internal static int GetCategoryId(string categoryName)
        {
            throw new NotImplementedException();
        }
        
        internal static Room GetRoom(int animalId)
        {
            throw new NotImplementedException();
        }
        
        internal static int GetDietPlanId(string dietPlanName)
        {
            throw new NotImplementedException();
        }

        // TODO: Adoption CRUD Operations
        internal static void Adopt(Animal animal, Client client)
        {
            throw new NotImplementedException();
        }

        internal static IQueryable<Adoption> GetPendingAdoptions()
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAdoption(bool isAdopted, Adoption adoption)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAdoption(int animalId, int clientId)
        {
            throw new NotImplementedException();
        }

        // TODO: Shots Stuff
        internal static IQueryable<AnimalShot> GetShots(Animal animal)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateShot(string shotName, Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}