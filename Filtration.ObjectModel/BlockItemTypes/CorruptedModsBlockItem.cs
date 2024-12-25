using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class CorruptedModsBlockItem : NumericFilterPredicateBlockItem
    {
        public CorruptedModsBlockItem()
        {
        }

        public CorruptedModsBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand)
            : base(predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "CorruptedMods";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "CorruptedMods";
        public override string SummaryText => "Corrupted Mods " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.Firebrick;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.CorruptedMods;
        public override int Minimum => 0;
        public override int Maximum => 3;
    }
}
