using Microsoft.AspNetCore.Identity;
using ShoeShop.Models;

namespace ShoeShop.Data.Seeder
{
    public class UserSeeder
    {
        public UserSeeder(IApplicationBuilder applicationBuilder) {
            UsersAsync(applicationBuilder).Wait();
        }
        public async Task UsersAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                var adminUser = await userManager.FindByEmailAsync("phanbathien700@gmail.com");
                if (adminUser == null)
                {
                    var address = new List<Address>
                    {
                        new Address
                        {
                            FullName = "Nguyen Van A",
                            Phone = "0387913347",
                            Email = "phanbathien700@gmail.com",
                            SpecificAddress = "205 Tran Hung Dao B, Phuong 10, Quan 5",
                            IsDefault = true
                        },
                        new Address
                        {
                            FullName = "Nguyen Van B",
                            Phone = "0369765342",
                            Email = "transinh342@gmail.com",
                            SpecificAddress = "An Duc, Hoai An, Binh Dinh"
                        }
                    };
                    var newAdminUser = new AppUser()
                    {
                        FullName = "Phan Ba Thien",
                        UserName = "phanbathien",
                        Email = "phanbathien700@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/45101901?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
                        Addresses = address,
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                var appUser = await userManager.FindByEmailAsync("trankimanh@gmail.com");
                if (appUser == null)
                {
					var address = new List<Address>
					{
						new Address
						{
							FullName = "Nguyen Van A",
							Phone = "0387913347",
							Email = "hgba@gmail.com",
							SpecificAddress = "Tan Binh",
							IsDefault = true
						},
						new Address
						{
							FullName = "Nguyen Van B",
							Phone = "0369765342",
							Email = "hga@gmail.com",
							SpecificAddress = "An Duc, Hoai An, Binh Dinh"
						}
					};
					var newAppUser = new AppUser()
                    {
                        FullName = "Trần Kim Anh",
                        UserName = "trankimanh",
                        Email = "trankimanh@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/120194990?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
						Addresses = address,
					};
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.Admin);
                }

                var appUser1 = await userManager.FindByEmailAsync("thien@gmail.com");
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        FullName = "Bá Thiên",
                        UserName = "bathien",
                        Email = "thien@gmail.com",
                        EmailConfirmed = true,
                        PhoneNumber = "0123456789",
                        ProfileImageUrl = "https://avatars.githubusercontent.com/u/120194990?v=4",
                        Status = true,
                        Gender = 0,
                        BirthDay = DateTime.Now,
					};
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.Admin);
                }
            }
        }
    }
}
