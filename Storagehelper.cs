using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Windows.Storage;

namespace DonationStation
{
    internal class Storagehelper
    {
        internal static async Task<List<Institution>> ReadXML(string datei)
        {
            try
            {
                StorageFile file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(datei);
                Stream stream = await file.OpenStreamForReadAsync();
                var rdr = new StreamReader(stream);
                var contents = await rdr.ReadToEndAsync();
                XmlReader reader = XmlReader.Create(new StringReader(contents));
                XmlSerializer serializer = new XmlSerializer(typeof(List<Institution>));
                var daten = (List<Institution>)serializer.Deserialize(reader);
                reader.Dispose();
                return daten;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return default(List<Institution>);
            }
        }


    }

  
}