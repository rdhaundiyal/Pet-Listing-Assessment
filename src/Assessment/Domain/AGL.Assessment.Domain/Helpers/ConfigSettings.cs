using AGL.Components.Helpers;

namespace AGL.Assessment.Domain.Helpers
{
 public static  class ConfigSettings
    {
     public static string PeopleServiceUri { get { return ConfigHelper.GetValue<string>("PeopleService"); } }
     public static string BaseUrl { get { return ConfigHelper.GetValue<string>("BaseUrl"); } }
     public static string GeneralExceptionMessage { get { return ConfigHelper.GetValue<string>("GeneralExceptionMessage"); } }
    }
}
