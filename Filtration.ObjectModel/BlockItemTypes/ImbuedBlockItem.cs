using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class ImbuedBlockItem : BooleanBlockItem
    {
        public ImbuedBlockItem()
        {
        }

        public ImbuedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Imbued";
        public override string DisplayHeading => "Imbued";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Imbued;
    }
}