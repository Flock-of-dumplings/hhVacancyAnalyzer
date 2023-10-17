using HhVacancyAnalyzerServer.Provider.Interfaces;
using HhVacancyAnalyzerServer.Provider.Models;

namespace HhVacancyAnalyzerServer.Provider.Services;

public class ItRolesHandlerService : IItRolesHandlerService
{
    private readonly IEnumerable<ItRole> _itRolesData;

    public ItRolesHandlerService()
    {
        _itRolesData = new List<ItRole>
        {
            new()
            {
                Id = "156",
                Name = "BI-аналитик, аналитик данных",
            },
            new()
            {
                Id = "160",
                Name = "DevOps-инженер",
            },
            new()
            {
                Id = "10",
                Name = "Аналитик",
            },
            new()
            {
                Id = "12",
                Name = "Арт-директор, креативный директор",
            },
            new()
            {
                Id = "150",
                Name = "Бизнес-аналитик",
            },
            new()
            {
                Id = "25",
                Name = "Гейм-дизайнер",
            },
            new()
            {
                Id = "165",
                Name = "Дата-сайентист",
            },
            new()
            {
                Id = "34",
                Name = "Дизайнер, художник",
            },
            new()
            {
                Id = "36",
                Name = "Директор по информационным технологиям (CIO)",
            },
            new()
            {
                Id = "73",
                Name = "Менеджер продукта",
            },
            new()
            {
                Id = "155",
                Name = "Методолог",
            },
            new()
            {
                Id = "96",
                Name = "Программист, разработчик",
            },
            new()
            {
                Id = "164",
                Name = "Продуктовый аналитик",
            },
            new()
            {
                Id = "104",
                Name = "Руководитель группы разработки",
            },
            new()
            {
                Id = "157",
                Name = "Руководитель отдела аналитики",
            },
            new()
            {
                Id = "107",
                Name = "Руководитель проектов",
            },
            new()
            {
                Id = "112",
                Name = "Сетевой инженер",
            },
            new()
            {
                Id = "113",
                Name = "Системный администратор",
            },
            new()
            {
                Id = "148",
                Name = "Системный аналитик",
            },
            new()
            {
                Id = "114",
                Name = "Системный инженер",
            },
            new()
            {
                Id = "116",
                Name = "Специалист по информационной безопасности",
            },
            new()
            {
                Id = "121",
                Name = "Специалист технической поддержки",
            },
            new()
            {
                Id = "124",
                Name = "Тестировщик",
            },
            new()
            {
                Id = "125",
                Name = "Технический директор (CTO)",
            },
            new()
            {
                Id = "126",
                Name = "Технический писатель",
            }
        };
    }

    public IEnumerable<ItRole> GetAllItRoles()
    {
        return _itRolesData;
    }
}