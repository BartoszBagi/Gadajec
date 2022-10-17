using Gadajec.Application.Common.Interfaces;
using Gadajec.Domain.Entities;
using Newtonsoft.Json;
using System.Text;

namespace Gadajec.Infrastructure.FileStore
{
    public class FileStore : IFileStore
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly IFileWrapper _fileWrapper;
        private readonly IDirectoryWrapper _directoryWrapper;

        public FileStore(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper)
        {
            _fileWrapper = fileWrapper;
            _directoryWrapper = directoryWrapper;
        }

        public string SafeWriteFile(byte[] content, string sourceFileName, string path)
        {
            _directoryWrapper.CreateDirectory(path);
            var outputFile = Path.Combine(path, sourceFileName);

            _fileWrapper.WriteAllBytes(outputFile, content);

            return outputFile;
        }

        public bool SafeMessageWrite(string fileName, Message message)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "Messages";
            _directoryWrapper.CreateDirectory(path);
            var outputFile = $"{path}\\{fileName}";
            bool result;
            


            try
            {
                if (!File.Exists(outputFile))
                {
                    var messages = new List<Message>();
                    messages.Add(message);
                    var jsonToOutput = JsonConvert.SerializeObject(messages, Formatting.Indented);
                    _fileWrapper.WriteJsonString(outputFile, jsonToOutput);
                }
                else
                {
                    var messages = JsonConvert.DeserializeObject<List<Message>>(SafeMessageRead(fileName));
                    messages.Add(message);
                    var jsonToOutput = JsonConvert.SerializeObject(messages, Formatting.Indented);
                    _fileWrapper.WriteJsonString(outputFile, jsonToOutput);
                }
                result = true;
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
                       
            return result;
        }

        public string SafeMessageRead(string fileName)
        {
            try
            {
                DirectoryInfo messagesDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "Messages");
                FileInfo[] messages = messagesDirectory.GetFiles("*.json");

                var jsonString = File.ReadAllText(messages.Where(m => m.Name == $"{fileName}").ToString());

                return jsonString;
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
        }
        public static Dictionary<String, Object> parse(byte[] json)
        {
            try
            {
                var reader = new StreamReader(new MemoryStream(json), Encoding.Default);

                Dictionary<String, Object> attachments = new JsonSerializer().Deserialize<Dictionary<string, object>>(new JsonTextReader(reader));

                return attachments;
            }
            catch (Exception ex)
            {
                _logger.Error($"Exception: {ex.Message}");
                throw;
            }
            
        }
    }
}
