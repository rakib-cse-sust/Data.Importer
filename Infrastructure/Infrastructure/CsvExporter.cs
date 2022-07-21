using Application.Contracts.Infrastructure;
using Application.Models;

namespace Infrastructure.Infrastructure
{
    public class CsvImporter : ICsvImporter
    {
        public ImportDataCollection GetImportedData(string filePath)
        {
            return new ImportDataCollection();
        }
    }
}