using PhlegmaticOne.ApiRequesting.Models.Requests;
using PhlegmaticOne.InnoGotchi.Shared.Statistics;

namespace PhlegmaticOne.InnoGotchi.Web.Requests.Overviews;

public class GetCollaboratedFarmStatisticsRequest : EmptyClientGetRequest<IList<PreviewFarmStatisticsDto>>
{
}