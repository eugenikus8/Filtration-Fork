using System;
using System.ComponentModel;

namespace Filtration.ObjectModel.Enums
{
    [Serializable]
    public enum SocketColor
    {
        [Description("R")]
        Red,
        [Description("G")]
        Green,
        [Description("B")]
        Blue,
        [Description("W")]
        White,
        [Description("A")]
        Abyss,
        [Description("D")]
        Delve
    }
}
