

namespace Syncfusion.EJ2.FileManager.Base
{
    /// <exclude />
    public interface IFirebaseRealtimeFileProviderBase : IFileProviderBase
    {
        void RegisterFirebaseRealtimeDB(string apiUrl, string rootNode, string serviceAccountKeyPath);
    }

}
