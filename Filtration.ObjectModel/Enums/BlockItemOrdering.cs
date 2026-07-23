using System.ComponentModel;

namespace Filtration.ObjectModel.Enums
{
    public enum BlockItemOrdering
    {
        //[en] Block ordering in Filtration
        //[ru] Порядок блоков в Filtration
        Action,
        Minimal,
        Identified,
        Corrupted,
        CorruptedMods,
        AlwaysShow, //POE2
        UnidentifiedItemTier, //POE2
        TwiceCorrupted, //POE2
        HasVaalUniqueMod, //POE2
        IsVaalUnique, //POE2
        Foulborn, //3.27
        HasCruciblePassiveTree,
        Mirrored,
        Replica,
        Scourged,
        AreaLevel,
        DropLevel,
        ItemLevel,
        Rarity,
        Class,
        BaseType,
        Quality,
        StackSize,
        LinkedSockets,
        Sockets,
        SocketGroup,
        Height,
        Width,
        SynthesisedItem,
        FracturedItem,
        MirageMap, //3.29 ???
        MapTier,
        WaystoneTier, //POE2
        BligtedMap,
        UberBlightedMap,
        GemLevel,
        AlternateQuality,
        TransfiguredGem,
        ZanaMemory, //3.26
        MemoryStrands, //3.26
        Imbued, //3.28
        Vestigial, //3.29
        HasImplicitMod,
        HasExplicitMod,
        AnyEnchantment,
        HasEnchantment,
        HasEaterOfWorldsImplicit,
        HasSearingExarchImplicit,
        HasInfluence,
        EnchantmentPassiveNum,
        EnchantmentPassiveNode,
        BaseDefencePercentile,
        BaseArmour,
        BaseEvasion,
        BaseEnergyShield,
        BaseWard,
        SetTextColor,
        SetBackgroundColor,
        SetBorderColor,
        SetFontSize,
        PlayAlertSound,
        PlayAlertSoundPositional,
        DisableDropSound,
        MinimapIcon,
        PlayEffect,
        CustomAlertSound,
        Continue,
    }
}
