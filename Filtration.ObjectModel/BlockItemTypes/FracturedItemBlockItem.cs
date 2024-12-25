using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class FracturedItemBlockItem : BooleanBlockItem
    {
        public FracturedItemBlockItem()
        {
        }

        public FracturedItemBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "FracturedItem";
        public override string DisplayHeading => "FracturedItem";
        public override Color SummaryBackgroundColor => Colors.DarkCyan;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.FracturedItem;
    }
}
