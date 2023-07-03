using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Xml;
using WebGIS.EfCore;
using WebGIS.Model;

namespace WebGIS.Parser
{
    public class GmlParserService
    {

        public static List<object> GmlParser(string fileContents)
        {

            List<object> updatedFeatures = new List<object>();
            // Load the XML content
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(fileContents);

            // Select all "NACINI_UPORABE" elements
            XmlNodeList nodeList = null;
            nodeList = doc.SelectNodes("//jis:ANO_CESTICE", GetNamespaceManager(doc));

            int i = 0;
            while (nodeList.Count == 0)
            {
                i++;
                string result = GetSpecificNode(i);
                nodeList = doc.SelectNodes(result, GetNamespaceManager(doc));
            }

            updatedFeatures = ParseGml(nodeList, i);

            return updatedFeatures;
 
        }



        public static List<object> ParseGml(XmlNodeList list, int designator)
        {
            List<object> updatedFeatures = new List<object>();

            switch (designator)
            {
                case 0:
                    updatedFeatures.AddRange(ParseAnoCestice(list));
                    break;
                case 1:
                    updatedFeatures.AddRange(ParseCestice(list));
                    break;
                case 2:
                    updatedFeatures.AddRange(ParseNaciniUporabe(list));
                    break;
                case 3:
                    updatedFeatures.AddRange(ParseCesticeZgrade(list));
                    break;
                case 4:
                    updatedFeatures.AddRange(ParseIdentifikacije(list));
                    break;
                case 5:
                    updatedFeatures.AddRange(ParseMedjeCestica(list));
                    break;
                default:
                    updatedFeatures.AddRange(ParseKatastarskeOpcine(list));
                    break;
            }

            return updatedFeatures;
        }



        public static List<CesticeZgradeModel> ParseCesticeZgrade(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<CesticeZgradeModel> objects = new List<CesticeZgradeModel>();
            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                CesticeZgradeModel obj = new CesticeZgradeModel();

                // Parse and store the data from XML into the object
                obj.CesticaId = GetElementValue(node, "jis:CESTICA_ID");
                obj.ZgradaId = GetElementValue(node, "jis:ZGRADA_ID");              

                // Add the object to the list
                objects.Add(obj);
            }

            return objects;
        }

        public static List<IdentifikacijeModel> ParseIdentifikacije(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<IdentifikacijeModel> objects = new List<IdentifikacijeModel>();
            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                IdentifikacijeModel obj = new IdentifikacijeModel();

                // Parse and store the data from XML into the object
                obj.MaticniBrojKo = GetElementValue(node, "jis:MATICNI_BROJ_KO");
                obj.CesticaId = GetElementValue(node, "jis:CESTICA_ID");
                obj.BrojCestice = GetElementValue(node, "jis:BROJ_CESTICE");
                obj.ZkCesticaId = GetElementValue(node, "jis:ZK_CESTICA_ID");
                obj.BrojZkCestice = GetElementValue(node, "jis:BROJ_ZK_CESTICE");
                obj.PodbrojZkCestice = GetElementValue(node, "jis:PODBROJ_ZK_CESTICE");
                obj.GlavnaKnjigaId = GetElementValue(node, "jis:GLAVNA_KNJIGA_ID");
                obj.OznakaVezeCestice = GetElementValue(node, "jis:OZNAKA_VEZE_CESTICE");
                obj.OznakaVezeZkCestice = GetElementValue(node, "jis:OZNAKA_VEZE_ZK_CESTICE");
                obj.Verificirano = GetElementValue(node, "jis:VERIFICIRANO");

                // Add the object to the list
                objects.Add(obj);
            }

            return objects;
        }

        // Rest of the method
        public static List<KatastarskeOpcineModel> ParseKatastarskeOpcine(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<KatastarskeOpcineModel> objects = new List<KatastarskeOpcineModel>();

            // Iterate through each "VRSTA_KATASTARSKE_OPCINE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                KatastarskeOpcineModel obj = new KatastarskeOpcineModel();

                // Parse and store the data from XML into the object
                obj.KatastarskaOpcinaId = GetElementValue(node, "jis:VRSTA_KATASTARSKE_OPCINE_ID");
                obj.MaticniBrojKo = GetElementValue(node, "jis:MATICNI_BROJ_KO");
                obj.VrstaKatastarskeOpcine = GetElementValue(node, "jis:VRSTA_KATASTARSKE_OPCINE");

                // Add the object to the list
                objects.Add(obj);
            }

            // Return the list of objects
            return objects;
        }

        public static List<MedjeCesticaModel> ParseMedjeCestica(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<MedjeCesticaModel> objects = new List<MedjeCesticaModel>();

            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                MedjeCesticaModel obj = new MedjeCesticaModel();

                // Parse and store the data from XML into the object
                obj.MedjaCesticeId = GetElementValue(node, "jis:MEDJA_CESTICE_ID");
                obj.MaticniBrojKo = GetElementValue(node, "jis:MATICNI_BROJ_KO");
                obj.Broj = GetElementValue(node, "jis:BROJ");

                // Add the object to the list
                objects.Add(obj);
            }

            // Return the list of objects
            return objects;
        }

        public static List<CesticeModel> ParseCestice(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<CesticeModel> objects = new List<CesticeModel>();

            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                CesticeModel obj = new CesticeModel();

                // Parse and store the data from XML into the object
                obj.CesticaId = GetElementValue(node, "jis:CESTICA_ID");
                obj.MaticniBrojKo = GetElementValue(node, "jis:MATICNI_BROJ_KO");
                obj.BrojCestice = GetElementValue(node, "jis:BROJ_CESTICE");
                obj.PovrsinaGraficka = GetElementValue(node, "jis:POVRSINA_GRAFICKA");
                obj.PovrsinaAtributna = GetElementValue(node, "jis:POVRSINA_ATRIBUTNA");
                obj.AdresaOpisna = GetElementValue(node, "jis:ADRESA_OPISNA");

                // Add the object to the list
                objects.Add(obj);
            }

            // Return the list of objects
            return objects;
        }

        public static List<NaciniUporabeModel> ParseNaciniUporabe(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<NaciniUporabeModel> objects = new List<NaciniUporabeModel>();

            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                NaciniUporabeModel obj = new NaciniUporabeModel();

                // Parse and store the data from XML into the object
                obj.NacinUporabeId = GetElementValue(node, "jis:NACIN_UPORABE_ID");
                obj.MaticniBrojKo = GetElementValue(node, "jis:MATICNI_BROJ_KO");
                obj.Povrsina = GetElementValue(node, "jis:POVRSINA");
                obj.SifraVrsteUporabe = GetElementValue(node, "jis:SIFRA_VRSTE_UPORABE");
                obj.NazivVrsteUporabe = GetElementValue(node, "jis:NAZIV_VRSTE_UPORABE");
                obj.PosjedovniListBroj = GetElementValue(node, "jis:POSJEDOVNI_LIST_BROJ");
                obj.CesticaId = GetElementValue(node, "jis:CESTICA_ID");
                obj.StatusNacinaUporabe = GetElementValue(node, "jis:STATUS_NACINA_UPORABE");
                obj.OznakaPravaGradjenja = GetElementValue(node, "jis:OZNAKA_PRAVA_GRADJENJA");

                // Add the object to the list
                objects.Add(obj);
            }

            // Return the list of objects
            return objects;
        }

        public static List<AnoCesticeModel> ParseAnoCestice(XmlNodeList list)
        {
            // Create a list to store the parsed data
            List<AnoCesticeModel> objects = new List<AnoCesticeModel>();

            // Iterate through each "NACINI_UPORABE" element
            foreach (XmlNode node in list)
            {
                // Create a new object to store the data
                AnoCesticeModel obj = new AnoCesticeModel();

                // Parse and store the data from XML into the object
                obj.AnoCesticaId = node.SelectSingleNode("jis:ANO_CESTICA_ID", GetUpdatedNamespaceManager()).InnerText;
                obj.MaticniBrojKo = node.SelectSingleNode("jis:MATICNI_BROJ_KO", GetUpdatedNamespaceManager()).InnerText;
                obj.BrojCestice = node.SelectSingleNode("jis:BROJ_CESTICE", GetUpdatedNamespaceManager()).InnerText;
                obj.Rotacija = node.SelectSingleNode("jis:ROTACIJA", GetUpdatedNamespaceManager()).InnerText;
                obj.Coordinates = node.SelectSingleNode("jis:GEOM/gml:Point/gml:coordinates", GetUpdatedNamespaceManager()).InnerText;


                    // Add the object to the list
                    objects.Add(obj);
            }

            // Return the list of objects
            return objects;
        }



        // Helper method to retrieve the value of an element by its XPath
        static string GetElementValue(XmlNode node, string xpath)
        {
            XmlNode valueNode = node.SelectSingleNode(xpath, GetNamespaceManager(node.OwnerDocument));
            return valueNode?.InnerText;
        }

        static XmlNamespaceManager GetUpdatedNamespaceManager()
        {
            XmlNamespaceManager nsManager = new XmlNamespaceManager(new NameTable());
            nsManager.AddNamespace("jis", "http://www.uredjenazemlja.hr");
            nsManager.AddNamespace("gml", "http://www.opengis.net/gml");
            return nsManager;
        }

        /*       // Helper method to retrieve the coordinates from the XML
               static List<UpdatedGmlCoordinate> GetCoordinates(XmlNode node)
               {
                   List<UpdatedGmlCoordinate> coordinates = new List<UpdatedGmlCoordinate>();


                   XmlNode coordinatesNode = node.SelectSingleNode("jis:GEOM/gml:Polygon/gml:outerBoundaryIs/gml:LinearRing/gml:coordinates", GetNamespaceManager(node.OwnerDocument));
                   if (coordinatesNode != null)
                   {

                       string coordinatesText = coordinatesNode.InnerText;
                       string[] coordinatePairs = coordinatesText.Split(' ');

                       foreach (string coordinatePair in coordinatePairs)
                       {
                           string[] values = coordinatePair.Split(',');
                           if (values.Length == 2)
                           {
                               double x = double.Parse(values[0]);
                               double y = double.Parse(values[1]);
                               UpdatedGmlCoordinate coord = new UpdatedGmlCoordinate(x, y);
                               coordinates.Add(coord);
                           }
                       }
                   }

                   return coordinates;
               }
        */
        // Helper method to create and configure the namespace manager for XPath queries
        static XmlNamespaceManager GetNamespaceManager(XmlDocument doc)
        {
            XmlNamespaceManager nsManager = new XmlNamespaceManager(doc.NameTable);
            nsManager.AddNamespace("jis", "http://www.uredjenazemlja.hr");
            nsManager.AddNamespace("gml", "http://www.opengis.net/gml/3.2");
            return nsManager;
        }
        static string GetSpecificNode(int value)
        {
            string result;

            switch (value)
            {
                case 0:
                    result = "//jis:ANO_CESTICE";
                    break;
                case 1:
                    result = "//jis:CESTICE";
                    break;
                case 2:
                    result = "//jis:NACINI_UPORABE";
                    break;
                case 3:
                    result = "//jis:CESTICE_ZGRADE";
                    break;
                case 4:
                    result = "//jis:IDENTIFIKACIJE";
                    break;
                case 5:
                    result = "//jis:MEDJE_CESTICA";
                    break;
                default:
                    result = "//jis:KATASTARSKE_OPCINE";
                    break;
            }

            return result;
        }


    }
}
