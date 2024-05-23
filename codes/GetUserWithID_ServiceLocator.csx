/*
Service Locator Pattern is a design pattern used to retrieve service instances in a centralized manner.
The Service Locator pattern involves a central registry (the service locator) that provides instances of services or dependencies. 
Instead of injecting dependencies, classes request them from the service locator.

this pattern: 
Simplifies the process of obtaining dependencies.
Easy to implement.
Can lead to hidden dependencies, making the code harder to understand and maintain.
Reduces testability because it introduces global state.
Tight coupling to the service locator.

In this code:
- We define an interface IUserRepository which declares the method GetUserById().
- We implement this interface in the UserRepository class, simulating fetching user data from a database.
- The ServiceLocator class is a central registry that provides instances of services and dependencies.
- The UserService class depends on IUserRepository and retrieves it from the ServiceLocator.
- We register an instance of UserRepository with the ServiceLocator.
- We create an instance of UserService, which gets its dependency from the ServiceLocator.
- Finally, we use the UserService to get user data.
*/

using System;

// Define an interface for the repository
public interface IUserRepository
{
    string GetUserById(int id);
}

// Implementation of the repository
public class UserRepository : IUserRepository
{
    public string GetUserById(int id)
    {
        // Simulating database access, in a real scenario, this would query the database
        return "User " + id.ToString();
    }
}

// Service Locator class which provides instances of services
public static class ServiceLocator
{
    private static readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

    // Method to register a service instance
    public static void RegisterService<T>(T service)
    {
        services[typeof(T)] = service;
    }

    // Method to get a service instance
    public static T GetService<T>()
    {
        return (T)services[typeof(T)];
    }
}

// Service class which depends on the repository
public class UserService
{
    private readonly IUserRepository _userRepository;

    // Constructor gets the repository from the Service Locator
    public UserService()
    {
        _userRepository = ServiceLocator.GetService<IUserRepository>();
    }

    public string GetUser(int userId)
    {
        // Using the repository to fetch user data
        return _userRepository.GetUserById(userId);
    }
}

// Register the repository instance with the Service Locator
ServiceLocator.RegisterService<IUserRepository>(new UserRepository());

// Create an instance of the service
UserService userService = new UserService();

// Use the service to get user data
string user = userService.GetUser(123);
Console.WriteLine(user);