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
        AlwaysShow, //poe2
        UnidentifiedItemTier, //poe2
        TwiceCorrupted, //poe2
        HasVaalUniqueMod, //poe2
        IsVaalUnique, //poe2
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
        MapTier,
        WaystoneTier, //poe2
        BligtedMap,
        UberBlightedMap,
        GemLevel,
        AlternateQuality,
        TransfiguredGem,
        ZanaMemory, //3.26
        MemoryStrands, //3.26
        Foulborn, //3.27
        Imbued, //3.28
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
