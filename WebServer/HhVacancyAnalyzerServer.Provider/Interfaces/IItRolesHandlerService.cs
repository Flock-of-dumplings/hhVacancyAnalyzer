using HhVacancyAnalyzerServer.Provider.Models;

namespace HhVacancyAnalyzerServer.Provider.Interfaces;

public interface IItRolesHandlerService
{
    IEnumerable<ItRole> GetAllItRoles();
}