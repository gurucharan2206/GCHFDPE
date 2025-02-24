namespace GCHFDPE.DecoratingObjects
{
    public abstract class ChangeInputCaseStreamDecorator : TextReader
    {
        protected TextReader _textReader;
        public abstract override string? ReadLine();
    }

    public class UpperCaseInputStream : ChangeInputCaseStreamDecorator
    {
        public UpperCaseInputStream(TextReader textReader)
        {
            this._textReader = textReader;
        }

        public override string? ReadLine()
        {
            return this._textReader.ReadLine()?.ToUpper();
        }
    }
}
