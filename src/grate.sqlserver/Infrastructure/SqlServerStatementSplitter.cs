using grate.Infrastructure;

namespace grate.SqlServer.Infrastructure;

public class SqlServerStatementSplitter : RegexStatementSplitter
{
    protected override string StringsRegex => @"(?<KEEP1>'[^']*')";
    protected override string DashCommentsRegex => @"(?<KEEP1>--.*$)";
    protected override string StarCommentsRegex => @"(?<KEEP1>/\*[\S\s]*?\*/)";
    protected override string SeparatorRegex => @"(?<KEEP1>^|\s)(?<BATCHSPLITTER>GO)(?<KEEP2>\s|;|$)";
}
