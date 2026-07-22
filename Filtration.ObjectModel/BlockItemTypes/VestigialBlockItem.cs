using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class VestigialBlockItem : BooleanBlockItem
    {
        public VestigialBlockItem()
        {
        }

        public VestigialBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "Vestigial";
        public override string DisplayHeading => "Vestigial";
        public override Color SummaryBackgroundColor => Colors.Purple;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Vestigial;
    }
}