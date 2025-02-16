﻿using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.Interfaces;
using CleanArchitectureDemo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
namespace CleanArchitectureDemo.Infrastructure;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users.Include(u => u.Orders).ToListAsync();
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _context.Users.Include(u => u.Orders).FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
