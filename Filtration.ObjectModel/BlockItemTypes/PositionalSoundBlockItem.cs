﻿using Filtration.ObjectModel.BlockItemBaseTypes;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class PositionalSoundBlockItem : DualIntegerBlockItem
    {
        public PositionalSoundBlockItem()
        {
            Value = 1;
            SecondValue = 79;
        }

        public PositionalSoundBlockItem(int value, int secondValue) : base(value, secondValue)
        {
        }

        public override string PrefixText => "PlayAlertSoundPositional";
        public override int MaximumAllowed => 1;
        public override string DisplayHeading => "Play Positional Alert Sound";
        public override int SortOrder => 18;
    }
}
