## Installation

2. To use yeoman, need Node.js. To install Node.js, need NVM (node version manager)
$ crul -o- https://…../install.sh | bash
restart the terminal
$ nvm ls-remote       # list all version of Node.js
$ nvm install 4.4.7     # install node.js
$ npm install -g npm    # install npm

3. Install packages
$ npm install -g yo bower grunt-cli gulp generator-aspnet

4. Create project
$ yo aspnet

5. Install VS Code
$sudo dpkg -i  XXX.deb
Ctl(CMD)+shit+p


## Add reference
Add dependency in .csproj (.net core 1.1)        
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version= "1.1.1"/>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version= "1.1.1"/>


## Install EF Core Command Line Tools
    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet

