## Authentication vs Authorization

    Authentication is the process of verifying who you are. 
    Authorization is the process of verifying what you can do. Any authenticated user might have their own set of permissions

    Authentication method:  session/cookies, tokens, signatures


## Update project
    PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="1.1.1"
    
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    Change the base class from DbContext to IdentityDbContext<ApplicationUser>:

    Remove the DbSet<ApplicationUser> Users property, as the IdentityDbContext base class already has it built in



## Service configration
public void ConfigureServices(IServiceCollection services)
{
    // Add Identity
    services.AddIdentity<ApplicationUser, IdentityRole>().
        AddEntityFrameworkStores<ApplicationDBContext>();

}
## UI Authorization
@using Microsoft.AspNetCore.Identity
@inject SignInManager<ApplicationUser> SignInManager

// Show / hide menu
@if(SignInManager.IsSignedIn(User))
{
}
else
{
}
    