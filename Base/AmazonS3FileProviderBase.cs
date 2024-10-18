

namespace Syncfusion.EJ2.FileManager.Base
{
    /// <exclude />
    public interface IAmazonS3FileProviderBase : IFileProviderBase
    {
        void RegisterAmazonS3(string bucketName, string awsAccessKeyId, string awsSecretAccessKey, string bucketRegion);
    }

}
