using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class AlwaysShowBlockItem : BooleanBlockItem
    {
        public AlwaysShowBlockItem()
        {
        }

        public AlwaysShowBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "AlwaysShow";
        public override string DisplayHeading => "AlwaysShow(POE2)";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.AlwaysShow;
    }
}