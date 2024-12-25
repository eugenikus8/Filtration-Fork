using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class MinimalBlockItem : NilBlockItem
    {
        public MinimalBlockItem() : base()
        {
        }

        public override string PrefixText => "Minimal";
        public override string DisplayHeading => "Minimal";
        public override string Description => "MinSizeNoBackgroundOnlyInRuthlessFilters";
        public override Color SummaryBackgroundColor => Colors.Orchid;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Minimal;
    }
}
