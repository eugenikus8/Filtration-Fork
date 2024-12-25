using System.Windows.Media;
using Filtration.ObjectModel.BlockItemBaseTypes;
using Filtration.ObjectModel.Enums;

namespace Filtration.ObjectModel.BlockItemTypes
{
    public sealed class TransfiguredGemBlockItem : BooleanBlockItem
    {
        public TransfiguredGemBlockItem()
        {
        }

        public TransfiguredGemBlockItem(bool booleanValue) : base(booleanValue)
        {
        }

        public override string PrefixText => "TransfiguredGem";
        public override string DisplayHeading => "TransfiguredGem";
        public override Color SummaryBackgroundColor => Colors.GreenYellow;
        public override Color SummaryTextColor => Colors.Black;
        public override BlockItemOrdering SortOrder => BlockItemOrdering.TransfiguredGem;
    }
}
