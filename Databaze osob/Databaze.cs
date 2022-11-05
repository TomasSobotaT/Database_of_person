using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Databaze_osob
{
    /// <summary>
    /// databáze osob / List tříd Osoba
    /// </summary>
    [Serializable]
    public class Databaze
    {

        public List<Osoba> Data { get; private set; }

        [XmlIgnore]
        public Osoba[] FiltrovanaData { get; private set; }

        public Databaze()
        {

            Data = new List<Osoba>();
            FiltrovanaData = Data.ToArray();


        }



        /// <summary>
        /// přidá instanci třídy Osoba do databaze
        /// </summary>
        /// <param name="osoba"></param>
        public void PridejZaznam(Osoba osoba) => Data.Add(osoba);

        /// <summary>
        /// odebere vybraný zaznam Osoby z databaze
        /// </summary>
        /// <param name="osoba"></param>
        public void OdeberZaznam(Osoba osoba) => Data.Remove(osoba);



        /// <summary>
        ///  serializuje a uloží databázi osob
        /// </summary>
        public void Uloz()
        {

            XmlSerializer xs = new XmlSerializer(Data.GetType());

            using (StreamWriter sw = new StreamWriter("data.xml"))
            {
                xs.Serialize(sw, Data);


            }

        }

        /// <summary>
        ///  deserializuje a nahraje databázi osob
        /// </summary>
        public void Nahraj()
        {

            if (File.Exists("data.xml"))
            {
                XmlSerializer xs = new XmlSerializer(Data.GetType());

                using (StreamReader sr = new StreamReader("data.xml"))
                {
                    Data = (List<Osoba>)xs.Deserialize(sr);


                }
            }
            FiltrovanaData = Data.ToArray();
        }



        /// <summary>
        ///  seřadí podle zvolené možnosti
        /// </summary>
        public void Serad(int podleCeho)
        {

            if (podleCeho == 1)
                Data = Data.OrderBy(a => a.Jmeno).ToList();
            if (podleCeho == 2)
                Data = Data.OrderBy(a => a.Prijmeni).ToList();
            if (podleCeho == 3)
                Data = Data.OrderBy(a => a.DatumNarozeni).ToList();

        }



        /// <summary>
        /// Vyfiltruje data podle zadaných parametrů
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="vek"></param>
        /// <param name="pohlavi"></param>
        public void Filtruj(string jmeno, int vek, string pohlavi)
        {

            List<Osoba> filtrovane = FiltrovanaData.ToList();

            if (jmeno != null)  // když je zadán text tak prohledá jmeno i příjmení jestli ho obsahuje
                filtrovane = filtrovane.FindAll(a => (a.Jmeno.Contains(jmeno) || a.Prijmeni.Contains(jmeno) || (a.Jmeno + " " + a.Prijmeni) == jmeno));

            if (pohlavi != "Vše")   //když není zadáno u pohlaví vše vyfiltruje pohlaví podle zadání
                filtrovane = filtrovane.FindAll(a => (a.Pohlavi == (pohlavi == "Muž" ? true : false)));

            if (vek > 0)    //když je věk > 0 najde osoby zadaného věku  
                filtrovane = filtrovane.FindAll(a => (a.Vek == vek));


            FiltrovanaData = filtrovane.ToArray();

        }



        /// <summary>
        /// když vypne filtr tak se resetuje znovu na všechny osoby
        /// </summary>
        public void ResetFiltru()
        {
            FiltrovanaData = Data.ToArray();

        }
    }
}

