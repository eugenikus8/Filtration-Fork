using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class TwiceCorruptedBlockItem : BooleanBlockItem
    {
        public TwiceCorruptedBlockItem()
        {
        }

        public TwiceCorruptedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "TwiceCorrupted";
        public override string DisplayHeading => "TwiceCorrupted(POE2)";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.TwiceCorrupted;
    }
}