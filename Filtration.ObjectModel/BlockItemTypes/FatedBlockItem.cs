using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class FatedBlockItem : BooleanBlockItem
    {
        public FatedBlockItem()
        {
        }

        public FatedBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Fated";
        public override string DisplayHeading => "Fated";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Fated;
    }
}