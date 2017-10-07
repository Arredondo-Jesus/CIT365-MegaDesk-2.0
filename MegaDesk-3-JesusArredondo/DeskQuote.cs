using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MegaDesk_3_JesusArredondo
{
    class DeskQuote
    {
        public string date { get; set; }
        public string clientName { get; set; }
        public int rushDays { get; set; }
        public int price { get; set; }


        public void calculatePrice(Desk desk, AddQuote addQuote) {
        
            int basePrice = 200;
            int deskSurface = desk.depth * desk.width;
            int drawersPrice = desk.drawers * 50;
            int rushDays = this.rushDays;
            int extraSurfacePrice = 0;
            int rushDaysPrice = 0;
            int materialPrice = 0;
            int [,] extraCharges = new int[3, 3];

            extraCharges = getRushOrder("rushOrderPrices.txt");


            if (deskSurface > 1000) {
                extraSurfacePrice = deskSurface - 1000;
            }


            switch (addQuote.getMaterial()) {
                case "Oak": materialPrice = (int)Desk.desktopMaterials.Oak; break;
                case "Laminate": materialPrice = (int)Desk.desktopMaterials.Laminate; break;
                case "Pine": materialPrice = (int)Desk.desktopMaterials.Pine; break;
                case "Rossewood": materialPrice = (int)Desk.desktopMaterials.Rossewood; break;
                case "Veneer": materialPrice = (int)Desk.desktopMaterials.Veneer; break;
                default: materialPrice = 0; break;
            }

            if (deskSurface > 0 && deskSurface < 1000)
            {
                switch (rushDays) {
                    case 3: rushDaysPrice = extraCharges[0, 0]; break;
                    case 5: rushDaysPrice = extraCharges[0, 1]; break; 
                    case 7: rushDaysPrice = extraCharges[0, 2]; break;
                    default: rushDaysPrice = 0; break;
                }
            }
            else if (deskSurface >= 1000 && deskSurface <= 2000)
            {
                switch (rushDays)
                {
                    case 3: rushDaysPrice = extraCharges[1, 0]; break;
                    case 5: rushDaysPrice = extraCharges[1, 1]; break;
                    case 7: rushDaysPrice = extraCharges[1, 2]; break;
                    default: rushDaysPrice = 0; break;
                }
            }
            else {
                switch (rushDays)
                {
                    case 3: rushDaysPrice = extraCharges[2, 0]; break;
                    case 5: rushDaysPrice = extraCharges[2, 1]; break;
                    case 7: rushDaysPrice = extraCharges[2, 2]; break;
                    default: rushDaysPrice = 0; break;
                }
            }

            this.price = basePrice + extraSurfacePrice + drawersPrice + rushDaysPrice + materialPrice;
        }

        public int[,] getRushOrder(string fileName) {
 
            int[,] extraCarges = new int[3,3];

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        extraCarges[i, j] = int.Parse(lines[j + (3 * i)]);
                        System.Windows.Forms.MessageBox.Show(extraCarges[i,j].ToString());
                    }
                }
                
                //System.Windows.Forms.MessageBox.Show(extraCarges.ToString());
            }
            catch (IOException e)
            {
                System.Windows.Forms.MessageBox.Show("There was a problem while trying to read the file" + e);
            }
            catch (NullReferenceException ne) {
                System.Windows.Forms.MessageBox.Show("Null point exception "+ ne);
            }

            return extraCarges;
        }

        public List<Desk> readJSONFile(string file) {
            StreamReader sr = new StreamReader("Quotes.json");
            string JSONString;

            try {
                while (!sr.EndOfStream) {
                    JSONString = sr.ReadLine();
                    Desk desk = new Desk();
                    JsonConvert.DeserializeObject(JSONString);

                }
            }
            catch () {

            }


            return null;
        }

        public void writeJSONFile(string file) {

        }

        public void saveQuote(AddQuote addQuote)
        {
            Desk desk = new Desk();

            desk.width = addQuote.getDeskDepth();
            desk.depth = addQuote.getDeskWidth();
            desk.size = addQuote.getDeskDepth() * addQuote.getDeskWidth();

            desk.drawers = addQuote.getDeskDrawers();
            addQuote.setSize(desk.size);

            
            this.clientName = addQuote.getClientName();
            this.rushDays = addQuote.getRushDays();

            this.calculatePrice(desk, addQuote);
            this.date = addQuote.getDate();
            addQuote.setPrice(this.price);


            /*
            string name = this.getClientName();
            string date = this.getDate().ToString();
            string width = desk.getDeskWidth().ToString();
            string depth = desk.getDeskDepth().ToString();
            string drawwers = desk.getDrawers().ToString();
            string rushDays = this.getRushDays().ToString();
            string price = this.getPrice().ToString();
            string size = desk.getSize().ToString();
            

            try
            {
                StreamReader streamReader = new StreamReader("Quotes.txt");
                if (streamReader.ReadLine() == null)
                {
                    streamReader.Close();
                    StreamWriter streamWriter1 = new StreamWriter("Quotes.txt", append: true);
                    string header = "Name,Date,Rush Days,Desk With, Desk Depth,Desk Drawers,Price";
                    streamWriter1.WriteLine(header);
                    streamWriter1.Close();
                }
                else
                {
                    streamReader.Close();
                }

            }
            catch (IOException e)
            {
                if (e.Source != null)
                {
                    System.Windows.Forms.MessageBox.Show("An error has occur while trying to open the file");
                }
            }
            finally {
                StreamWriter streamWriter = new StreamWriter("Quotes.txt", append: true);
                //string content = name + "," + date + "," + rushDays + "," + width + "," + depth + "," + drawwers + ","
                //    + price;
                streamWriter.WriteLine(content);
                streamWriter.Close();
            } */
        }
        
    }
}
