﻿using System.Collections.Generic;

namespace Filtration.ObjectModel.Commands.ItemFilterScript
{
    public class MoveBlocksToBottomCommand : IUndoableCommand
    {
        private readonly IItemFilterScript _itemFilterScript;
        private readonly List<int> _sourceIndexes;

        public MoveBlocksToBottomCommand(IItemFilterScript itemFilterScript, IItemFilterBlockBase block)
        {
            _itemFilterScript = itemFilterScript;
            _sourceIndexes = new List<int> { _itemFilterScript.ItemFilterBlocks.IndexOf(block) };
        }

        public MoveBlocksToBottomCommand(IItemFilterScript itemFilterScript, List<int> sourceIndexes)
        {
            _itemFilterScript = itemFilterScript;
            _sourceIndexes = sourceIndexes;
            _sourceIndexes.Sort();
        }

        public void Execute()
        {
            List<IItemFilterBlockBase> blocksToMove = new List<IItemFilterBlockBase>();
            for (var i = 0; i < _sourceIndexes.Count; i++)
            {
                blocksToMove.Add(_itemFilterScript.ItemFilterBlocks[_sourceIndexes[i]]);
            }

            for (var i = _sourceIndexes.Count - 1; i >= 0; i--)
            {
                _itemFilterScript.ItemFilterBlocks.RemoveAt(_sourceIndexes[i]);
            }

            foreach (var block in blocksToMove)
            {
                _itemFilterScript.ItemFilterBlocks.Add(block);
            }
        }

        public void Undo()
        {
            List<IItemFilterBlockBase> blocksToMove = new List<IItemFilterBlockBase>();
            for (var i = 0; i < _sourceIndexes.Count; i++)
            {
                var movedIndex = _itemFilterScript.ItemFilterBlocks.Count - _sourceIndexes.Count;
                blocksToMove.Add(_itemFilterScript.ItemFilterBlocks[movedIndex]);
                _itemFilterScript.ItemFilterBlocks.RemoveAt(movedIndex);
            }

            for (var i = 0; i < _sourceIndexes.Count; i++)
            {
                _itemFilterScript.ItemFilterBlocks.Insert(_sourceIndexes[i], blocksToMove[i]);
            }
        }

        public void Redo() => Execute();
    }
}
