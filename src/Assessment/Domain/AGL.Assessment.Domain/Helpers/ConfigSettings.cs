using AGL.Components.Helpers;

namespace AGL.Assessment.Domain.Helpers
{
 public static  class ConfigSettings
    {
     public static string PeopleServiceUri { get { return ConfigHelper.GetValue<string>("PeopleService"); } }
    }
}
