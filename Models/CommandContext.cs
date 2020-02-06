using Microsoft.EntityFrameworkCore;
/*  settum eftirfarandi inn í CmdApi.csproj skrána til að þetta using directive að ofan virkaði, örugglega ekki rétt 
    leiðin til að gera þetta því ég er að blanda saman 2.2 leiðinni og 3.1 leiðinni, en kann bara ekki að fá þetta 
    í lag öðruvísi, fáum líka 2 viðvaranir núna þegar gert er : dotnet build sem komu þegar þessu var bætt við.
    *** Uppfærsla ***
    Nú keyrði ég eftirfarandi skipun úr terminalinu : dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.1
    og þýddi/buildaði aftur og fékk þá engar viðvaranir. Þannig að þetta virðist hafa verið það sem þurfti. Fékk þetta frá : 
    https://docs.microsoft.com/en-us/ef/core/providers/index?tabs=dotnet-core-cli
    og svo valdi ég Microsoft.EntityFrameworkCore.SqlServer og fór þá inn á : https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer
    og þar fann ég skipunina.
*/
namespace CmdApi.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        {

        }

        public DbSet<Command> CommandItems {get; set;}
        
    }
}