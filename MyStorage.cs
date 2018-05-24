using System;
using System.IO;
using System.Xml.Serialization;
using Windows.ApplicationModel;
using Windows.Storage;

namespace DonationStation
{
    public class MyStorage
    {
        public static void storeXML<T>(T data, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream;
            stream = new FileStream(filename, FileMode.Create);
            serializer.Serialize(stream, data);
        }

        internal static T readXML<T>(string filename)
        {
            try
            {
                ////FileStream stream;
                ////stream = new FileStream(filename, FileMode.Open);
                //StorageFile file = StorageFile.GetFileFromPathAsync(Windows.ApplicationModel.Package.Current.InstalledLocation.Path + filename).GetResults();
                ////StreamReader test = new StreamReader(file.OpenStreamForReadAsync().Result);
                //using (StreamReader sr = new StreamReader(file.OpenStreamForReadAsync().Result))
                //{
                //    XmlSerializer serializer = new XmlSerializer(typeof(T));
                //    return (T)serializer.Deserialize(sr);
                //}
                string path = Path.Combine(Package.Current.InstalledLocation.Path, filename);
                XDocument loadedData = XDocument.Load(path);
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occurred: '{0}'", e);
                return default(T);
            }
        }
    }
}