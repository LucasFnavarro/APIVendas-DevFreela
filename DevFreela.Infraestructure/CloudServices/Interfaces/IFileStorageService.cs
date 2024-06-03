namespace DevFreela.Infraestructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
