using System;
using System.Windows.Documents;

namespace XText
{
    public class XLineBreak : XInline
    {
        public XLineBreak() : base(() => null)
        { }

        public XLineBreak(Func<bool> writeIf) : base(writeIf, () => null)
        { }

        protected override Inline BuildElementInternal()
        {
            return new LineBreak();
        }

        public override string ToString()
        {
            return Environment.NewLine;
        }

        public override string ToPlainString()
        {
            return Environment.NewLine;
        }
    }
}