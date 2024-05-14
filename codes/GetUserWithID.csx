/*
Dependency Injection (DI) is a design pattern widely used in software development, 
particularly in object-oriented programming, 
to achieve loose coupling between classes or components

In this code:
- We define an interface IUserRepository which declares the method GetUserById().
- We implement this interface in the UserRepository class, where we simulate fetching user data from a database.
- The UserService class depends on IUserRepository and receives an instance of it through its constructor. This is constructor injection.
- Then in main code we create an instance of UserRepository and pass it to the UserService constructor, thus injecting the dependency.
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

// Service class which depends on the repository
public class UserService
{
    private readonly IUserRepository _userRepository;

    // Constructor injection
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public string GetUser(int userId)
    {
        // Using the repository to fetch user data
        return _userRepository.GetUserById(userId);
    }
}


// Create an instance of the repository
IUserRepository userRepository = new UserRepository();

// Inject the repository instance into the service
UserService userService = new UserService(userRepository);

// Use the service to get user data
string user = userService.GetUser(123);
Console.WriteLine(user);

