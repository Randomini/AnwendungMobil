using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Xml;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DonationStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //public class ClassInstListe : List<Institution> { }
        //static ClassInstListe liste = new ClassInstListe();
        //List<Institution> liste = new ClassInstListe();
        static List<Institution> liste = new List<Institution> { };
        public const string datei = "D:\\InstiData17.xml";

        //  static XmlSerializer serializer;
        static XmlSerializer serializer = new XmlSerializer(typeof(List<Institution>));
        static FileStream stream;

        public static async Task<List<Institution>> DeserializeObject()

        {
            List<Institution> tmp = new List<Institution>();
            await Task.Run(() =>
            {

                stream = new FileStream(@"D:\InstiData17.xml", FileMode.Open);

                //liste = (ClassInstListe)serializer.Deserialize(stream);
                List<Institution> liste = new List<Institution>((IEnumerable<Institution>)serializer.Deserialize(stream));
                stream.Dispose();
                return;
            });
            return liste;
        }



        public MainPage()
        {
            this.InitializeComponent();

            liste = Storagehelper.ReadXML(datei).Result;
            //Storagehelper.ReadXML("InstiData17.xml");


        }





        private void button_Click(object sender, RoutedEventArgs e)
        {


            foreach (Institution tmpinst in liste)
            {
                
                textBlock.Text += tmpinst.Name;
                textBlock.Text += tmpinst.Arbeit;
            }
        }
    }
}
