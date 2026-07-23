using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class MirageMapBlockItem : BooleanBlockItem
    {
        public MirageMapBlockItem()
        {
        }

        public MirageMapBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "MirageMap";
        public override string DisplayHeading => "MirageMap";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.MirageMap;
    }
}