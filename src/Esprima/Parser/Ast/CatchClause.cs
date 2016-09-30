namespace Esprima.Ast
{
    public class CatchClause : Node, Statement
    {
        public ArrayPatternElement Param; // BindingIdentifier | BindingPattern;
        public BlockStatement Body;

        public CatchClause(ArrayPatternElement param, BlockStatement body)
        {
            Type = Nodes.CatchClause;
            Param = param;
            Body = body;
        }
    }
}