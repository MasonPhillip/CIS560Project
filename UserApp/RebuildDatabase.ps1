Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "MovieDatabase"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\DropDatabase.ps1" -Database $Database
& ".\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Schemas\Movie.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.Users.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.Genres.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.Studios.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.People.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.Movies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.Roles.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Tables\Movie.PersonalRatings.sql"


Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.AverageCostProductionByGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.AverageStudioProfitByGenre.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreateMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreatePeople.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreatePersonalRatings.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreateRole.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreateStudio.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.CreateUsers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.HighestPaidWithin.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.RatingCompareByMovieName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.SaveMovie.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.SavePersonalRating.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.SaveRole.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Procedures\Movie.SaveUser.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Data\Movie.Genres.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Data\Movie.Studios.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Data\Movie.People.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Data\Movie.Movies.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "WindowsFormsApp1\Sql\Data\Movie.Roles.sql"


Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
