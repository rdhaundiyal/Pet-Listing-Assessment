using System.ComponentModel;

namespace AGL.Assessment.Domain.Model
{
    public enum PetType
    {
        [Description("cat")]
        Cat,
        [Description("dog")]
        Dog,
        [Description("fish")]
        Fish
    }
}