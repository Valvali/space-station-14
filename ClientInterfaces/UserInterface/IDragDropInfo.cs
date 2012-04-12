﻿using ClientInterfaces.GOC;
using GorgonLibrary.Graphics;

namespace ClientInterfaces.UserInterface
{
    public interface IDragDropInfo
    {
        IEntity DragEntity { get; }
        IPlayerAction DragAction { get; }
        Sprite DragSprite { get; }
        bool IsEntity { get; }
        bool IsActive { get; }
        double Duration { get; }

        void Reset();

        void StartDrag(IEntity entity);
        void StartDrag(IPlayerAction action);
    }
}