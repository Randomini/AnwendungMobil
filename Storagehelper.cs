using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DonationStation
{
    internal class Storagehelper
    {
        internal static async Task<List<Institution>> ReadXML(string datei)
        {
            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(datei);
            var stream = await file.OpenReadAsync();
            var rdr = new StreamReader(stream.AsStream());
            var contents = await rdr.ReadToEndAsync();
            XmlReader reader = XmlReader.Create(new StringReader(contents));
            XmlSerializer serializer = new XmlSerializer(typeof(List<Institution>));
            var daten = (List<Institution>)serializer.Deserialize(reader);
            reader.Dispose();
            return daten;
        }


    }

  
}