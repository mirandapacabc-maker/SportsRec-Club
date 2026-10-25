using Microsoft.Extensions.Logging;
using SportsRec.Club.Interfaces;

namespace SportsRec.Club.Services
{
    public class CourtManager : ICourtManager
    {
        private readonly ILogger<CourtManager> _logger;

        public CourtManager(ILogger<CourtManager> logger)
        {
            _logger = logger;
        }

        public void InitializeFacilitySchedule()
        {
            _logger.LogInformation("Horarios de canchas y áreas recreativas del club cargados en la web.");
        }
    }
}