using Application.Models;

namespace Application.Contracts.Infrastructure
{
    public interface ICsvImporter
    {
        ImportDataCollection GetImportedData(string filePath);
    }
}
