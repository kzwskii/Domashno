using RegisterSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RegisterSystem.Repository;

public class UserRepository : IUserRepository
{
    public void Add(User entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        using UserContext db = new();
        db.Users.Add(entity);
        db.SaveChanges();
    }

    public void Delete(int id)
    {
        using UserContext db = new();
        var userToRemove = db.Users.Find(id);
        if (userToRemove == null)
        {
            return;
        }

        db.Users.Remove(userToRemove);
        db.SaveChanges();
    }

    public List<User> GetAll()
    {
        using UserContext db = new();
        return db.Users.AsNoTracking().ToList();
    }

    public User GetById(int id)
    {
        using UserContext db = new();
        return db.Users.AsNoTracking().FirstOrDefault(u => u.UserId == id);
    }

    public void Update(int id)
    {
        throw new NotSupportedException("Update(int id) is not supported. Use Update(User entity) overload to update a user.");
    }

    public void Update(User entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        using UserContext db = new();
        var existing = db.Users.Find(entity.UserId);
        if (existing == null)
        {
            throw new InvalidOperationException($"User with id {entity.UserId} not found.");
        }
        db.Entry(existing).CurrentValues.SetValues(entity);
        db.SaveChanges();
    }

}
