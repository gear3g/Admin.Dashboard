namespace Admin.Dashboard.Common.Logging
{
    public interface IRequestCorrelationIdentifier
    {
        string CorrelationID { get; }
    }
}