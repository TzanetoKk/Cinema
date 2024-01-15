using Cinema.Models;
using System;
using System.Collections.Generic;

public class UserService
{
    private readonly List<User> _users;

    public UserService()
    {
        _users = new List<User>
        {
            new User
            {
                Username = "user1",
                Email = "user1@example.com",
                Password = "hashed_password1", // Αυτή πρέπει να είναι η κατευθυντήρια αξία
                Create_time = DateTime.Now,
                Salt = "salt1",
                Role = "Customer"
            },
            new User
            {
                Username = "user2",
                Email = "user2@example.com",
                Password = "hashed_password2", // Αυτή πρέπει να είναι η κατευθυντήρια αξία
                Create_time = DateTime.Now,
                Salt = "salt2",
                Role = "ContentAdmin"
            }
            // Προσθέστε άλλους χρήστες αν χρειάζεται
        };
    }

    public List<User> GetAllUsers()
    {
        return _users;
    }

    // Άλλες λειτουργίες όπως προσθήκη, ενημέρωση, διαγραφή κλπ.
}
