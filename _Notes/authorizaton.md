## Authentication vs Authorization

    Authentication is the process of verifying who you are. 
    Authorization is the process of verifying what you can do.

    Authentication method:  session/cookies, tokens, signatures


## Package reference
    PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="1.1.1"

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
    