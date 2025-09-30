using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public class MemoryStrandsBlockItem : NumericFilterPredicateBlockItem
    {
        public MemoryStrandsBlockItem()
        {
        }

        public MemoryStrandsBlockItem(FilterPredicateOperator predicateOperator, int predicateOperand)
            : base(predicateOperator, predicateOperand)
        {
        }

        public override string PrefixText => "MemoryStrands";
        public override int MaximumAllowed => 2;
        public override string DisplayHeading => "MemoryStrands";
        public override string SummaryText => "Memory Strands " + FilterPredicate;
        public override Color SummaryBackgroundColor => Colors.Aqua;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.MemoryStrands;
        public override int Minimum => 0;
        public override int Maximum => 100;
    }
}
