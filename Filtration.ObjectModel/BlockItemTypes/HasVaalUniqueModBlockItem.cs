using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class HasVaalUniqueModBlockItem : BooleanBlockItem
    {
        public HasVaalUniqueModBlockItem()
        {
        }

        public HasVaalUniqueModBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "HasVaalUniqueMod";
        public override string DisplayHeading => "HasVaalUniqueMod(POE2)";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasVaalUniqueMod;
    }
}