using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class UberBlightedMapBlockItem : BooleanBlockItem
    {
        public UberBlightedMapBlockItem()
        {
        }

        public UberBlightedMapBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "UberBlightedMap";
        public override string DisplayHeading => "UberBlightedMap";
        public override Color SummaryBackgroundColor => Colors.DarkKhaki;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.UberBlightedMap;
    }
}
