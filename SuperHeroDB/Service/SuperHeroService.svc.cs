using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace SuperHeroDB.Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SuperHeroService
    {
        [OperationContract,WebGet(ResponseFormat =WebMessageFormat.Json)]
       public List<SuperHero> GetAllHeroes()
        {
            return Data.SuperHeroes;
        }
    }
}
