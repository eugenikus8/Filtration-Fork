using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class ContinueBlockItem : NilBlockItem
    {
        public ContinueBlockItem() : base()
        {
        }

        public override string PrefixText => "Continue";
        public override string DisplayHeading => "Continue";
        public override string Description => "NotStopWhenItemMatchesThisBlock";
        public override Color SummaryBackgroundColor => Colors.Orchid;
        public override Color SummaryTextColor => Colors.White;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.Continue;
    }
}
