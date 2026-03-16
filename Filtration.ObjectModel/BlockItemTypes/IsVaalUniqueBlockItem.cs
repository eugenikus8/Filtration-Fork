using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class IsVaalUniqueBlockItem : BooleanBlockItem
    {
        public IsVaalUniqueBlockItem()
        {
        }

        public IsVaalUniqueBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "IsVaalUnique";
        public override string DisplayHeading => "IsVaalUnique(POE2)";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.IsVaalUnique;
    }
}