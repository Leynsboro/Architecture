﻿namespace Assets.Visitor
{
    public interface IEnemyVisitor
    {
        void Visit(Elf elf);
        void Visit(Human human);
        void Visit(Ork ork);
        void Visit(Robot robot);
    }
}
