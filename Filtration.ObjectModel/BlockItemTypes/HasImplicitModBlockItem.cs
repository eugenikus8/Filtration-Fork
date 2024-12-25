using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class HasImplicitModBlockItem : BooleanBlockItem
    {
        public HasImplicitModBlockItem()
        {
        }

        public HasImplicitModBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "HasImplicitMod";
        public override string DisplayHeading => "ImplicitMod";
        public override Color SummaryBackgroundColor => Colors.DarkGray;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasImplicitMod;
    }
}
