using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Smuggle_INC
{
    public partial class home : Form
    {
        private void currencyconversion(string previouscurrency, string nextcurrency)
        {
            string selectedcurrency = Smuggle_INC.Properties.Settings.Default.selectedcurrency;
            string selectedinventory = Smuggle_INC.Properties.Settings.Default.selectedinventory;
            int amount = Smuggle_INC.Properties.Settings.Default.mainaccountamount;
            Smuggle_INC.Properties.Settings.Default.Reset();
            Smuggle_INC.Properties.Settings.Default.selectedcurrency = selectedcurrency;
            Smuggle_INC.Properties.Settings.Default.selectedinventory = selectedinventory;
            Smuggle_INC.Properties.Settings.Default.mainaccountamount = amount;

            Random rndagriculturecoffee = new Random();
            Smuggle_INC.Properties.Settings.Default.agriculturecoffee = rndagriculturecoffee.Next(1, 5);
            Random rndagriculturecorn = new Random();
            Smuggle_INC.Properties.Settings.Default.agriculturecorn = rndagriculturecorn.Next(2, 7);
            Random rndagricultureoats = new Random();
            Smuggle_INC.Properties.Settings.Default.agricultureoats = rndagricultureoats.Next(1, 6);
            Random rndagriculturerice = new Random();
            Smuggle_INC.Properties.Settings.Default.agriculturerice = rndagriculturerice.Next(8, 14);
            Random rndagriculturesoybeans = new Random();
            Smuggle_INC.Properties.Settings.Default.agriculturesoybeans = rndagriculturesoybeans.Next(5, 11);
            Random rndagriculturewheat = new Random();
            Smuggle_INC.Properties.Settings.Default.agriculturewheat = rndagriculturewheat.Next(170, 200);
            Random rndanimalsbeef = new Random();
            Smuggle_INC.Properties.Settings.Default.animalsbeef = rndanimalsbeef.Next(100, 150);
            Random rndanimalseggs = new Random();
            Smuggle_INC.Properties.Settings.Default.animalseggs = rndanimalseggs.Next(6, 12);
            Random rndanimalsfeedercattle = new Random();
            Smuggle_INC.Properties.Settings.Default.animalsfeedercattle = rndanimalsfeedercattle.Next(1, 5);
            Random rndanimalsfreshporkbellies = new Random();
            Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies = rndanimalsfreshporkbellies.Next(75, 110);
            Random rndanimalslivecattle = new Random();
            Smuggle_INC.Properties.Settings.Default.animalslivecattle = rndanimalslivecattle.Next(1, 5);
            Random rndanimalsmilk = new Random();
            Smuggle_INC.Properties.Settings.Default.animalsmilk = rndanimalsmilk.Next(7, 13);
            Random rndgrocerybutter = new Random();
            Smuggle_INC.Properties.Settings.Default.grocerybutter = rndgrocerybutter.Next(2, 8);
            Random rndgrocerycocoa = new Random();
            Smuggle_INC.Properties.Settings.Default.grocerycocoa = rndgrocerycocoa.Next(1, 5);
            Random rndgroceryorangejuice = new Random();
            Smuggle_INC.Properties.Settings.Default.groceryorangejuice = rndgroceryorangejuice.Next(1, 5);
            Random rndgrocerysugar = new Random();
            Smuggle_INC.Properties.Settings.Default.grocerysugar = rndgrocerysugar.Next(1, 5);
            Random rndmetalsaluminium = new Random();
            Smuggle_INC.Properties.Settings.Default.metalsaluminium = rndmetalsaluminium.Next(1700, 1900);
            Random rndmetalscopper = new Random();
            Smuggle_INC.Properties.Settings.Default.metalscopper = rndmetalscopper.Next(6000, 6250);
            Random rndmetalsironore = new Random();
            Smuggle_INC.Properties.Settings.Default.metalsironore = rndmetalsironore.Next(80, 120);
            Random rndmetalslead = new Random();
            Smuggle_INC.Properties.Settings.Default.metalsironore = rndmetalslead.Next(1800, 1900);
            Random rndmetalsnickel = new Random();
            Smuggle_INC.Properties.Settings.Default.metalsnickel = rndmetalsnickel.Next(11000, 12500);
            Random rndpetroleumcrudeoil = new Random();
            Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil = rndpetroleumcrudeoil.Next(50, 75);
            Random rndpetroleumdiesel = new Random();
            Smuggle_INC.Properties.Settings.Default.petroleumdiesel = rndpetroleumdiesel.Next(1, 10);
            Random rndpetroleumpetrol = new Random();
            Smuggle_INC.Properties.Settings.Default.petroleumpetrol = rndpetroleumpetrol.Next(1, 10);
            Random rndpetroleumrbobgasoline = new Random();
            Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline = rndpetroleumrbobgasoline.Next(1, 7);
            Random rndpreciousmetalsgold = new Random();
            Smuggle_INC.Properties.Settings.Default.preciousmetalsgold = rndpreciousmetalsgold.Next(1100, 1350);
            Random rndpreciousmetalsplatinum = new Random();
            Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum = rndpreciousmetalsplatinum.Next(750, 900);
            Random rndpreciousmetalssilver = new Random();
            Smuggle_INC.Properties.Settings.Default.preciousmetalssilver = rndpreciousmetalssilver.Next(10, 25);
            Random rndplastic = new Random();
            Smuggle_INC.Properties.Settings.Default.plastic = rndplastic.Next(4, 12);
            Random rndnaturalgas = new Random();
            Smuggle_INC.Properties.Settings.Default.naturalgas = rndnaturalgas.Next(2, 12);
            Random rndbiofuels = new Random();
            Smuggle_INC.Properties.Settings.Default.biofuels = rndbiofuels.Next(7, 15);


            if (previouscurrency == "dollars" && nextcurrency == "renminbi")
            {
                Smuggle_INC.Properties.Settings.Default.agriculturecoffee *= 7;
                Smuggle_INC.Properties.Settings.Default.agriculturecorn *= 7;
                Smuggle_INC.Properties.Settings.Default.agricultureoats *= 7;
                Smuggle_INC.Properties.Settings.Default.agriculturerice *= 7;
                Smuggle_INC.Properties.Settings.Default.agriculturesoybeans *= 7;
                Smuggle_INC.Properties.Settings.Default.agriculturewheat *= 7;
                Smuggle_INC.Properties.Settings.Default.animalsbeef *= 7;
                Smuggle_INC.Properties.Settings.Default.animalseggs *= 7;
                Smuggle_INC.Properties.Settings.Default.animalsfeedercattle *= 7;
                Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies *= 7;
                Smuggle_INC.Properties.Settings.Default.animalslivecattle *= 7;
                Smuggle_INC.Properties.Settings.Default.animalsmilk *= 7;
                Smuggle_INC.Properties.Settings.Default.grocerybutter *= 7;
                Smuggle_INC.Properties.Settings.Default.grocerycocoa *= 7;
                Smuggle_INC.Properties.Settings.Default.groceryorangejuice *= 7;
                Smuggle_INC.Properties.Settings.Default.grocerysugar *= 7;
                Smuggle_INC.Properties.Settings.Default.metalsaluminium *= 7;
                Smuggle_INC.Properties.Settings.Default.metalscopper *= 7;
                Smuggle_INC.Properties.Settings.Default.metalsironore *= 7;
                Smuggle_INC.Properties.Settings.Default.metalslead *= 7;
                Smuggle_INC.Properties.Settings.Default.metalsnickel *= 7;
                Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil *= 7;
                Smuggle_INC.Properties.Settings.Default.petroleumdiesel *= 7;
                Smuggle_INC.Properties.Settings.Default.petroleumpetrol *= 7;
                Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline *= 7;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsgold *= 7;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum *= 7;
                Smuggle_INC.Properties.Settings.Default.preciousmetalssilver *= 7;
            }
            if (previouscurrency == "dollars" && nextcurrency == "rupees")
            {
                Smuggle_INC.Properties.Settings.Default.agriculturecorn *= 70;
                Smuggle_INC.Properties.Settings.Default.agricultureoats *= 70;
                Smuggle_INC.Properties.Settings.Default.agriculturerice *= 70;
                Smuggle_INC.Properties.Settings.Default.agriculturesoybeans *= 70;
                Smuggle_INC.Properties.Settings.Default.agriculturewheat *= 70;
                Smuggle_INC.Properties.Settings.Default.animalsbeef *= 70;
                Smuggle_INC.Properties.Settings.Default.animalseggs *= 70;
                Smuggle_INC.Properties.Settings.Default.animalsfeedercattle *= 70;
                Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies *= 70;
                Smuggle_INC.Properties.Settings.Default.animalslivecattle *= 70;
                Smuggle_INC.Properties.Settings.Default.animalsmilk *= 70;
                Smuggle_INC.Properties.Settings.Default.grocerybutter *= 70;
                Smuggle_INC.Properties.Settings.Default.grocerycocoa *= 70;
                Smuggle_INC.Properties.Settings.Default.groceryorangejuice *= 70;
                Smuggle_INC.Properties.Settings.Default.grocerysugar *= 70;
                Smuggle_INC.Properties.Settings.Default.metalsaluminium *= 70;
                Smuggle_INC.Properties.Settings.Default.metalscopper *= 70;
                Smuggle_INC.Properties.Settings.Default.metalsironore *= 70;
                Smuggle_INC.Properties.Settings.Default.metalslead *= 70;
                Smuggle_INC.Properties.Settings.Default.metalsnickel *= 70;
                Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil *= 70;
                Smuggle_INC.Properties.Settings.Default.petroleumdiesel *= 70;
                Smuggle_INC.Properties.Settings.Default.petroleumpetrol *= 70;
                Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline *= 70;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsgold *= 70;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum *= 70;
                Smuggle_INC.Properties.Settings.Default.preciousmetalssilver *= 70;
            }
            if (previouscurrency == "dollars" && nextcurrency == "ruble")
            {
                Smuggle_INC.Properties.Settings.Default.agriculturecorn *= 64;
                Smuggle_INC.Properties.Settings.Default.agricultureoats *= 64;
                Smuggle_INC.Properties.Settings.Default.agriculturerice *= 64;
                Smuggle_INC.Properties.Settings.Default.agriculturesoybeans *= 64;
                Smuggle_INC.Properties.Settings.Default.agriculturewheat *= 64;
                Smuggle_INC.Properties.Settings.Default.animalsbeef *= 64;
                Smuggle_INC.Properties.Settings.Default.animalseggs *= 64;
                Smuggle_INC.Properties.Settings.Default.animalsfeedercattle *= 64;
                Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies *= 64;
                Smuggle_INC.Properties.Settings.Default.animalslivecattle *= 64;
                Smuggle_INC.Properties.Settings.Default.animalsmilk *= 64;
                Smuggle_INC.Properties.Settings.Default.grocerybutter *= 64;
                Smuggle_INC.Properties.Settings.Default.grocerycocoa *= 64;
                Smuggle_INC.Properties.Settings.Default.groceryorangejuice *= 64;
                Smuggle_INC.Properties.Settings.Default.grocerysugar *= 64;
                Smuggle_INC.Properties.Settings.Default.metalsaluminium *= 64;
                Smuggle_INC.Properties.Settings.Default.metalscopper *= 64;
                Smuggle_INC.Properties.Settings.Default.metalsironore *= 64;
                Smuggle_INC.Properties.Settings.Default.metalslead *= 64;
                Smuggle_INC.Properties.Settings.Default.metalsnickel *= 64;
                Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil *= 64;
                Smuggle_INC.Properties.Settings.Default.petroleumdiesel *= 64;
                Smuggle_INC.Properties.Settings.Default.petroleumpetrol *= 64;
                Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline *= 64;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsgold *= 64;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum *= 64;
                Smuggle_INC.Properties.Settings.Default.preciousmetalssilver *= 64;
            }
            if (previouscurrency == "dollars" && nextcurrency == "dirham")
            {
                Smuggle_INC.Properties.Settings.Default.agriculturecorn *= 4;
                Smuggle_INC.Properties.Settings.Default.agricultureoats *= 4;
                Smuggle_INC.Properties.Settings.Default.agriculturerice *= 4;
                Smuggle_INC.Properties.Settings.Default.agriculturesoybeans *= 4;
                Smuggle_INC.Properties.Settings.Default.agriculturewheat *= 4;
                Smuggle_INC.Properties.Settings.Default.animalsbeef *= 4;
                Smuggle_INC.Properties.Settings.Default.animalseggs *= 4;
                Smuggle_INC.Properties.Settings.Default.animalsfeedercattle *= 4;
                Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies *= 4;
                Smuggle_INC.Properties.Settings.Default.animalslivecattle *= 4;
                Smuggle_INC.Properties.Settings.Default.animalsmilk *= 4;
                Smuggle_INC.Properties.Settings.Default.grocerybutter *= 4;
                Smuggle_INC.Properties.Settings.Default.grocerycocoa *= 4;
                Smuggle_INC.Properties.Settings.Default.groceryorangejuice *= 4;
                Smuggle_INC.Properties.Settings.Default.grocerysugar *= 4;
                Smuggle_INC.Properties.Settings.Default.metalsaluminium *= 4;
                Smuggle_INC.Properties.Settings.Default.metalscopper *= 4;
                Smuggle_INC.Properties.Settings.Default.metalsironore *= 4;
                Smuggle_INC.Properties.Settings.Default.metalslead *= 4;
                Smuggle_INC.Properties.Settings.Default.metalsnickel *= 4;
                Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil *= 4;
                Smuggle_INC.Properties.Settings.Default.petroleumdiesel *= 4;
                Smuggle_INC.Properties.Settings.Default.petroleumpetrol *= 4;
                Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline *= 4;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsgold *= 4;
                Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum *= 4;
                Smuggle_INC.Properties.Settings.Default.preciousmetalssilver *= 4;
            }
            if (previouscurrency == "renminbi" && nextcurrency == "dollars")
            {

            }
            if (previouscurrency == "renminbi" && nextcurrency == "rupees")
            {

            }
            if (previouscurrency == "renminbi" && nextcurrency == "ruble")
            {

            }
            if (previouscurrency == "renminbi" && nextcurrency == "poundsterling")
            {

            }
            if (previouscurrency == "rupees" && nextcurrency == "dollars")
            {

            }
            if (previouscurrency == "rupees" && nextcurrency == "renminbi")
            {

            }
            if (previouscurrency == "rupees" && nextcurrency == "ruble")
            {

            }
            if (previouscurrency == "rupees" && nextcurrency == "poundtsterling")
            {

            }
            if (previouscurrency == "ruble" && nextcurrency == "dollars")
            {

            }
            if (previouscurrency == "ruble" && nextcurrency == "renminbi")
            {

            }
            if (previouscurrency == "ruble" && nextcurrency == "rupees")
            {

            }
            if (previouscurrency == "ruble" && nextcurrency == "poundtsterling")
            {

            }
            if (previouscurrency == "poundsterling" && nextcurrency == "dollars")
            {

            }
            if (previouscurrency == "poundsterling" && nextcurrency == "renminbi")
            {

            }
            if (previouscurrency == "poundsterling" && nextcurrency == "rupees")
            {

            }
            if (previouscurrency == "poundsterling" && nextcurrency == "ruble")
            {

            }
        }
        private void assigninventorybuy(string item1, int bp1)
        {
            switch (item1)
            {
                case "Crude Oil":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                    Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilbp);
                    break;
                case "RBOB Gasoline":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                    Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolinebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolinebp);
                    break;
                case "Petrol":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                    Smuggle_INC.Properties.Settings.Default.petroleumpetrolbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrolbp);
                    break;
                case "Diesel":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                    Smuggle_INC.Properties.Settings.Default.petroleumdieselbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdieselbp);
                    break;
                case "Wheat":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                    Smuggle_INC.Properties.Settings.Default.agriculturewheatbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheatbp);
                    break;
                case "Corn":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                    Smuggle_INC.Properties.Settings.Default.agriculturecornbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecornbp);
                    break;
                case "Oats":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                    Smuggle_INC.Properties.Settings.Default.agricultureoatsbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoatsbp);
                    break;
                case "Rice":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                    Smuggle_INC.Properties.Settings.Default.agriculturericebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturericebp);
                    break;
                case "Soybeans":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                    Smuggle_INC.Properties.Settings.Default.agriculturesoybeansbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeansbp);
                    break;
                case "Coffee":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                    Smuggle_INC.Properties.Settings.Default.agriculturecoffeebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffeebp);
                    break;
                case "Feeder Cattle":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                    Smuggle_INC.Properties.Settings.Default.animalsfeedercattlebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattlebp);
                    break;
                case "Live Cattle":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                    Smuggle_INC.Properties.Settings.Default.animalslivecattlebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattlebp);
                    break;
                case "Beef":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                    Smuggle_INC.Properties.Settings.Default.animalsbeefbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeefbp);
                    break;
                case "Fresh Pork Bellies":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                    Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesbp);
                    break;
                case "Eggs":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggsq);
                    Smuggle_INC.Properties.Settings.Default.animalseggsbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggsbp);
                    break;
                case "Milk":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                    Smuggle_INC.Properties.Settings.Default.animalsmilkbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilkbp);
                    break;
                case "Cocoa":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                    Smuggle_INC.Properties.Settings.Default.grocerycocoabp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoabp);
                    break;
                case "Butter":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                    Smuggle_INC.Properties.Settings.Default.grocerybutterbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutterbp);
                    break;
                case "Orange Juice":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                    Smuggle_INC.Properties.Settings.Default.groceryorangejuicebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuicebp);
                    break;
                case "Sugar":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                    Smuggle_INC.Properties.Settings.Default.grocerysugarbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugarbp);
                    break;
                case "Aluminium":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                    Smuggle_INC.Properties.Settings.Default.metalsaluminiumbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminiumbp);
                    break;
                case "Nickel":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                    Smuggle_INC.Properties.Settings.Default.metalsnickelbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickelbp);
                    break;
                case "Copper":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopperq);
                    Smuggle_INC.Properties.Settings.Default.metalscopperbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopperbp);
                    break;
                case "Lead":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsleadq);
                    Smuggle_INC.Properties.Settings.Default.metalsleadbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsleadbp);
                    break;
                case "Iron Ore":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                    Smuggle_INC.Properties.Settings.Default.metalsironorebp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironorebp);
                    break;
                case "Gold":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                    Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldbp);
                    break;
                case "Silver":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                    Smuggle_INC.Properties.Settings.Default.preciousmetalssilverbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilverbp);
                    break;
                case "Platinum":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                    Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumbp);
                    break;
                case "Plastic":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plasticq);
                    Smuggle_INC.Properties.Settings.Default.plasticbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plasticbp);
                    break;
                case "Natural Gas":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgasq);
                    Smuggle_INC.Properties.Settings.Default.naturalgasbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgasbp);
                    break;
                case "Bio Fuels":
                    inventorynamelabel1.Text = item1;
                    inventoryquantitylabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuelsq);
                    Smuggle_INC.Properties.Settings.Default.biofuelsbp = bp1;
                    inventorybplabel1.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuelsbp);
                    break;
            }
        }
        private void inventorybuyrefreshwhilerun(string item, int bp)
        {
            if (item == inventorynamelabel1.Text || item == inventorynamelabel2.Text || item == inventorynamelabel3.Text || item == inventorynamelabel4.Text || item == inventorynamelabel5.Text || item == inventorynamelabel6.Text || item == inventorynamelabel7.Text || item == inventorynamelabel8.Text || item == inventorynamelabel9.Text || item == inventorynamelabel10.Text || item == inventorynamelabel11.Text || item == inventorynamelabel12.Text || item == inventorynamelabel13.Text || item == inventorynamelabel14.Text || item == inventorynamelabel15.Text || item == inventorynamelabel16.Text)
            {
                int quantity = 0;
                switch (item)
                {
                    case "Crude Oil":

                        quantity = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq;
                        
                        break;
                    case "RBOB Gasoline":

                        quantity = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq;
                        
                        break;
                    case "Petrol":

                        quantity = Smuggle_INC.Properties.Settings.Default.petroleumpetrolq;
                        
                        break;
                    case "Diesel":

                        quantity = Smuggle_INC.Properties.Settings.Default.petroleumdieselq;
                        
                        break;
                    case "Wheat":

                        quantity = Smuggle_INC.Properties.Settings.Default.agriculturewheatq;
                        
                        break;
                    case "Corn":

                        quantity = Smuggle_INC.Properties.Settings.Default.agriculturecornq;
                        
                        break;
                    case "Oats":

                        quantity = Smuggle_INC.Properties.Settings.Default.agricultureoatsq;
                        
                        break;
                    case "Rice":

                        quantity = Smuggle_INC.Properties.Settings.Default.agriculturericeq;
                        
                        break;
                    case "Soybeans":

                        quantity = Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq;
                        
                        break;
                    case "Coffee":

                        quantity = Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq;
                        
                        break;
                    case "Feeder Cattle":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq;
                        
                        break;
                    case "Live Cattle":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalslivecattleq;
                        
                        break;
                    case "Beef":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalsbeefq;
                        
                        break;
                    case "Fresh Pork Bellies":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq;
                        
                        break;
                    case "Eggs":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalseggsq;
                        
                        break;
                    case "Milk":

                        quantity = Smuggle_INC.Properties.Settings.Default.animalsmilkq;
                       
                        break;
                    case "Cocoa":

                        quantity = Smuggle_INC.Properties.Settings.Default.grocerycocoaq;
                        
                        break;
                    case "Butter":

                        quantity = Smuggle_INC.Properties.Settings.Default.grocerybutterq;
                        
                        break;
                    case "Orange Juice":

                        quantity = Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq;
                        
                        break;
                    case "Sugar":

                        quantity = Smuggle_INC.Properties.Settings.Default.grocerysugarq;
                        
                        break;
                    case "Aluminium":

                        quantity = Smuggle_INC.Properties.Settings.Default.metalsaluminiumq;
                        
                        break;
                    case "Nickel":

                        quantity = Smuggle_INC.Properties.Settings.Default.metalsnickelq;
                        
                        break;
                    case "Copper":

                        quantity = Smuggle_INC.Properties.Settings.Default.metalscopperq;
                        
                        break;
                    case "Lead":

                        quantity = Smuggle_INC.Properties.Settings.Default.metalsleadq;
                       
                        break;
                    case "Iron Ore":

                        quantity = Smuggle_INC.Properties.Settings.Default.metalsironoreq;
                        
                        break;
                    case "Gold":

                        quantity = Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq;
                       
                        break;
                    case "Silver":

                        quantity = Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq;
                        
                        break;
                    case "Platinum":

                        quantity = Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq;

                        break;
                    case "Plastic":

                        quantity = Smuggle_INC.Properties.Settings.Default.plasticq;
                        
                        break;
                    case "Natural Gas":

                        quantity = Smuggle_INC.Properties.Settings.Default.naturalgasq;
                        
                        break;
                    case "Bio Fuels":

                        quantity = Smuggle_INC.Properties.Settings.Default.biofuelsq;
                        
                        break;
                }
                if (item == inventorynamelabel1.Text)
                {

                    inventory1.Visible = true;
                    inventoryquantitylabel1.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel2.Text)
                {

                    inventory2.Visible = true;
                    inventoryquantitylabel2.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel3.Text)
                {

                    inventory3.Visible = true;
                    inventoryquantitylabel3.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel4.Text)
                {

                    inventory4.Visible = true;
                    inventoryquantitylabel4.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel5.Text)
                {

                    inventory5.Visible = true;
                    inventoryquantitylabel5.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel6.Text)
                {

                    inventory6.Visible = true;
                    inventoryquantitylabel6.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel7.Text)
                {

                    inventory7.Visible = true;
                    inventoryquantitylabel7.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel8.Text)
                {

                    inventory8.Visible = true;
                    inventoryquantitylabel8.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel9.Text)
                {

                    inventory9.Visible = true;
                    inventoryquantitylabel9.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel10.Text)
                {

                    inventory10.Visible = true;
                    inventoryquantitylabel10.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel11.Text)
                {

                    inventory11.Visible = true;
                    inventoryquantitylabel11.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel12.Text)
                {

                    inventory12.Visible = true;
                    inventoryquantitylabel12.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel13.Text)
                {

                    inventory13.Visible = true;
                    inventoryquantitylabel13.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel14.Text)
                {

                    inventory14.Visible = true;
                    inventoryquantitylabel14.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel15.Text)
                {

                    inventory15.Visible = true;
                    inventoryquantitylabel15.Text = System.Convert.ToString(quantity);
                }
                if (item == inventorynamelabel16.Text)
                {

                    inventory16.Visible = true;
                    inventoryquantitylabel16.Text = System.Convert.ToString(quantity);
                }
            }
            else
            {
                if (inventory15.Visible == true)
                {
                    inventory16.Visible = true;
                    inventorynamelabel16.Text = inventorynamelabel15.Text;
                    inventorynamelabel15.Text = "";
                    inventoryquantitylabel16.Text = inventoryquantitylabel15.Text;
                    inventoryquantitylabel15.Text = "";
                    inventorybplabel16.Text = inventorybplabel15.Text;
                    inventorybplabel15.Text = "";
                }
                if (inventory14.Visible == true)
                {
                    inventory15.Visible = true;
                    inventorynamelabel15.Text = inventorynamelabel14.Text;
                    inventorynamelabel14.Text = "";
                    inventoryquantitylabel15.Text = inventoryquantitylabel14.Text;
                    inventoryquantitylabel14.Text = "";
                    inventorybplabel15.Text = inventorybplabel14.Text;
                    inventorybplabel14.Text = "";
                }
                if (inventory13.Visible == true)
                {
                    inventory14.Visible = true;
                    inventorynamelabel14.Text = inventorynamelabel13.Text;
                    inventorynamelabel13.Text = "";
                    inventoryquantitylabel14.Text = inventoryquantitylabel13.Text;
                    inventoryquantitylabel13.Text = "";
                    inventorybplabel14.Text = inventorybplabel13.Text;
                    inventorybplabel13.Text = "";
                }
                if (inventory12.Visible == true)
                {
                    inventory13.Visible = true;
                    inventorynamelabel13.Text = inventorynamelabel12.Text;
                    inventorynamelabel12.Text = "";
                    inventoryquantitylabel13.Text = inventoryquantitylabel12.Text;
                    inventoryquantitylabel12.Text = "";
                    inventorybplabel13.Text = inventorybplabel12.Text;
                    inventorybplabel12.Text = "";
                }
                if (inventory11.Visible == true)
                {
                    inventory12.Visible = true;
                    inventorynamelabel12.Text = inventorynamelabel11.Text;
                    inventorynamelabel11.Text = "";
                    inventoryquantitylabel12.Text = inventoryquantitylabel11.Text;
                    inventoryquantitylabel11.Text = "";
                    inventorybplabel12.Text = inventorybplabel11.Text;
                    inventorybplabel11.Text = "";
                }
                if (inventory10.Visible == true)
                {
                    inventory11.Visible = true;
                    inventorynamelabel11.Text = inventorynamelabel10.Text;
                    inventorynamelabel10.Text = "";
                    inventoryquantitylabel11.Text = inventoryquantitylabel10.Text;
                    inventoryquantitylabel10.Text = "";
                    inventorybplabel11.Text = inventorybplabel10.Text;
                    inventorybplabel10.Text = "";
                }
                if (inventory9.Visible == true)
                {
                    inventory10.Visible = true;
                    inventorynamelabel10.Text = inventorynamelabel9.Text;
                    inventorynamelabel9.Text = "";
                    inventoryquantitylabel10.Text = inventoryquantitylabel9.Text;
                    inventoryquantitylabel9.Text = "";
                    inventorybplabel10.Text = inventorybplabel9.Text;
                    inventorybplabel9.Text = "";
                }
                if (inventory8.Visible == true)
                {
                    inventory9.Visible = true;
                    inventorynamelabel9.Text = inventorynamelabel8.Text;
                    inventorynamelabel8.Text = "";
                    inventoryquantitylabel9.Text = inventoryquantitylabel8.Text;
                    inventoryquantitylabel8.Text = "";
                    inventorybplabel9.Text = inventorybplabel8.Text;
                    inventorybplabel8.Text = "";
                }
                if (inventory7.Visible == true)
                {
                    inventory8.Visible = true;
                    inventorynamelabel8.Text = inventorynamelabel7.Text;
                    inventorynamelabel7.Text = "";
                    inventoryquantitylabel8.Text = inventoryquantitylabel7.Text;
                    inventoryquantitylabel7.Text = "";
                    inventorybplabel8.Text = inventorybplabel7.Text;
                    inventorybplabel7.Text = "";
                }
                if (inventory6.Visible == true)
                {
                    inventory7.Visible = true;
                    inventorynamelabel7.Text = inventorynamelabel6.Text;
                    inventorynamelabel6.Text = "";
                    inventoryquantitylabel7.Text = inventoryquantitylabel6.Text;
                    inventoryquantitylabel6.Text = "";
                    inventorybplabel7.Text = inventorybplabel6.Text;
                    inventorybplabel6.Text = "";
                }
                if (inventory5.Visible == true)
                {
                    inventory6.Visible = true;
                    inventorynamelabel6.Text = inventorynamelabel5.Text;
                    inventorynamelabel5.Text = "";
                    inventoryquantitylabel6.Text = inventoryquantitylabel5.Text;
                    inventoryquantitylabel5.Text = "";
                    inventorybplabel6.Text = inventorybplabel5.Text;
                    inventorybplabel5.Text = "";
                }
                if (inventory4.Visible == true)
                {
                    inventory5.Visible = true;
                    inventorynamelabel5.Text = inventorynamelabel4.Text;
                    inventorynamelabel4.Text = "";
                    inventoryquantitylabel5.Text = inventoryquantitylabel4.Text;
                    inventoryquantitylabel4.Text = "";
                    inventorybplabel5.Text = inventorybplabel4.Text;
                    inventorybplabel4.Text = "";
                }
                if (inventory3.Visible == true)
                {
                    inventory4.Visible = true;
                    inventorynamelabel4.Text = inventorynamelabel3.Text;
                    inventorynamelabel3.Text = "";
                    inventoryquantitylabel4.Text = inventoryquantitylabel3.Text;
                    inventoryquantitylabel3.Text = "";
                    inventorybplabel4.Text = inventorybplabel3.Text;
                    inventorybplabel3.Text = "";
                }
                if (inventory2.Visible == true)
                {
                    inventory3.Visible = true;
                    inventorynamelabel3.Text = inventorynamelabel2.Text;
                    inventorynamelabel2.Text = "";
                    inventoryquantitylabel3.Text = inventoryquantitylabel2.Text;
                    inventoryquantitylabel2.Text = "";
                    inventorybplabel3.Text = inventorybplabel2.Text;
                    inventorybplabel2.Text = "";
                }
                if (inventory1.Visible == true)
                {
                    inventory2.Visible = true;
                    inventorynamelabel2.Text = inventorynamelabel1.Text;
                    inventorynamelabel1.Text = "";
                    inventoryquantitylabel2.Text = inventoryquantitylabel1.Text;
                    inventoryquantitylabel1.Text = "";
                    inventorybplabel2.Text = inventorybplabel1.Text;
                    inventorybplabel1.Text = "";
                }
                inventory1.Visible = true;
                assigninventorybuy(item, bp);
            }    
        }
        private void clearprevioushiddeninventory()
        {
            if (inventory1.Visible == false)
            {
                inventorynamelabel1.Text = "";
                inventoryquantitylabel1.Text = "";
                inventorybplabel1.Text = "";
            }
            if (inventory2.Visible == false)
            {
                inventorynamelabel2.Text = "";
                inventoryquantitylabel2.Text = "";
                inventorybplabel2.Text = "";
            }
            if (inventory3.Visible == false)
            {
                inventorynamelabel3.Text = "";
                inventoryquantitylabel3.Text = "";
                inventorybplabel3.Text = "";
            }
            if (inventory4.Visible == false)
            {
                inventorynamelabel4.Text = "";
                inventoryquantitylabel4.Text = "";
                inventorybplabel4.Text = "";
            }
            if (inventory5.Visible == false)
            {
                inventorynamelabel5.Text = "";
                inventoryquantitylabel5.Text = "";
                inventorybplabel5.Text = "";
            }
            if (inventory6.Visible == false)
            {
                inventorynamelabel6.Text = "";
                inventoryquantitylabel6.Text = "";
                inventorybplabel6.Text = "";
            }
            if (inventory7.Visible == false)
            {
                inventorynamelabel7.Text = "";
                inventoryquantitylabel7.Text = "";
                inventorybplabel7.Text = "";
            }
            if (inventory8.Visible == false)
            {
                inventorynamelabel8.Text = "";
                inventoryquantitylabel8.Text = "";
                inventorybplabel8.Text = "";
            }
            if (inventory9.Visible == false)
            {
                inventorynamelabel9.Text = "";
                inventoryquantitylabel9.Text = "";
                inventorybplabel9.Text = "";
            }
            if (inventory10.Visible == false)
            {
                inventorynamelabel10.Text = "";
                inventoryquantitylabel10.Text = "";
                inventorybplabel10.Text = "";
            }
            if (inventory11.Visible == false)
            {
                inventorynamelabel11.Text = "";
                inventoryquantitylabel11.Text = "";
                inventorybplabel11.Text = "";
            }
            if (inventory12.Visible == false)
            {
                inventorynamelabel12.Text = "";
                inventoryquantitylabel12.Text = "";
                inventorybplabel12.Text = "";
            }
            if (inventory13.Visible == false)
            {
                inventorynamelabel13.Text = "";
                inventoryquantitylabel13.Text = "";
                inventorybplabel13.Text = "";
            }
            if (inventory14.Visible == false)
            {
                inventorynamelabel14.Text = "";
                inventoryquantitylabel14.Text = "";
                inventorybplabel14.Text = "";
            }
            if (inventory15.Visible == false)
            {
                inventorynamelabel15.Text = "";
                inventoryquantitylabel15.Text = "";
                inventorybplabel15.Text = "";
            }
            if (inventory16.Visible == false)
            {
                inventorynamelabel16.Text = "";
                inventoryquantitylabel16.Text = "";
                inventorybplabel16.Text = "";
            }
        }
        private void inventorysellrefreshwhilerun(string item)                          
        {
            int quantity = 0;
            switch (item)
            {
                case "Crude Oil":

                    quantity = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq;

                    break;
                case "RBOB Gasoline":

                    quantity = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq;

                    break;
                case "Petrol":

                    quantity = Smuggle_INC.Properties.Settings.Default.petroleumpetrolq;

                    break;
                case "Diesel":

                    quantity = Smuggle_INC.Properties.Settings.Default.petroleumdieselq;

                    break;
                case "Wheat":

                    quantity = Smuggle_INC.Properties.Settings.Default.agriculturewheatq;

                    break;
                case "Corn":

                    quantity = Smuggle_INC.Properties.Settings.Default.agriculturecornq;

                    break;
                case "Oats":

                    quantity = Smuggle_INC.Properties.Settings.Default.agricultureoatsq;

                    break;
                case "Rice":

                    quantity = Smuggle_INC.Properties.Settings.Default.agriculturericeq;

                    break;
                case "Soybeans":

                    quantity = Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq;

                    break;
                case "Coffee":

                    quantity = Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq;

                    break;
                case "Feeder Cattle":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq;

                    break;
                case "Live Cattle":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalslivecattleq;

                    break;
                case "Beef":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalsbeefq;

                    break;
                case "Fresh Pork Bellies":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq;

                    break;
                case "Eggs":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalseggsq;

                    break;
                case "Milk":

                    quantity = Smuggle_INC.Properties.Settings.Default.animalsmilkq;

                    break;
                case "Cocoa":

                    quantity = Smuggle_INC.Properties.Settings.Default.grocerycocoaq;

                    break;
                case "Butter":

                    quantity = Smuggle_INC.Properties.Settings.Default.grocerybutterq;

                    break;
                case "Orange Juice":

                    quantity = Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq;

                    break;
                case "Sugar":

                    quantity = Smuggle_INC.Properties.Settings.Default.grocerysugarq;

                    break;
                case "Aluminium":

                    quantity = Smuggle_INC.Properties.Settings.Default.metalsaluminiumq;

                    break;
                case "Nickel":

                    quantity = Smuggle_INC.Properties.Settings.Default.metalsnickelq;

                    break;
                case "Copper":

                    quantity = Smuggle_INC.Properties.Settings.Default.metalscopperq;

                    break;
                case "Lead":

                    quantity = Smuggle_INC.Properties.Settings.Default.metalsleadq;

                    break;
                case "Iron Ore":

                    quantity = Smuggle_INC.Properties.Settings.Default.metalsironoreq;

                    break;
                case "Gold":

                    quantity = Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq;

                    break;
                case "Silver":

                    quantity = Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq;

                    break;
                case "Plastic":

                    quantity = Smuggle_INC.Properties.Settings.Default.plasticq;

                    break;
                case "Natural Gas":

                    quantity = Smuggle_INC.Properties.Settings.Default.naturalgasq;

                    break;
                case "Bio Fuels":

                    quantity = Smuggle_INC.Properties.Settings.Default.biofuelsq;

                    break;
            }
            if (quantity >= 0)
            {
                if (item == inventorynamelabel1.Text)
                {


                    inventoryquantitylabel1.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(1);
                    }
                }
                if (item == inventorynamelabel2.Text)
                {


                    inventoryquantitylabel2.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(2);
                    }
                }
                if (item == inventorynamelabel3.Text)
                {


                    inventoryquantitylabel3.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(3);
                    }
                }
                if (item == inventorynamelabel4.Text)
                {


                    inventoryquantitylabel4.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(4);
                    }
                }
                if (item == inventorynamelabel5.Text)
                {


                    inventoryquantitylabel5.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(5);
                    }
                }
                if (item == inventorynamelabel6.Text)
                {


                    inventoryquantitylabel6.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(6);
                    }
                }
                if (item == inventorynamelabel7.Text)
                {


                    inventoryquantitylabel7.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(7);
                    }
                }
                if (item == inventorynamelabel8.Text)
                {


                    inventoryquantitylabel8.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(8);
                    }
                }
                if (item == inventorynamelabel9.Text)
                {


                    inventoryquantitylabel9.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(9);
                    }
                }
                if (item == inventorynamelabel10.Text)
                {


                    inventoryquantitylabel10.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(10);
                    }
                }
                if (item == inventorynamelabel11.Text)
                {


                    inventoryquantitylabel11.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(11);
                    }
                }
                if (item == inventorynamelabel12.Text)
                {


                    inventoryquantitylabel12.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(12);
                    }
                }
                if (item == inventorynamelabel13.Text)
                {


                    inventoryquantitylabel13.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(13);
                    }
                }
                if (item == inventorynamelabel14.Text)
                {


                    inventoryquantitylabel14.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(14);
                    }
                }
                if (item == inventorynamelabel15.Text)
                {


                    inventoryquantitylabel15.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(15);
                    }
                }
                if (item == inventorynamelabel16.Text)
                {
                    

                    inventoryquantitylabel16.Text = System.Convert.ToString(quantity);
                    if (quantity == 0)
                    {
                        assigninventorysell(16);
                    }
                }
            }
            
        }
        private void assigninventorysell(int inventoryno)
        {
            if (inventoryno == 1)
            {
                inventorynamelabel1.Text = inventorynamelabel2.Text;
                inventoryquantitylabel1.Text = inventoryquantitylabel2.Text;
                inventorybplabel1.Text = inventorybplabel2.Text;
                if (inventorynamelabel1.Text == "")
                {
                    inventory1.Visible = false;
                }
                if(inventory2.Visible == false)
                {
                    inventory1.Visible = false;
                }
                inventorynamelabel2.Text = inventorynamelabel3.Text;
                inventoryquantitylabel2.Text = inventoryquantitylabel3.Text;
                inventorybplabel2.Text = inventorybplabel3.Text;
                if (inventorynamelabel2.Text == "")
                {
                    inventory2.Visible = false;
                }
                if (inventorynamelabel1.Text == inventorynamelabel2.Text)
                {
                    inventory2.Visible = false;
                }
                inventorynamelabel3.Text = inventorynamelabel4.Text;
                inventoryquantitylabel3.Text = inventoryquantitylabel4.Text;
                inventorybplabel3.Text = inventorybplabel4.Text;
                if (inventorynamelabel3.Text == "")
                {
                    inventory3.Visible = false;
                }
                if (inventorynamelabel2.Text == inventorynamelabel3.Text)
                {
                    inventory3.Visible = false;
                }
                inventorynamelabel4.Text = inventorynamelabel5.Text;
                inventoryquantitylabel4.Text = inventoryquantitylabel5.Text;
                inventorybplabel4.Text = inventorybplabel5.Text;
                if (inventorynamelabel4.Text == "")
                {
                    inventory4.Visible = false;
                }
                if (inventorynamelabel3.Text == inventorynamelabel4.Text)
                {
                    inventory4.Visible = false;
                }
                inventorynamelabel5.Text = inventorynamelabel6.Text;
                inventoryquantitylabel5.Text = inventoryquantitylabel6.Text;
                inventorybplabel5.Text = inventorybplabel6.Text;
                if (inventorynamelabel5.Text == "")
                {
                    inventory5.Visible = false;
                }
                if (inventorynamelabel4.Text == inventorynamelabel5.Text)
                {
                    inventory5.Visible = false;
                }
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
                
            }
            if (inventoryno == 2)
            {
                inventorynamelabel2.Text = inventorynamelabel3.Text;
                inventoryquantitylabel2.Text = inventoryquantitylabel3.Text;
                inventorybplabel2.Text = inventorybplabel3.Text;
                if (inventorynamelabel2.Text == "")
                {
                    inventory2.Visible = false;
                }
                if (inventorynamelabel1.Text == inventorynamelabel2.Text)
                {
                    inventory2.Visible = false;
                }
                inventorynamelabel3.Text = inventorynamelabel4.Text;
                inventoryquantitylabel3.Text = inventoryquantitylabel4.Text;
                inventorybplabel3.Text = inventorybplabel4.Text;
                if (inventorynamelabel3.Text == "")
                {
                    inventory3.Visible = false;
                }
                if (inventorynamelabel2.Text == inventorynamelabel3.Text)
                {
                    inventory3.Visible = false;
                }
                inventorynamelabel4.Text = inventorynamelabel5.Text;
                inventoryquantitylabel4.Text = inventoryquantitylabel5.Text;
                inventorybplabel4.Text = inventorybplabel5.Text;
                if (inventorynamelabel4.Text == "")
                {
                    inventory4.Visible = false;
                }
                if (inventorynamelabel3.Text == inventorynamelabel4.Text)
                {
                    inventory4.Visible = false;
                }
                inventorynamelabel5.Text = inventorynamelabel6.Text;
                inventoryquantitylabel5.Text = inventoryquantitylabel6.Text;
                inventorybplabel5.Text = inventorybplabel6.Text;
                if (inventorynamelabel5.Text == "")
                {
                    inventory5.Visible = false;
                }
                if (inventorynamelabel4.Text == inventorynamelabel5.Text)
                {
                    inventory5.Visible = false;
                }
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if(inventoryno == 3)
            {
                inventorynamelabel3.Text = inventorynamelabel4.Text;
                inventoryquantitylabel3.Text = inventoryquantitylabel4.Text;
                inventorybplabel3.Text = inventorybplabel4.Text;
                if (inventorynamelabel3.Text == "")
                {
                    inventory3.Visible = false;
                }
                if (inventorynamelabel2.Text == inventorynamelabel3.Text)
                {
                    inventory3.Visible = false;
                }
                inventorynamelabel4.Text = inventorynamelabel5.Text;
                inventoryquantitylabel4.Text = inventoryquantitylabel5.Text;
                inventorybplabel4.Text = inventorybplabel5.Text;
                if (inventorynamelabel4.Text == "")
                {
                    inventory4.Visible = false;
                }
                if (inventorynamelabel3.Text == inventorynamelabel4.Text)
                {
                    inventory4.Visible = false;
                }
                inventorynamelabel5.Text = inventorynamelabel6.Text;
                inventoryquantitylabel5.Text = inventoryquantitylabel6.Text;
                inventorybplabel5.Text = inventorybplabel6.Text;
                if (inventorynamelabel5.Text == "")
                {
                    inventory5.Visible = false;
                }
                if (inventorynamelabel4.Text == inventorynamelabel5.Text)
                {
                    inventory5.Visible = false;
                }
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory(); 
                inventory16.Visible = false;
            }
            if (inventoryno == 4)
            {
                inventorynamelabel4.Text = inventorynamelabel5.Text;
                inventoryquantitylabel4.Text = inventoryquantitylabel5.Text;
                inventorybplabel4.Text = inventorybplabel5.Text;
                if (inventorynamelabel4.Text == "")
                {
                    inventory4.Visible = false;
                }
                if (inventorynamelabel3.Text == inventorynamelabel4.Text)
                {
                    inventory4.Visible = false;
                }
                inventorynamelabel5.Text = inventorynamelabel6.Text;
                inventoryquantitylabel5.Text = inventoryquantitylabel6.Text;
                inventorybplabel5.Text = inventorybplabel6.Text;
                if (inventorynamelabel5.Text == "")
                {
                    inventory5.Visible = false;
                }
                if (inventorynamelabel4.Text == inventorynamelabel5.Text)
                {
                    inventory5.Visible = false;
                }
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 5)
            {
                inventorynamelabel5.Text = inventorynamelabel6.Text;
                inventoryquantitylabel5.Text = inventoryquantitylabel6.Text;
                inventorybplabel5.Text = inventorybplabel6.Text;
                if (inventorynamelabel5.Text == "")
                {
                    inventory5.Visible = false;
                }
                if (inventorynamelabel4.Text == inventorynamelabel5.Text)
                {
                    inventory5.Visible = false;
                }
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 6)
            {
                inventorynamelabel6.Text = inventorynamelabel7.Text;
                inventoryquantitylabel6.Text = inventoryquantitylabel7.Text;
                inventorybplabel6.Text = inventorybplabel7.Text;
                if (inventorynamelabel6.Text == "")
                {
                    inventory6.Visible = false;
                }
                if (inventorynamelabel5.Text == inventorynamelabel6.Text)
                {
                    inventory6.Visible = false;
                }
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 7)
            {
                inventorynamelabel7.Text = inventorynamelabel8.Text;
                inventoryquantitylabel7.Text = inventoryquantitylabel8.Text;
                inventorybplabel7.Text = inventorybplabel8.Text;
                if (inventorynamelabel7.Text == "")
                {
                    inventory7.Visible = false;
                }
                if (inventorynamelabel6.Text == inventorynamelabel7.Text)
                {
                    inventory7.Visible = false;
                }
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 8)
            {
                inventorynamelabel8.Text = inventorynamelabel9.Text;
                inventoryquantitylabel8.Text = inventoryquantitylabel9.Text;
                inventorybplabel8.Text = inventorybplabel9.Text;
                if (inventorynamelabel8.Text == "")
                {
                    inventory8.Visible = false;
                }
                if (inventorynamelabel7.Text == inventorynamelabel8.Text)
                {
                    inventory8.Visible = false;
                }
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 9)
            {
                inventorynamelabel9.Text = inventorynamelabel10.Text;
                inventoryquantitylabel9.Text = inventoryquantitylabel10.Text;
                inventorybplabel9.Text = inventorybplabel10.Text;
                if (inventorynamelabel9.Text == "")
                {
                    inventory9.Visible = false;
                }
                if (inventorynamelabel8.Text == inventorynamelabel9.Text)
                {
                    inventory9.Visible = false;
                }
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 10)
            {
                inventorynamelabel10.Text = inventorynamelabel11.Text;
                inventoryquantitylabel10.Text = inventoryquantitylabel11.Text;
                inventorybplabel10.Text = inventorybplabel11.Text;
                if (inventorynamelabel10.Text == "")
                {
                    inventory10.Visible = false;
                }
                if (inventorynamelabel9.Text == inventorynamelabel10.Text)
                {
                    inventory10.Visible = false;
                }
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 11)
            {
                inventorynamelabel11.Text = inventorynamelabel12.Text;
                inventoryquantitylabel11.Text = inventoryquantitylabel12.Text;
                inventorybplabel11.Text = inventorybplabel12.Text;
                if (inventorynamelabel11.Text == "")
                {
                    inventory11.Visible = false;
                }
                if (inventorynamelabel10.Text == inventorynamelabel11.Text)
                {
                    inventory11.Visible = false;
                }
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 12)
            {
                inventorynamelabel12.Text = inventorynamelabel13.Text;
                inventoryquantitylabel12.Text = inventoryquantitylabel13.Text;
                inventorybplabel12.Text = inventorybplabel13.Text;
                if (inventorynamelabel12.Text == "")
                {
                    inventory12.Visible = false;
                }
                if (inventorynamelabel11.Text == inventorynamelabel12.Text)
                {
                    inventory12.Visible = false;
                }
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 13)
            {
                inventorynamelabel13.Text = inventorynamelabel14.Text;
                inventoryquantitylabel13.Text = inventoryquantitylabel14.Text;
                inventorybplabel13.Text = inventorybplabel14.Text;
                if (inventorynamelabel13.Text == "")
                {
                    inventory13.Visible = false;
                }
                if (inventorynamelabel12.Text == inventorynamelabel13.Text)
                {
                    inventory13.Visible = false;
                }
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 14)
            {
                inventorynamelabel14.Text = inventorynamelabel15.Text;
                inventoryquantitylabel14.Text = inventoryquantitylabel15.Text;
                inventorybplabel14.Text = inventorybplabel15.Text;
                if (inventorynamelabel14.Text == "")
                {
                    inventory14.Visible = false;
                }
                if (inventorynamelabel13.Text == inventorynamelabel14.Text)
                {
                    inventory14.Visible = false;
                }
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 15)
            {
                inventorynamelabel15.Text = inventorynamelabel16.Text;
                inventoryquantitylabel15.Text = inventoryquantitylabel16.Text;
                inventorybplabel15.Text = inventorybplabel16.Text;
                if (inventorynamelabel15.Text == "")
                {
                    inventory15.Visible = false;
                }
                if (inventorynamelabel14.Text == inventorynamelabel15.Text)
                {
                    inventory15.Visible = false;
                }
                clearprevioushiddeninventory();
                inventory16.Visible = false;
            }
            if (inventoryno == 16)
            {
                inventory16.Visible = false;
                clearprevioushiddeninventory();
            }
        }
        private void cancelinventoryselection()
        {
            inventory2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory6.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory8.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory10.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory12.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory14.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory16.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            inventory1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory3.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory5.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory7.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory9.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory11.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory13.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            inventory15.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
        }

        private void cancelselection()
        {
            panel3.Visible = false;
            usabutton.FlatAppearance.BorderSize = 0;
            panel4.Visible = false;
            russiabutton.FlatAppearance.BorderSize = 0;
            panel5.Visible = false;
            indiabutton.FlatAppearance.BorderSize = 0;
            panel6.Visible = false;
            chinabutton.FlatAppearance.BorderSize = 0;
            panel7.Visible = false;
            ukbutton.FlatAppearance.BorderSize = 0;
        }
        private void cancelcompleteselection()
        {
            petroleumdecrement.Enabled = false;
            petroleumincrement.Enabled = false;
            buypetroleum.BackColor = System.Drawing.Color.White;
            sellpetroleum.BackColor = System.Drawing.Color.White;
            buypetroleum.Enabled = false;
            sellpetroleum.Enabled = false;
            placeorderpetroleum.Enabled = false;
            petroleumcombobox.SelectedItem = null;
            petroleumquantity.Text = "0";
            petroleumtotal.Text = "0";

            agriculturedecrement.Enabled = false;
            agricultureincrement.Enabled = false;
            buyagriculture.BackColor = System.Drawing.Color.White;
            sellagriculture.BackColor = System.Drawing.Color.White;
            buyagriculture.Enabled = false;
            sellagriculture.Enabled = false;
            placeorderagriculture.Enabled = false;
            agriculturecombobox.SelectedItem = null;
            agriculturequantity.Text = "0";
            agriculturetotal.Text = "0";
                                                                                    
            animalsdecrement.Enabled = false;
            animalsincrement.Enabled = false;
            buyanimals.BackColor = System.Drawing.Color.White;
            sellanimals.BackColor = System.Drawing.Color.White;
            buyanimals.Enabled = false;
            sellanimals.Enabled = false;
            placeorderanimals.Enabled = false;
            animalscombobox.SelectedItem = null;
            animalsquantity.Text = "0";
            animalstotal.Text = "0";

            grocerydecrement.Enabled = false;
            groceryincrement.Enabled = false;
            buygrocery.BackColor = System.Drawing.Color.White;
            sellgrocery.BackColor = System.Drawing.Color.White;
            buygrocery.Enabled = false;
            sellgrocery.Enabled = false;
            placeordergrocery.Enabled = false;
            grocerycombobox.SelectedItem = null;
            groceryquantity.Text = "0";
            grocerytotal.Text = "0";

            metalsdecrement.Enabled = false;
            metalsincrement.Enabled = false;
            buymetals.BackColor = System.Drawing.Color.White;
            sellmetals.BackColor = System.Drawing.Color.White;
            buymetals.Enabled = false;
            sellmetals.Enabled = false;
            placeordermetals.Enabled = false;
            metalscombobox.SelectedItem = null;
            metalsquantity.Text = "0";
            metalstotal.Text = "0";

            preciousmetalsdecrement.Enabled = false;
            preciousmetalsincrement.Enabled = false;
            buypreciousmetals.BackColor = System.Drawing.Color.White;
            sellpreciousmetals.BackColor = System.Drawing.Color.White;
            buypreciousmetals.Enabled = false;
            sellpreciousmetals.Enabled = false;
            placeorderpreciousmetals.Enabled = false;
            preciousmetalscombobox.SelectedItem = null;
            preciousmetalsquantity.Text = "0";
            preciousmetalstotal.Text = "0";

            plasticdecrement.Enabled = false;
            plasticincrement.Enabled = false;
            buyplastic.BackColor = System.Drawing.Color.White;
            sellplastic.BackColor = System.Drawing.Color.White;
            buyplastic.Enabled = true;
            if (Smuggle_INC.Properties.Settings.Default.plasticq != 0)
            {
                sellplastic.Enabled = true;
            }
            if (Smuggle_INC.Properties.Settings.Default.plasticq == 0)
            {
                sellplastic.Enabled = false;
            }
            placeorderplastic.Enabled = false;
            plasticquantity.Text = "0";
            plastictotal.Text = "0";

            naturalgasdecrement.Enabled = false;
            naturalgasincrement.Enabled = false;
            buynaturalgas.BackColor = System.Drawing.Color.White;
            sellnaturalgas.BackColor = System.Drawing.Color.White;
            buynaturalgas.Enabled = true;
            if (Smuggle_INC.Properties.Settings.Default.naturalgasq != 0)
            {
                sellnaturalgas.Enabled = true;
            }
            if (Smuggle_INC.Properties.Settings.Default.naturalgasq == 0)
            {
                sellnaturalgas.Enabled = false;
            }
            placeordernaturalgas.Enabled = false;
            naturalgasquantity.Text = "0";
            naturalgastotal.Text = "0";

            biofuelsdecrement.Enabled = false;
            biofuelsincrement.Enabled = false;
            buybiofuels.BackColor = System.Drawing.Color.White;
            sellbiofuels.BackColor = System.Drawing.Color.White;
            buybiofuels.Enabled = true;
            if (Smuggle_INC.Properties.Settings.Default.biofuelsq != 0)
            {
                sellbiofuels.Enabled = true;
            }
            if (Smuggle_INC.Properties.Settings.Default.biofuelsq == 0)
            {
                sellbiofuels.Enabled = false;
            }
            placeorderbiofuels.Enabled = false;
            biofuelsquantity.Text = "0";
            biofuelstotal.Text = "0";
        }
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            cancelcompleteselection();
            string screenwidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenheight = Screen.PrimaryScreen.Bounds.Height.ToString();
            int screenwidthint = System.Convert.ToInt32(screenwidth);
            int screenheightint = System.Convert.ToInt32(screenheight);
            Size = new Size(screenwidthint, screenheightint);
            WindowState = FormWindowState.Normal;
            int amount = 0;
            amount = Smuggle_INC.Properties.Settings.Default.mainaccountamount;
            string amountconverted = System.Convert.ToString(amount);
            mainaccountamountlabel.Text = amountconverted;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel14.BackgroundImage = Properties.Resources.russiaflag;
            panel14.BackgroundImageLayout = ImageLayout.Stretch;
            if (panel4.Visible == false)
            {
                cancelselection();
                panel4.Visible = true;
                russiabutton.FlatAppearance.BorderSize = 5;
            }
            else if (panel4.Visible == true)
            {
                cancelselection();
                panel4.Visible = false;
                russiabutton.FlatAppearance.BorderSize = 0;
            }
            Smuggle_INC.Properties.Settings.Default.Reset();
            MessageBox.Show(System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel14.BackgroundImage = Properties.Resources.usaflag;
            panel14.BackgroundImageLayout = ImageLayout.Tile;
            if (panel3.Visible == false)
            {
                cancelselection();
                panel3.Visible = true;
                usabutton.FlatAppearance.BorderSize = 5;
            }
            else if (panel3.Visible == true)
            {
                cancelselection();
                panel3.Visible = false;
                usabutton.FlatAppearance.BorderSize = 0;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Smuggle_INC.Properties.Settings.Default.Save();
        }

        private void indiabutton_Click(object sender, EventArgs e)
        {
            panel14.BackgroundImage = Properties.Resources.indiaflag___Copy;
            panel14.BackgroundImageLayout = ImageLayout.Tile;
            if (panel5.Visible == false)
            {
                cancelselection();
                panel5.Visible = true;
                indiabutton.FlatAppearance.BorderSize = 5;
            }
            else if (panel5.Visible == true)
            {
                cancelselection();
                panel5.Visible = false;
                indiabutton.FlatAppearance.BorderSize = 0;
            }
        }

        private void chinabutton_Click(object sender, EventArgs e)
        {
            panel14.BackgroundImage = Properties.Resources.chinaflag___Copy;
            panel14.BackgroundImageLayout = ImageLayout.Stretch;
            if (panel6.Visible == false)
            {
                cancelselection();
                panel6.Visible = true;
                chinabutton.FlatAppearance.BorderSize = 5;
            }
            else if (panel6.Visible == true)
            {
                cancelselection();
                panel6.Visible = false;
                chinabutton.FlatAppearance.BorderSize = 0;
            }
        }

        private void ukbutton_Click(object sender, EventArgs e)
        {
            panel14.BackgroundImage = Properties.Resources.uaeflag;
            panel14.BackgroundImageLayout = ImageLayout.Tile;
            if (panel7.Visible == false)
            {
                cancelselection();
                panel7.Visible = true;
                ukbutton.FlatAppearance.BorderSize = 5;
            }
            else if (panel7.Visible == true)
            {
                cancelselection();
                panel7.Visible = false;
                ukbutton.FlatAppearance.BorderSize = 0;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_MouseMove(object sender, MouseEventArgs e)
        {
            inventory1.BackColor = System.Drawing.Color.DimGray;
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "panel15")
            {
            }
            else
            {
                inventory1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void panel15_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "panel15";
            cancelinventoryselection();
            inventory1.BackColor = System.Drawing.Color.DimGray;
        }

        private void panel15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }




        private void panel17_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "panel17";
            cancelinventoryselection();
            inventory2.BackColor = System.Drawing.Color.Gray;
        }

        private void panel17_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void panel17_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "panel17")
            {
            }
            else
            {
                inventory2.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void panel17_MouseMove(object sender, MouseEventArgs e)
        {
            inventory2.BackColor = System.Drawing.Color.Gray;
        }




        private void panel20_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "panel20";
            cancelinventoryselection();
            inventory1.BackColor = System.Drawing.Color.DimGray;
        }

        private void panel20_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void panel20_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "panel20")
            {
            }
            else
            {
                inventory1.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void panel20_MouseMove(object sender, MouseEventArgs e)
        {
            inventory1.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory3_Paint(object sender, PaintEventArgs e)
        {

        }




        private void inventory3_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory3";
            cancelinventoryselection();
            inventory3.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory3.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory3_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory3")
            {
            }
            else
            {
                inventory3.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory3_MouseMove(object sender, MouseEventArgs e)
        {
            inventory3.BackColor = System.Drawing.Color.DimGray;
        }




        private void inventory4_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory4";
            cancelinventoryselection();
            inventory4.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory4_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory4")
            {
            }
            else
            {
                inventory4.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory4_MouseMove(object sender, MouseEventArgs e)
        {
            inventory4.BackColor = System.Drawing.Color.Gray;
        }




        private void inventory5_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory5";
            cancelinventoryselection();
            inventory5.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory5.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory5_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory5")
            {
            }
            else
            {
                inventory5.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory5_MouseMove(object sender, MouseEventArgs e)
        {
            inventory5.BackColor = System.Drawing.Color.DimGray;
        }




        private void inventory6_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory6";
            cancelinventoryselection();
            inventory6.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory6.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory6_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory6")
            {
            }
            else
            {
                inventory6.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory6_MouseMove(object sender, MouseEventArgs e)
        {
            inventory6.BackColor = System.Drawing.Color.Gray;
        }



        private void inventory7_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory7";
            cancelinventoryselection();
            inventory7.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory7.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory7_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory7")
            {
            }
            else
            {
                inventory7.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory7_MouseMove(object sender, MouseEventArgs e)
        {
            inventory7.BackColor = System.Drawing.Color.DimGray;
        }



        private void inventory8_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory8";
            cancelinventoryselection();
            inventory8.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory8.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory8_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory8")
            {
            }
            else
            {
                inventory8.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory8_MouseMove(object sender, MouseEventArgs e)
        {
            inventory8.BackColor = System.Drawing.Color.Gray;
        }



        private void inventory9_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory9";
            cancelinventoryselection();
            inventory9.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory9.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory9_MouseHover(object sender, EventArgs e)
        {

        }

        private void inventory9_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory9")
            {
            }
            else
            {
                inventory9.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory9_MouseMove(object sender, MouseEventArgs e)
        {
            inventory9.BackColor = System.Drawing.Color.DimGray;
        }



        private void inventory10_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory10";
            cancelinventoryselection();
            inventory10.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory10.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory10_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory10")
            {
            }
            else
            {
                inventory10.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory10_MouseMove(object sender, MouseEventArgs e)
        {
            inventory10.BackColor = System.Drawing.Color.Gray;
        }



        private void inventory11_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory11";
            cancelinventoryselection();
            inventory11.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory11.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory11_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory11")
            {
            }
            else
            {
                inventory11.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory11_MouseMove(object sender, MouseEventArgs e)
        {
            inventory11.BackColor = System.Drawing.Color.DimGray;
        }



        private void inventory12_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory12";
            cancelinventoryselection();
            inventory12.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory12_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory12.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory12_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory12")
            {
            }
            else
            {
                inventory12.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory12_MouseMove(object sender, MouseEventArgs e)
        {
            inventory12.BackColor = System.Drawing.Color.Gray;
        }



        private void inventory13_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory13";
            cancelinventoryselection();
            inventory13.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory13_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory13.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory13_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory13")
            {
            }
            else
            {
                inventory13.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory13_MouseMove(object sender, MouseEventArgs e)
        {
            inventory13.BackColor = System.Drawing.Color.DimGray;
        }



        private void inventory14_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory14";
            cancelinventoryselection();
            inventory14.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory14_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory14.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory14_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory14")
            {
            }
            else
            {
                inventory14.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory14_MouseMove(object sender, MouseEventArgs e)
        {
            inventory14.BackColor = System.Drawing.Color.Gray;
        }



        private void inventory15_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory15";
            cancelinventoryselection();
            inventory15.BackColor = System.Drawing.Color.DimGray;
        }

        private void inventory15_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory15.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory15_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory15")
            {
            }
            else
            {
                inventory15.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
            }
        }

        private void inventory15_MouseMove(object sender, MouseEventArgs e)
        {
            inventory15.BackColor = System.Drawing.Color.DimGray;
        }



        private void inventory16_MouseClick(object sender, MouseEventArgs e)
        {
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "inventory16";
            cancelinventoryselection();
            inventory16.BackColor = System.Drawing.Color.Gray;
        }

        private void inventory16_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            inventory16.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            Smuggle_INC.Properties.Settings.Default.selectedinventory = "";
        }

        private void inventory16_MouseLeave(object sender, EventArgs e)
        {
            if (Smuggle_INC.Properties.Settings.Default.selectedinventory == "inventory16")
            {
            }
            else
            {
                inventory16.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void inventory16_MouseMove(object sender, MouseEventArgs e)
        {
            inventory16.BackColor = System.Drawing.Color.Gray;
        }

        private void petroleumdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(petroleumquantity.Text) >= 1)
            {
                if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                {
                    int petroleumtotalint = System.Convert.ToInt32(petroleumtotal.Text);
                    petroleumtotalint -= Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil;
                    petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    int petroleumquantityint1 = System.Convert.ToInt32(petroleumquantity.Text);
                    petroleumquantityint1--;
                    petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                }
                if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                {
                    int petroleumtotalint = System.Convert.ToInt32(petroleumtotal.Text);
                    petroleumtotalint -= Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline;
                    petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    int petroleumquantityint1 = System.Convert.ToInt32(petroleumquantity.Text);
                    petroleumquantityint1--;
                    petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                }
                if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                {
                    int petroleumtotalint = System.Convert.ToInt32(petroleumtotal.Text);
                    petroleumtotalint -= Smuggle_INC.Properties.Settings.Default.petroleumpetrol;
                    petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    int petroleumquantityint1 = System.Convert.ToInt32(petroleumquantity.Text);
                    petroleumquantityint1--;
                    petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                }
                if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                {
                    int petroleumtotalint = System.Convert.ToInt32(petroleumtotal.Text);
                    petroleumtotalint -= Smuggle_INC.Properties.Settings.Default.petroleumdiesel;
                    petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    int petroleumquantityint1 = System.Convert.ToInt32(petroleumquantity.Text);
                    petroleumquantityint1--;
                    petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                }
            }
            else
            {
                petroleumdecrement.Enabled = false;
            }     
            petroleumincrement.Enabled = true;
        }

        private void petroleumcombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buypetroleum.Enabled = true;
            sellpetroleum.Enabled = false;           
            petroleumtotal.Text = "0";
            petroleumquantity.Text = "0";
            petroleumincrement.Enabled = false;
            petroleumdecrement.Enabled = false;
            buypetroleum.BackColor = System.Drawing.Color.White;
            sellpetroleum.BackColor = System.Drawing.Color.White;
            if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil" && Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq > 0)
            {
                sellpetroleum.Enabled = true;
            }
            if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline" && Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq > 0)
            {
                sellpetroleum.Enabled = true;
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Petrol" && Smuggle_INC.Properties.Settings.Default.petroleumpetrolq > 0)
            {
                sellpetroleum.Enabled = true;
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Diesel" && Smuggle_INC.Properties.Settings.Default.petroleumdieselq > 0)
            {
                sellpetroleum.Enabled = true;
            }
        }

        private void buypetroleum_Click(object sender, EventArgs e)
        {
            petroleumdecrement.Enabled = true;
            buypetroleum.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellpetroleum.BackColor = System.Drawing.Color.White;
            petroleumincrement.Enabled = true;
            if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
            {
                petroleumquantity.Text = System.Convert.ToString(1);
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
            }
            if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
            {
                petroleumquantity.Text = System.Convert.ToString(1);
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);         
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
            {
                petroleumquantity.Text = System.Convert.ToString(1);
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrol);        
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
            {
                petroleumquantity.Text = System.Convert.ToString(1);
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
            }
        }

        private void sellpetroleum_Click(object sender, EventArgs e)
        {       
            buypetroleum.BackColor = System.Drawing.Color.White;
            sellpetroleum.BackColor = System.Drawing.Color.Red;
            if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
            {
                petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq.ToString();
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                petroleumdecrement.Enabled = true;
                petroleumincrement.Enabled = false;
                
            }
            if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
            {
                petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq.ToString();
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                petroleumdecrement.Enabled = true;
                petroleumincrement.Enabled = false;
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
            {
                petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumpetrolq.ToString();
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrol * Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                petroleumdecrement.Enabled = true;
                petroleumincrement.Enabled = false;
            }
            if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
            {
                petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumdieselq.ToString();
                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdiesel * Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                petroleumdecrement.Enabled = true;
                petroleumincrement.Enabled = false;
            }
        }

        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void placeorderpetroleum_Click(object sender, EventArgs e)
        {   if(buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if(buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (inventory16.Visible == false)
                {
                    if (System.Convert.ToInt32(petroleumtotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                    {
                        if (System.Convert.ToInt32(petroleumtotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)  ///ADD THE INVENTORY LIMIT CHECK HERE
                        {
                            sellpetroleum.Enabled = true;
                            Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq += System.Convert.ToInt32(petroleumquantity.Text);
                            Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(petroleumtotal.Text);
                            mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                            inventorybuyrefreshwhilerun("Crude Oil", Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
                            MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                    {
                        if (System.Convert.ToInt32(petroleumtotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                        {
                            sellpetroleum.Enabled = true;
                            Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq += System.Convert.ToInt32(petroleumquantity.Text);
                            Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(petroleumtotal.Text);
                            mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                            inventorybuyrefreshwhilerun("RBOB Gasoline", Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);
                            MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                    {
                        sellpetroleum.Enabled = true;
                        if (System.Convert.ToInt32(petroleumtotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                        {
                            Smuggle_INC.Properties.Settings.Default.petroleumpetrolq += System.Convert.ToInt32(petroleumquantity.Text);
                            Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(petroleumtotal.Text);
                            mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                            inventorybuyrefreshwhilerun("Petrol", Smuggle_INC.Properties.Settings.Default.petroleumpetrol);
                            MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                    {
                        sellpetroleum.Enabled = true;
                        if (System.Convert.ToInt32(petroleumtotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                        {
                            Smuggle_INC.Properties.Settings.Default.petroleumdieselq += System.Convert.ToInt32(petroleumquantity.Text);
                            Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(petroleumtotal.Text);
                            mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                            inventorybuyrefreshwhilerun("Diesel", Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
                            MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Inventory limit exceeded, sell some comodities to free up space", "Smuggle INC.");
                }
            }
            if (sellpetroleum.BackColor == System.Drawing.Color.Red)
            {
                if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                {
                    Smuggle_INC.Properties.Settings.Default.tempsellquantity = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq;
                    Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq -= System.Convert.ToInt32(petroleumquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(petroleumtotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);                  
                    petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                    petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
                    if(petroleumquantity.Text == "0" && petroleumtotal.Text == "0")
                    {                       
                        sellpetroleum.Enabled = false;
                        buypetroleum.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Crude Oil");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                {
                    Smuggle_INC.Properties.Settings.Default.tempsellquantity = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq;
                    Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq -= System.Convert.ToInt32(petroleumquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(petroleumtotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                    petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);
                    if (petroleumquantity.Text == "0" && petroleumtotal.Text == "0")
                    {
                        sellpetroleum.Enabled = false;
                        buypetroleum.PerformClick();
                    }
                    inventorysellrefreshwhilerun("RBOB Gasoline");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                {
                    Smuggle_INC.Properties.Settings.Default.petroleumpetrolq -= System.Convert.ToInt32(petroleumquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(petroleumtotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                    petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumpetrol);
                    if (petroleumquantity.Text == "0" && petroleumtotal.Text == "0")
                    {
                        sellpetroleum.Enabled = false;
                        buypetroleum.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Petrol");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                {
                    Smuggle_INC.Properties.Settings.Default.petroleumdieselq -= System.Convert.ToInt32(petroleumquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(petroleumtotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                    petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
                    if (petroleumquantity.Text == "0" && petroleumtotal.Text == "0")
                    {
                        sellpetroleum.Enabled = false;
                        buypetroleum.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Diesel");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }       
        }

        private void petroleumincrement_Click(object sender, EventArgs e)
        {
            if (petroleumquantity.Text == "")
            {
                petroleumquantity.Text = "0";
            }
            if (petroleumquantity.Text != "")
            {                                                                       
                if (buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                    {
                        petroleumdecrement.Enabled = true;
                        int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                        petroleumquantityint1++;
                        this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                        int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil * petroleumquantityint1;
                        petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                    {
                        petroleumdecrement.Enabled = true;
                        int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                        petroleumquantityint1++;
                        this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                        int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline * petroleumquantityint1;
                        petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                    {
                        petroleumdecrement.Enabled = true;
                        int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                        petroleumquantityint1++;
                        this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                        int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumpetrol * petroleumquantityint1;
                        petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                    {
                        petroleumdecrement.Enabled = true;
                        int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                        petroleumquantityint1++;
                        this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                        int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumdiesel * petroleumquantityint1;
                        petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                    }                
                }
                if (sellpetroleum.BackColor == System.Drawing.Color.Red)
                {
                    petroleumdecrement.Enabled = true;
                    int petroleumquantity1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                    if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                    {
                        if (petroleumquantity1 <= Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq)
                        {
                            int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                            petroleumquantityint1++;
                            this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                            int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil * petroleumquantityint1;
                            petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                    {
                        if (petroleumquantity1 <= Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq)
                        {
                            int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                            petroleumquantityint1++;
                            this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                            int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline * petroleumquantityint1;
                            petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                    {
                        if (petroleumquantity1 <= Smuggle_INC.Properties.Settings.Default.petroleumpetrolq)
                        {
                            int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                            petroleumquantityint1++;
                            this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                            int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumpetrol * petroleumquantityint1;
                            petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                        }
                    }
                    if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                    {
                        if (petroleumquantity1 <= Smuggle_INC.Properties.Settings.Default.petroleumdieselq)
                        {
                            int petroleumquantityint1 = System.Convert.ToInt32(this.petroleumquantity.Text);
                            petroleumquantityint1++;
                            this.petroleumquantity.Text = System.Convert.ToString(petroleumquantityint1);
                            int petroleumtotalint = Smuggle_INC.Properties.Settings.Default.petroleumdiesel * petroleumquantityint1;
                            petroleumtotal.Text = System.Convert.ToString(petroleumtotalint);
                        }
                    }
                }
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void petroleumcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void petroleumincrement_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            petroleumquantity.ReadOnly = true;
        }

        private void petroleumquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {             
                if (petroleumquantity.Text == "")  
                {
                    petroleumtotal.Text = "";
                    petroleumdecrement.Enabled = false;
                    placeorderpetroleum.Enabled = false;
                }
                if (petroleumquantity.Text != "")
                {
                    if (System.Convert.ToInt32(petroleumquantity.Text) == 0)
                    {
                        placeorderpetroleum.Enabled = false;
                        petroleumdecrement.Enabled = false;
                        petroleumtotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(petroleumquantity.Text) > 0)
                    {
                        placeorderpetroleum.Enabled = true;
                        petroleumdecrement.Enabled = true;
                    }
                    if (buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(petroleumquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            petroleumincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(petroleumquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            petroleumincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(petroleumquantity.Text) > 0)
                        {
                            if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                            {
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                            {
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                            {
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumpetrol);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                            {
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
                            }
                        }
                    }
                    if (sellpetroleum.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil" && System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq)        
                            {
                                if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq)
                                {
                                    petroleumincrement.Enabled = true;
                                }
                                if (petroleumquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq))
                                {
                                    petroleumincrement.Enabled = false;                                                                                          
                                }
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
                            }
                            else if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil" && System.Convert.ToInt32(petroleumquantity.Text) > Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq)       
                            {
                                petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline" && System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq)        
                            {
                                if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq)
                                {
                                    petroleumincrement.Enabled = true;
                                }
                                if (petroleumquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq))
                                {
                                    petroleumincrement.Enabled = false;                                                                                          
                                }
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);
                            }
                            else if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline" && System.Convert.ToInt32(petroleumquantity.Text) > Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq)       
                            {
                                petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "Petrol" && System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumpetrolq)        
                            {
                                if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumpetrolq)
                                {
                                    petroleumincrement.Enabled = true;
                                }
                                if (petroleumquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrolq))
                                {
                                    petroleumincrement.Enabled = false;
                                }
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumpetrol);
                            }
                            else if (petroleumcombobox.SelectedItem.ToString() == "Petrol" && System.Convert.ToInt32(petroleumquantity.Text) > Smuggle_INC.Properties.Settings.Default.petroleumpetrolq)
                            {
                                petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrol * Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                            }
                            if (petroleumcombobox.SelectedItem.ToString() == "Diesel" && System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumdieselq)        
                            {
                                if (System.Convert.ToInt32(petroleumquantity.Text) <= Smuggle_INC.Properties.Settings.Default.petroleumdieselq)
                                {
                                    petroleumincrement.Enabled = true;
                                }
                                if (petroleumquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdieselq))
                                {
                                    petroleumincrement.Enabled = false;
                                }
                                petroleumtotal.Text = System.Convert.ToString(System.Convert.ToInt32(petroleumquantity.Text) * Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
                            }
                            else if (petroleumcombobox.SelectedItem.ToString() == "Diesel" && System.Convert.ToInt32(petroleumquantity.Text) > Smuggle_INC.Properties.Settings.Default.petroleumdieselq)
                            {
                                petroleumquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                                petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdiesel * Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (petroleumquantity.Text == "")
                    {
                        petroleumtotal.Text = "";
                        petroleumdecrement.Enabled = false;
                    }
                    if(petroleumquantity.Text != "")              
                    {
                        if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = System.Convert.ToString(1);
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil);
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = System.Convert.ToString(1);
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline);
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = System.Convert.ToString(1);
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrol);
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = System.Convert.ToString(1);
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdiesel);
                        }
                        if (System.Convert.ToInt32(petroleumquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(petroleumquantity.Text) >= 0)
                        {
                            this.petroleumquantity.ReadOnly = false;
                            petroleumincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(petroleumquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)                        
                        {
                            petroleumincrement.Enabled = false;
                            petroleumdecrement.Enabled = true;
                        }
                    }
                }
                if (sellpetroleum.BackColor == System.Drawing.Color.Red)                         
                {
                    if (petroleumquantity.Text == "")
                    {
                        petroleumtotal.Text = "";
                        petroleumdecrement.Enabled = false;
                    }
                    if (petroleumquantity.Text != "")
                    {
                        if (petroleumcombobox.SelectedItem.ToString() == "Crude Oil")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq.ToString();
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumcrudeoil * Smuggle_INC.Properties.Settings.Default.petroleumcrudeoilq);
                            petroleumdecrement.Enabled = true;
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "RBOB Gasoline")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq.ToString();
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumrbobgasoline * Smuggle_INC.Properties.Settings.Default.petroleumrbobgasolineq);
                            petroleumdecrement.Enabled = true;
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "Petrol")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumpetrolq.ToString();
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumpetrol * Smuggle_INC.Properties.Settings.Default.petroleumpetrolq);
                            petroleumdecrement.Enabled = true;
                        }
                        if (petroleumcombobox.SelectedItem.ToString() == "Diesel")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            petroleumquantity.Text = Smuggle_INC.Properties.Settings.Default.petroleumdieselq.ToString();
                            petroleumtotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.petroleumdiesel * Smuggle_INC.Properties.Settings.Default.petroleumdieselq);
                            petroleumdecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void petroleumquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if(buypetroleum.BackColor == System.Drawing.Color.DeepSkyBlue || sellpetroleum.BackColor == System.Drawing.Color.Red)
            petroleumquantity.ReadOnly = false;
        }

        private void petroleumquantity_Validated(object sender, EventArgs e)
        {

        }

        private void sellpetroleum_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void buypetroleum_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void agriculturecombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buyagriculture.Enabled = true;
            sellagriculture.Enabled = false;
            agriculturetotal.Text = "0";
            agriculturequantity.Text = "0";
            agricultureincrement.Enabled = false;
            agriculturedecrement.Enabled = false;
            buyagriculture.BackColor = System.Drawing.Color.White;
            sellagriculture.BackColor = System.Drawing.Color.White;
            if (agriculturecombobox.SelectedItem.ToString() == "Wheat" && Smuggle_INC.Properties.Settings.Default.agriculturewheatq > 0)
            {
                sellagriculture.Enabled = true;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Corn" && Smuggle_INC.Properties.Settings.Default.agriculturecornq > 0)
            {
                sellagriculture.Enabled = true;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Oats" && Smuggle_INC.Properties.Settings.Default.agricultureoatsq > 0)
            {
                sellagriculture.Enabled = true;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Rice" && Smuggle_INC.Properties.Settings.Default.agriculturericeq > 0)
            {
                sellagriculture.Enabled = true;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Soybeans" && Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq > 0)
            {
                sellagriculture.Enabled = true;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Coffee" && Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq > 0)
            {
                sellagriculture.Enabled = true;
            }
        }

        private void agriculturedecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(agriculturequantity.Text) >= 1)
            {
                if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agriculturewheat;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agriculturecorn;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agricultureoats;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agriculturerice;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agriculturesoybeans;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                {
                    int agriculturetotalint = System.Convert.ToInt32(agriculturetotal.Text);
                    agriculturetotalint -= Smuggle_INC.Properties.Settings.Default.agriculturecoffee;
                    agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    int agriculturequantityint1 = System.Convert.ToInt32(agriculturequantity.Text);
                    agriculturequantityint1--;
                    agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                }
            }
            else
            {
                agriculturedecrement.Enabled = false;
            }
            agricultureincrement.Enabled = true;
        }

        private void agricultureincrement_Click(object sender, EventArgs e)
        {
            if (agriculturequantity.Text == "")
            {
                agriculturequantity.Text = "0";
            }
            if (agriculturequantity.Text != "")
            {
                if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturewheat * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturecorn * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agricultureoats * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Rice")              
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturerice * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturesoybeans * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                    {
                        agriculturedecrement.Enabled = true;
                        int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                        agriculturequantityint1++;
                        this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                        int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturecoffee * agriculturequantityint1;
                        agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                    }
                }
                if (sellagriculture.BackColor == System.Drawing.Color.Red)
                {
                    agriculturedecrement.Enabled = true;
                    int agriculturequantity1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                    if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agriculturewheatq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturewheat * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agriculturecornq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturecorn * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agricultureoatsq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agricultureoats * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agriculturericeq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturerice * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturesoybeans * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                    if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                    {
                        if (agriculturequantity1 <= Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq)
                        {
                            int agriculturequantityint1 = System.Convert.ToInt32(this.agriculturequantity.Text);
                            agriculturequantityint1++;
                            this.agriculturequantity.Text = System.Convert.ToString(agriculturequantityint1);
                            int agriculturetotalint = Smuggle_INC.Properties.Settings.Default.agriculturecoffee * agriculturequantityint1;
                            agriculturetotal.Text = System.Convert.ToString(agriculturetotalint);
                        }
                    }
                }
            }
        }

        private void agriculturetotal_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void agriculturequantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue || sellagriculture.BackColor == System.Drawing.Color.Red)
                agriculturequantity.ReadOnly = false;
        }

        private void agriculturequantity_Leave(object sender, EventArgs e)
        {
            agriculturequantity.ReadOnly = true;
        }

        private void agriculturequantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (agriculturequantity.Text == "")
                {
                    agriculturetotal.Text = "";
                    agriculturedecrement.Enabled = false;
                    placeorderagriculture.Enabled = false;
                }
                if (agriculturequantity.Text != "")
                {
                    if (System.Convert.ToInt32(agriculturequantity.Text) == 0)
                    {
                        placeorderagriculture.Enabled = false;
                        agriculturedecrement.Enabled = false;
                        agriculturetotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(agriculturequantity.Text) > 0)
                    {
                        placeorderagriculture.Enabled = true;
                        agriculturedecrement.Enabled = true;
                    }
                    if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(agriculturequantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)                        
                        {
                            agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            agricultureincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(agriculturequantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            agricultureincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(agriculturequantity.Text) > 0)
                        {
                            if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturewheat);
                            } 
                            if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecorn);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agricultureoats);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturerice);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                            {
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
                            }
                        }
                    }
                    if (sellagriculture.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (agriculturecombobox.SelectedItem.ToString() == "Wheat" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturewheatq)       
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturewheatq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheatq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturewheat);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Wheat" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agriculturewheatq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheat * Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Corn" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturecornq)
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturecornq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecornq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecorn);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Corn" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agriculturecornq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecorn * Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Oats" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agricultureoatsq)
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agricultureoatsq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoatsq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agricultureoats);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Oats" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agricultureoatsq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoats * Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Rice" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturericeq)
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturericeq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturericeq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturerice);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Rice" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agriculturericeq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturerice * Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Soybeans" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq)
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Soybeans" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeans * Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                            }
                            if (agriculturecombobox.SelectedItem.ToString() == "Coffee" && System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq)
                            {
                                if (System.Convert.ToInt32(agriculturequantity.Text) <= Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq)
                                {
                                    agricultureincrement.Enabled = true;
                                }
                                if (agriculturequantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq))
                                {
                                    agricultureincrement.Enabled = false;
                                }
                                agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
                            }
                            else if (agriculturecombobox.SelectedItem.ToString() == "Coffee" && System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq)
                            {
                                agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffee * Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (agriculturequantity.Text == "")
                    {
                        agriculturetotal.Text = "";
                        agriculturedecrement.Enabled = false;
                    }
                    if (agriculturequantity.Text != "")
                    {
                        if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheat);
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecorn);
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoats);
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturerice);
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = System.Convert.ToString(1);
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
                        }
                        if (System.Convert.ToInt32(agriculturequantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(agriculturequantity.Text) >= 0)
                        {
                            this.agriculturequantity.ReadOnly = false;
                            agricultureincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(agriculturequantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            agricultureincrement.Enabled = false;
                            agriculturedecrement.Enabled = true;
                        }
                    }
                }
                if (sellagriculture.BackColor == System.Drawing.Color.Red)
                {
                    if (agriculturequantity.Text == "")
                    {
                        agriculturetotal.Text = "";
                        agriculturedecrement.Enabled = false;
                    }
                    if (agriculturequantity.Text != "")
                    {
                        if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturewheatq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheat * Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                            agriculturedecrement.Enabled = true;
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturecornq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecorn * Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                            agriculturedecrement.Enabled = true;
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agricultureoatsq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoats * Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                            agriculturedecrement.Enabled = true;
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturericeq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturerice * Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                            agriculturedecrement.Enabled = true;
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeans * Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                            agriculturedecrement.Enabled = true;
                        }
                        if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq.ToString();
                            agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffee * Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                            agriculturedecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buyagriculture_Click(object sender, EventArgs e)
        {
            agriculturedecrement.Enabled = true;
            buyagriculture.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellagriculture.BackColor = System.Drawing.Color.White;
            agricultureincrement.Enabled = true;
            if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheat);
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Corn")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecorn);
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Oats")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoats);
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Rice")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturerice);
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
            {
                agriculturequantity.Text = System.Convert.ToString(1);
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
            }
        }

        private void sellagriculture_Click(object sender, EventArgs e)
        {
            buyagriculture.BackColor = System.Drawing.Color.White;
            sellagriculture.BackColor = System.Drawing.Color.Red;
            if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturewheatq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheat * Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Corn")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturecornq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecorn * Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Oats")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agricultureoatsq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoats * Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Rice")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturericeq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturerice * Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeans * Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
            if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
            {
                agriculturequantity.Text = Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq.ToString();
                agriculturetotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffee * Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                agriculturedecrement.Enabled = true;
                agricultureincrement.Enabled = false;
            }
        }

        private void placeorderagriculture_Click(object sender, EventArgs e)
        {
            if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buyagriculture.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(agriculturetotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agriculturewheatq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Wheat", Smuggle_INC.Properties.Settings.Default.agriculturewheat);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agriculturecornq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Corn", Smuggle_INC.Properties.Settings.Default.agriculturecorn);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agricultureoatsq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Oats", Smuggle_INC.Properties.Settings.Default.agricultureoats);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agriculturericeq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Rice", Smuggle_INC.Properties.Settings.Default.agriculturerice);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Soybeans", Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                {
                    if (System.Convert.ToInt32(agriculturetotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellagriculture.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq += System.Convert.ToInt32(agriculturequantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(agriculturetotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Coffee", Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
            }
            if (sellagriculture.BackColor == System.Drawing.Color.Red)
            {
                if (agriculturecombobox.SelectedItem.ToString() == "Wheat")
                {
                    Smuggle_INC.Properties.Settings.Default.agriculturewheatq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturewheatq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturewheat);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Wheat");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Corn")
                {
                    Smuggle_INC.Properties.Settings.Default.agriculturecornq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecornq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecorn);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Corn");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Oats")
                {
                    Smuggle_INC.Properties.Settings.Default.agricultureoatsq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agricultureoatsq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agricultureoats);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Oats");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Rice")
                {
                    Smuggle_INC.Properties.Settings.Default.agriculturericeq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturericeq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturerice);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Rice");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Soybeans")
                {
                    Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturesoybeansq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturesoybeans);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Soybeans");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (agriculturecombobox.SelectedItem.ToString() == "Coffee")
                {
                    Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq -= System.Convert.ToInt32(agriculturequantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(agriculturetotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    agriculturequantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.agriculturecoffeeq);
                    agriculturetotal.Text = System.Convert.ToString(System.Convert.ToInt32(agriculturequantity.Text) * Smuggle_INC.Properties.Settings.Default.agriculturecoffee);
                    if (agriculturequantity.Text == "0" && agriculturetotal.Text == "0")
                    {
                        sellagriculture.Enabled = false;
                        buyagriculture.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Coffee");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
        }

        private void agriculturecombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void petroleumcombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void animalscombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buyanimals.Enabled = true;
            sellanimals.Enabled = false;
            animalstotal.Text = "0";
            animalsquantity.Text = "0";
            animalsincrement.Enabled = false;
            animalsdecrement.Enabled = false;
            buyanimals.BackColor = System.Drawing.Color.White; 
            sellanimals.BackColor = System.Drawing.Color.White;                             
            if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle" && Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq > 0)
            {
                sellanimals.Enabled = true;
            }
            if (animalscombobox.SelectedItem.ToString() == "Live Cattle" && Smuggle_INC.Properties.Settings.Default.animalslivecattleq > 0)
            {
                sellanimals.Enabled = true;
            }
            if (animalscombobox.SelectedItem.ToString() == "Beef" && Smuggle_INC.Properties.Settings.Default.animalsbeefq > 0)
            {
                sellanimals.Enabled = true;
            }
            if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies" && Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq > 0)
            {
                sellanimals.Enabled = true;
            }
            if (animalscombobox.SelectedItem.ToString() == "Eggs" && Smuggle_INC.Properties.Settings.Default.animalseggsq > 0)
            {
                sellanimals.Enabled = true;
            }
            if (animalscombobox.SelectedItem.ToString() == "Milk" && Smuggle_INC.Properties.Settings.Default.animalsmilkq > 0)
            {
                sellanimals.Enabled = true;
            }
        }

        private void animalscombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void animalsdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(animalsquantity.Text) >= 1)
            {
                if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalsfeedercattle;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
                if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalslivecattle;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
                if (animalscombobox.SelectedItem.ToString() == "Beef")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalsbeef;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
                if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
                if (animalscombobox.SelectedItem.ToString() == "Eggs")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalseggs;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
                if (animalscombobox.SelectedItem.ToString() == "Milk")
                {
                    int animalstotalint = System.Convert.ToInt32(animalstotal.Text);
                    animalstotalint -= Smuggle_INC.Properties.Settings.Default.animalsmilk;
                    animalstotal.Text = System.Convert.ToString(animalstotalint);
                    int animalsquantityint1 = System.Convert.ToInt32(animalsquantity.Text);
                    animalsquantityint1--;
                    animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                }
            }
            else
            {
                animalsdecrement.Enabled = false;
            }
            animalsincrement.Enabled = true;
        }

        private void animalsincrement_Click(object sender, EventArgs e)
        {
            if (animalsquantity.Text == "")
            {
                animalsquantity.Text = "0";
            }
            if (animalsquantity.Text != "")
            {
                if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsfeedercattle * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalslivecattle * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Beef")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsbeef * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Eggs")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalseggs * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Milk")
                    {
                        animalsdecrement.Enabled = true;
                        int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                        animalsquantityint1++;
                        this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                        int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsmilk * animalsquantityint1;
                        animalstotal.Text = System.Convert.ToString(animalstotalint);
                    }
                }                                                                                   
                if (sellanimals.BackColor == System.Drawing.Color.Red)
                {                                                                                       
                    animalsdecrement.Enabled = true;
                    int animalsquantity1 = System.Convert.ToInt32(this.animalsquantity.Text);
                    if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsfeedercattle * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalslivecattleq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalslivecattle * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Beef")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalsbeefq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsbeef * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Eggs")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalseggsq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalseggs * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                    if (animalscombobox.SelectedItem.ToString() == "Milk")
                    {
                        if (animalsquantity1 <= Smuggle_INC.Properties.Settings.Default.animalsmilkq)
                        {
                            int animalsquantityint1 = System.Convert.ToInt32(this.animalsquantity.Text);
                            animalsquantityint1++;
                            this.animalsquantity.Text = System.Convert.ToString(animalsquantityint1);
                            int animalstotalint = Smuggle_INC.Properties.Settings.Default.animalsmilk * animalsquantityint1;
                            animalstotal.Text = System.Convert.ToString(animalstotalint);
                        }
                    }
                }
            }
        }

        private void animalsquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue || sellanimals.BackColor == System.Drawing.Color.Red)
                animalsquantity.ReadOnly = false;
        }

        private void animalsquantity_Leave(object sender, EventArgs e)
        {
            animalsquantity.ReadOnly = true;
        }

        private void animalsquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (animalsquantity.Text == "")
                {
                    animalstotal.Text = "";
                    animalsdecrement.Enabled = false;
                    placeorderanimals.Enabled = false;
                }
                if (animalsquantity.Text != "")
                {
                    if (System.Convert.ToInt32(animalsquantity.Text) == 0)
                    {
                        placeorderanimals.Enabled = false;
                        animalsdecrement.Enabled = false;
                        animalstotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(animalsquantity.Text) > 0)
                    {
                        placeorderanimals.Enabled = true;
                        animalsdecrement.Enabled = true;
                    }
                    if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(animalsquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            animalsincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(animalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            animalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(animalsquantity.Text) > 0)
                        {
                            if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalslivecattle);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Beef")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsbeef);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Eggs")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalseggs);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Milk")
                            {
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsmilk);
                            }
                        }
                    }
                    if (sellanimals.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattle * Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Live Cattle" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalslivecattleq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalslivecattleq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattleq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalslivecattle);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Live Cattle" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalslivecattleq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattle * Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Beef" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsbeefq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsbeefq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeefq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsbeef);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Beef" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalsbeefq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeef * Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Eggs" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalseggsq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalseggsq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggsq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalseggs);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Eggs" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalseggsq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggsq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggs * Smuggle_INC.Properties.Settings.Default.animalseggsq);
                            }
                            if (animalscombobox.SelectedItem.ToString() == "Milk" && System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsmilkq)
                            {
                                if (System.Convert.ToInt32(animalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.animalsmilkq)
                                {
                                    animalsincrement.Enabled = true;
                                }
                                if (animalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilkq))
                                {
                                    animalsincrement.Enabled = false;
                                }
                                animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsmilk);
                            }
                            else if (animalscombobox.SelectedItem.ToString() == "Milk" && System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.animalsmilkq)
                            {
                                animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilk * Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (animalsquantity.Text == "")
                    {
                        animalstotal.Text = "";
                        animalsdecrement.Enabled = false;
                    }
                    if (animalsquantity.Text != "")
                    {
                        if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattle);
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Beef")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeef);
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Eggs")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggs);
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Milk")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilk);
                        }
                        if (System.Convert.ToInt32(animalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(animalsquantity.Text) >= 0)
                        {
                            this.animalsquantity.ReadOnly = false;
                            animalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(animalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            animalsincrement.Enabled = false;
                            animalsdecrement.Enabled = true;
                        }
                    }
                }
                if (sellanimals.BackColor == System.Drawing.Color.Red)
                {
                    if (animalsquantity.Text == "")
                    {
                        animalstotal.Text = "";
                        animalsdecrement.Enabled = false;
                    }
                    if (animalsquantity.Text != "")
                    {
                        if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattle * Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                            animalsdecrement.Enabled = true;
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalslivecattleq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattle * Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                            animalsdecrement.Enabled = true;
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Beef")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsbeefq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeef * Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                            animalsdecrement.Enabled = true;
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                            animalsdecrement.Enabled = true;
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Eggs")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalseggsq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggs * Smuggle_INC.Properties.Settings.Default.animalseggsq);
                            animalsdecrement.Enabled = true;
                        }
                        if (animalscombobox.SelectedItem.ToString() == "Milk")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsmilkq.ToString();
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilk * Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                            animalsdecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buyanimals_Click(object sender, EventArgs e)
        {
            animalsdecrement.Enabled = true;
            buyanimals.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellanimals.BackColor = System.Drawing.Color.White;
            animalsincrement.Enabled = true;
            if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
            }
            if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattle);
            }
            if (animalscombobox.SelectedItem.ToString() == "Beef")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeef);
            }
            if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
            }
            if (animalscombobox.SelectedItem.ToString() == "Eggs")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggs);
            }
            if (animalscombobox.SelectedItem.ToString() == "Milk")
            {
                animalsquantity.Text = System.Convert.ToString(1);
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilk);
            }
        }

        private void sellanimals_Click(object sender, EventArgs e)
        {
            buyanimals.BackColor = System.Drawing.Color.White;
            sellanimals.BackColor = System.Drawing.Color.Red;
            if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattle * Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
            if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalslivecattleq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattle * Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
            if (animalscombobox.SelectedItem.ToString() == "Beef")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsbeefq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeef * Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
            if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
            if (animalscombobox.SelectedItem.ToString() == "Eggs")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalseggsq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggs * Smuggle_INC.Properties.Settings.Default.animalseggsq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
            if (animalscombobox.SelectedItem.ToString() == "Milk")
            {
                animalsquantity.Text = Smuggle_INC.Properties.Settings.Default.animalsmilkq.ToString();
                animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilk * Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                animalsdecrement.Enabled = true;
                animalsincrement.Enabled = false;
            }
        }

        private void placeorderanimals_Click(object sender, EventArgs e)               
        {
            if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buyanimals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(animalstotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Feeder Cattle", Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalslivecattleq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Live Cattle", Smuggle_INC.Properties.Settings.Default.animalslivecattle);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (animalscombobox.SelectedItem.ToString() == "Beef")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalsbeefq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Beef", Smuggle_INC.Properties.Settings.Default.animalsbeef);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Fresh Pork Bellies", Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (animalscombobox.SelectedItem.ToString() == "Eggs")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalseggsq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Eggs", Smuggle_INC.Properties.Settings.Default.animalseggs);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (animalscombobox.SelectedItem.ToString() == "Milk")
                {
                    if (System.Convert.ToInt32(animalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellanimals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.animalsmilkq += System.Convert.ToInt32(animalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(animalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Milk", Smuggle_INC.Properties.Settings.Default.animalsmilk);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
            }
            if (sellanimals.BackColor == System.Drawing.Color.Red)
            {
                if (animalscombobox.SelectedItem.ToString() == "Feeder Cattle")
                {
                    Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfeedercattleq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfeedercattle);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Feeder Cattle");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Live Cattle")
                {
                    Smuggle_INC.Properties.Settings.Default.animalslivecattleq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalslivecattleq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalslivecattle);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Live Cattle");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Beef")
                {
                    Smuggle_INC.Properties.Settings.Default.animalsbeefq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsbeefq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsbeef);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Beef");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Fresh Pork Bellies")
                {
                    Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsfreshporkbelliesq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsfreshporkbellies);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Fresh Pork Bellies");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Eggs")
                {
                    Smuggle_INC.Properties.Settings.Default.animalseggsq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalseggsq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalseggs);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Eggs");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (animalscombobox.SelectedItem.ToString() == "Milk")
                {
                    Smuggle_INC.Properties.Settings.Default.animalsmilkq -= System.Convert.ToInt32(animalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(animalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    animalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.animalsmilkq);
                    animalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(animalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.animalsmilk);
                    if (animalsquantity.Text == "0" && animalstotal.Text == "0")
                    {
                        sellanimals.Enabled = false;
                        buyanimals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Milk");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
        }

        private void grocerycombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buygrocery.Enabled = true;
            sellgrocery.Enabled = false;
            grocerytotal.Text = "0";
            groceryquantity.Text = "0";
            groceryincrement.Enabled = false;
            grocerydecrement.Enabled = false;
            buygrocery.BackColor = System.Drawing.Color.White;
            sellgrocery.BackColor = System.Drawing.Color.White;
            if (grocerycombobox.SelectedItem.ToString() == "Cocoa" && Smuggle_INC.Properties.Settings.Default.grocerycocoaq > 0)
            {
                sellgrocery.Enabled = true;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Butter" && Smuggle_INC.Properties.Settings.Default.grocerybutterq > 0)
            {
                sellgrocery.Enabled = true;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Orange Juice" && Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq > 0)
            {
                sellgrocery.Enabled = true;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Sugar" && Smuggle_INC.Properties.Settings.Default.grocerysugarq > 0)
            {
                sellgrocery.Enabled = true;
            }
        }

        private void grocerycombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void grocerydecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(groceryquantity.Text) >= 1)
            {
                if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                {
                    int grocerytotalint = System.Convert.ToInt32(grocerytotal.Text);
                    grocerytotalint -= Smuggle_INC.Properties.Settings.Default.grocerycocoa;
                    grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    int groceryquantityint1 = System.Convert.ToInt32(groceryquantity.Text);
                    groceryquantityint1--;
                    groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                }
                if (grocerycombobox.SelectedItem.ToString() == "Butter")
                {
                    int grocerytotalint = System.Convert.ToInt32(grocerytotal.Text);
                    grocerytotalint -= Smuggle_INC.Properties.Settings.Default.grocerybutter;
                    grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    int groceryquantityint1 = System.Convert.ToInt32(groceryquantity.Text);
                    groceryquantityint1--;
                    groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                }
                if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                {
                    int grocerytotalint = System.Convert.ToInt32(grocerytotal.Text);
                    grocerytotalint -= Smuggle_INC.Properties.Settings.Default.groceryorangejuice;
                    grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    int groceryquantityint1 = System.Convert.ToInt32(groceryquantity.Text);
                    groceryquantityint1--;
                    groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                }
                if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                {
                    int grocerytotalint = System.Convert.ToInt32(grocerytotal.Text);
                    grocerytotalint -= Smuggle_INC.Properties.Settings.Default.grocerysugar;
                    grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    int groceryquantityint1 = System.Convert.ToInt32(groceryquantity.Text);
                    groceryquantityint1--;
                    groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                }
            }
            else
            {
                grocerydecrement.Enabled = false;
            }
            groceryincrement.Enabled = true;
        }

        private void groceryincrement_Click(object sender, EventArgs e)
        {
            if (groceryquantity.Text == "")
            {
                groceryquantity.Text = "0";
            }
            if (groceryquantity.Text != "")
            {
                if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                    {
                        grocerydecrement.Enabled = true;
                        int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                        groceryquantityint1++;
                        this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                        int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerycocoa * groceryquantityint1;
                        grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Butter")
                    {
                        grocerydecrement.Enabled = true;
                        int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                        groceryquantityint1++;
                        this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                        int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerybutter * groceryquantityint1;
                        grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                    {
                        grocerydecrement.Enabled = true;
                        int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                        groceryquantityint1++;
                        this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                        int grocerytotalint = Smuggle_INC.Properties.Settings.Default.groceryorangejuice * groceryquantityint1;
                        grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                    {
                        grocerydecrement.Enabled = true;
                        int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                        groceryquantityint1++;
                        this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                        int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerysugar * groceryquantityint1;
                        grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                    }
                }
                if (sellgrocery.BackColor == System.Drawing.Color.Red)
                {
                    grocerydecrement.Enabled = true;
                    int groceryquantity1 = System.Convert.ToInt32(this.groceryquantity.Text);
                    if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                    {
                        if (groceryquantity1 <= Smuggle_INC.Properties.Settings.Default.grocerycocoaq)
                        {
                            int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                            groceryquantityint1++;
                            this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                            int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerycocoa * groceryquantityint1;
                            grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                        }
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Butter")
                    {
                        if (groceryquantity1 <= Smuggle_INC.Properties.Settings.Default.grocerybutterq)
                        {
                            int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                            groceryquantityint1++;
                            this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                            int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerybutter * groceryquantityint1;
                            grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                        }
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                    {
                        if (groceryquantity1 <= Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq)
                        {
                            int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                            groceryquantityint1++;
                            this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                            int grocerytotalint = Smuggle_INC.Properties.Settings.Default.groceryorangejuice * groceryquantityint1;
                            grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                        }
                    }
                    if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                    {
                        if (groceryquantity1 <= Smuggle_INC.Properties.Settings.Default.grocerysugarq)
                        {
                            int groceryquantityint1 = System.Convert.ToInt32(this.groceryquantity.Text);
                            groceryquantityint1++;
                            this.groceryquantity.Text = System.Convert.ToString(groceryquantityint1);
                            int grocerytotalint = Smuggle_INC.Properties.Settings.Default.grocerysugar * groceryquantityint1;
                            grocerytotal.Text = System.Convert.ToString(grocerytotalint);
                        }
                    }
                }
            }
        }

        private void groceryquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue || sellgrocery.BackColor == System.Drawing.Color.Red)
                groceryquantity.ReadOnly = false;
        }

        private void groceryquantity_Leave(object sender, EventArgs e)
        {
            groceryquantity.ReadOnly = true;
        }

        private void groceryquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (groceryquantity.Text == "")
                {
                    grocerytotal.Text = "";
                    grocerydecrement.Enabled = false;
                    placeordergrocery.Enabled = false;
                }
                if (groceryquantity.Text != "")
                {
                    if (System.Convert.ToInt32(groceryquantity.Text) == 0)
                    {
                        placeordergrocery.Enabled = false;
                        grocerydecrement.Enabled = false;
                        grocerytotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(groceryquantity.Text) > 0)
                    {
                        placeordergrocery.Enabled = true;
                        grocerydecrement.Enabled = true;
                    }
                    if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(groceryquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            groceryincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(groceryquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            groceryincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(groceryquantity.Text) > 0)
                        {
                            if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                            {
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerycocoa);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Butter")
                            {
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerybutter);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                            {
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                            {
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerysugar);
                            }
                        }
                    }
                    if (sellgrocery.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (grocerycombobox.SelectedItem.ToString() == "Cocoa" && System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerycocoaq)
                            {
                                if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerycocoaq)
                                {
                                    groceryincrement.Enabled = true;
                                }
                                if (groceryquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoaq))
                                {
                                    groceryincrement.Enabled = false;
                                }
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerycocoa);
                            }
                            else if (grocerycombobox.SelectedItem.ToString() == "Cocoa" && System.Convert.ToInt32(groceryquantity.Text) > Smuggle_INC.Properties.Settings.Default.grocerycocoaq)
                            {
                                groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoa * Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Butter" && System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerybutterq)
                            {
                                if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerybutterq)
                                {
                                    groceryincrement.Enabled = true;
                                }
                                if (groceryquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutterq))
                                {
                                    groceryincrement.Enabled = false;
                                }
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerybutter);
                            }
                            else if (grocerycombobox.SelectedItem.ToString() == "Butter" && System.Convert.ToInt32(groceryquantity.Text) > Smuggle_INC.Properties.Settings.Default.grocerybutterq)
                            {
                                groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutter * Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Orange Juice" && System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq)
                            {
                                if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq)
                                {
                                    groceryincrement.Enabled = true;
                                }
                                if (groceryquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq))
                                {
                                    groceryincrement.Enabled = false;
                                }
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
                            }
                            else if (grocerycombobox.SelectedItem.ToString() == "Orange Juice" && System.Convert.ToInt32(groceryquantity.Text) > Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq)
                            {
                                groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuice * Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                            }
                            if (grocerycombobox.SelectedItem.ToString() == "Sugar" && System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerysugarq)
                            {
                                if (System.Convert.ToInt32(groceryquantity.Text) <= Smuggle_INC.Properties.Settings.Default.grocerysugarq)
                                {
                                    groceryincrement.Enabled = true;
                                }
                                if (groceryquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugarq))
                                {
                                    groceryincrement.Enabled = false;
                                }
                                grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerysugar);
                            }
                            else if (grocerycombobox.SelectedItem.ToString() == "Sugar" && System.Convert.ToInt32(groceryquantity.Text) > Smuggle_INC.Properties.Settings.Default.grocerysugarq)
                            {
                                groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugar * Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (groceryquantity.Text == "")
                    {
                        grocerytotal.Text = "";
                        grocerydecrement.Enabled = false;
                    }
                    if (groceryquantity.Text != "")
                    {
                        if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoa);
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Butter")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutter);
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            animalsquantity.Text = System.Convert.ToString(1);
                            animalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugar);
                        }
                        if (System.Convert.ToInt32(groceryquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(groceryquantity.Text) >= 0)
                        {
                            this.groceryquantity.ReadOnly = false;
                            groceryincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(groceryquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            groceryincrement.Enabled = false;
                            grocerydecrement.Enabled = true;
                        }
                    }
                }
                if (sellgrocery.BackColor == System.Drawing.Color.Red)
                {
                    if (groceryquantity.Text == "")
                    {
                        grocerytotal.Text = "";
                        grocerydecrement.Enabled = false;
                    }
                    if (groceryquantity.Text != "")
                    {
                        if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerycocoaq.ToString();
                            grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoa * Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                            grocerydecrement.Enabled = true;
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Butter")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerybutterq.ToString();
                            grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutter * Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                            grocerydecrement.Enabled = true;
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq.ToString();
                            grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuice * Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                            grocerydecrement.Enabled = true;
                        }
                        if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerysugarq.ToString();
                            grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugar * Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                            grocerydecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buygrocery_Click(object sender, EventArgs e)
        {
            grocerydecrement.Enabled = true;
            buygrocery.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellgrocery.BackColor = System.Drawing.Color.White;
            groceryincrement.Enabled = true;
            if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
            {
                groceryquantity.Text = System.Convert.ToString(1);
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoa);
            }
            if (grocerycombobox.SelectedItem.ToString() == "Butter")
            {
                groceryquantity.Text = System.Convert.ToString(1);
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutter);
            }
            if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
            {
                groceryquantity.Text = System.Convert.ToString(1);
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
            }
            if (grocerycombobox.SelectedItem.ToString() == "Sugar")
            {
                groceryquantity.Text = System.Convert.ToString(1);
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugar);
            }
        }

        private void sellgrocery_Click(object sender, EventArgs e)
        {
            buygrocery.BackColor = System.Drawing.Color.White;
            sellgrocery.BackColor = System.Drawing.Color.Red;
            if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
            {
                groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerycocoaq.ToString();
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoa * Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                grocerydecrement.Enabled = true;
                groceryincrement.Enabled = false;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Butter")
            {
                groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerybutterq.ToString();
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutter * Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                grocerydecrement.Enabled = true;
                groceryincrement.Enabled = false;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
            {
                groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq.ToString();
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuice * Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                grocerydecrement.Enabled = true;
                groceryincrement.Enabled = false;
            }
            if (grocerycombobox.SelectedItem.ToString() == "Sugar")
            {
                groceryquantity.Text = Smuggle_INC.Properties.Settings.Default.grocerysugarq.ToString();
                grocerytotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugar * Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                grocerydecrement.Enabled = true;
                groceryincrement.Enabled = false;
            }
        }

        private void placeordergrocery_Click(object sender, EventArgs e)
        {
            if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buygrocery.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(grocerytotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                {
                    if (System.Convert.ToInt32(grocerytotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellgrocery.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.grocerycocoaq += System.Convert.ToInt32(groceryquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(grocerytotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Cocoa", Smuggle_INC.Properties.Settings.Default.grocerycocoa);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (grocerycombobox.SelectedItem.ToString() == "Butter")
                {
                    if (System.Convert.ToInt32(grocerytotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellgrocery.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.grocerybutterq += System.Convert.ToInt32(groceryquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(grocerytotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Butter", Smuggle_INC.Properties.Settings.Default.grocerybutter);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                {
                    if (System.Convert.ToInt32(grocerytotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellgrocery.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq += System.Convert.ToInt32(groceryquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(grocerytotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Orange Juice", Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                {
                    if (System.Convert.ToInt32(grocerytotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellgrocery.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.grocerysugarq += System.Convert.ToInt32(groceryquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(grocerytotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Sugar", Smuggle_INC.Properties.Settings.Default.grocerysugar);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
            }
            if (sellgrocery.BackColor == System.Drawing.Color.Red)
            {
                if (grocerycombobox.SelectedItem.ToString() == "Cocoa")
                {
                    Smuggle_INC.Properties.Settings.Default.grocerycocoaq -= System.Convert.ToInt32(groceryquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(grocerytotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerycocoaq);
                    grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerycocoa);
                    if (groceryquantity.Text == "0" && grocerytotal.Text == "0")
                    {
                        sellgrocery.Enabled = false;
                        buygrocery.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Cocoa");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (grocerycombobox.SelectedItem.ToString() == "Butter")
                {
                    Smuggle_INC.Properties.Settings.Default.grocerybutterq -= System.Convert.ToInt32(groceryquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(grocerytotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerybutterq);
                    grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerybutter);
                    if (groceryquantity.Text == "0" && grocerytotal.Text == "0")
                    {
                        sellgrocery.Enabled = false;
                        buygrocery.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Butter");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (grocerycombobox.SelectedItem.ToString() == "Orange Juice")
                {
                    Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq -= System.Convert.ToInt32(groceryquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(grocerytotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.groceryorangejuiceq);
                    grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.groceryorangejuice);
                    if (groceryquantity.Text == "0" && grocerytotal.Text == "0")
                    {
                        sellgrocery.Enabled = false;
                        buygrocery.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Orange Juice");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (grocerycombobox.SelectedItem.ToString() == "Sugar")
                {
                    Smuggle_INC.Properties.Settings.Default.grocerysugarq -= System.Convert.ToInt32(groceryquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(grocerytotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    groceryquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.grocerysugarq);
                    grocerytotal.Text = System.Convert.ToString(System.Convert.ToInt32(groceryquantity.Text) * Smuggle_INC.Properties.Settings.Default.grocerysugar);
                    if (groceryquantity.Text == "0" && grocerytotal.Text == "0")
                    {
                        sellgrocery.Enabled = false;
                        buygrocery.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Sugar");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
        }

        private void metalscombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buymetals.Enabled = true;
            sellmetals.Enabled = false;
            metalstotal.Text = "0";
            metalsquantity.Text = "0";
            metalsincrement.Enabled = false;
            metalsdecrement.Enabled = false;
            buymetals.BackColor = System.Drawing.Color.White;
            sellmetals.BackColor = System.Drawing.Color.White;
            if (metalscombobox.SelectedItem.ToString() == "Aluminium" && Smuggle_INC.Properties.Settings.Default.metalsaluminiumq > 0)
            {
                sellmetals.Enabled = true;
            }
            if (metalscombobox.SelectedItem.ToString() == "Nickel" && Smuggle_INC.Properties.Settings.Default.metalsnickelq > 0)
            {
                sellmetals.Enabled = true;
            }
            if (metalscombobox.SelectedItem.ToString() == "Copper" && Smuggle_INC.Properties.Settings.Default.metalscopperq > 0)
            {
                sellmetals.Enabled = true;
            }
            if (metalscombobox.SelectedItem.ToString() == "Lead" && Smuggle_INC.Properties.Settings.Default.metalsleadq > 0)
            {
                sellmetals.Enabled = true;
            }
            if (metalscombobox.SelectedItem.ToString() == "Iron Ore" && Smuggle_INC.Properties.Settings.Default.metalsironoreq > 0)
            {
                sellmetals.Enabled = true;
            }
        }

        private void metalscombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void metalsdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(metalsquantity.Text) >= 1)
            {
                if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                {
                    int metalstotalint = System.Convert.ToInt32(metalstotal.Text);
                    metalstotalint -= Smuggle_INC.Properties.Settings.Default.metalsaluminium;
                    metalstotal.Text = System.Convert.ToString(metalstotalint);
                    int metalsquantityint1 = System.Convert.ToInt32(metalsquantity.Text);
                    metalsquantityint1--;
                    metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                }
                if (metalscombobox.SelectedItem.ToString() == "Nickel")
                {
                    int metalstotalint = System.Convert.ToInt32(metalstotal.Text);
                    metalstotalint -= Smuggle_INC.Properties.Settings.Default.metalsnickel;
                    metalstotal.Text = System.Convert.ToString(metalstotalint);
                    int metalsquantityint1 = System.Convert.ToInt32(metalsquantity.Text);
                    metalsquantityint1--;
                    metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                }
                if (metalscombobox.SelectedItem.ToString() == "Copper")
                {
                    int metalstotalint = System.Convert.ToInt32(metalstotal.Text);
                    metalstotalint -= Smuggle_INC.Properties.Settings.Default.metalscopper;
                    metalstotal.Text = System.Convert.ToString(metalstotalint);
                    int metalsquantityint1 = System.Convert.ToInt32(metalsquantity.Text);
                    metalsquantityint1--;
                    metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                }
                if (metalscombobox.SelectedItem.ToString() == "Lead")
                {
                    int metalstotalint = System.Convert.ToInt32(metalstotal.Text);
                    metalstotalint -= Smuggle_INC.Properties.Settings.Default.metalslead;
                    metalstotal.Text = System.Convert.ToString(metalstotalint);
                    int metalsquantityint1 = System.Convert.ToInt32(metalsquantity.Text);
                    metalsquantityint1--;
                    metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                }
                if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                {
                    int metalstotalint = System.Convert.ToInt32(metalstotal.Text);
                    metalstotalint -= Smuggle_INC.Properties.Settings.Default.metalsironore;
                    metalstotal.Text = System.Convert.ToString(metalstotalint);
                    int metalsquantityint1 = System.Convert.ToInt32(metalsquantity.Text);
                    metalsquantityint1--;
                    metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                }
            }
            else
            {
                metalsdecrement.Enabled = false;
            }
            metalsincrement.Enabled = true;
        }

        private void metalsquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue || sellmetals.BackColor == System.Drawing.Color.Red)
                metalsquantity.ReadOnly = false;
        }

        private void metalsquantity_Leave(object sender, EventArgs e)
        {
            metalsquantity.ReadOnly = true;
        }

        private void metalsincrement_Click(object sender, EventArgs e)
        {
            if (metalsquantity.Text == "")
            {
                metalsquantity.Text = "0";
            }
            if (metalsquantity.Text != "")
            {
                if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                    {
                        metalsdecrement.Enabled = true;
                        int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                        metalsquantityint1++;
                        this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                        int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsaluminium * metalsquantityint1;
                        metalstotal.Text = System.Convert.ToString(metalstotalint);
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Nickel")
                    {
                        metalsdecrement.Enabled = true;
                        int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                        metalsquantityint1++;
                        this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                        int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsnickel * metalsquantityint1;
                        metalstotal.Text = System.Convert.ToString(metalstotalint);
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Copper")
                    {
                        metalsdecrement.Enabled = true;
                        int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                        metalsquantityint1++;
                        this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                        int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalscopper * metalsquantityint1;
                        metalstotal.Text = System.Convert.ToString(metalstotalint);
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Lead")
                    {
                        metalsdecrement.Enabled = true;
                        int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                        metalsquantityint1++;
                        this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                        int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalslead * metalsquantityint1;
                        metalstotal.Text = System.Convert.ToString(metalstotalint);
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                    {
                        metalsdecrement.Enabled = true;
                        int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                        metalsquantityint1++;
                        this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                        int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsironore * metalsquantityint1;
                        metalstotal.Text = System.Convert.ToString(metalstotalint);
                    }
                }
                if (sellmetals.BackColor == System.Drawing.Color.Red)
                {
                    metalsdecrement.Enabled = true;
                    int metalsquantity1 = System.Convert.ToInt32(this.metalsquantity.Text);
                    if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                    {
                        if (metalsquantity1 <= Smuggle_INC.Properties.Settings.Default.metalsaluminiumq)
                        {
                            int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                            metalsquantityint1++;
                            this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                            int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsaluminium * metalsquantityint1;
                            metalstotal.Text = System.Convert.ToString(metalstotalint);
                        }
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Nickel")
                    {
                        if (metalsquantity1 <= Smuggle_INC.Properties.Settings.Default.metalsnickelq)
                        {
                            int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                            metalsquantityint1++;
                            this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                            int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsnickel * metalsquantityint1;
                            metalstotal.Text = System.Convert.ToString(metalstotalint);
                        }
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Copper")
                    {
                        if (metalsquantity1 <= Smuggle_INC.Properties.Settings.Default.metalscopperq)
                        {
                            int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                            metalsquantityint1++;
                            this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                            int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalscopper * metalsquantityint1;
                            metalstotal.Text = System.Convert.ToString(metalstotalint);
                        }
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Lead")
                    {
                        if (metalsquantity1 <= Smuggle_INC.Properties.Settings.Default.metalsleadq)
                        {
                            int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                            metalsquantityint1++;
                            this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                            int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalslead * metalsquantityint1;
                            metalstotal.Text = System.Convert.ToString(metalstotalint);
                        }
                    }
                    if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                    {
                        if (metalsquantity1 <= Smuggle_INC.Properties.Settings.Default.metalsironoreq)
                        {
                            int metalsquantityint1 = System.Convert.ToInt32(this.metalsquantity.Text);
                            metalsquantityint1++;
                            this.metalsquantity.Text = System.Convert.ToString(metalsquantityint1);
                            int metalstotalint = Smuggle_INC.Properties.Settings.Default.metalsironore * metalsquantityint1;
                            metalstotal.Text = System.Convert.ToString(metalstotalint);
                        }
                    }
                }
            }
        }

        private void metalsquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (metalsquantity.Text == "")
                {
                    metalstotal.Text = "";
                    metalsdecrement.Enabled = false;
                    placeordermetals.Enabled = false;
                }
                if (metalsquantity.Text != "")
                {
                    if (System.Convert.ToInt32(metalsquantity.Text) == 0)
                    {
                        placeordermetals.Enabled = false;
                        metalsdecrement.Enabled = false;
                        metalstotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(metalsquantity.Text) > 0)
                    {
                        placeordermetals.Enabled = true;
                        metalsdecrement.Enabled = true;
                    }
                    if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(metalsquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            metalsincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(metalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            metalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(metalsquantity.Text) > 0)
                        {
                            if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                            {
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsaluminium);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Nickel")
                            {
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsnickel);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Copper")
                            {
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalscopper);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Lead")
                            {
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalslead);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                            {
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsironore);
                            }
                        }
                    }
                    if (sellmetals.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (metalscombobox.SelectedItem.ToString() == "Aluminium" && System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsaluminiumq)
                            {
                                if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsaluminiumq)
                                {
                                    metalsincrement.Enabled = true;
                                }
                                if (metalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminiumq))
                                {
                                    metalsincrement.Enabled = false;
                                }
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsaluminium);
                            }
                            else if (metalscombobox.SelectedItem.ToString() == "Aluminium" && System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.metalsaluminiumq)
                            {
                                metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminium * Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Nickel" && System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsnickelq)
                            {
                                if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsnickelq)
                                {
                                    metalsincrement.Enabled = true;
                                }
                                if (metalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickelq))
                                {
                                    metalsincrement.Enabled = false;
                                }
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsnickel);
                            }
                            else if (metalscombobox.SelectedItem.ToString() == "Nickel" && System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.metalsnickelq)
                            {
                                metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickel * Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Copper" && System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalscopperq)
                            {
                                if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalscopperq)
                                {
                                    metalsincrement.Enabled = true;
                                }
                                if (metalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopperq))
                                {
                                    metalsincrement.Enabled = false;
                                }
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalscopper);
                            }
                            else if (metalscombobox.SelectedItem.ToString() == "Copper" && System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.metalscopperq)
                            {
                                metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopperq);
                                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopper * Smuggle_INC.Properties.Settings.Default.metalscopperq);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Lead" && System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsleadq)
                            {
                                if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsleadq)
                                {
                                    metalsincrement.Enabled = true;
                                }
                                if (metalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsleadq))
                                {
                                    metalsincrement.Enabled = false;
                                }
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalslead);
                            }
                            else if (metalscombobox.SelectedItem.ToString() == "Lead" && System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.metalsleadq)
                            {
                                metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsleadq);
                                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalslead * Smuggle_INC.Properties.Settings.Default.metalsleadq);
                            }
                            if (metalscombobox.SelectedItem.ToString() == "Iron Ore" && System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsironoreq)
                            {
                                if (System.Convert.ToInt32(metalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.metalsironoreq)
                                {
                                    metalsincrement.Enabled = true;
                                }
                                if (metalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironoreq))
                                {
                                    metalsincrement.Enabled = false;
                                }
                                metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsironore);
                            }
                            else if (metalscombobox.SelectedItem.ToString() == "Iron Ore" && System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.metalsironoreq)
                            {
                                metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironore * Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                            }
                        }
                    }
                }
            }
            catch                                                               
            {
                if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (metalsquantity.Text == "")
                    {
                        metalstotal.Text = "";
                        metalsdecrement.Enabled = false;
                    }
                    if (metalsquantity.Text != "")
                    {
                        if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = System.Convert.ToString(1);
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminium);
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Nickel")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = System.Convert.ToString(1);
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickel);
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Copper")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = System.Convert.ToString(1);
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopper);
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Lead")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = System.Convert.ToString(1);
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalslead);
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = System.Convert.ToString(1);
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironore);
                        }
                        if (System.Convert.ToInt32(metalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(metalsquantity.Text) >= 0)
                        {
                            this.metalsquantity.ReadOnly = false;
                            metalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(metalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            metalsincrement.Enabled = false;
                            metalsdecrement.Enabled = true;
                        }
                    }
                }
                if (sellmetals.BackColor == System.Drawing.Color.Red)
                {
                    if (metalsquantity.Text == "")
                    {
                        metalstotal.Text = "";
                        metalsdecrement.Enabled = false;
                    }
                    if (metalsquantity.Text != "")
                    {
                        if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsaluminiumq.ToString();
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminium * Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                            metalsdecrement.Enabled = true;
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Nickel")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsnickelq.ToString();
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickel * Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                            metalsdecrement.Enabled = true;
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Copper")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalscopperq.ToString();
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopper * Smuggle_INC.Properties.Settings.Default.metalscopperq);
                            metalsdecrement.Enabled = true;
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Lead")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsleadq.ToString();
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalslead * Smuggle_INC.Properties.Settings.Default.metalsleadq);
                            metalsdecrement.Enabled = true;
                        }
                        if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsironoreq.ToString();
                            metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironore * Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                            metalsdecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buymetals_Click(object sender, EventArgs e)
        {
            metalsdecrement.Enabled = true;
            buymetals.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellmetals.BackColor = System.Drawing.Color.White;
            metalsincrement.Enabled = true;
            if (metalscombobox.SelectedItem.ToString() == "Aluminium")
            {
                metalsquantity.Text = System.Convert.ToString(1);
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminium);
            }
            if (metalscombobox.SelectedItem.ToString() == "Nickel")
            {
                metalsquantity.Text = System.Convert.ToString(1);
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickel);
            }
            if (metalscombobox.SelectedItem.ToString() == "Copper")
            {
                metalsquantity.Text = System.Convert.ToString(1);
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopper);
            }
            if (metalscombobox.SelectedItem.ToString() == "Lead")
            {
                metalsquantity.Text = System.Convert.ToString(1);
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalslead);
            }
            if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
            {
                metalsquantity.Text = System.Convert.ToString(1);
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironore);
            }
        }

        private void sellmetals_Click(object sender, EventArgs e)
        {
            buymetals.BackColor = System.Drawing.Color.White;
            sellmetals.BackColor = System.Drawing.Color.Red;
            if (metalscombobox.SelectedItem.ToString() == "Aluminium")
            {
                metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsaluminiumq.ToString();
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminium * Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                metalsdecrement.Enabled = true;
                metalsincrement.Enabled = false;
            }
            if (metalscombobox.SelectedItem.ToString() == "Nickel")
            {
                metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsnickelq.ToString();
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickel * Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                metalsdecrement.Enabled = true;
                metalsincrement.Enabled = false;
            }
            if (metalscombobox.SelectedItem.ToString() == "Copper")
            {
                metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalscopperq.ToString();
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopper * Smuggle_INC.Properties.Settings.Default.metalscopperq);
                metalsdecrement.Enabled = true;
                metalsincrement.Enabled = false;
            }
            if (metalscombobox.SelectedItem.ToString() == "Lead")
            {
                metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsleadq.ToString();
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalslead * Smuggle_INC.Properties.Settings.Default.metalsleadq);
                metalsdecrement.Enabled = true;
                metalsincrement.Enabled = false;
            }
            if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
            {
                metalsquantity.Text = Smuggle_INC.Properties.Settings.Default.metalsironoreq.ToString();
                metalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironore * Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                metalsdecrement.Enabled = true;
                metalsincrement.Enabled = false;
            }
        }

        private void placeordermetals_Click(object sender, EventArgs e)
        {
            if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buymetals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(metalstotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                {
                    if (System.Convert.ToInt32(metalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.metalsaluminiumq += System.Convert.ToInt32(metalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(metalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Aluminium", Smuggle_INC.Properties.Settings.Default.metalsaluminium);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (metalscombobox.SelectedItem.ToString() == "Nickel")
                {
                    if (System.Convert.ToInt32(metalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.metalsnickelq += System.Convert.ToInt32(metalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(metalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Nickel", Smuggle_INC.Properties.Settings.Default.metalsnickel);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (metalscombobox.SelectedItem.ToString() == "Copper")
                {
                    if (System.Convert.ToInt32(metalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.metalscopperq += System.Convert.ToInt32(metalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(metalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Copper", Smuggle_INC.Properties.Settings.Default.metalscopper);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (metalscombobox.SelectedItem.ToString() == "Lead")
                {
                    if (System.Convert.ToInt32(metalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.metalsleadq += System.Convert.ToInt32(metalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(metalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Lead", Smuggle_INC.Properties.Settings.Default.metalslead);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                {
                    if (System.Convert.ToInt32(metalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.metalsironoreq += System.Convert.ToInt32(metalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(metalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Iron Ore", Smuggle_INC.Properties.Settings.Default.metalsironore);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
            }
            if (sellmetals.BackColor == System.Drawing.Color.Red)
            {
                if (metalscombobox.SelectedItem.ToString() == "Aluminium")
                {
                    Smuggle_INC.Properties.Settings.Default.metalsaluminiumq -= System.Convert.ToInt32(metalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(metalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsaluminiumq);
                    metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsaluminium);
                    if (metalsquantity.Text == "0" && metalstotal.Text == "0")
                    {
                        sellmetals.Enabled = false;
                        buymetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Aluminium");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (metalscombobox.SelectedItem.ToString() == "Nickel")
                {
                    Smuggle_INC.Properties.Settings.Default.metalsnickelq -= System.Convert.ToInt32(metalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(metalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsnickelq);
                    metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsnickel);
                    if (metalsquantity.Text == "0" && metalstotal.Text == "0")
                    {
                        sellmetals.Enabled = false;
                        buymetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Nickel");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (metalscombobox.SelectedItem.ToString() == "Copper")
                {
                    Smuggle_INC.Properties.Settings.Default.metalscopperq -= System.Convert.ToInt32(metalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(metalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalscopperq);
                    metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalscopper);
                    if (metalsquantity.Text == "0" && metalstotal.Text == "0")
                    {
                        sellmetals.Enabled = false;
                        buymetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Copper");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (metalscombobox.SelectedItem.ToString() == "Lead")
                {
                    Smuggle_INC.Properties.Settings.Default.metalsleadq -= System.Convert.ToInt32(metalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(metalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsleadq);
                    metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalslead);
                    if (metalsquantity.Text == "0" && metalstotal.Text == "0")
                    {
                        sellmetals.Enabled = false;
                        buymetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Lead");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (metalscombobox.SelectedItem.ToString() == "Iron Ore")
                {
                    Smuggle_INC.Properties.Settings.Default.metalsironoreq -= System.Convert.ToInt32(metalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(metalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    metalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.metalsironoreq);
                    metalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(metalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.metalsironore);
                    if (metalsquantity.Text == "0" && metalstotal.Text == "0")
                    {
                        sellmetals.Enabled = false;
                        buymetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Iron Ore");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
        }

        private void preciousmetalscombobox_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
        }

        private void preciousmetalsquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue || sellpreciousmetals.BackColor == System.Drawing.Color.Red)
                preciousmetalsquantity.ReadOnly = false;
        }

        private void preciousmetalsquantity_Leave(object sender, EventArgs e)
        {
            preciousmetalsquantity.ReadOnly = true;
        }

        private void preciousmetalsdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(preciousmetalsquantity.Text) >= 1)
            {
                if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                {
                    int preciousmetalstotalint = System.Convert.ToInt32(preciousmetalstotal.Text);
                    preciousmetalstotalint -= Smuggle_INC.Properties.Settings.Default.preciousmetalsgold;
                    preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    int preciousmetalsquantityint1 = System.Convert.ToInt32(preciousmetalsquantity.Text);
                    preciousmetalsquantityint1--;
                    preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                {
                    int preciousmetalstotalint = System.Convert.ToInt32(preciousmetalstotal.Text);
                    preciousmetalstotalint -= Smuggle_INC.Properties.Settings.Default.preciousmetalssilver;
                    preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    int preciousmetalsquantityint1 = System.Convert.ToInt32(preciousmetalsquantity.Text);
                    preciousmetalsquantityint1--;
                    preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                {
                    int preciousmetalstotalint = System.Convert.ToInt32(preciousmetalstotal.Text);
                    preciousmetalstotalint -= Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum;
                    preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    int preciousmetalsquantityint1 = System.Convert.ToInt32(preciousmetalsquantity.Text);
                    preciousmetalsquantityint1--;
                    preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                }
            }
            else
            {
                preciousmetalsdecrement.Enabled = false;
            }
            preciousmetalsincrement.Enabled = true;
        }

        private void preciousmetalsincrement_Click(object sender, EventArgs e)
        {
            if (preciousmetalsquantity.Text == "")
            {
                preciousmetalsquantity.Text = "0";
            }
            if (preciousmetalsquantity.Text != "")
            {
                if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                    {
                        preciousmetalsdecrement.Enabled = true;
                        int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                        preciousmetalsquantityint1++;
                        this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                        int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalsgold * preciousmetalsquantityint1;
                        preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    }
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                    {
                        preciousmetalsdecrement.Enabled = true;
                        int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                        preciousmetalsquantityint1++;
                        this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                        int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalssilver * preciousmetalsquantityint1;
                        preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    }
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                    {
                        preciousmetalsdecrement.Enabled = true;
                        int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                        preciousmetalsquantityint1++;
                        this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                        int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum * preciousmetalsquantityint1;
                        preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                    }
                }
                if (sellpreciousmetals.BackColor == System.Drawing.Color.Red)
                {
                    preciousmetalsdecrement.Enabled = true;
                    int preciousmetalsquantity1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                    {
                        if (preciousmetalsquantity1 <= Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq)
                        {
                            int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                            preciousmetalsquantityint1++;
                            this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                            int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalsgold * preciousmetalsquantityint1;
                            preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                        }
                    }
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                    {
                        if (preciousmetalsquantity1 <= Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq)
                        {
                            int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                            preciousmetalsquantityint1++;
                            this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                            int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalssilver * preciousmetalsquantityint1;
                            preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                        }
                    }
                    if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                    {
                        if (preciousmetalsquantity1 <= Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq)
                        {
                            int preciousmetalsquantityint1 = System.Convert.ToInt32(this.preciousmetalsquantity.Text);
                            preciousmetalsquantityint1++;
                            this.preciousmetalsquantity.Text = System.Convert.ToString(preciousmetalsquantityint1);
                            int preciousmetalstotalint = Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum * preciousmetalsquantityint1;
                            preciousmetalstotal.Text = System.Convert.ToString(preciousmetalstotalint);
                        }
                    }
                }
            }
        }

        private void preciousmetalscombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buypreciousmetals.Enabled = true;
            sellpreciousmetals.Enabled = false;
            preciousmetalstotal.Text = "0";
            preciousmetalsquantity.Text = "0";
            preciousmetalsincrement.Enabled = false;
            preciousmetalsdecrement.Enabled = false;
            buypreciousmetals.BackColor = System.Drawing.Color.White;
            sellpreciousmetals.BackColor = System.Drawing.Color.White;
            if (preciousmetalscombobox.SelectedItem.ToString() == "Gold" && Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq > 0)
            {
                sellpreciousmetals.Enabled = true;
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Silver" && Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq > 0)
            {
                sellpreciousmetals.Enabled = true;
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum" && Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq > 0)
            {
                sellpreciousmetals.Enabled = true;
            }
        }

        private void preciousmetalsquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (preciousmetalsquantity.Text == "")
                {
                    preciousmetalstotal.Text = "";
                    preciousmetalsdecrement.Enabled = false;
                    placeorderpreciousmetals.Enabled = false;
                }
                if (preciousmetalsquantity.Text != "")
                {
                    if (System.Convert.ToInt32(preciousmetalsquantity.Text) == 0)
                    {
                        placeorderpreciousmetals.Enabled = false;
                        preciousmetalsdecrement.Enabled = false;
                        preciousmetalstotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(preciousmetalsquantity.Text) > 0)
                    {
                        placeorderpreciousmetals.Enabled = true;
                        preciousmetalsdecrement.Enabled = true;
                    }
                    if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            preciousmetalsincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            preciousmetalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(preciousmetalsquantity.Text) > 0)
                        {
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                            {
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
                            }
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                            {
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
                            }
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                            {
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
                            }
                        }
                    }
                    if (sellpreciousmetals.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Gold" && System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq)
                            {
                                if (System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq)
                                {
                                    preciousmetalsincrement.Enabled = true;
                                }
                                if (preciousmetalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq))
                                {
                                    preciousmetalsincrement.Enabled = false;
                                }
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
                            }
                            else if (preciousmetalscombobox.SelectedItem.ToString() == "Gold" && System.Convert.ToInt32(preciousmetalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq)
                            {
                                preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgold * Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                            }
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Silver" && System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq)
                            {
                                if (System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq)
                                {
                                    preciousmetalsincrement.Enabled = true;
                                }
                                if (preciousmetalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq))
                                {
                                    preciousmetalsincrement.Enabled = false;
                                }
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
                            }
                            else if (preciousmetalscombobox.SelectedItem.ToString() == "Silver" && System.Convert.ToInt32(preciousmetalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq)
                            {
                                preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilver * Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                            }
                            if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum" && System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq)
                            {
                                if (System.Convert.ToInt32(preciousmetalsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq)
                                {
                                    preciousmetalsincrement.Enabled = true;
                                }
                                if (preciousmetalsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq))
                                {
                                    preciousmetalsincrement.Enabled = false;
                                }
                                preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
                            }
                            else if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum" && System.Convert.ToInt32(preciousmetalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq)
                            {
                                preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (preciousmetalsquantity.Text == "")
                    {
                        preciousmetalstotal.Text = "";
                        preciousmetalsdecrement.Enabled = false;
                    }
                    if (preciousmetalsquantity.Text != "")
                    {
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = System.Convert.ToString(1);
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
                        }
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = System.Convert.ToString(1);
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
                        }
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = System.Convert.ToString(1);
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
                        }
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(preciousmetalsquantity.Text) >= 0)
                        {
                            this.preciousmetalsquantity.ReadOnly = false;
                            preciousmetalsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(preciousmetalsquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            preciousmetalsincrement.Enabled = false;
                            preciousmetalsdecrement.Enabled = true;
                        }
                    }
                }
                if (sellpreciousmetals.BackColor == System.Drawing.Color.Red)
                {
                    if (preciousmetalsquantity.Text == "")
                    {
                        preciousmetalstotal.Text = "";
                        preciousmetalsdecrement.Enabled = false;
                    }
                    if (preciousmetalsquantity.Text != "")
                    {
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq.ToString();
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgold * Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                            metalsdecrement.Enabled = true;
                        }
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq.ToString();
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilver * Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                            metalsdecrement.Enabled = true;
                        }
                        if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                        {
                            MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                            preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq.ToString();
                            preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                            metalsdecrement.Enabled = true;
                        }
                    }
                }
            }
        }

        private void buypreciousmetals_Click(object sender, EventArgs e)
        {
            preciousmetalsdecrement.Enabled = true;
            buypreciousmetals.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellpreciousmetals.BackColor = System.Drawing.Color.White;
            preciousmetalsincrement.Enabled = true;
            if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
            {
                preciousmetalsquantity.Text = System.Convert.ToString(1);
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
            {
                preciousmetalsquantity.Text = System.Convert.ToString(1);
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
            {
                preciousmetalsquantity.Text = System.Convert.ToString(1);
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
            }
        }

        private void sellpreciousmetals_Click(object sender, EventArgs e)
        {
            buypreciousmetals.BackColor = System.Drawing.Color.White;
            sellpreciousmetals.BackColor = System.Drawing.Color.Red;
            if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
            {
                preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq.ToString();
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgold * Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                preciousmetalsdecrement.Enabled = true;
                preciousmetalsincrement.Enabled = false;
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
            {
                preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq.ToString();
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilver * Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                preciousmetalsdecrement.Enabled = true;
                preciousmetalsincrement.Enabled = false;
            }
            if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
            {
                preciousmetalsquantity.Text = Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq.ToString();
                preciousmetalstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                preciousmetalsdecrement.Enabled = true;
                preciousmetalsincrement.Enabled = false;
            }
        }

        private void placeorderpreciousmetals_Click(object sender, EventArgs e)
        {
            if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buypreciousmetals.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(preciousmetalstotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                {
                    if (System.Convert.ToInt32(preciousmetalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellpreciousmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq += System.Convert.ToInt32(preciousmetalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(preciousmetalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Gold", Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                {
                    if (System.Convert.ToInt32(preciousmetalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellpreciousmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq += System.Convert.ToInt32(preciousmetalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(preciousmetalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Silver", Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                {
                    if (System.Convert.ToInt32(preciousmetalstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                    {
                        sellpreciousmetals.Enabled = true;
                        Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq += System.Convert.ToInt32(preciousmetalsquantity.Text);
                        Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(preciousmetalstotal.Text);
                        mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                        inventorybuyrefreshwhilerun("Platinum", Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
                        MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                    }
                }
            }
            if (sellpreciousmetals.BackColor == System.Drawing.Color.Red)
            {
                if (preciousmetalscombobox.SelectedItem.ToString() == "Gold")
                {
                    Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq -= System.Convert.ToInt32(preciousmetalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(preciousmetalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsgoldq);
                    preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsgold);
                    if (preciousmetalsquantity.Text == "0" && preciousmetalstotal.Text == "0")
                    {
                        sellpreciousmetals.Enabled = false;
                        buypreciousmetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Gold");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Silver")
                {
                    Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq -= System.Convert.ToInt32(preciousmetalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(preciousmetalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalssilverq);
                    preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalssilver);
                    if (preciousmetalsquantity.Text == "0" && preciousmetalstotal.Text == "0")
                    {
                        sellpreciousmetals.Enabled = false;
                        buypreciousmetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Silver");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
                if (preciousmetalscombobox.SelectedItem.ToString() == "Platinum")
                {
                    Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq -= System.Convert.ToInt32(preciousmetalsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(preciousmetalstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    preciousmetalsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinumq);
                    preciousmetalstotal.Text = System.Convert.ToString(System.Convert.ToInt32(preciousmetalsquantity.Text) * Smuggle_INC.Properties.Settings.Default.preciousmetalsplatinum);
                    if (preciousmetalsquantity.Text == "0" && preciousmetalstotal.Text == "0")
                    {
                        sellpreciousmetals.Enabled = false;
                        buypreciousmetals.PerformClick();
                    }
                    inventorysellrefreshwhilerun("Platinum");
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
        }

        private void plasticdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(plasticquantity.Text) >= 1)
            {     
                int plastictotalint = System.Convert.ToInt32(plastictotal.Text);
                plastictotalint -= Smuggle_INC.Properties.Settings.Default.plastic;
                plastictotal.Text = System.Convert.ToString(plastictotalint);
                int plasticquantityint1 = System.Convert.ToInt32(plasticquantity.Text);
                plasticquantityint1--;
                plasticquantity.Text = System.Convert.ToString(plasticquantityint1);            
            }
            else
            {
                plasticdecrement.Enabled = false;
            }
            plasticincrement.Enabled = true;
        }

        private void plasticincrement_Click(object sender, EventArgs e)
        {
            if (plasticquantity.Text == "")
            {
                plasticquantity.Text = "0";
            }
            if (plasticquantity.Text != "")
            {
                if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    plasticdecrement.Enabled = true;
                    int plasticquantityint1 = System.Convert.ToInt32(this.plasticquantity.Text);
                    plasticquantityint1++;
                    this.plasticquantity.Text = System.Convert.ToString(plasticquantityint1);
                    int plastictotalint = Smuggle_INC.Properties.Settings.Default.plastic * plasticquantityint1;
                    plastictotal.Text = System.Convert.ToString(plastictotalint);
                }
                if (sellplastic.BackColor == System.Drawing.Color.Red)                          
                {
                    plasticdecrement.Enabled = true;
                    int plasticquantity1 = System.Convert.ToInt32(this.plasticquantity.Text);
                    if (plasticquantity1 <= Smuggle_INC.Properties.Settings.Default.plasticq)
                    {
                        int plasticquantityint1 = System.Convert.ToInt32(this.plasticquantity.Text);
                        plasticquantityint1++;
                        this.plasticquantity.Text = System.Convert.ToString(plasticquantityint1);
                        int plastictotalint = Smuggle_INC.Properties.Settings.Default.plastic * plasticquantityint1;
                        plastictotal.Text = System.Convert.ToString(plastictotalint);
                    }
                }
            }
        }

        private void plasticquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue || sellplastic.BackColor == System.Drawing.Color.Red)
                plasticquantity.ReadOnly = false;
        }

        private void plasticquantity_Leave(object sender, EventArgs e)
        {
            plasticquantity.ReadOnly = true;
        }

        private void buyplastic_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            plasticdecrement.Enabled = true;
            buyplastic.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellplastic.BackColor = System.Drawing.Color.White;
            plasticincrement.Enabled = true;
            plasticquantity.Text = System.Convert.ToString(1);
            plastictotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plastic);
        }

        private void sellplastic_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            buyplastic.BackColor = System.Drawing.Color.White;
            sellplastic.BackColor = System.Drawing.Color.Red;
            plasticquantity.Text = Smuggle_INC.Properties.Settings.Default.plasticq.ToString();
            plastictotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plastic * Smuggle_INC.Properties.Settings.Default.plasticq);
            plasticdecrement.Enabled = true;
            plasticincrement.Enabled = false;
        }

        private void plasticquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (plasticquantity.Text == "")
                {
                    plastictotal.Text = "";
                    plasticdecrement.Enabled = false;
                    placeorderplastic.Enabled = false;
                }
                if (plasticquantity.Text != "")
                {
                    if (System.Convert.ToInt32(plasticquantity.Text) == 0)
                    {
                        placeorderplastic.Enabled = false;
                        plasticdecrement.Enabled = false;
                        plastictotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(plasticquantity.Text) > 0)
                    {
                        placeorderplastic.Enabled = true;
                        plasticdecrement.Enabled = true;
                    }
                    if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(plasticquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            plasticquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            plasticincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(plasticquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            plasticincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(plasticquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(plasticquantity.Text) > 0)
                        {
                            plastictotal.Text = System.Convert.ToString(System.Convert.ToInt32(plasticquantity.Text) * Smuggle_INC.Properties.Settings.Default.plastic);
                        }
                    }
                    if (sellplastic.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(plasticquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (System.Convert.ToInt32(plasticquantity.Text) <= Smuggle_INC.Properties.Settings.Default.plasticq)
                            {
                                if (System.Convert.ToInt32(plasticquantity.Text) <= Smuggle_INC.Properties.Settings.Default.plasticq)
                                {
                                    plasticincrement.Enabled = true;
                                }
                                if (plasticquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plasticq))
                                {
                                    plasticincrement.Enabled = false;
                                }
                                plastictotal.Text = System.Convert.ToString(System.Convert.ToInt32(plasticquantity.Text) * Smuggle_INC.Properties.Settings.Default.plastic);
                            }
                            else if (System.Convert.ToInt32(plasticquantity.Text) > Smuggle_INC.Properties.Settings.Default.plasticq)
                            {
                                plasticquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plasticq);
                                plastictotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plastic * Smuggle_INC.Properties.Settings.Default.plasticq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (plasticquantity.Text == "")
                    {
                        plastictotal.Text = "";
                        plasticdecrement.Enabled = false;
                    }
                    if (plasticquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        plasticquantity.Text = System.Convert.ToString(1);
                        plastictotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plastic);
                        if (System.Convert.ToInt32(plasticquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(plasticquantity.Text) >= 0)
                        {
                            this.plasticquantity.ReadOnly = false;
                            plasticincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(plasticquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            plasticincrement.Enabled = false;
                            plasticdecrement.Enabled = true;
                        }
                    }
                }
                if (sellplastic.BackColor == System.Drawing.Color.Red)
                {
                    if (plasticquantity.Text == "")
                    {
                        plastictotal.Text = "";
                        plasticdecrement.Enabled = false;
                    }
                    if (plasticquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        plasticquantity.Text = Smuggle_INC.Properties.Settings.Default.plasticq.ToString();
                        plastictotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plastic * Smuggle_INC.Properties.Settings.Default.plasticq);
                        plasticdecrement.Enabled = true;
                    }
                }
            }
        }

        private void placeorderplastic_Click(object sender, EventArgs e)
        {
            if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buyplastic.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(plastictotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (System.Convert.ToInt32(plastictotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    sellplastic.Enabled = true;
                    Smuggle_INC.Properties.Settings.Default.plasticq += System.Convert.ToInt32(plasticquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(plastictotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    inventorybuyrefreshwhilerun("Plastic", Smuggle_INC.Properties.Settings.Default.plastic);
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
            if (sellplastic.BackColor == System.Drawing.Color.Red)
            {
                Smuggle_INC.Properties.Settings.Default.plasticq -= System.Convert.ToInt32(plasticquantity.Text);
                Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(plastictotal.Text);
                mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                plasticquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.plasticq);
                plastictotal.Text = System.Convert.ToString(System.Convert.ToInt32(plasticquantity.Text) * Smuggle_INC.Properties.Settings.Default.plastic);
                if (plasticquantity.Text == "0" && plastictotal.Text == "0")
                {
                    sellplastic.Enabled = false;
                    buyplastic.PerformClick();
                }
                inventorysellrefreshwhilerun("Plastic");
                MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
            }
        }

        private void naturalgasdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(naturalgasquantity.Text) >= 1)
            {
                int naturalgastotalint = System.Convert.ToInt32(naturalgastotal.Text);
                naturalgastotalint -= Smuggle_INC.Properties.Settings.Default.naturalgas;
                naturalgastotal.Text = System.Convert.ToString(naturalgastotalint);
                int naturalgasquantityint1 = System.Convert.ToInt32(naturalgasquantity.Text);
                naturalgasquantityint1--;
                naturalgasquantity.Text = System.Convert.ToString(naturalgasquantityint1);
            }
            else
            {
                naturalgasdecrement.Enabled = false;
            }
            naturalgasincrement.Enabled = true;
        }

        private void naturalgasincrement_Click(object sender, EventArgs e)
        {
            if (naturalgasquantity.Text == "")
            {
                naturalgasquantity.Text = "0";
            }
            if (naturalgasquantity.Text != "")
            {
                if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    naturalgasdecrement.Enabled = true;
                    int naturalgasquantityint1 = System.Convert.ToInt32(this.naturalgasquantity.Text);
                    naturalgasquantityint1++;
                    this.naturalgasquantity.Text = System.Convert.ToString(naturalgasquantityint1);
                    int naturalgastotalint = Smuggle_INC.Properties.Settings.Default.naturalgas * naturalgasquantityint1;
                    naturalgastotal.Text = System.Convert.ToString(naturalgastotalint);
                }
                if (sellnaturalgas.BackColor == System.Drawing.Color.Red)
                {
                    naturalgasdecrement.Enabled = true;
                    int naturalgasquantity1 = System.Convert.ToInt32(this.naturalgasquantity.Text);
                    if (naturalgasquantity1 <= Smuggle_INC.Properties.Settings.Default.naturalgasq)
                    {
                        int naturalgasquantityint1 = System.Convert.ToInt32(this.naturalgasquantity.Text);
                        naturalgasquantityint1++;
                        this.naturalgasquantity.Text = System.Convert.ToString(naturalgasquantityint1);
                        int naturalgastotalint = Smuggle_INC.Properties.Settings.Default.naturalgas * naturalgasquantityint1;
                        naturalgastotal.Text = System.Convert.ToString(naturalgastotalint);
                    }
                }
            }
        }

        private void naturalgasquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue || sellnaturalgas.BackColor == System.Drawing.Color.Red)
                naturalgasquantity.ReadOnly = false;
        }

        private void naturalgasquantity_Leave(object sender, EventArgs e)
        {
            naturalgasquantity.ReadOnly = true;
        }

        private void naturalgasquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (naturalgasquantity.Text == "")
                {
                    naturalgastotal.Text = "";
                    naturalgasdecrement.Enabled = false;
                    placeordernaturalgas.Enabled = false;
                }
                if (naturalgasquantity.Text != "")
                {
                    if (System.Convert.ToInt32(naturalgasquantity.Text) == 0)
                    {
                        placeordernaturalgas.Enabled = false;
                        naturalgasdecrement.Enabled = false;
                        naturalgastotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(naturalgasquantity.Text) > 0)
                    {
                        placeordernaturalgas.Enabled = true;
                        naturalgasdecrement.Enabled = true;
                    }
                    if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(naturalgasquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            naturalgasquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            naturalgasincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(naturalgasquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            naturalgasincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(naturalgasquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(naturalgasquantity.Text) > 0)
                        {
                            naturalgastotal.Text = System.Convert.ToString(System.Convert.ToInt32(naturalgasquantity.Text) * Smuggle_INC.Properties.Settings.Default.naturalgas);
                        }
                    }
                    if (sellnaturalgas.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(naturalgasquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (System.Convert.ToInt32(naturalgasquantity.Text) <= Smuggle_INC.Properties.Settings.Default.naturalgasq)
                            {
                                if (System.Convert.ToInt32(naturalgasquantity.Text) <= Smuggle_INC.Properties.Settings.Default.naturalgasq)
                                {
                                    naturalgasincrement.Enabled = true;
                                }
                                if (naturalgasquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgasq))
                                {
                                    naturalgasincrement.Enabled = false;
                                }
                                naturalgastotal.Text = System.Convert.ToString(System.Convert.ToInt32(naturalgasquantity.Text) * Smuggle_INC.Properties.Settings.Default.naturalgas);
                            }
                            else if (System.Convert.ToInt32(naturalgasquantity.Text) > Smuggle_INC.Properties.Settings.Default.naturalgasq)
                            {
                                naturalgasquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgasq);
                                naturalgastotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgas * Smuggle_INC.Properties.Settings.Default.naturalgasq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (naturalgasquantity.Text == "")
                    {
                        naturalgastotal.Text = "";
                        naturalgasdecrement.Enabled = false;
                    }
                    if (naturalgasquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        naturalgasquantity.Text = System.Convert.ToString(1);
                        naturalgastotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgas);
                        if (System.Convert.ToInt32(naturalgasquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(naturalgasquantity.Text) >= 0)
                        {
                            this.naturalgasquantity.ReadOnly = false;
                            naturalgasincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(naturalgasquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            naturalgasincrement.Enabled = false;
                            naturalgasdecrement.Enabled = true;
                        }
                    }
                }
                if (sellnaturalgas.BackColor == System.Drawing.Color.Red)
                {
                    if (naturalgasquantity.Text == "")
                    {
                        naturalgastotal.Text = "";
                        naturalgasdecrement.Enabled = false;
                    }
                    if (naturalgasquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        naturalgasquantity.Text = Smuggle_INC.Properties.Settings.Default.naturalgasq.ToString();
                        naturalgastotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgas * Smuggle_INC.Properties.Settings.Default.naturalgasq);
                        naturalgasdecrement.Enabled = true;
                    }
                }
            }
        }

        private void buynaturalgas_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            naturalgasdecrement.Enabled = true;
            buynaturalgas.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellnaturalgas.BackColor = System.Drawing.Color.White;
            naturalgasincrement.Enabled = true;
            naturalgasquantity.Text = System.Convert.ToString(1);
            naturalgastotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgas);
        }

        private void sellnaturalgas_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            buynaturalgas.BackColor = System.Drawing.Color.White;
            sellnaturalgas.BackColor = System.Drawing.Color.Red;
            naturalgasquantity.Text = Smuggle_INC.Properties.Settings.Default.naturalgasq.ToString();
            naturalgastotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgas * Smuggle_INC.Properties.Settings.Default.naturalgasq);
            naturalgasdecrement.Enabled = true;
            naturalgasincrement.Enabled = false;
        }

        private void placeordernaturalgas_Click(object sender, EventArgs e)
        {
            if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buynaturalgas.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(naturalgastotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (System.Convert.ToInt32(naturalgastotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    sellnaturalgas.Enabled = true;
                    Smuggle_INC.Properties.Settings.Default.naturalgasq += System.Convert.ToInt32(naturalgasquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(naturalgastotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    inventorybuyrefreshwhilerun("Natural Gas", Smuggle_INC.Properties.Settings.Default.naturalgas);
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
            if (sellnaturalgas.BackColor == System.Drawing.Color.Red)
            {
                Smuggle_INC.Properties.Settings.Default.naturalgasq -= System.Convert.ToInt32(naturalgasquantity.Text);
                Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(naturalgastotal.Text);
                mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                naturalgasquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.naturalgasq);
                naturalgastotal.Text = System.Convert.ToString(System.Convert.ToInt32(naturalgasquantity.Text) * Smuggle_INC.Properties.Settings.Default.naturalgas);
                if (naturalgasquantity.Text == "0" && naturalgastotal.Text == "0")
                {
                    sellnaturalgas.Enabled = false;
                    buynaturalgas.PerformClick();
                }
                inventorysellrefreshwhilerun("Natural Gas");
                MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
            }
        }

        private void biofuelsincrement_Click(object sender, EventArgs e)
        {
            if (biofuelsquantity.Text == "")
            {
                biofuelsquantity.Text = "0";
            }
            if (biofuelsquantity.Text != "")
            {
                if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    biofuelsdecrement.Enabled = true;
                    int biofuelsquantityint1 = System.Convert.ToInt32(this.biofuelsquantity.Text);
                    biofuelsquantityint1++;
                    this.biofuelsquantity.Text = System.Convert.ToString(biofuelsquantityint1);
                    int biofuelstotalint = Smuggle_INC.Properties.Settings.Default.biofuels * biofuelsquantityint1;
                    biofuelstotal.Text = System.Convert.ToString(biofuelstotalint);
                }
                if (sellbiofuels.BackColor == System.Drawing.Color.Red)
                {
                    biofuelsdecrement.Enabled = true;
                    int biofuelsquantity1 = System.Convert.ToInt32(this.biofuelsquantity.Text);
                    if (biofuelsquantity1 <= Smuggle_INC.Properties.Settings.Default.biofuelsq)
                    {
                        int biofuelsquantityint1 = System.Convert.ToInt32(this.biofuelsquantity.Text);
                        biofuelsquantityint1++;
                        this.biofuelsquantity.Text = System.Convert.ToString(biofuelsquantityint1);
                        int biofuelstotalint = Smuggle_INC.Properties.Settings.Default.biofuels * biofuelsquantityint1;
                        biofuelstotal.Text = System.Convert.ToString(biofuelstotalint);
                    }
                }
            }
        }

        private void biofuelsquantity_MouseClick(object sender, MouseEventArgs e)
        {
            if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue || sellbiofuels.BackColor == System.Drawing.Color.Red)
                biofuelsquantity.ReadOnly = false;
        }

        private void biofuelsquantity_Leave(object sender, EventArgs e)
        {
            biofuelsquantity.ReadOnly = true;
        }

        private void biofuelsquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (biofuelsquantity.Text == "")
                {
                    biofuelstotal.Text = "";
                    biofuelsdecrement.Enabled = false;
                    placeorderbiofuels.Enabled = false;
                }
                if (biofuelsquantity.Text != "")
                {
                    if (System.Convert.ToInt32(biofuelsquantity.Text) == 0)
                    {
                        placeorderbiofuels.Enabled = false;
                        biofuelsdecrement.Enabled = false;
                        biofuelstotal.Text = "0";
                    }
                    if (System.Convert.ToInt32(biofuelsquantity.Text) > 0)
                    {
                        placeorderbiofuels.Enabled = true;
                        biofuelsdecrement.Enabled = true;
                    }
                    if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue)
                    {
                        if (System.Convert.ToInt32(biofuelsquantity.Text) >= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            biofuelsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.buyselllimit);
                            biofuelsincrement.Enabled = false;
                        }
                        if (System.Convert.ToInt32(biofuelsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            biofuelsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(biofuelsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit && System.Convert.ToInt32(biofuelsquantity.Text) > 0)
                        {
                            biofuelstotal.Text = System.Convert.ToString(System.Convert.ToInt32(biofuelsquantity.Text) * Smuggle_INC.Properties.Settings.Default.biofuels);
                        }
                    }
                    if (sellbiofuels.BackColor == System.Drawing.Color.Red)
                    {
                        if (System.Convert.ToInt32(biofuelsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.buyselllimit)
                        {
                            if (System.Convert.ToInt32(biofuelsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.biofuelsq)
                            {
                                if (System.Convert.ToInt32(biofuelsquantity.Text) <= Smuggle_INC.Properties.Settings.Default.biofuelsq)
                                {
                                    biofuelsincrement.Enabled = true;
                                }
                                if (biofuelsquantity.Text == System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuelsq))
                                {
                                    biofuelsincrement.Enabled = false;
                                }
                                biofuelstotal.Text = System.Convert.ToString(System.Convert.ToInt32(biofuelsquantity.Text) * Smuggle_INC.Properties.Settings.Default.biofuels);
                            }
                            else if (System.Convert.ToInt32(biofuelsquantity.Text) > Smuggle_INC.Properties.Settings.Default.biofuelsq)
                            {
                                biofuelsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuelsq);
                                biofuelstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuels * Smuggle_INC.Properties.Settings.Default.biofuelsq);
                            }
                        }
                    }
                }
            }
            catch
            {
                if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue)
                {
                    if (biofuelsquantity.Text == "")
                    {
                        biofuelstotal.Text = "";
                        biofuelsdecrement.Enabled = false;
                    }
                    if (biofuelsquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        biofuelsquantity.Text = System.Convert.ToString(1);
                        biofuelstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuels);
                        if (System.Convert.ToInt32(biofuelsquantity.Text) < Smuggle_INC.Properties.Settings.Default.buyselllimit - 1 && System.Convert.ToInt32(biofuelsquantity.Text) >= 0)
                        {
                            this.biofuelsquantity.ReadOnly = false;
                            biofuelsincrement.Enabled = true;
                        }
                        if (System.Convert.ToInt32(biofuelsquantity.Text) > Smuggle_INC.Properties.Settings.Default.buyselllimit - 1)
                        {
                            biofuelsincrement.Enabled = false;
                            biofuelsdecrement.Enabled = true;
                        }
                    }
                }
                if (sellbiofuels.BackColor == System.Drawing.Color.Red)
                {
                    if (biofuelsquantity.Text == "")
                    {
                        biofuelstotal.Text = "";
                        biofuelsdecrement.Enabled = false;
                    }
                    if (biofuelsquantity.Text != "")
                    {
                        MessageBox.Show("Enter Only Numerical Values, Whole or Positive Values", "Error");
                        biofuelsquantity.Text = Smuggle_INC.Properties.Settings.Default.biofuelsq.ToString();
                        biofuelstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuels * Smuggle_INC.Properties.Settings.Default.biofuelsq);
                        biofuelsdecrement.Enabled = true;
                    }
                }
            }
        }

        private void placeorderbiofuels_Click(object sender, EventArgs e)
        {
            if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == true)
            {
                MessageBox.Show("Inventory Limit Exceeded, sell some comodities to free up space.", "Smuggle INC.");
            }
            if (buybiofuels.BackColor == System.Drawing.Color.DeepSkyBlue && inventory16.Visible == false)
            {
                if (System.Convert.ToInt32(biofuelstotal.Text) > Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    MessageBox.Show("Not Enough Main Account Balance!", "Smuggle INC.");
                }
                if (System.Convert.ToInt32(biofuelstotal.Text) <= Smuggle_INC.Properties.Settings.Default.mainaccountamount)
                {
                    sellbiofuels.Enabled = true;
                    Smuggle_INC.Properties.Settings.Default.biofuelsq += System.Convert.ToInt32(biofuelsquantity.Text);
                    Smuggle_INC.Properties.Settings.Default.mainaccountamount -= System.Convert.ToInt32(biofuelstotal.Text);
                    mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                    inventorybuyrefreshwhilerun("Bio Fuels", Smuggle_INC.Properties.Settings.Default.biofuels);
                    MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
                }
            }
            if (sellbiofuels.BackColor == System.Drawing.Color.Red)
            {
                Smuggle_INC.Properties.Settings.Default.biofuelsq -= System.Convert.ToInt32(biofuelsquantity.Text);
                Smuggle_INC.Properties.Settings.Default.mainaccountamount += System.Convert.ToInt32(biofuelstotal.Text);
                mainaccountamountlabel.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.mainaccountamount);
                biofuelsquantity.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuelsq);
                biofuelstotal.Text = System.Convert.ToString(System.Convert.ToInt32(biofuelsquantity.Text) * Smuggle_INC.Properties.Settings.Default.biofuels);
                if (biofuelsquantity.Text == "0" && biofuelstotal.Text == "0")
                {
                    sellbiofuels.Enabled = false;
                    buybiofuels.PerformClick();
                }
                inventorysellrefreshwhilerun("Bio Fuels");
                MessageBox.Show("Transaction Successfully Completed", "Smuggle INC.");
            }
        }

        private void sellbiofuels_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            buybiofuels.BackColor = System.Drawing.Color.White;
            sellbiofuels.BackColor = System.Drawing.Color.Red;
            biofuelsquantity.Text = Smuggle_INC.Properties.Settings.Default.biofuelsq.ToString();
            biofuelstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuels * Smuggle_INC.Properties.Settings.Default.biofuelsq);
            biofuelsdecrement.Enabled = true;
            biofuelsincrement.Enabled = false;
        }

        private void biofuelsdecrement_Click(object sender, EventArgs e)
        {
            if (System.Convert.ToInt32(biofuelsquantity.Text) >= 1)
            {
                int biofuelstotalint = System.Convert.ToInt32(biofuelstotal.Text);
                biofuelstotalint -= Smuggle_INC.Properties.Settings.Default.biofuels;
                biofuelstotal.Text = System.Convert.ToString(biofuelstotalint);
                int biofuelsquantityint1 = System.Convert.ToInt32(biofuelsquantity.Text);
                biofuelsquantityint1--;
                biofuelsquantity.Text = System.Convert.ToString(biofuelsquantityint1);
            }
            else
            {
                biofuelsdecrement.Enabled = false;
            }
            biofuelsincrement.Enabled = true;

        }

        private void buybiofuels_Click(object sender, EventArgs e)
        {
            cancelcompleteselection();
            biofuelsdecrement.Enabled = true;
            buybiofuels.BackColor = System.Drawing.Color.DeepSkyBlue;
            sellbiofuels.BackColor = System.Drawing.Color.White;
            biofuelsincrement.Enabled = true;
            biofuelsquantity.Text = System.Convert.ToString(1);
            biofuelstotal.Text = System.Convert.ToString(Smuggle_INC.Properties.Settings.Default.biofuels);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void petroleumcombobox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void petroleumcombobox_DropDown(object sender, EventArgs e)
        {
           
        }
    }
}