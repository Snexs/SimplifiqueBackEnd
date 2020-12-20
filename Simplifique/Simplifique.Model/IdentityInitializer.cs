using Microsoft.AspNetCore.Identity;
using Simplifique.Domain;
using Simplifique.Infra;
using System;

namespace Simplifique.Model
{
    public class IdentityInitializer
    {
        private readonly SimplifiqueContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IdentityInitializer(
            SimplifiqueContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_context.Database.EnsureCreated())
            {
                if (!_roleManager.RoleExistsAsync(Roles.ROLE_API_SIMPLIFIQUE).Result)
                {
                    var resultado = _roleManager.CreateAsync(
                        new IdentityRole(Roles.ROLE_API_SIMPLIFIQUE)).Result;
                    if (!resultado.Succeeded)
                    {
                        throw new Exception(
                            $"Erro durante a criação da role {Roles.ROLE_API_SIMPLIFIQUE}.");
                    }
                }

                CreateUser(
                    new ApplicationUser()
                    {
                        UserName = "admin_simplifique",
                        Email = "adminSimplifique@teste.com.br",
                        EmailConfirmed = true
                    }, "AdminAPIAlturas01!", Roles.ROLE_API_SIMPLIFIQUE);

                CreateUser(
                    new ApplicationUser()
                    {
                        UserName = "usrinvalido_simplifique",
                        Email = "usrinvalido-simplifique@teste.com.br",
                        EmailConfirmed = true
                    }, "UsrInvSimplifique01!");
            }
        }

        private void CreateUser(
            ApplicationUser user,
            string password,
            string initialRole = null)
        {
            if (_userManager.FindByNameAsync(user.UserName).Result == null)
            {
                var resultado = _userManager
                    .CreateAsync(user, password).Result;

                if (resultado.Succeeded &&
                    !String.IsNullOrWhiteSpace(initialRole))
                {
                    _userManager.AddToRoleAsync(user, initialRole).Wait();
                }
            }
        }
    }
}