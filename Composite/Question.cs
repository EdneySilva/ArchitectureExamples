using System;

namespace Composite
{
    class Question : QuestionaryElement
    {
        public Question(string description) : base(description) { }

        public override void Show()
        {
            Console.WriteLine(this.Description);
        }
    }
}