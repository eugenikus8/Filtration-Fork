using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class ZanaMemoryBlockItem : BooleanBlockItem
    {
        public ZanaMemoryBlockItem()
        {
        }

        public ZanaMemoryBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "ZanaMemory";
        public override string DisplayHeading => "ZanaMemory";
        public override Color SummaryBackgroundColor => Colors.MediumVioletRed;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.ZanaMemory;
    }
}