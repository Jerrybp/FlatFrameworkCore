using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flat.Application.DepartmentApp.Dtos;
using Flat.Application.MenuApp.Dtos;
using Flat.Application.RoleApp.Dtos;
using Flat.Application.UserApp.Dtos;
using Flat.Domain.Entities;
using AutoMapper;

namespace Flat.Application
{
    /// <summary>
    /// Enity与Dto映射
    /// </summary>
    public class FlatMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Menu, MenuDto>();
                cfg.CreateMap<MenuDto, Menu>();
                cfg.CreateMap<Department, DepartmentDto>();
                cfg.CreateMap<DepartmentDto, Department>();
                cfg.CreateMap<RoleDto, Role>();
                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleMenuDto, RoleMenu>();
                cfg.CreateMap<RoleMenu, RoleMenuDto>();
                cfg.CreateMap<UserDto, User>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserRoleDto, UserRole>();
                cfg.CreateMap<UserRole, UserRoleDto>();
            });
        }
    }
}
