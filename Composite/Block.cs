using System;
using System.Collections.Generic;

namespace Composite
{
    class Block : QuestionaryElement
    {
        private List<QuestionaryElement> Elements { get; } = new List<QuestionaryElement>();

        public Block(string description) : base(description) { }

        public Block Add(QuestionaryElement element)
        {
            Elements.Add(element);
            return this;
        }

        public Block Remove(QuestionaryElement element)
        {
            Elements.Remove(element);
            return this;
        }

        public override void Show()
        {
            Console.WriteLine(this.Description);

            Elements.ForEach((item) =>
            {
                item.Show();
            });
        }
    }
}