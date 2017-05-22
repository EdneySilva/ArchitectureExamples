namespace Composite
{
    /// <summary>
    /// This is the component, the common interface, contains the general definition 
    /// </summary>
    abstract class QuestionaryElement
    {
        protected string Description { get; set; }

        public QuestionaryElement(string description)
        {
            Description = description;
        }

        public abstract void Show();
    }
}