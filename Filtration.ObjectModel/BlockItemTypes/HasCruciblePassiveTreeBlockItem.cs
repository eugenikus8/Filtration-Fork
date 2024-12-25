using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class HasCruciblePassiveTreeBlockItem : BooleanBlockItem
    {
        public HasCruciblePassiveTreeBlockItem()
        {
        }

        public HasCruciblePassiveTreeBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "HasCruciblePassiveTree";
        public override string DisplayHeading => "Crucible";
        public override Color SummaryBackgroundColor => Colors.DarkOrange;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.HasCruciblePassiveTree;
    }
}
