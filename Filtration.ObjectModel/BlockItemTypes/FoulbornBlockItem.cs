using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class FoulbornBlockItem : BooleanBlockItem
    {
        public FoulbornBlockItem()
        {
        }

        public FoulbornBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Foulborn";
        public override string DisplayHeading => "Foulborn";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Foulborn;
    }
}