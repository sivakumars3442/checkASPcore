

namespace Syncfusion.EJ2.FileManager.Base
{
    /// <exclude />
    public interface IAmazonS3MVCFileProviderBase : IFileProviderBase
    {
        void RegisterAmazonS3(string bucketName, string awsAccessKeyId, string awsSecretAccessKey, string bucketRegion);
    }

}
