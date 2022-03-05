using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();
            CreateMap<Usuario, CustomIdentityUser>();
        }

        private void CustomIdentityUser()
        {
            throw new NotImplementedException();
        }
    }
}
