using AutoMapper;
using JopipediaAPI.Data.Context;
using JopipediaAPI.Data.DTO.UserRole;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace JopipediaAPI.Data.Service;

public class UserRoleService : IUserRoleService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;

    public UserRoleService(AppDbContext context, IMapper mapper, IConfiguration configuration)
    {
        _context = context;
        _mapper = mapper;
        _configuration = configuration;
    }


    async public Task<ServiceResponse<List<UserRoleDTO>>> GetAll()
    {
        // Get all user roles
        var userRoles = await _context.UserRoles.ToListAsync();
        return ServiceResponse<List<UserRoleDTO>>
            .Success(userRoles.Select(ur => _mapper.Map<UserRoleDTO>(ur))
                .ToList());
    }

    async public Task<ServiceResponse<UserRoleDTO>> GetById(Guid id)
    {
        //Get user role by id
        var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.Id == id);
        //Check if user role is not found
        if (userRole == null)
        {
            return ServiceResponse<UserRoleDTO>.NotFound("notFound","User Role not found");
        }

        return ServiceResponse<UserRoleDTO>.Success(_mapper.Map<UserRoleDTO>(userRole));
    }

    async public Task<ServiceResponse<UserRoleDTO>> Create(UserRoleDTO userRole)
    {
        //Create new user role Model from DTO
        var newUserRole = _mapper.Map<UserRole>(userRole);
        //Add new user role to database
        await _context.UserRoles.AddAsync(newUserRole);
        //Save changes
        await _context.SaveChangesAsync();
        //Map the new user role to DTO
        var data = _mapper.Map<UserRoleDTO>(newUserRole);
        //Return the new user role DTO
        return ServiceResponse<UserRoleDTO>.Success(data);
    }

    async public Task<ServiceResponse<UserRoleDTO>> Update(Guid id, UserRoleDTO userRole)
    {
        //Get user role to update
        var userRoleToUpdate = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.Id == id);
        //Check if user role is not found
        if (userRoleToUpdate == null)
        {
            return ServiceResponse<UserRoleDTO>.NotFound("notFound","User Role not found");
        }
        userRole.Id = id;
        //Map the updated user role to the user role model
        _mapper.Map(userRole, userRoleToUpdate);
        //Save changes
        await _context.SaveChangesAsync();
        //Map the updated user role to DTO
        var data = _mapper.Map<UserRoleDTO>(userRoleToUpdate);
        //Return the updated user role DTO
        return ServiceResponse<UserRoleDTO>.Success(data);
    }
}