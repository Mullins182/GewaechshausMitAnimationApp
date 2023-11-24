using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace GewaechshausMitAnimation.Model
{
    public class GewaechshausSystems
    {
        private bool lueftung = false;
        private bool kuehlung = false;
        private bool heizung  = false;
        private bool verdunkl = false;

        public GewaechshausSystems() { }

        public string getLueftungStatus()
        { 
            if (lueftung == true)
            {
                return "AN";       
            }
            else
            {
                return "AUS";
            }
        }
        public string getKuehlungStatus() 
        {
            if (kuehlung == true)
            {
                return "AN";
            }
            else
            {
                return "AUS";
            }
        }
        public string getHeizungStatus()
        {
            if (heizung == true)
            {
                return "AN";
            }
            else
            {
                return "AUS";
            }
        }
        public string getVerdunklStatus()
        {
            if (verdunkl == true)
            {
                return "AKTIV";
            }
            else
            {
                return "INAKTIV";
            }
        }

        public void setLueftung(bool value)
        {
            lueftung = value;        
        }
        public void setKuehlung(bool value)
        {  
            kuehlung = value;            
        }
        public void setHeizung(bool value)
        {
            heizung = value;
        }
        public void setVerdunkl(bool value)
        {
            verdunkl = value;
        }

        public void setSystems(int x, int y)
        {
            if (x < 13 && y > 13)
            {
                lueftung    = true;
                heizung     = false;
                kuehlung    = false;
                verdunkl    = false;
            }
            else if (x < 13 && y <= 13)
            {
                lueftung    = false;
                heizung     = true;
                kuehlung    = false;
                verdunkl    = false;
            }
            else if (x >= 13 && x <= 30)
            {
                lueftung    = false;
                heizung     = false;
                kuehlung    = false;
                verdunkl    = false;
            }
            else if (x > 30 && y < 30)
            {
                lueftung    = true;
                heizung     = false;
                kuehlung    = false;
                verdunkl    = true;
            }
            else if (x > 30 && y > 30)
            {
                lueftung    = false;
                heizung     = false;
                kuehlung    = true;
                verdunkl    = true;
            }
        }
    }
}
