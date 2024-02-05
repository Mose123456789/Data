using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class RoleService
{
    private readonly RoleRepository _roleRepository;

    public RoleService(RoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public RoleEntity CreateRole(string roleName)
    {
        var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);
        roleEntity ??= _roleRepository.Create(new RoleEntity { RoleName = roleName });

        return roleEntity;
    }

    public RoleEntity GetRoleByName(string roleName)
    {
        var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);

        return roleEntity;
    }

    public RoleEntity GetRoleById(int Id)
    {
        var roleEntity = _roleRepository.Get(x => x.Id == Id);

        return roleEntity;
    }

    public IEnumerable<RoleEntity> GetRoles()
    {
        var roles = _roleRepository.GetAll();

        return roles;
    }

    public RoleEntity UpdateRole(RoleEntity roleEntity)
    {
        var updatedroleEntity = _roleRepository.Update(x => x.Id == roleEntity.Id, roleEntity);

        return roleEntity;
    }

    public void DeleteRole(int Id)
    {
        _roleRepository.Delete(x => x.Id == Id);
    }
}