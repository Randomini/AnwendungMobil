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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DonationStation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public class ClassInstListe : List<Institution> { }
        List<Institution> liste = new ClassInstListe();

        static XmlSerializer serializer;
        static FileStream stream;

        public static ClassInstListe DeserializeObject()
        {
            stream = new FileStream(@"InstiData17.xml", FileMode.Open);
            return (ClassInstListe)serializer.Deserialize(stream);
        }



        public MainPage()
        {
            this.InitializeComponent();

            liste = App.ReadXML<List<Institution>>();

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
